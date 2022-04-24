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
            Staff staff = new Staff();
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
            if (GlobalData.role.Equals("staff", StringComparison.InvariantCultureIgnoreCase))
            {
                List<ToolStripMenuItem> allItems = new List<ToolStripMenuItem>();
                foreach (ToolStripMenuItem toolItem in this.menuStrip1.Items)
                {
                    allItems.Add(toolItem);
                    allItems.AddRange(GetItems(toolItem));
                }
                allItems.ForEach(x =>
                {
                    if (x == StaffToolStripMenuItem || x == MasterToolStripMenuItem)
                    {
                        x.Visible = true;
                    }
                    else
                    {
                        x.Visible = false;
                    }
                });
            }
            
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

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_attendence add_Attendence = new Add_attendence();
            DisplayForm(add_Attendence);
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        
    }
}
