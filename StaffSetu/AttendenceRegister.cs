using Setu.Common.DTO;
using System;
using Setu.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Staff_Management.Helper;

namespace Staff_Management
{
    public partial class AttendenceRegister : BaseForm
    {
        int _ROWINDEX = -1;
        List<int> RowIndexToUpdate = new List<int>();
        const string _Status = "Status";
        const string _StartTime = "StartTime";
        const string _EndTime = "EndTime";
        const string _WorkingHrs = "WorkingHrs";

        public AttendenceRegister()
        {
            InitializeComponent();
            FORMNAME = this.Text;
        }

        private void AttendenceRegister_Load(object sender, EventArgs e)
        {
            DtAttendenceDate.Value = DateTime.Now;
            if (GetAttendenceByDate())
            {
                ResourceHelper.SetLabel(this);
                ActiveControl = DtAttendenceDate;
            }
            else
            {
                Close();
            }
        }

        private void DtAttendenceDate_ValueChanged(object sender, EventArgs e)
        {
            LbDay.Text = "(" + DtAttendenceDate.Value.Equals("ddd") + ")"; 
            GetAttendenceByDate();
        }

        private bool GetAttendenceByDate()
        {
            bool result = true;

            Setu.Common.DTO.AttendenceRules attendenceRules = new Setu.Common.DTO.AttendenceRules
            {
                date = DtAttendenceDate.Value
            };
            var val = RestAPIHelper.PostAsync<ApiResponse<List<AttendenceRegisterResponseDTO>>>(ApiConstants.API_POST_ATTENDENCE_GET_ATTENDENCE_BY_DATE, attendenceRules);
            if (val != null)
            {
                if (val.IsSuccessfull)
                {
                    dataGridAttendence.DataSource = val.Data;
                    foreach (DataGridViewRow row in dataGridAttendence.Rows)
                    {
                        SetColumnReadOnly(row.Cells["Status"].ToString(), row.Index);
                        
                    }
                }
                else
                {
                    DisplayMessage(ResourceHelper.GetValue("NO_RECORD_FOUND"), FORMNAME, MessageTypeEnum.ERROR);
                }
            }
            else
            {
                DisplayMessage(ResourceHelper.GetValue("MSG_ERROR_CALLING_API"), FORMNAME, MessageTypeEnum.ERROR);
            }

            return result;
        }

        private void dataGridAttendence_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            object Sender = new object();
            Sender = e.Control;
            RemoveAllFunctions(e);
            int rowIndex = dataGridAttendence.CurrentCell.RowIndex;
            _ROWINDEX = dataGridAttendence.CurrentCell.RowIndex;
            if (!RowIndexToUpdate.Contains(_ROWINDEX))
            {
                RowIndexToUpdate.Add(_ROWINDEX);
            }
            int noOfRows = dataGridAttendence.RowCount;
            if (e.Control is TextBox)
            {
                TextBox tb = (TextBox)e.Control;
                tb.AutoCompleteMode = AutoCompleteMode.None;
            }
            if (dataGridAttendence.CurrentCell.OwningColumn.Name == _Status)
            {
                var column = (ComboBox)e.Control;
                column.SelectedIndexChanged += Status_SelectedIndexChanged;
            }
            else if (dataGridAttendence.CurrentCell.OwningColumn.Name == _StartTime || dataGridAttendence.CurrentCell.OwningColumn.Name == _EndTime)
            {
                TextBox txtbox = (TextBox)e.Control;
                txtbox.KeyPress += TxtTime_KeyPress;
                txtbox.Leave += Time_TextLeave;

            }
        }

        private void Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ctrl = (ComboBox)sender;

            SetColumnReadOnly(ctrl.Text, dataGridAttendence.CurrentRow.Index);
        }

        private void RemoveAllFunctions(DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                TextBox textBox = (TextBox)e.Control;
                textBox.KeyPress -= TxtTime_KeyPress;
                textBox.Leave -= Time_TextLeave;//credit/debit leave
            }
            else if (e.Control is ComboBox)
            {
                ComboBox comboBox = (ComboBox)e.Control;
                comboBox.SelectedIndexChanged -= Status_SelectedIndexChanged;
            }
        }
        private void SetColumnReadOnly(string Status, int Index)
        {
            if (Status == "Present")
            {
                dataGridAttendence.Rows[Index].Cells[_StartTime].ReadOnly = false;
                dataGridAttendence.Rows[Index].Cells[_EndTime].ReadOnly = false;
            }
            else
            {

                dataGridAttendence.Rows[Index].Cells[_StartTime].ReadOnly = true;
                dataGridAttendence.Rows[Index].Cells[_EndTime].ReadOnly = true;
                dataGridAttendence.Rows[Index].Cells[_StartTime].Value = string.Empty;
                dataGridAttendence.Rows[Index].Cells[_EndTime].Value = string.Empty;
                dataGridAttendence.Rows[Index].Cells[_WorkingHrs].Value = string.Empty;


            }
        }
        private void TxtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            int index = ((TextBox)sender).SelectionStart;
            string T = Regex.Replace(((TextBox)sender).Text, "[A-Za-z :]", "");
            if (char.IsDigit(e.KeyChar) && !((TextBox)sender).ReadOnly)
            {
                TextBox time = ((TextBox)sender);
                char[] TimeArray = time.Text.ToArray();
                if (TimeArray.Length == 1 && TimeArray[0] != ':')
                {
                    time.Text += e.KeyChar + ":00";
                    e.Handled = true;
                    time.SelectionStart = index + 2;
                    time.SelectionLength = time.Text.Length - (index + 2);

                }
                if (T.Length > 4 && char.IsDigit(e.KeyChar) && !(time.SelectionLength > 0))
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar == 'P') || (e.KeyChar == 'p'))
            {
                TextBox time = ((TextBox)sender);
                if (!time.Text.Contains(TimeTypeEnum.PM.ToString()))
                {
                    time.Text += " " + TimeTypeEnum.PM.ToString();
                    time.SelectionStart = time.Text.Length;
                }
                e.Handled = true;
            }
            else if (e.KeyChar == 'A' || e.KeyChar == 'a')
            {
                TextBox time = ((TextBox)sender);
                if (!time.Text.Contains(TimeTypeEnum.AM.ToString()))
                {
                    time.Text += " " + TimeTypeEnum.AM.ToString();
                    time.SelectionStart = time.Text.Length;
                }

                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar) && !(e.KeyChar == ':') && !(e.KeyChar == Convert.ToChar(Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void Time_TextLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            ConvertTime Time = new ConvertTime();
            string time = Regex.Replace(textBox.Text, "[A-Za-z ]", "");
            if (dataGridAttendence.CurrentCell.OwningColumn.Name == _StartTime || dataGridAttendence.CurrentCell.OwningColumn.Name == _EndTime)
            {
                Time.settime(time, true);
            }
            else
            {
                Time.settime(time, false);
            }
            if (textBox.Text.Contains(TimeTypeEnum.PM.ToString()))
            {
                textBox.Text = Time.Hour + ":" + Time.Minute + " " + TimeTypeEnum.PM.ToString();
            }
            else
            if (textBox.Text.Contains(TimeTypeEnum.AM.ToString()))
            {
                textBox.Text = Time.Hour + ":" + Time.Minute + " " + TimeTypeEnum.AM.ToString();
            }
            else if (dataGridAttendence.CurrentCell.OwningColumn.Name == _StartTime)
            {
                textBox.Text = Time.Hour + ":" + Time.Minute + " " + Time.type;
            }
            else if (dataGridAttendence.CurrentCell.OwningColumn.Name == _EndTime)
            {
                textBox.Text = Time.Hour + ":" + Time.Minute + " " + Time.type;
            }
            if (!string.IsNullOrEmpty(time.Replace(":", "")))
            {
                dataGridAttendence.CurrentCell.Value = textBox.Text;
                SetWorkingHrs(dataGridAttendence.CurrentCell.RowIndex);
            }
        }

        private void SetWorkingHrs(int index)
        {
            if (!(dataGridAttendence.Rows[index].Cells[_EndTime].Value).IsStringNullOrEmpty() && !(dataGridAttendence.Rows[index].Cells[_StartTime].Value).IsStringNullOrEmpty())
            {
                int H = 0;
                int M = 0;
                ConvertTime Start = new ConvertTime();
                ConvertTime End = new ConvertTime();
                ConvertTime WorkingHours = new ConvertTime();
                string StartTime = Regex.Replace((dataGridAttendence.Rows[index].Cells[_StartTime].Value).ToString(), "[A-Za-z ]", "");
                string EndTime = Regex.Replace((dataGridAttendence.Rows[index].Cells[_EndTime].Value).ToString(), "[A-Za-z ]", "");
                string StartTimeType = Regex.Replace((dataGridAttendence.Rows[index].Cells[_StartTime].Value).ToString(), "[0-9: ]", "");
                string EndTimeType = Regex.Replace((dataGridAttendence.Rows[index].Cells[_EndTime].Value).ToString(), "[0-9: ]", "");
                Start.settime(StartTime);
                End.settime(EndTime);
                if (End.Hour.ToInt32() != 0 || End.Minute.ToInt32() != 0)
                {
                    if (StartTimeType != EndTimeType)
                    {
                        if (Start.Hour.ToInt32() == End.Hour.ToInt32())
                        {
                            H = 12;
                        }
                        else if (Start.Hour.ToInt32() < 12 && End.Hour.ToInt32() < 12)
                        {
                            H = (12 - Start.Hour.ToInt32()) + End.Hour.ToInt32();
                        }
                        else if (Start.Hour.ToInt32() < 12 && End.Hour.ToInt32() == 12)
                        {
                            H = (12 - Start.Hour.ToInt32());
                        }
                        else if (Start.Hour.ToInt32() == 12 && End.Hour.ToInt32() < 12)
                        {
                            H = 12 + (End.Hour.ToInt32());
                        }

                    }
                    else if (StartTimeType == EndTimeType)
                    {
                        if (Start.Hour.ToInt32() == End.Hour.ToInt32())
                        {
                            H = 0;
                        }
                        else if (Start.Hour.ToInt32() < 12 && End.Hour.ToInt32() < 12)
                        {
                            if (Start.Hour.ToInt32() > End.Hour.ToInt32())
                            {
                                H = (24 - Start.Hour.ToInt32()) + End.Hour.ToInt32();
                            }
                            else
                            {
                                H = End.Hour.ToInt32() - Start.Hour.ToInt32();
                            }
                        }
                        else if (Start.Hour.ToInt32() < 12 && End.Hour.ToInt32() == 12)
                        {
                            H = (24 - Start.Hour.ToInt32());
                        }
                        else if (Start.Hour.ToInt32() == 12 && End.Hour.ToInt32() < 12)
                        {
                            H = (End.Hour.ToInt32());
                        }

                    }
                    if (End.Minute.ToInt32() >= Start.Minute.ToInt32())
                    {
                        M = End.Minute.ToInt32() - Start.Minute.ToInt32();
                    }
                    else if (Start.Minute.ToInt32() > End.Minute.ToInt32())
                    {
                        if (H != 0)
                        {
                            H = H - 1;

                            M = 60 - Start.Minute.ToInt32() + End.Minute.ToInt32();
                        }
                    }
                    if (M < 0)
                    {
                        H = H - 1;
                        M = (M + 60) % 60; ;
                    }
                    H = H + M / 60;
                    M = M % 60;
                }
                WorkingHours.settime(H + ":" + M);
                if (WorkingHours.Hour.ToInt32() < 0)
                {
                    DisplayMessage(ResourceHelper.GetValue("MSG_ERROR_STARTTIME_LESS_ENDTIME"), FORMNAME, MessageTypeEnum.ERROR);
                    return;
                }
                else
                {
                    dataGridAttendence.Rows[index].Cells[_WorkingHrs].Value = WorkingHours.Hour + ":" + WorkingHours.Minute;
                }
            }
            else
            {
                dataGridAttendence.Rows[index].Cells[_WorkingHrs].Value = "00:00";
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DisplayMessage(ResourceHelper.GetValue("Msg_Quit"), FORMNAME, MessageTypeEnum.INPUTBOX);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                object sender = new object();
                EventArgs eventArgs = new EventArgs();
                BtnQuit_Click(sender, eventArgs);
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int index = 0;
                List<tblAttendence> tblAttendences = new List<tblAttendence>();
                foreach (DataGridViewRow row in dataGridAttendence.Rows)
                {
                    if(!row.Cells["Status"].IsStringNullOrEmpty())
                    {
                        if (RowIndexToUpdate.Contains(index))
                        {
                            tblAttendence tblAttendence = new tblAttendence();
                            tblAttendence.ID = Convert.ToInt32(row.Cells["ID"].Value);
                            tblAttendence.StaffID = Convert.ToInt32(row.Cells["StaffId"].Value);
                            tblAttendence.myDate = DtAttendenceDate.Value;
                            tblAttendence.Status = row.Cells["Status"].Value.ToString()[0];
                            if (tblAttendence.Status == 'P')
                            {
                                var startTime = ConvertTime24Format(Convert.ToString(row.Cells["StartTime"].Value));
                                tblAttendence.StartTime = startTime;
                                tblAttendence.EndTime = ConvertTime24Format(Convert.ToString(row.Cells["EndTime"].Value));
                            }
                            tblAttendences.Add(tblAttendence);
                        }
                    }
                    
                    index++;
                }
                var val = RestAPIHelper.PostAsync<ApiResponse<bool>>(ApiConstants.API_POST_ATTENDENCE_INSERT_UPDATE, tblAttendences);
                if (val != null)
                {
                    if (val.IsSuccessfull)
                    {
                        DisplayMessage(ResourceHelper.GetValue("MSG_SUCCESS_UPDATING_ATTENDENCE"), FORMNAME, MessageTypeEnum.SUCCESS); ;
                    }
                    else
                    {
                        DisplayMessage(ResourceHelper.GetValue("MSG_ERROR_UPDATING_ATTENDENCE"), FORMNAME, MessageTypeEnum.ERROR);
                    }
                }
                else
                {
                    DisplayMessage(ResourceHelper.GetValue("MSG_ERROR_CALLING_API"), FORMNAME, MessageTypeEnum.ERROR);
                }
            }
            catch (Exception)
            {
                DisplayMessage(ResourceHelper.GetValue("MSG_ERROR_UPDATING_ATTENDENCE"), FORMNAME, MessageTypeEnum.ERROR);
            }
        }
        private string ConvertTime24Format(string time)
        {
            if (time.Contains(TimeTypeEnum.AM.ToString()))
            {
                time = time.Replace(TimeTypeEnum.AM.ToString(), "").Trim();
            }
            else if (time.Contains(TimeTypeEnum.PM.ToString()))
            {
                time = time.Replace(TimeTypeEnum.PM.ToString(), "").Trim();
                var timePart = time.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
                time = (Convert.ToInt32(timePart[0]) + 12) + ":" + timePart[1];
            }
            return time;
        }

        private void dataGridAttendence_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ConvertTime Time = new ConvertTime();

            int index = 0;
            foreach (DataGridViewRow row in dataGridAttendence.Rows)
            {
                string startTime = Convert.ToString( row.Cells["StartTime"].Value);
                if (!string.IsNullOrEmpty(startTime))
                {
                    string time = Regex.Replace(startTime, "[A-Za-z ]", "");
                    Time.settime(time, true);
                    row.Cells["StartTime"].Value =  Time.Hour + ":" + Time.Minute + " " + Time.type;
                }
                string endTime = Convert.ToString(row.Cells["EndTime"].Value);
                if (!string.IsNullOrEmpty(startTime))
                {
                    string time = Regex.Replace(endTime, "[A-Za-z ]", "");
                    Time.settime(time, true);
                    row.Cells["EndTime"].Value = Time.Hour + ":" + Time.Minute + " " + Time.type;
                }
                SetWorkingHrs(index);
                index++;
            }
        }
    }
}
