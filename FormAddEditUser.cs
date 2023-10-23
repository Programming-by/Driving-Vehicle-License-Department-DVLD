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
        clsUserData _User;

        int _PersonID;

        DataGridView AllPeople;
        public enum enMode { AddNew = 0, Update = 1 }

        enMode _Mode;
        public FormAddEditUser(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;

            if (_PersonID == -1)
            {
                _Mode = enMode.AddNew;
            } else
            {
                _Mode = enMode.Update;
            }
            AllPeople = new DataGridView();

        }

        public void GetAllPeople(DataGridView dgvAllPeople)
        {
            AllPeople = dgvAllPeople;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
           


            tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1 < tabControl1.TabCount) ?
                            tabControl1.SelectedIndex + 1 : tabControl1.SelectedIndex;


        }
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
            e.Cancel = true;
            txtUserName.Focus();
            errorProvider1.SetError(txtUserName, "UserName cannot be blank!");
            } else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserName, "");
            }
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "Password cannot be blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, "");
            }



        }
        private void CheckIfPasswordNotEqualConfirmPassword(CancelEventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                e.Cancel = true;
                txtPassword.Focus();
                txtConfirmPassword.Focus();
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation doesn't match Password!");


            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, "");
                errorProvider1.SetError(txtConfirmPassword, "");
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

            CheckIfPasswordNotEqualConfirmPassword(e);

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            ctrlPersonCardWithFilter ctrlPersonCardWithFilter = new ctrlPersonCardWithFilter();

            _User = clsUserData.Find(ctrlPersonCardWithFilter.PersonID);

            if (_User == null)
            {
                MessageBox.Show("User doesn't exist");
                return;
            }

            if (_User.Save())
            {
                MessageBox.Show("Data Saved Successfully");
            } else
            {
                MessageBox.Show("Data Failed To Save");

            }
        }
    }
}
