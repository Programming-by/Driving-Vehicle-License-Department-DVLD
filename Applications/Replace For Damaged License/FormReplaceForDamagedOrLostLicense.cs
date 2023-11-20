using DVLDBusinessLayer;
using DVLDClasses;
using DVLDWinForm.Licenses;
using DVLDWinForm.Licenses.Local_Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLDBusinessLayer.clsLicenseData;

namespace DVLDWinForm.Applications.Replace_For_Damaged_License
{
    public partial class FormReplaceForDamagedOrLostLicense : Form
    {
        private int _NewLicenseID = -1;
        public FormReplaceForDamagedOrLostLicense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int _GetApplicationTypeID()
        {
            if (rbDamagedLicense.Checked)
               return (int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense;
            else
                return (int)clsApplication.enApplicationType.ReplaceLostDrivingLicense;
        }

        private enIssueReason _GetIssueReason()
        {
            if (rbDamagedLicense.Checked)
                return clsLicenseData.enIssueReason.DamagedReplacement;
            else
                return clsLicenseData.enIssueReason.LostReplacement;
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Issue a Replacement for the license","Confirm",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
        
            clsLicenseData _NewLicense = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.Replace(_GetIssueReason() , clsGlobal.CurrentUser.UserID);
            
            if (_NewLicense == null)
            {
                MessageBox.Show("Failed to Issue a replacement for this  License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblApplicationID.Text = _NewLicense.ApplicationID.ToString();
            _NewLicenseID = _NewLicense.LicenseID;
            lblRenewedLicenseID.Text = _NewLicenseID.ToString();
            MessageBox.Show("Licensed Replaced Successfully with id = " + _NewLicense.LicenseID, "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            btnIssueReplacement.Enabled = false;
            gbReplacementFor.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            llShowLicenseInfo.Enabled = true;
        
        }

        private void FormReplaceForDamagedOrLostLicense_Load(object sender, EventArgs e)
        {

            lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;

            rbDamagedLicense.Checked = true;
        }
        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Replacement For Damaged License";
            this.Text = lblTitle.Text;
            lblApplicationFees.Text = clsApplicationTypesData.Find(_GetApplicationTypeID()).Fees.ToString();
        }
        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Replacement For Lost License";
            this.Text = lblTitle.Text;
            lblApplicationFees.Text = clsApplicationTypesData.Find(_GetApplicationTypeID()).Fees.ToString();

        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int SelectedLicenseID = obj;
            lblOldLicenseID.Text = SelectedLicenseID.ToString();

            llShowLicenseHistory.Enabled = (SelectedLicenseID != -1);

            if (SelectedLicenseID == -1)
            {
                return;
            }


            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
            MessageBox.Show("Selected License Is not Active", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                btnIssueReplacement.Enabled = false;
                return;
            }

            btnIssueReplacement.Enabled = true;
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowPersonLicenseHistory frm = new FormShowPersonLicenseHistory(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);

            frm.ShowDialog();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowLicenseInfo frm = new FormShowLicenseInfo(_NewLicenseID);

            frm.ShowDialog();
        }

    }
}
