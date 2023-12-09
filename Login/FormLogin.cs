using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Net;
using DVLDClasses;

namespace DVLDWinForm
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        clsUserData User = clsUserData.FindByUserNameAndPassword(txtUserName.Text, clsGlobal.ComputeHash(txtPassword.Text));

            if (User != null)
            {
                if (chkRememberMe.Checked)
                {
                    clsGlobal.RememberUserNameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                } else
                {
                    clsGlobal.RememberUserNameAndPassword("", "");
                }



                if (!User.IsActive)
                {
                    txtUserName.Focus();
                    MessageBox.Show("Your account is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                clsGlobal.CurrentUser = User;
                this.Hide();
                FormMain frm = new FormMain(this);
                frm.ShowDialog();
            } else
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid UserName/Password", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName,ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                chkRememberMe.Checked = true;
            } else
            {
                chkRememberMe.Checked = false;
            }


        }
    }
}
