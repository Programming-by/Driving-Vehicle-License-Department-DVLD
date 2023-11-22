using DVLDBusinessLayer;
using DVLDWinForm.Licenses;
using DVLDWinForm.Licenses.Detain_License;
using DVLDWinForm.Licenses.Local_Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWinForm.Applications.Release_License
{
    public partial class FormListDetainedLicenses : Form
    {
        public FormListDetainedLicenses()
        {
            InitializeComponent();
        }

        private DataTable _dtAllDetainedLicenses;

        private void FormListDetainedLicenses_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            _dtAllDetainedLicenses = clsDetainLicenseData.GetAllDetainLicenses();
            dgvDetained.DataSource = _dtAllDetainedLicenses;
            lblRecordsCount.Text = _dtAllDetainedLicenses.Rows.Count.ToString();
            if (dgvDetained.Rows.Count > 0 )
            {

                dgvDetained.Columns[0].HeaderText = "D.ID";
                dgvDetained.Columns[0].Width = 90;

                dgvDetained.Columns[1].HeaderText = "L.ID";
                dgvDetained.Columns[1].Width = 90;

                dgvDetained.Columns[2].HeaderText = "D.Date";
                dgvDetained.Columns[2].Width = 160;

                dgvDetained.Columns[3].HeaderText = "Is Released";
                dgvDetained.Columns[3].Width = 110;

                dgvDetained.Columns[4].HeaderText = "Fine Fees";
                dgvDetained.Columns[4].Width = 110;

                dgvDetained.Columns[5].HeaderText = "Release Date";
                dgvDetained.Columns[5].Width = 160;

                dgvDetained.Columns[6].HeaderText = "N.No";
                dgvDetained.Columns[6].Width = 90;

                dgvDetained.Columns[7].HeaderText = "Full Name";
                dgvDetained.Columns[7].Width = 330;

                dgvDetained.Columns[8].HeaderText = "Release App ID";
                dgvDetained.Columns[8].Width = 150;
            }

        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetained.CurrentRow.Cells[1].Value;
            int PersonID = clsLicenseData.Find(LicenseID).DriverInfo.PersonID;

            FormShowPersonLicenseHistory frm = new FormShowPersonLicenseHistory(PersonID);

            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShowLicenseInfo frm = new FormShowLicenseInfo((int)dgvDetained.CurrentRow.Cells[1].Value);

            frm.ShowDialog();
        }
        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetained.CurrentRow.Cells[1].Value;
            int PersonID = clsLicenseData.Find(LicenseID).DriverInfo.PersonID;

            FormShowPersonLicenseHistory frm = new FormShowPersonLicenseHistory(PersonID);

            frm.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetained.CurrentRow.Cells[1].Value;
 
            FormReleaseLicense frm = new FormReleaseLicense(LicenseID);

            frm.ShowDialog();
            FormListDetainedLicenses_Load(null, null);

        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            FormDetainLicense frm = new FormDetainLicense();

            frm.ShowDialog();
            FormListDetainedLicenses_Load(null, null);

        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            FormReleaseLicense frm = new FormReleaseLicense();
            frm.ShowDialog();
            FormListDetainedLicenses_Load(null,null);
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFilters.Text == "Is Released")
            {
                txtFilterBy.Visible = false;
                cbIsReleased.Visible = true;
                cbIsReleased.Focus();
                cbIsReleased.SelectedIndex = 0;
            }
             else
             {
                 txtFilterBy.Visible = (cbFilters.Text != "None");
                 cbIsReleased.Visible = false;

                if (cbFilters.Text == "None")
                {
                    txtFilterBy.Enabled = false;
                } else
                {
                    txtFilterBy.Enabled = true;
                    txtFilterBy.Text = "";
                    txtFilterBy.Focus();
                }
             }
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilters.Text)
            {
                case "DetainID":
                    FilterColumn = "DetainID";
                    break;

                case "Is Released":
                    FilterColumn = "IsReleased";

                    break;

                case "NationalNo.":
                    FilterColumn = "NationalNo";

                    break;
                case "Full Name":
                    FilterColumn = "FullName";

                    break;

                case "Release Application ID":
                    FilterColumn = "ReleaseApplicationID";

                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilterBy.Text == ""  || cbFilters.Text == "None")
            {
                _dtAllDetainedLicenses.DefaultView.RowFilter = "";
                lblRecordsCount.Text = _dtAllDetainedLicenses.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "DetainID" || FilterColumn == "ReleaseApplicationID")
                _dtAllDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim());
            else
                _dtAllDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim());
            lblRecordsCount.Text = _dtAllDetainedLicenses.Rows.Count.ToString();

        }

        private void cbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsReleased";
            string FilterResult = cbIsReleased.Text;
            switch (FilterResult)
            {
                case "All":

                    break;

                case "Yes":
                    FilterResult = "1";
                    break;

                case "No":
                    FilterResult = "0";
                    break;
                default:
                    break;
            }

            if (cbIsReleased.Text == "All")
                _dtAllDetainedLicenses.DefaultView.RowFilter = "";
            else
                _dtAllDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}]= {1}", FilterColumn, FilterResult);

            lblRecordsCount.Text = _dtAllDetainedLicenses.Rows.Count.ToString();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            releaseDetainedLicenseToolStripMenuItem.Enabled = !((bool)dgvDetained.CurrentRow.Cells[3].Value);

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.Text == "Detain ID" || cbFilters.Text == "Release Application ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
