using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDClasses;
using DVLDWinForm.Applications.International_Driving_License_Application;
using DVLDWinForm.Applications.Renew_Local_License;
using DVLDWinForm.Applications.Replace_For_Damaged_License;
using DVLDWinForm.Drivers;
using DVLDWinForm.Licenses.Detain_License;

namespace DVLDWinForm
{
    public partial class FormMain : Form
    {
        Form _frmLogin;
        public FormMain(Form frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }

    
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShowAllPeople frm = new FormShowAllPeople();

            frm.ShowDialog();
        }
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShowAllUsers frm = new FormShowAllUsers();

            frm.ShowDialog();
        }
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();

        }
       
        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShowUserDetails frm = new FormShowUserDetails(clsGlobal.CurrentUser.UserID);

            frm.ShowDialog();

        }

      

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormManageApplicationTypes frm = new FormManageApplicationTypes();

            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManageTestTypes frm = new FormManageTestTypes();

            frm.ShowDialog();

            
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddUpdateDrivingLicenseApplication frm = new FormAddUpdateDrivingLicenseApplication();

            frm.ShowDialog();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListLocalDrivingLicenseApplications frm = new FormListLocalDrivingLicenseApplications();

            frm.ShowDialog();
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangePassword frm = new FormChangePassword(clsGlobal.CurrentUser.UserID);

            frm.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManageApplicationTypes frm = new FormManageApplicationTypes();

            frm.ShowDialog();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManageTestTypes frm = new FormManageTestTypes();

            frm.ShowDialog();
        }

        private void manageLocalDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListLocalDrivingLicenseApplications frm = new FormListLocalDrivingLicenseApplications();

            frm.ShowDialog();

        }

        private void localLicenseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormAddUpdateDrivingLicenseApplication frm = new FormAddUpdateDrivingLicenseApplication();
                
           frm.ShowDialog();

        }

        private void ManageInternationaDrivingLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormListInternationalDrivingLicenseApplications frm = new FormListInternationalDrivingLicenseApplications();

            frm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShowAllDrivers frm = new FormShowAllDrivers();

            frm.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewInternationalLicenseApplication frm = new FormNewInternationalLicenseApplication();

            frm.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRenewLocalDrivingLicenseApplication frm = new FormRenewLocalDrivingLicenseApplication();

            frm.ShowDialog();
        }

        private void ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReplaceForDamagedOrLostLicense frm = new FormReplaceForDamagedOrLostLicense();

            frm.ShowDialog();
        }

        private void ManageDetainedLicensestoolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDetainLicense frm = new FormDetainLicense();    

            frm.ShowDialog();

        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
