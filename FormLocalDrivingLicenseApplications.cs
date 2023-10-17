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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _RefreshDrivingLicenseApplications()
        {
            dgvAllPeople.DataSource = clsLocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplications();

        }

        private void FormLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            _RefreshDrivingLicenseApplications();
            cbFilters.SelectedIndex = 0;

        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.Text != "None")
            {
                txtFilter1.Visible = true;
                txtFilter1.Text = "";

                if (cbFilters.Text == "L.D.L.AppID")
                {
                    txtFilter1.Mask = "000999";
                }
                else if (cbFilters.Text == "NationalNo.")
                {
                    txtFilter1.Mask = "L9999";
                }
                else if (cbFilters.Text == "Full Name" || cbFilters.Text == "Status")
                {
                    txtFilter1.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";

                }
            }
            else
            {

                txtFilter1.Visible = false;
            }

            _RefreshDrivingLicenseApplications();
        }

        private void txtFilter1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
    
        }

        private void _GetDataViewData(DataView dtFilteredView)
        {
            dgvAllPeople.DataSource = dtFilteredView;
        }


        private void txtFilter1_TextChanged(object sender, EventArgs e)
        {
            DataTable dtFiltered = clsLocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplications();
            DataView dtFilteredView = dtFiltered.DefaultView;
            switch (cbFilters.Text)
            {
                case "L.D.L.AppID":
                    if (txtFilter1.Text == "")
                    {
                        dtFilteredView.RowFilter = string.Empty;

                    }
                    else
                    {
                        dtFilteredView.RowFilter = $"LDLAppID='{txtFilter1.Text}'";
                    }

                    break;
                case "NationalNo.":
                    dtFilteredView.RowFilter = $"NationalNo='{txtFilter1.Text}'";

                    break;
                case "Full Name":
                    dtFilteredView.RowFilter = $"FullName='{txtFilter1.Text}'";
                    break;
                case "Status":

                    dtFilteredView.RowFilter = $"Status='{txtFilter1.Text}'";
                    break;
                default:
                    break;
            }
            _GetDataViewData(dtFilteredView);
        }

        private void btnAddNewApplication_Click(object sender, EventArgs e)
        {
            FormNewDrivingLicenseApplication frm = new FormNewDrivingLicenseApplication();

            frm.ShowDialog();
        }
    }
}
