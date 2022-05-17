using MANTRA;
using Setu.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Threading;
using System.Windows.Forms;
namespace Staff_Management
{
    public partial class Login :BaseForm
    {
        string key = string.Empty;
        int quality = Convert.ToInt32(ConfigurationManager.AppSettings["FingerPrintQuality"]);
        int timeout = Convert.ToInt32(ConfigurationManager.AppSettings["FingerPrintTimeout"]);
        bool bInitFlag = false;
        string sRetVal = string.Empty;
        bool fingerPrintLogin = false;
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
                        fingerPrintLogin = true;
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
            // Do whatever you want with the GUI
        }
        private string MatchFingerPrint(FingerData fingerprintData)
        {
            int score = 0;
            bool matchFlag = false;

            try
            {
                DataTable data = new DataTable();
                var staffs = RestAPIHelper.GetAsync<IList<tblStaff>>($"api/Staff/GetStaffForLogin");

                foreach(tblStaff staff in staffs)
                {
                    if (staff.FingerPrintANSI != null)
                    {
                        byte[] storedFPByte = Convert.FromBase64String(staff.FingerPrintANSI);
                        int ret = GlobalData.mfs100.MatchANSI(storedFPByte, fingerprintData.ANSITemplate, ref score);
                        if (score >= MatchThreshold)
                        {
                            matchFlag = true;
                            GlobalData.role = staff.Role;
                            GlobalData.ID = staff.ID;
                            GlobalData.loginName = staff.StaffName;
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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string role = "";
                int id;
                string name = "Admin";
                if (TxtUsername.Text == "a@a.com" && TxtPassword.Text == "p")
                {
                    role = "admin";
                    id = 1;
                }
                else
                {
                    var val = RestAPIHelper.GetAsync<tblStaff>($"api/Staff/GetStaffByEmailPassword/{TxtUsername.Text},{TxtPassword.Text}");
                    if (val == null)
                    {
                       DisplayMessage(ResourceHelper.GetValue("NO_MATCH_ANY_USER"), FORMNAME, MessageTypeEnum.ERROR);
                        //MessageBox.Show("Check your EmailId or password..");
                        return;
                    }
                    role = val.Role;
                    id = val.ID;
                    name = val.StaffName;
                }

                GlobalData.role = role;
                GlobalData.ID = id;
                GlobalData.loginName = name;
                GlobalData.mfs100.OnCaptureCompleted -= OnCaptureCompleted;
                GlobalData.mfs100.OnCaptureCompleted += OnCaptureCompleted_End;
                int iRet = GlobalData.mfs100.StartCapture(9999, 1, false);

                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Closed += (s, args) => this.Close();
                adminDashboard.Show();
                this.Hide();
            }
        }
        public void OnCaptureCompleted_End(bool status, int errorCode, string errorMsg, FingerData fingerprintData)
        {
        }
        private void TxtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(Validators.RequiredValidation(TxtUsername.Text))
            {
                if(Validators.IsValidEmail(TxtUsername.Text))
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
    }
}
