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

namespace DVLDWinForm
{
    //save txtUserName and txtPassword to txt file
    //on form load Remember Data
    public partial class FormLogin : Form
    {
        clsUserData _User;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            _User = clsUserData.Find(txtUserName.Text, txtPassword.Text);
            

            if (_User == null )
            {
                MessageBox.Show("Invalid UserName/Password", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_User.IsActive)
            {
                MessageBox.Show("Your Account is Deactivated, Please Contact your Admin!", "Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ( _User.UserName == txtUserName.Text && _User.Password == txtPassword.Text && _User.IsActive )
            {
                clsGlobalSettings.CurrentUserInfo = _User;
                 clsGlobalSettings.CurrentUserInfo.PersonData.PersonID = _User.PersonID;
                Form1 frm = new Form1();
                frm.ShowDialog();
            }


        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
          
        }

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRememberMe.Checked)
            {
                
            }
        }
    }
}
