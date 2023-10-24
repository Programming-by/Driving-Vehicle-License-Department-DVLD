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
    public partial class FormAddEditUser : Form
    {


        public enum enMode { AddNew = 0, Update = 1 }

        enMode _Mode;

        int _UserID = -1;

        clsUserData _User;

        public FormAddEditUser()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;

        }
        public FormAddEditUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;

            _Mode = enMode.Update;

        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUserData();
                tpLoginInfo.Enabled = false;

            }
            else
            {
                lblTitle.Text = "Update User";
                this.Text = "Update User";
                tpLoginInfo.Enabled = true;
                btnSave.Enabled = true;
            }

            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chkIsActive.Checked = true;


        }

        private void _LoadData()
        {
            _User = clsUserData.FindByUserID(_UserID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;

            if (_User == null )
            {
                MessageBox.Show("This form will be closed because No User with ID = " + _UserID);
                this.Close();
                return;
            }

            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName.ToString();
            txtPassword.Text = _User.Password.ToString();
            txtConfirmPassword.Text = _User.Password.ToString();
            chkIsActive.Checked = _User.IsActive == true ? true  : false;
            ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);

        }
        private void FormAddEditUser_Load(object sender, EventArgs e)
        {
           _ResetDefaultValues();
            if(_Mode == enMode.Update)
                _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpLoginInfo.Enabled = true;
                tbUserInfo.SelectedTab = tbUserInfo.TabPages["tpLoginInfo"];
            }

            if (ctrlPersonCardWithFilter1.PersonID != -1)
            {

                if (clsUserData.isUserExistForPersonID(ctrlPersonCardWithFilter1.PersonID))
                {

                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.FilterFocus();
                }

                else
                {
                    btnSave.Enabled = true;
                    tpLoginInfo.Enabled = true;
                    tbUserInfo.SelectedTab = tbUserInfo.TabPages["tpLoginInfo"];
                }
            }

            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus(); 
            }

        }
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
            e.Cancel = true;
            errorProvider1.SetError(txtUserName, "UserName cannot be blank!");
            } else
            {
                errorProvider1.SetError(txtUserName, "");
            }

 
            if (_Mode == enMode.AddNew)
            {
                if (clsUserData.isUserExist(txtUserName.Text))
                {
                    e.Cancel = true;
                    txtUserName.Focus();
                    errorProvider1.SetError(txtUserName, "username is used by another user");
                } else
                {
                    errorProvider1.SetError(txtUserName, null);
                }
            } else
            {
                if (_User.UserName != txtUserName.Text)
                {
                    e.Cancel = true;
                    txtUserName.Focus();
                    errorProvider1.SetError(txtUserName, "username is used by another user");
                    return;
                }else
                {
                    errorProvider1.SetError(txtUserName, null);
                }
            }













        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be blank!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPassword, "");
            }



        }
        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }

        }
       
        private void FormAddEditUser_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }
      
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text;
            _User.IsActive = chkIsActive.Checked == true ? true : false;

            if (_User.Save())
            {
                lblUserID.Text = _User.UserID.ToString();
                _Mode = enMode.Update;
                lblTitle.Text = "Update User";
                this.Text = "Update User";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

    }
}
