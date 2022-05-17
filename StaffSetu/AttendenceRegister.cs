using Setu.Common.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
        }

        private void AttendenceRegister_Load(object sender, EventArgs e)
        {
            string strDate = DateTime.Now.ToString("dd-MM-yyyyy");
            DtAttendenceDate.Value = DateTime.Now;
            if (GetAttendenceByDate())
            {
                //SetDtStatus();
                ResourceHelper.SetLabel(this);
                ActiveControl = DtAttendenceDate;
                FORMNAME = ResourceHelper.GetValue("lblAttendenceRegister");

            }
            else
            {
                this.Close();
            }
        }

        private void DtAttendenceDate_ValueChanged(object sender, EventArgs e)
        {
            LbDay.Text = "(" + DtAttendenceDate.Value.ToString("ddd") + ")"; 
            GetAttendenceByDate();
        }

        private bool GetAttendenceByDate()
        {
            bool result = true;

            Setu.Common.DTO.AttendenceRules attendenceRules = new Setu.Common.DTO.AttendenceRules();
            attendenceRules.date = DateTime.Now.Date;
            var val = RestAPIHelper.PostAsync<List<AttendenceRegisterResponseDTO>>("api/Attendence/GetAttendenceByDate", attendenceRules);
            if (val != null)
            {
                dataGridAttendence.DataSource = val;
            }
            else
            {
                DisplayMessage(ResourceHelper.GetValue("NO_RECORD_FOUND"), FORMNAME, MessageTypeEnum.ERROR);
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
                //TextBox txtbox = (TextBox)e.Control;
                //txtbox.TextChanged += StatusTextBox_TextChanged;
                //txtbox.KeyUp -= TextBoxOfAutoComplete_KeyUp;
                //txtbox.Leave += Status_Leave;
                //var WorkingTime = (dataGridAttendence.Rows[_ROWINDEX].Cells["WorkingTime"].Value);
                //DataRow dataRow = _DtStatus.Select(_Status + "='" + ResourceHelper.GetValue(AttendanceStatusEnum.Half_Day.ToString()) + "'").FirstOrDefault();
                //if (!(WorkingTime.IsStringNullOrEmpty()))
                //{
                //    if (dataRow != null)
                //    {
                //        _DtStatus.Rows.Remove(dataRow);
                //    }
                //}
                //else if (dataRow == null)
                //{
                //    AttendanceStatusEnum status = AttendanceStatusEnum.Half_Day;
                //    _DtStatus.Rows.Add((short)status, ResourceHelper.GetValue(status.ToString()));
                //}
                //SetDataGrid(_DtStatus, ref DatagridAutoComp, StatusColumn, StatusFitler, txtbox.Text);
                //DatagridAutoComp.Enter -= DatagridAutoComp_Enter;
                //DatagridAutoComp.Enter += DatagridAutoComp_Enter;
                //DatagridAutoComp.RowEnter -= DatagridAutoComp_RowEnter;
                //DatagridAutoComp.RowEnter += DatagridAutoComp_RowEnter;
                //CreateAutoComplete(dataGridAttendence, DatagridAutoComp, this, true);
                //iSelectedRow = -1;
                //DatagridAutoComp.Visible = false;
            }
            else if (dataGridAttendence.CurrentCell.OwningColumn.Name == _StartTime || dataGridAttendence.CurrentCell.OwningColumn.Name == _EndTime)
            {
                TextBox txtbox = (TextBox)e.Control;
                txtbox.KeyPress += TxtTime_KeyPress;
                txtbox.Leave += Time_TextLeave;

            }
            else if (dataGridAttendence.CurrentCell.OwningColumn.Name == _WorkingHrs)
            {
                //TextBox txtbox = (TextBox)e.Control;
                //txtbox.KeyPress += TxtBreakTime_KeyPress;
                //txtbox.Leave += BreakTime_TextLeave;

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
                //DataGridAccountGroup.Rows[Index].Cells[_WorkingHrs].ReadOnly = false;
            }
            else
            {

                dataGridAttendence.Rows[Index].Cells[_StartTime].ReadOnly = true;
                dataGridAttendence.Rows[Index].Cells[_EndTime].ReadOnly = true;
                // DataGridAccountGroup.Rows[Index].Cells[_WorkingHrs].ReadOnly = true;
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
                textBox.Text = Time.Hour + ":" + Time.Minute + " " + TimeTypeEnum.AM.ToString();
            }
            else if (dataGridAttendence.CurrentCell.OwningColumn.Name == _EndTime)
            {
                textBox.Text = Time.Hour + ":" + Time.Minute + " " + TimeTypeEnum.PM.ToString();
            }
            if (!string.IsNullOrEmpty(time.Replace(":", "")))
            {
                dataGridAttendence.CurrentCell.Value = textBox.Text;
                SetWorkingHrs(dataGridAttendence.CurrentCell.RowIndex);
            }
            //DataGridAccountGroup.EndEdit();
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

    }
}
