﻿using DVLDBusinessLayer;
using DVLDClasses;
using DVLDWinForm.Licenses.Local_Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWinForm.Licenses.Detain_License
{
    public partial class FormDetainLicense : Form
    {
        private int _DetainID = -1;
        private int _SelectedLicenseID = -1;

        public FormDetainLicense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to detain this license?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }



            _DetainID = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.Detain(Convert.ToSingle(txtFineFees.Text), clsGlobal.CurrentUser.UserID);

            if (_DetainID == -1)
            {
                MessageBox.Show("Failed to Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            lblDetainID.Text = _DetainID.ToString();
            MessageBox.Show("License Detained Successfully with ID=" + _DetainID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDetain.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            txtFineFees.Enabled = false;    
            llShowLicenseInfo.Enabled = true;
        
        }

        private void FormDetainLicense_Load(object sender, EventArgs e)
        {
            lblDetainDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;
        }

        private void FormDetainLicense_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {

            _SelectedLicenseID = obj;

            lblLicenseID.Text = _SelectedLicenseID.ToString();
            llShowLicenseHistory.Enabled = (_SelectedLicenseID != -1);

            if (_SelectedLicenseID == -1)
            {
                return;
            }

            if (ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsDetained)
            {
                MessageBox.Show("Selected License i already detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtFineFees.Focus();
            
            btnDetain.Enabled = true;
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FormShowPersonLicenseHistory frm = new FormShowPersonLicenseHistory(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);

            frm.ShowDialog();

        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowLicenseInfo frm = new FormShowLicenseInfo(_SelectedLicenseID);

            frm.ShowDialog();   
        }

        private void txtFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFineFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "Fees cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(txtFineFees, null);

            }

            if (!clsValidation.IsNumber(txtFineFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "Invalid Number.");

            } else
            {
                errorProvider1.SetError(txtFineFees, null);
            }

        }
    }
}
