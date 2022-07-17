using MANTRA;
using Setu.Common.DTO;
using Setu.Entities;
using Staff_Management.Helper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Staff_Management
{
    public partial class Login :BaseForm
    {
        string key = string.Empty;
        bool bInitFlag = false;
        string sRetVal = string.Empty;
        int MatchThreshold = 500;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            FORMNAME = this.Name;
            ResourceHelper.SetLabel(this);
            TxtUsername.Focus();
            ActiveControl = TxtUsername;
            try
            {
                ConfigureFingerPrintDevice();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // To capture the Upper right "X" click
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x10) // The upper right "X" was clicked
            {
                AutoValidate = AutoValidate.Disable; //Deactivate all validations
            }
            base.WndProc(ref m);
        }
        private void ConfigureFingerPrintDevice()
        {
            try
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                GlobalData.mfs100 = new MFS100(key);
                GlobalData.mfs100.Init();
                GlobalData.mfs100.StartCapture();
                GlobalData.mfs100.OnMFS100Attached += OnMFS100Attached;
                GlobalData.mfs100.OnMFS100Detached += OnMFS100Detached;
                GlobalData.mfs100.OnPreview += OnPreview;
                GlobalData.mfs100.OnCaptureCompleted += OnCaptureCompleted;
                
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message, FORMNAME, MessageTypeEnum.ERROR);
            }
        }

        void OnMFS100Attached()
        {
            try
            {
                if (bInitFlag == false)
                {
                    int ret = GlobalData.mfs100.Init();
                    if (ret != 0)
                    {
                        DisplayMessage(ResourceHelper.GetValue("MSG_ERROR_DEVICE_INITIATE") + ":" + GlobalData.mfs100.GetErrorMsg(ret), FORMNAME, MessageTypeEnum.ERROR);
                    }
                    else
                    {
                        bInitFlag = true;
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayMessage(ResourceHelper.GetValue("MSG_ERROR_DEVICE_NOT_CONNECTED") + ex.Message, FORMNAME, MessageTypeEnum.ERROR);
            }
        }
        void OnMFS100Detached()
        {
            try
            {
                bInitFlag = false;
                DisplayMessage(ResourceHelper.GetValue("MSG_DEVICE_REMOVED"), FORMNAME, MessageTypeEnum.INFO);
                int ret = GlobalData.mfs100.Uninit();
            }
            catch (Exception ex)
            {
                DisplayMessage(ResourceHelper.GetValue("MSG_ERROR_DEVICE_NOT_CONNECTED") + ex.Message, FORMNAME, MessageTypeEnum.ERROR);
            }
        }
        void OnPreview(FingerData fingerprintData)
        {
            Thread trd = new Thread(() =>
            {
                try
                {
                    if (fingerprintData != null)
                    {
                        //pbxFingerPrint.Image = fingerprintData.FingerImage;
                        //pbxFingerPrint.Refresh();
                    }
                }
                catch (Exception)
                {
                }
            });
            trd.Start();

        }

        void OnCaptureCompleted(bool status, int errorCode, string errorMsg, FingerData fingerprintData)
        {
            try
            {
                if (status)
                {
                    sRetVal = MatchFingerPrint(fingerprintData);
                    if (sRetVal != GlobalData.SUCCESS)
                    {
                        DisplayMessage(sRetVal, FORMNAME, MessageTypeEnum.ERROR);
                    }
                    else
                    {
                        this.Hide();
                        Thread t = new Thread(new ThreadStart(Safe_DoSomethingOnGui));
                        t.SetApartmentState(ApartmentState.STA);
                        t.Start();
                    }
                }
                else
                {
                    GlobalData.mfs100.StartCapture();
                }
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message, FORMNAME, MessageTypeEnum.ERROR);
            }
        }
        private void Safe_DoSomethingOnGui()
        {
            AdminDashboard objDash = new AdminDashboard();
            objDash.Closed += (s, args) => this.Close();
            Application.Run(objDash);
        }
        private string MatchFingerPrint(FingerData fingerprintData)
        {
            int score = 0;
            bool matchFlag = false;

            try
            {
                DataTable data = new DataTable();               
                var response = RestAPIHelper.GetAsync<ApiResponse<List<tblStaff>>>(ApiConstants.API_GET_STAFF_GETSTAFFFORLOGIN);
                if(response.IsSuccessfull == true)
                {
                    List<tblStaff> staffs = response.Data;

                    foreach (tblStaff staff in staffs)
                    {
                        if (staff.FingerPrintANSI != null)
                        {
                            byte[] storedFPByte = Convert.FromBase64String(staff.FingerPrintANSI);
                            int ret = GlobalData.mfs100.MatchANSI(storedFPByte, fingerprintData.ANSITemplate, ref score);
                            if (score >= MatchThreshold)
                            {
                                matchFlag = true;
                                TokenRequest tokenRequest = new TokenRequest();
                                tokenRequest.Email = staff.EmailID;
                                tokenRequest.Password = staff.Password;
                                AuthenticateLogin(tokenRequest);
                                break;
                            }
                        }
                    }
                    if (matchFlag)
                    {
                        return GlobalData.SUCCESS;
                    }
                    else
                    {
                        GlobalData.mfs100.StartCapture();
                        return ResourceHelper.GetValue("NO_MATCH_ANY_USER");
                    }

                }
                else
                {
                    return ResourceHelper.GetValue("NO_MATCH_ANY_USER"); ;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private void ResetPage()
        {
            TxtUsername.Text = string.Empty;
            TxtPassword.Text = string.Empty;    
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetPage();
        }
        private void AuthenticateLogin(TokenRequest tokenRequest)
        {
            TokenResponse tokenResponse = RestAPIHelper.PostAsync<TokenResponse>(ApiConstants.API_POST_LOGIN_AUTHENTICATE, tokenRequest);

            if (tokenResponse == null)
            {
                DisplayMessage(ResourceHelper.GetValue("NO_MATCH_ANY_USER"), FORMNAME, MessageTypeEnum.ERROR);
            }
            else
            {
                GlobalData.role = tokenResponse.Role;
                GlobalData.ID = tokenResponse.Id;
                GlobalData.loginName = tokenResponse.UserName;
                GlobalData.token = tokenResponse.Token;
                GlobalData.mfs100.OnCaptureCompleted -= OnCaptureCompleted;
                GlobalData.mfs100.OnCaptureCompleted += OnCaptureCompleted_End;
                int iRet = GlobalData.mfs100.StartCapture(9999, 1, false);

                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Closed += (s, args) => this.Close();
                adminDashboard.Show();
                this.Hide();
            }
            return;
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                TokenRequest tokenRequest = new TokenRequest();
                tokenRequest.Email = TxtUsername.Text;
                tokenRequest.Password = TxtPassword.Text;

                AuthenticateLogin(tokenRequest);             
            }
        }
        public void OnCaptureCompleted_End(bool status, int errorCode, string errorMsg, FingerData fingerprintData)
        {
        }
        private void TxtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
                if (Validators.RequiredValidation(TxtUsername.Text))
                {
                    if (Validators.IsValidEmail(TxtUsername.Text))
                    {
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(TxtUsername, ResourceHelper.GetValue("EMAIL_VALIDATION_FAIL"));
                        TxtUsername.Focus();
                        e.Cancel = true;
                    }
                }
                else
                {
                    errorProvider1.SetError(TxtUsername, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                    TxtUsername.Focus();
                    e.Cancel = true;
                }
        }

        private void TxtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Validators.RequiredValidation(TxtPassword.Text))
            {
                
                    errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(TxtPassword, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                TxtPassword.Focus();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
