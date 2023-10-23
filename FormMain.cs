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

namespace DVLDWinForm
{
    public partial class FormMain : Form
    {
        Form _frm;
        public FormMain(Form frm)
        {
            InitializeComponent();
            _frm = frm;
        }

        private void btnShowAllPeople_Click(object sender, EventArgs e)
        {
            FormShowAllPeople frm = new FormShowAllPeople();

            frm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!_RememberMe.Checked)
            //{
            //clsGlobalSettings.CurrentUserInfo.UserName = "";
            //clsGlobalSettings.CurrentUserInfo.Password = "";
            //DataBack?.Invoke(clsGlobalSettings.CurrentUserInfo.UserName,clsGlobalSettings.CurrentUserInfo.Password);
            //}

            this.Close();
        }
        private void btnShowAllUsers_Click(object sender, EventArgs e)
        {
            FormShowAllUsers frm = new FormShowAllUsers();


            frm.ShowDialog();
        }

       

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShowUserDetails frm = new FormShowUserDetails();

            ctrlUserCard.LoadUserInfo(clsGlobal.CurrentUser.UserID);
            ctrlUserCard.LoadPersonInfo(clsGlobal.CurrentUser.PersonData.PersonID);

            
            //  ctrlUserCard.GetAllPeople();

            frm.ShowDialog();

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangePassword frm = new FormChangePassword();


            ctrlUserCard.LoadUserInfo(clsGlobal.CurrentUser.UserID);
            ctrlUserCard.LoadPersonInfo(clsGlobal.CurrentUser.PersonID);


            //  ctrlUserCard.GetAllPeople(dgvAllPeople);

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
            FormNewDrivingLicenseApplication frm = new FormNewDrivingLicenseApplication();

            frm.ShowDialog();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLocalDrivingLicenseApplications frm = new FormLocalDrivingLicenseApplications();

            frm.ShowDialog();
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void msMainMenue_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
