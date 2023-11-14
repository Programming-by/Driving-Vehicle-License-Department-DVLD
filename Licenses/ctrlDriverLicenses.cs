using DVLDBusinessLayer;
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

namespace DVLDWinForm.Licenses
{
    public partial class ctrlDriverLicenses : UserControl
    {
        private int _DriverID;
        private clsDriverData _Driver;
        private DataTable _dtDriverLocalLicensesHistory;
        private DataTable _dtDriverInternationalLicensesHistory;

        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }
        private void _LoadInternationalLicensesInfo()
        {
            _dtDriverInternationalLicensesHistory = clsDriverData.GetInternationalLicenses(_DriverID);
            dgvInternational.DataSource = _dtDriverInternationalLicensesHistory;
            lblRecordsCount.Text = dgvInternational.Rows.Count.ToString();
            if (dgvInternational.Rows.Count > 0)
            {

                dgvInternational.Columns[0].HeaderText = "Int.License ID";
                dgvInternational.Columns[0].Width = 160;

                dgvInternational.Columns[1].HeaderText = "App.ID";
                dgvInternational.Columns[1].Width = 130;

                dgvInternational.Columns[2].HeaderText = "L.License ID";
                dgvInternational.Columns[2].Width = 130;

                dgvInternational.Columns[3].HeaderText = "Issue Date";
                dgvInternational.Columns[3].Width = 180;

                dgvInternational.Columns[4].HeaderText = "Expiration Date";
                dgvInternational.Columns[4].Width = 180;

                dgvInternational.Columns[5].HeaderText = "Is Active";
                dgvInternational.Columns[5].Width = 120;

            }
        }

        private void _LoadLocalLicensesInfo()
        {
            _dtDriverLocalLicensesHistory = clsDriverData.GetLicenses(_DriverID);
            dgvLocal.DataSource = _dtDriverLocalLicensesHistory;
            lblRecordsCount.Text = dgvLocal.Rows.Count.ToString();
            if (dgvLocal.Rows.Count > 0)
            {

                dgvLocal.Columns[0].HeaderText = "Lic.ID";
                dgvLocal.Columns[0].Width = 110;

                dgvLocal.Columns[1].HeaderText = "App.ID";
                dgvLocal.Columns[1].Width = 110;

                dgvLocal.Columns[2].HeaderText = "Class Name";
                dgvLocal.Columns[2].Width = 270;

                dgvLocal.Columns[3].HeaderText = "Issue Date";
                dgvLocal.Columns[3].Width = 170;

                dgvLocal.Columns[4].HeaderText = "Expiration Date";
                dgvLocal.Columns[4].Width = 170;

                dgvLocal.Columns[5].HeaderText = "Is Active";
                dgvLocal.Columns[5].Width = 110;

            }
        }
      public void LoadInfo(int DriverID)
        {
            _DriverID = DriverID;
            _Driver = clsDriverData.FindByDriverID(DriverID);

            if ( _Driver == null)
            {
                MessageBox.Show("There is no Driver ID With id " + _Driver.DriverID);
                return;
            }

            _LoadLocalLicensesInfo();
            _LoadInternationalLicensesInfo();

        }

        public void LoadInfoByPersonID(int PersonID)
        {
            _Driver = clsDriverData.FindByPersonID(PersonID);

            if (_Driver == null)
            {
                MessageBox.Show("there is no Driver linked with Person id: " + PersonID);
                return;
            }

            _DriverID = _Driver.DriverID;
          
            _LoadLocalLicensesInfo();
            _LoadInternationalLicensesInfo();

        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvLocal.CurrentRow.Cells[0].Value;  
            FormShowLicenseInfo frm = new FormShowLicenseInfo(LicenseID);
            frm.ShowDialog();
        }

        private void showInternationalLicenseInfotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int InternationalLicenseID = (int)dgvInternational.CurrentRow.Cells[0].Value;
            FormShowInternationalLicenseInfo frm = new FormShowInternationalLicenseInfo(InternationalLicenseID);
            frm.ShowDialog();
        }

        public void Clear()
        {
            _dtDriverLocalLicensesHistory.Clear();
            _dtDriverInternationalLicensesHistory.Clear();
        }
    }
}
