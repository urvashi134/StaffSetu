using MANTRA;
using Setu.Common.DTO;
using Setu.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staff_Management
{
    public partial class DailyAttendence : BaseForm
    {
        public int id = 0;
        string key = string.Empty;
        bool bInitFlag = false;
        Bitmap bmp = null;
        int quality = Convert.ToInt32(ConfigurationManager.AppSettings["FingerPrintQuality"]);
        byte[] byteANSI = null;
        int MatchThreshold = 500;

        public DailyAttendence()
        {
            InitializeComponent();
        }

        private void Add_attendence_Load(object sender, EventArgs e)
        {
            ConfigureFingerPrintDevice();
            //AutoCompleteStringCollection id = new AutoCompleteStringCollection();
            //id.Add("10");
            //id.Add("11");
            //id.Add("122");
            //id.Add("1456");
            //TxtStaffID.AutoCompleteMode = AutoCompleteMode.Suggest;
            //TxtStaffID.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //TxtStaffID.AutoCompleteCustomSource = id;
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
                    string sRetVal = MatchFingerPrint(fingerprintData);
                    if (sRetVal != GlobalData.SUCCESS)
                    {
                        DisplayMessage(sRetVal, FORMNAME, MessageTypeEnum.ERROR);
                    }
                    else
                    {
                        TxtStaffID_Leave(null, null);
                    }
                }
                else
                {
                    GlobalData.mfs100.StartCapture();
                    //DisplayMessage("Capture Failed.\nFinger data could not be recorded properly.", FORMNAME, MessageTypeEnum.ERROR);
                }
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message, FORMNAME, MessageTypeEnum.ERROR);
            }
        }

        private string MatchFingerPrint(FingerData fingerprintData)
        {
            int score = 0;
            bool matchFlag = false;

            try
            {
                DataTable data = new DataTable();
                var staffs = RestAPIHelper.GetAsync<IList<tblStaff>>($"api/Staff/GetStaffForLogin");

                foreach (tblStaff staff in staffs)
                {
                    if (staff.FingerPrintANSI != null)
                    {
                        fingerprintData.FingerImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        if (bmp != null)
                            bmp.Dispose();

                        PictureBox pictureBox = PictureBx_AddUserReg_FingerprintImpression;
                        bmp = new Bitmap(pictureBox.Width, pictureBox.Height, pictureBox.CreateGraphics());
                        var graph = Graphics.FromImage(bmp);
                        graph.DrawImage(fingerprintData.FingerImage, 0, 0, pictureBox.Width, pictureBox.Height);
                        pictureBox.Image = bmp;
                        pictureBox.Refresh();

                        byte[] storedFPByte = Convert.FromBase64String(staff.FingerPrintANSI);
                        int ret = GlobalData.mfs100.MatchANSI(storedFPByte, fingerprintData.ANSITemplate, ref score);
                        if (score >= MatchThreshold)
                        {
                            matchFlag = true;
                            TxtStaffID.Text = staff.ID.ToString();
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                tblAttendence tblAttendence = new tblAttendence
                {
                    ID = id,
                    StaffID = Convert.ToInt32(TxtStaffID.Text),
                    myDate = DtToday.Value
                };
                if (rdBtnPresent.Checked)
                {
                    tblAttendence.Status = 'P';
                    tblAttendence.StartTime = timeStart.Value.ToString("HH:mm");
                    tblAttendence.EndTime = timeEnd.Value.ToString("HH:mm");
                    //string startTime = "08:00";
                    //string[] delim = { ":" };
                    //string[] start = startTime.Split(delim, StringSplitOptions.RemoveEmptyEntries);
                    //DateTime dt = new DateTime(0, 0, 0, Convert.ToInt32(start[0]), Convert.ToInt32(start[1]), 0);
                }
                else
                {
                    tblAttendence.StartTime = "00:00";
                    tblAttendence.EndTime = "00:00";
                    if (rdBtnAbsent.Checked)
                        tblAttendence.Status = 'A';
                    else
                        tblAttendence.Status = 'L';
                }
                if (id == 0)
                {
                    var val = RestAPIHelper.PostAsync<tblAttendence>("api/Attendence/InsertAttendence", tblAttendence);
                    if (val == null)
                    {
                        // MessageBox.Show(ResourceHelper.GetValue("UNSUCCESSFULL_ATTENDENCE_ADDITION"));
                        MessageBox.Show("Not Successfull");
                    }
                    else
                    {
                        //MessageBox.Show(ResourceHelper.GetValue("SUCCESSFULL"));
                        MessageBox.Show("Successfull");
                    }
                }
                else
                {
                    var val = RestAPIHelper.PostAsync<tblAttendence>("api/Attendence/UpdateAttendence", tblAttendence);
                    if (val == null)
                    {
                        // MessageBox.Show(ResourceHelper.GetValue(""));
                        MessageBox.Show("Unsuccessfull");
                    }

                    else
                    {
                        MessageBox.Show("Successfull");
                        //MessageBox.Show(ResourceHelper.GetValue(""));
                    }

                }
                ResetPage();

            }
        }
        private void TxtStaffID_Validating(object sender, CancelEventArgs e)
        {
            if (Validators.RequiredValidation(TxtStaffID.Text))
            {
                if (Validators.IsNumeric(TxtStaffID.Text))
                {
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(TxtStaffID, ResourceHelper.GetValue("NUMERIC_VALIDATION_FAIL"));
                    TxtStaffID.Focus();
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider1.SetError(TxtStaffID, ResourceHelper.GetValue("REQUIRED_VALIDATION_FAIL"));
                TxtStaffID.Focus();
                e.Cancel = true;
            }
        }

        private void rdBtnPresent_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnPresent.Checked)
            {
                timeStart.Enabled = true;
                timeEnd.Enabled = true;
            }
            else
            {
                timeStart.Enabled = false;
                timeEnd.Enabled = false;
            }
        }
        private void ResetPage()
        {
            try
            {
                TxtStaffID.Text = string.Empty;
                DtToday.Value = DateTime.Today;
                rdBtnPresent.Checked = true;
                DateTime dt = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0);
                timeStart.Value = dt;
                timeEnd.Value = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void TxtStaffID_Leave(object sender, EventArgs e)
        {
            try
            {
                int staffId = Convert.ToInt32(TxtStaffID.Text);
                DateTime date = DtToday.Value.Date;
                Setu.Common.DTO.AttendenceRules obj = new Setu.Common.DTO.AttendenceRules();
                obj.staffId = staffId;
                obj.date = date;
                var val = RestAPIHelper.PostAsync<tblAttendence>("api/Attendence/GetAttendenceByStaffIdDate", obj);
                if (val != null)
                {
                    id = val.ID;
                    if (val.Status == 'P')
                        rdBtnPresent.Checked = true;
                    else if (val.Status == 'A')
                        rdBtnAbsent.Checked = true;
                    else
                        rdBtnLeave.Checked = true;

                    string[] delim = { ":" };
                    string[] start = val.StartTime.Split(delim, StringSplitOptions.RemoveEmptyEntries);
                    DateTime dt1 = new DateTime(date.Year, date.Month, date.Day, Convert.ToInt32(start[0]), Convert.ToInt32(start[1]), 0);
                    timeStart.Value = dt1;
                    string[] end = val.EndTime.Split(delim, StringSplitOptions.RemoveEmptyEntries);
                    DateTime dt2 = new DateTime(date.Year, date.Month, date.Day, Convert.ToInt32(end[0]), Convert.ToInt32(end[1]), 0);
                    timeEnd.Value = dt2;
                }
            }
            catch (Exception)
            {

            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetPage();
        }
    }
}
