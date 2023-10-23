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
using DVLDClasses;

namespace DVLDWinForm
{

    
    public partial class FormChangePassword : Form
    {
        clsUserData _User;
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _User = clsUserData.Find(clsGlobal.CurrentUser.UserName, (clsGlobal.CurrentUser.Password));


            if (_User == null)
            {
                MessageBox.Show("error");
                return;
            }

            _User.Password = txtNewPassword.Text;

            if (_User.Save())
            {
                clsGlobal.CurrentUser.Password = _User.Password;
                MessageBox.Show("Password Change Successfully");
            }
           
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtCurrentPassword.Text))
            {
                e.Cancel = true;
                txtCurrentPassword.Focus();
                errorProvider1.SetError(txtCurrentPassword, "Current Password cannot be blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCurrentPassword, "");
            }

            CheckIfCurrentPasswordNotEqualUserPassword(e);

  
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                e.Cancel = true;
                txtNewPassword.Focus();
                errorProvider1.SetError(txtNewPassword, "Password cannot be blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNewPassword, "");
            }
        }
        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                e.Cancel = true;
                txtConfirmPassword.Focus();
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password cannot be blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, "");
            }

            CheckIfNewPasswordNotEqualConfirmPassword(e);
         

        }

        private void CheckIfCurrentPasswordNotEqualUserPassword(CancelEventArgs e)
        {
            if (txtCurrentPassword.Text != clsGlobal.CurrentUser.Password)
            {
                e.Cancel = true;
                txtCurrentPassword.Focus();
                errorProvider1.SetError(txtCurrentPassword, "Current Password doesn't match User Password!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCurrentPassword, "");
            }

        }

        private void CheckIfNewPasswordNotEqualConfirmPassword(CancelEventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                e.Cancel = true;
                txtNewPassword.Focus();
                txtConfirmPassword.Focus();
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation doesn't match New Password!");


            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNewPassword, "");
                errorProvider1.SetError(txtConfirmPassword, "");

            }
           // CheckIfNewPasswordIsDifferentThanCurrentPassword(e);
        }

        private void CheckIfNewPasswordIsDifferentThanCurrentPassword(CancelEventArgs e)
        {
            if (txtNewPassword.Text == txtCurrentPassword.Text)
            {
                e.Cancel = true;
                txtNewPassword.Focus();
                errorProvider1.SetError(txtNewPassword, "New Password can't't be the same as Current Password!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNewPassword, "");
            }

        }
   
    }
}
