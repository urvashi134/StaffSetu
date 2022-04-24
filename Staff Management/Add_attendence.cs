using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Staff_Management
{
    public partial class Add_attendence : Form
    {
        public Add_attendence()
        {
            InitializeComponent();
        }

        private void Add_attendence_Load(object sender, EventArgs e)
        {
            FillStatus();
        }
        private void FillStatus()
        {
            List<ComboBoxDataSources> comboBoxDataSources = new List<ComboBoxDataSources>();
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "P",
                DisplayMember = "Present"
            });
            comboBoxDataSources.Add(new ComboBoxDataSources()
            {
                Value = "A",
                DisplayMember = "Absent"
            });
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
