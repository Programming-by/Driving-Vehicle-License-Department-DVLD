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
        int _UserID;
        public FormChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _ResetDefaultValues()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtCurrentPassword.Focus();
        }
        private void FormChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            _User = clsUserData.FindByUserID(_UserID);

            if (_User == null)
            {
                MessageBox.Show("Could not Find User with id = " + _UserID,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

                return;

            }

            ctrlUserCard1.LoadUserInfo(_UserID);

        }
        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtCurrentPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Current Password cannot be blank!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, "");
            }

            if (clsGlobal.ComputeHash(txtCurrentPassword.Text.Trim()) != _User.Password)
            {
                e.Cancel = true;
                txtCurrentPassword.Focus();
                errorProvider1.SetError(txtCurrentPassword, "Current Password doesn't match User Password!");
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, "");
            }

        }
        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "Password cannot be blank!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, "");
            }
        }
        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
          
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation doesn't match New Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, "");
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Password = clsGlobal.ComputeHash(txtNewPassword.Text);

            if (_User.Save())
            {
                MessageBox.Show("Password Changed Successfully.",
                "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefaultValues();
            }
           
        }
    }
}
