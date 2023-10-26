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
            dgvApplications.DataSource = _dtAllApplications;
            cbFilters.SelectedIndex = 0;
            lblLocalDrivingLicenseApplicationsCount.Text = dgvApplications.Rows.Count.ToString();
            if (dgvApplications.Rows.Count > 0)
            {

            dgvApplications.Columns[0].HeaderText = "L.D.L.AppID";
            dgvApplications.Columns[0].Width = 110;

            dgvApplications.Columns[1].HeaderText = "Driving Class";
            dgvApplications.Columns[1].Width = 350;

            dgvApplications.Columns[2].HeaderText = "National No";
            dgvApplications.Columns[2].Width = 110;

            dgvApplications.Columns[3].HeaderText = "Full Name";
            dgvApplications.Columns[3].Width = 400;

            dgvApplications.Columns[4].HeaderText = "Application Date";
            dgvApplications.Columns[4].Width = 200;

            dgvApplications.Columns[5].HeaderText = "Passed Tests";
            dgvApplications.Columns[5].Width = 200;

            dgvApplications.Columns[6].HeaderText = "Status";
            dgvApplications.Columns[6].Width = 200;

            }
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter1.Visible = (cbFilters.Text != "None");

            if (txtFilter1.Visible)
                txtFilter1.Text = "";
                txtFilter1.Focus();
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
                    break;
            }
            if (txtFilter1.Text.Trim() == "" || cbFilters.Text == "None")
            {
                _dtAllApplications.DefaultView.RowFilter = "";
                lblLocalDrivingLicenseApplicationsCount.Text = dgvApplications.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "LocalDrivingLicenseApplicationID")
            {
                _dtAllApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter1.Text.Trim());

            }
            else
            {
                _dtAllApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter1.Text.Trim());

            }

        }

        private void btnAddNewApplication_Click(object sender, EventArgs e)
        {
            FormNewDrivingLicenseApplication frm = new FormNewDrivingLicenseApplication();

            frm.ShowDialog();
        }

        private void txtFilter1_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (cbFilters.Text == "L.D.L.AppID")
                    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
