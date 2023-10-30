using DVLDBusinessLayer;
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
    public partial class FormLocalDrivingLicenseApplications : Form
    {
        public FormLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private static DataTable _dtAllApplications;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            _dtAllApplications = clsLocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplications();
            dgvLocalDrivingLicenseApplications.DataSource = _dtAllApplications;
            lblLocalDrivingLicenseApplicationsCount.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
            if (dgvLocalDrivingLicenseApplications.Rows.Count > 0)
            {

            dgvLocalDrivingLicenseApplications.Columns[0].HeaderText = "L.D.L.AppID";
            dgvLocalDrivingLicenseApplications.Columns[0].Width = 120;

            dgvLocalDrivingLicenseApplications.Columns[1].HeaderText = "Driving Class";
            dgvLocalDrivingLicenseApplications.Columns[1].Width = 300;

            dgvLocalDrivingLicenseApplications.Columns[2].HeaderText = "National No";
            dgvLocalDrivingLicenseApplications.Columns[2].Width = 150;

            dgvLocalDrivingLicenseApplications.Columns[3].HeaderText = "Full Name";
            dgvLocalDrivingLicenseApplications.Columns[3].Width = 350;

            dgvLocalDrivingLicenseApplications.Columns[4].HeaderText = "Application Date";
            dgvLocalDrivingLicenseApplications.Columns[4].Width = 170;

            dgvLocalDrivingLicenseApplications.Columns[5].HeaderText = "Passed Tests";
            dgvLocalDrivingLicenseApplications.Columns[5].Width = 150;

            dgvLocalDrivingLicenseApplications.Columns[6].HeaderText = "Status";
            dgvLocalDrivingLicenseApplications.Columns[6].Width = 200;

            }
            cbFilters.SelectedIndex = 0;
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter1.Visible = (cbFilters.Text != "None");

            if (txtFilter1.Visible)
                txtFilter1.Text = "";
                txtFilter1.Focus();

            _dtAllApplications.DefaultView.RowFilter = "";
            lblLocalDrivingLicenseApplicationsCount.Text =  _dtAllApplications.Rows.Count.ToString();

        }

        private void txtFilter1_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilters.Text)
            {
                case "L.D.L.AppID":
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;
                case "NationalNo.":
                    FilterColumn = "NationalNo";

                    break;
                case "Full Name":
                    FilterColumn = "FullName";

                    break;
                case "Status":
                    FilterColumn = "Status";

                    break;
                default:
                    FilterColumn = "None";
                    break;
            }
            if (txtFilter1.Text.Trim() == "" || cbFilters.Text == "None")
            {
                _dtAllApplications.DefaultView.RowFilter = "";
                lblLocalDrivingLicenseApplicationsCount.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "LocalDrivingLicenseApplicationID")
                _dtAllApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter1.Text.Trim());
            else
                _dtAllApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter1.Text.Trim());
         
            lblLocalDrivingLicenseApplicationsCount.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();

        }

        private void btnAddNewApplication_Click(object sender, EventArgs e)
        {
            FormNewDrivingLicenseApplication frm = new FormNewDrivingLicenseApplication();

            frm.ShowDialog();

            FormLocalDrivingLicenseApplications_Load(null, null);
        }

        private void txtFilter1_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (cbFilters.Text == "L.D.L.AppID")
                    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure do want to cancel this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int LocalDrivingLicenseID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplications LocalDrivingLicenseApplications = clsLocalDrivingLicenseApplications.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseID);

            if (LocalDrivingLicenseApplications != null)
            { 
                if (LocalDrivingLicenseApplications.Cancel())
                {
                    MessageBox.Show("Application Canceled Successfully", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormLocalDrivingLicenseApplications_Load(null, null);
                    return;
                }
                else
                {
                    MessageBox.Show("Could not cancel application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
