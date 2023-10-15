using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowAllPeople_Click(object sender, EventArgs e)
        {
            FormShowAllPeople frm = new FormShowAllPeople();

            frm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

            ctrlUserCard.LoadUserInfo(clsGlobalSettings.CurrentUserInfo.UserID);
            ctrlUserCard.LoadPersonInfo(clsGlobalSettings.CurrentUserInfo.PersonData.PersonID);

            
            //  ctrlUserCard.GetAllPeople();

            frm.ShowDialog();

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangePassword frm = new FormChangePassword();


            ctrlUserCard.LoadUserInfo(clsGlobalSettings.CurrentUserInfo.UserID);
            ctrlUserCard.LoadPersonInfo(clsGlobalSettings.CurrentUserInfo.PersonID);


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
    }
}
