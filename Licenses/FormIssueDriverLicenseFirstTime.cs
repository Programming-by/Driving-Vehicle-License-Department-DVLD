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

namespace DVLDWinForm.Licenses
{
    
    public partial class FormIssueDriverLicenseFirstTime : Form
    {
        int _LocalLicenseApplicationID = -1;
        clsLicenseData _License;
        public FormIssueDriverLicenseFirstTime(int LocalLicenseApplicationID)
        {
            InitializeComponent();
            _LocalLicenseApplicationID = LocalLicenseApplicationID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _License = new clsLicenseData();
            //if (_)
            //{
            //MessageBox.Show("License Issued Successfully with License ID = ");
            //}

        }

        private void FormIssueDriverLicenseFirstTime_Load(object sender, EventArgs e)
        {
            ctrlDrivingLicenseApplicationInfo1.LoadApplicationInfoByLocalDrivingAppID(_LocalLicenseApplicationID);
        }
    }
}
