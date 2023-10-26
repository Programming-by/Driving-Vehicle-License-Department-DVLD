﻿using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLDWinForm
{
    public partial class FormInternationalDrivingLicenseApplications : Form
    {
        public FormInternationalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private static DataTable _dtAllApplications;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        private void FormInternationalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            _dtAllApplications = clsInternationalDrivingLicenseApplications.GetAllInternationalDrivingLicenseApplications();
            dgvApplications.DataSource = _dtAllApplications;
            cbFilters.SelectedIndex = 0;
            lblLocalDrivingLicenseApplicationsCount.Text = dgvApplications.Rows.Count.ToString();
            if (dgvApplications.Rows.Count > 0)
            {

            dgvApplications.Columns[0].HeaderText = "Int.License ID";
            dgvApplications.Columns[0].Width = 110;

            dgvApplications.Columns[1].HeaderText = "Application ID";
            dgvApplications.Columns[1].Width = 110;

            dgvApplications.Columns[2].HeaderText = "Driver ID";
            dgvApplications.Columns[2].Width = 110;

            dgvApplications.Columns[3].HeaderText = "L.License ID";
            dgvApplications.Columns[3].Width = 110;

            dgvApplications.Columns[4].HeaderText = "Issue Date";
            dgvApplications.Columns[4].Width = 200;

            dgvApplications.Columns[5].HeaderText = "Expiration Date";
            dgvApplications.Columns[5].Width = 200;

            dgvApplications.Columns[6].HeaderText = "Is Active";
            dgvApplications.Columns[6].Width = 110;

            }
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(cbFilters.Text == "Is Active")
            {
                txtFilter1.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            } else
            {
            txtFilter1.Visible = (cbFilters.Text != "None");
            cbIsActive.Visible = false;
            txtFilter1.Text = "";
            txtFilter1.Focus();

            }

        }

        private void txtFilter1_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";
            switch (cbFilters.Text)
            {
                case "International License ID":
                    FilterColumn = "InternationalLicenseID";
                    break;
                case "Application ID":
                    FilterColumn = "ApplicationID";

                    break;
                case "Driver ID":
                    FilterColumn = "DriverID";

                    break;
                case "Local License ID":
                    FilterColumn = "IssuedUsingLocalLicenseID";

                    break;
                default:
                    break;
            }
            if (txtFilter1.Text.Trim() == "" || cbFilters.Text == "None")
            {
                _dtAllApplications.DefaultView.RowFilter = "";
                lblLocalDrivingLicenseApplicationsCount.Text = dgvApplications.Rows.Count.ToString();
                return;
            }

                _dtAllApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter1.Text.Trim());
            
        }

        private void btnAddNewApplication_Click(object sender, EventArgs e)
        {
            //FormNewDrivingLicenseApplication frm = new FormNewDrivingLicenseApplication();

            //frm.ShowDialog();
        }

        private void txtFilter1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string[] IDs = {"International License ID","Application ID","Driver ID", "Local License ID" };

                if (IDs.Contains(cbFilters.Text))
                    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;
            switch (cbIsActive.Text)
            {
                case "All":

                    break;

                case "Yes":
                    FilterValue = "1";
                    break;

                case "No":
                    FilterValue = "0";

                    break;

            }
            if (cbIsActive.Text == "All")
                _dtAllApplications.DefaultView.RowFilter = "";
            else
            _dtAllApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

        }
    }
}

