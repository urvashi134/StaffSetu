using Setu.Common.DTO;
using StaffSetu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Staff_Management
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x10) // The upper right "X" was clicked
            {
                AutoValidate = AutoValidate.Disable; //Deactivate all validations
            }
            base.WndProc(ref m);
        }
        private void DisplayForm(Form myForm)
        {
            myForm.Dock = DockStyle.Fill;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(myForm);

            myForm.Show();
        }

        private void StaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff_New staff = new Staff_New();
            DisplayForm(staff);
        }

        private void DeaprtmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            DisplayForm(department);
        }
        private void DesignationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Designation designation = new Designation();
            DisplayForm(designation);
        }

        private void SubjectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            DisplayForm (subject);
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            if (GlobalData.role.Equals(RolesConstant.ROLE_STAFF, StringComparison.InvariantCultureIgnoreCase))
            {
                List<ToolStripMenuItem> allItems = new List<ToolStripMenuItem>();
                foreach (ToolStripMenuItem toolItem in this.menuStrip1.Items)
                {
                    allItems.Add(toolItem);
                    allItems.AddRange(GetItems(toolItem));
                }
                allItems.ForEach(x =>
                {
                    if (x == StaffToolStripMenuItem || x == MasterToolStripMenuItem ||
                    x==SubjectToolStripMenuItem1||x==AttendenceToolStripMenuItem || x==AttendenceRulesToolStripMenuItem ||
                    x==viewToolStripMenuItem || x==userwiseToolStripMenuItem || x==salaryToolStripMenuItem || x==salaryreportToolStripMenuItem
                    || x== logoutToolStripMenuItem)
                    {
                        x.Visible = true;
                    }
                    else
                    {
                        x.Visible = false;
                    }
                });
            }
            
            lblLoginName.Text = GlobalData.loginName;
            
        }
        private IEnumerable<ToolStripMenuItem> GetItems(ToolStripMenuItem item)
        {
            foreach (ToolStripMenuItem dropDownItem in item.DropDownItems)
            {
                if (dropDownItem.HasDropDownItems)
                {
                    foreach (ToolStripMenuItem subItem in GetItems(dropDownItem))
                        yield return subItem;
                }
                yield return dropDownItem;
            }
        }

        private void MarkIndividualAttendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyAttendence add_Attendence = new DailyAttendence();
            DisplayForm(add_Attendence);
        }

        private void MarkMultipleAttendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttendenceRegister attendenceRegister = new AttendenceRegister();
            DisplayForm(attendenceRegister);
        }

        private void AttendenceRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttendenceRules attendence_Rules = new AttendenceRules();
            DisplayForm(attendence_Rules);
        }

        private void userwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserWiseAttendence userWiseAttendence = new UserWiseAttendence();
            DisplayForm(userWiseAttendence);
        }

        private void monthwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthWiseAttendence monthWiseAttendence = new MonthWiseAttendence();
            DisplayForm(monthWiseAttendence);
        }

        private void confirmSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmAttendence confirm  = new ConfirmAttendence();
            DisplayForm(confirm);

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserWiseSalary salaryReport = new UserWiseSalary();
            DisplayForm(salaryReport);
        }
    }
}
