using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWinForm.Drivers
{
    public partial class FormShowAllDrivers : Form
    {
        private DataTable _dtAllDrivers;

        public FormShowAllDrivers()
        {
            InitializeComponent();
        }

        private void FormShowAllDrivers_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            _dtAllDrivers = clsDriverData.GetAllDrivers();
            lblRecordsCount.Text = _dtAllDrivers.Rows.Count.ToString();
            dgvDrivers.DataSource = _dtAllDrivers;


            if (dgvDrivers.Rows.Count > 0 )
            {
                dgvDrivers.Columns[0].HeaderText = "Driver ID";
                dgvDrivers.Columns[0].Width = 120;

                dgvDrivers.Columns[1].HeaderText = "Person ID";
                dgvDrivers.Columns[1].Width = 120;

                dgvDrivers.Columns[2].HeaderText = "National No";
                dgvDrivers.Columns[2].Width = 140;

                dgvDrivers.Columns[3].HeaderText = "Full Name";
                dgvDrivers.Columns[3].Width = 320;

                dgvDrivers.Columns[4].HeaderText = "Date";
                dgvDrivers.Columns[4].Width = 170;

                dgvDrivers.Columns[5].HeaderText = "Active Licenses";
                dgvDrivers.Columns[5].Width = 150;
            }


        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtFilter.Visible = cbFilters.Text != "None";

            if (cbFilters.Text == "None")
            {
                txtFilter.Enabled = false;
            } else
            {
                txtFilter.Enabled = true;
            }
                txtFilter.Text = "";
                txtFilter.Focus();
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch(cbFilters.Text)
            {

                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";

                    break;

                case "National No.":
                    FilterColumn = "NationalNo";

                    break;

                case "FullName":
                    FilterColumn = "FullName";

                    break;
                default:
                    FilterColumn = "None";
                    break;

            }

            if (txtFilter.Text.Trim() == "" || cbFilters.Text == "None")
            {
                _dtAllDrivers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = _dtAllDrivers.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "FullName" || FilterColumn == "NationalNo")
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text);
            else 
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}",FilterColumn,txtFilter.Text) ;

            lblRecordsCount.Text = _dtAllDrivers.Rows.Count.ToString();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (cbFilters.Text == "Driver ID" || cbFilters.Text == "Person ID")
                    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
