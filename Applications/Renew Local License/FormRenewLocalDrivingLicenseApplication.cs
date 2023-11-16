using DVLDBusinessLayer;
using DVLDClasses;
using DVLDWinForm.Licenses;
using DVLDWinForm.Licenses.Controls;
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

namespace DVLDWinForm.Applications.Renew_Local_License
{
    public partial class FormRenewLocalDrivingLicenseApplication : Form
    {
        private int _NewLicenseID = -1;
        public FormRenewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }


        private void btnRenewLicense_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsLicenseData NewLicense = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.RenewLicense(txtNotes.Text.Trim(),clsGlobal.CurrentUser.UserID);

            if (NewLicense == null)
            {
                MessageBox.Show("Failed to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblApplicationID.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;
            lblRenewedLicenseID.Text = _NewLicenseID.ToString();
            MessageBox.Show("Licensed Renewed Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnRenewLicense.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            llShowLicenseInfo.Enabled = true;


        }

        private void FormRenewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {

            lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblIssueDate.Text = lblApplicationDate.Text;
            lblExpirationDate.Text = "???";
            lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;
            lblApplicationFees.Text = clsApplicationTypesData.Find((int) clsApplication.enApplicationType.RenewDrivingLicense).Fees.ToString();
        
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
            int DefaultValidityLength = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassInfo.DefaultValidityLength;
            lblExpirationDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(DefaultValidityLength));
            lblLicenseFees.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassInfo.ClassFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblLicenseFees.Text)).ToString();
            txtNotes.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.Notes;

            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsLicenseExpired())
            {
                MessageBox.Show("Selected License is not yet expired,it will expire in " + ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.ExpirationDate, "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenewLicense.Enabled = false;
                return;
            }

            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Selected License is Not Active, choose an active license."
                                , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                btnRenewLicense.Enabled = false;
                return;
            }
               btnRenewLicense.Enabled = true;

        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowPersonLicenseHistory frm = new FormShowPersonLicenseHistory(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID); ;

            frm.ShowDialog();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowLicenseInfo frm = new FormShowLicenseInfo(_NewLicenseID);

            frm.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRenewLocalDrivingLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
    }
}
