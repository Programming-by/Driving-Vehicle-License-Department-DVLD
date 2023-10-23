using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWinForm
{
    public partial class FormShowAllUsers : Form
    {

        public FormShowAllUsers()
        {
            InitializeComponent();
        }

        private void _RefreshUsersList()
        {
            dgvAllPeople.DataSource = clsUserData.GetAllUsers();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void _CountAllUsers()
        {
            lblUsersCount.Text = clsUserData.CountUsers().ToString();
        }

        private void FormShowAllUsers_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();
            _CountAllUsers();
            cbFilters.SelectedIndex = 0;
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            FormAddEditUser frm = new FormAddEditUser(-1);
            frm.ShowDialog();
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.Text != "None")
            {
                
                txtFilter1.Visible = true;
                txtFilter1.Text = "";
               cbActiveOrNot.Visible = false;


                if (cbFilters.Text == "Person ID" || cbFilters.Text == "User ID")
                {
                    txtFilter1.Mask = "000999";
                }

                
                else if (cbFilters.Text == "Is Active")
                {
                    txtFilter1.Visible = false;
                    cbActiveOrNot.Visible = true;
                    cbActiveOrNot.SelectedIndex = 0;

                }
                else
                {
                    txtFilter1.Mask = "";

                }

            }
            else
            {

                txtFilter1.Visible = false;
                 cbActiveOrNot.Visible = false;
            }
            _RefreshUsersList();
        }
        private void _GetDataViewData(DataView dtFilteredView)
        {

            dgvAllPeople.DataSource = dtFilteredView;

        }

        private void txtFilter1_TextChanged(object sender, EventArgs e)
        {

            DataTable dtFiltered = clsUserData.GetAllUsers();
            DataView dtFilteredView = dtFiltered.DefaultView;
            switch (cbFilters.Text)
            {
                case "User ID":

                    if (txtFilter1.Text == "")
                    {
                        dtFilteredView.RowFilter = string.Empty;

                    }
                    else
                    {
                        dtFilteredView.RowFilter = $"UserID='{txtFilter1.Text}'";
                    }

                    break;
                case "UserName":
                    dtFilteredView.RowFilter = $"UserName='{txtFilter1.Text}'";

                    break;
                case "Person ID":
                    if (txtFilter1.Text == "")
                    {
                        dtFilteredView.RowFilter = string.Empty;

                    }
                    else
                    {
                        dtFilteredView.RowFilter = $"PersonID='{txtFilter1.Text}'";
                    }

                    break;
                case "Full Name":
                    dtFilteredView.RowFilter = $"FullName='{txtFilter1.Text}'";

                    break;
               
               
                default:
                    break;
            }
            _GetDataViewData(dtFilteredView);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShowUserDetails frm = new FormShowUserDetails();

            ctrlUserCard.LoadUserInfo((int)dgvAllPeople.CurrentRow.Cells[0].Value);
            ctrlUserCard.LoadPersonInfo((int)dgvAllPeople.CurrentRow.Cells[1].Value);


             ctrlUserCard.GetAllPeople(dgvAllPeople);

          
            frm.ShowDialog();
        }
        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddEditUser frm = new FormAddEditUser(-1);
            
            frm.GetAllPeople(dgvAllPeople);

            frm.ShowDialog();

            _RefreshUsersList();
        }

     
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormAddEditUser frm = new FormAddEditUser((int)dgvAllPeople.CurrentRow.Cells[1].Value);

          //  ctrlPersonCard.LoadPersonInfo((int)dgvAllPeople.CurrentRow.Cells[1].Value);
             
            frm.ShowDialog();

            _RefreshUsersList();


        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete User [" + (int)dgvAllPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsUserData.DeleteUser((int)dgvAllPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User has been Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   _RefreshUsersList();
                }
                else
                {
                    MessageBox.Show("User is not deleted due to data connected to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }



            //if (MessageBox.Show("Are you sure you want to delete Person [" + (int)dgvAllPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            //{
            //    if (clsPersonData.DeletePerson((int)dgvAllPeople.CurrentRow.Cells[0].Value))
            //    {
            //        MessageBox.Show("Person Deleted Successfully", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    }
            //}
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is not Implemented Yet!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void sendPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is not Implemented Yet!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void cbActiveOrNot_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dtFiltered = clsUserData.GetAllUsers();
            DataView dtFilteredView = dtFiltered.DefaultView;
            if (cbActiveOrNot.SelectedIndex == 0)
            {
                _GetDataViewData(dtFilteredView);

                return;
            }

                    dtFilteredView.RowFilter = $"IsActive ='{cbActiveOrNot.SelectedIndex == 1}'";

                _GetDataViewData(dtFilteredView);
           
        }      
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangePassword frm = new FormChangePassword();


            ctrlUserCard.LoadUserInfo((int)dgvAllPeople.CurrentRow.Cells[0].Value);
            ctrlUserCard.LoadPersonInfo((int)dgvAllPeople.CurrentRow.Cells[1].Value);


            ctrlUserCard.GetAllPeople(dgvAllPeople);


            frm.ShowDialog();
           
        }
    }
}
