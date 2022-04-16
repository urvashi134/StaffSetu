using Setu.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Staff_Management
{
    public partial class Designation : Form
    {
        public Designation()
        {
            InitializeComponent();
        }

        private void ViewDesg()
        {
            var val = RestAPIHelper.GetAsync<List<tblDesignation>>("api/Designation/GetDesignation");
            DataGridViewDesg.DataSource = val;
        }
        private void BtnSaveDesg_Click(object sender, EventArgs e)
        {
            tblDesignation objtblDesignation = new tblDesignation();
            objtblDesignation.ID = 0;
            objtblDesignation.Name = TxtDesg.Text.ToString();

            var val = RestAPIHelper.PostAsync<tblDesignation>("api/Designation/InsertDesignation", objtblDesignation);

            if (val == null)
            {
                MessageBox.Show("Addition Failed..");
            }
            else
            {
                MessageBox.Show("Designation Added Succesfully..");
            }

            ResetDesg();
            ViewDesg();
        }

        private void Designation_Load(object sender, EventArgs e)
        {
            ViewDesg();
        }
        private void ResetDesg()
        {
            TxtDesg.Text = string.Empty;
        }
        private void BtnResetDesg_Click(object sender, EventArgs e)
        {
            ResetDesg();
        }
    }
}
