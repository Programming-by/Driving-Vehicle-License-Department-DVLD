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

        private static DataTable _dtAllUsers;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        private void FormShowAllUsers_Load(object sender, EventArgs e)
        {
            _dtAllUsers = clsUserData.GetAllUsers();
            dgvUsers.DataSource = _dtAllUsers;
            cbFilters.SelectedIndex = 0;
            lblUsersCount.Text = dgvUsers.Rows.Count.ToString();
            if (dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 110;

                dgvUsers.Columns[1].HeaderText = "Person ID";
                dgvUsers.Columns[1].Width = 120;


                dgvUsers.Columns[2].HeaderText = "Full Name";
                dgvUsers.Columns[2].Width = 350;

                dgvUsers.Columns[3].HeaderText = "UserName";
                dgvUsers.Columns[3].Width = 120;

                dgvUsers.Columns[4].HeaderText = "Is Active";
                dgvUsers.Columns[4].Width = 120;
            }

        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            FormAddEditUser frm = new FormAddEditUser();
            frm.ShowDialog();
            FormShowAllUsers_Load(null,null);
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.Text == "Is Active")
            {
                txtFilter1.Visible = false;
                cbActiveOrNot.Visible = true;
                cbActiveOrNot.Focus();
                cbActiveOrNot.SelectedIndex = 0;

            }
            else
            {
            txtFilter1.Visible = (cbFilters.Text != "None");
            cbActiveOrNot.Visible = false;
            txtFilter1.Text = "";
            txtFilter1.Focus();
            
            }
        }

        private void txtFilter1_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilters.Text)
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;
                case "UserName":
                    FilterColumn = "UserName";

                    break;
                case "Person ID":
                    FilterColumn = "PersonID";

                    break;
                case "Full Name":
                    FilterColumn = "FullName";

                    break;
               
               
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilter1.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lblUsersCount.Text = _dtAllUsers.Rows.Count.ToString();
                return;
            }

            if (FilterColumn != "FullName" && FilterColumn != "UserName")
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}",FilterColumn , txtFilter1.Text.Trim());
            else
            _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter1.Text.Trim());

            lblUsersCount.Text = _dtAllUsers.Rows.Count.ToString();

        }
        private void cbActiveOrNot_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string Filter = cbActiveOrNot.Text;
           switch(Filter)
            {
                case "All":
                    break;
                case "Yes":
                    Filter = "1";

                    break;

                case "No":
                    Filter = "0";
                    break;

            }

            if(cbActiveOrNot.Text.Trim() == "All")
             _dtAllUsers.DefaultView.RowFilter = "";
            else
             _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, Filter);


            lblUsersCount.Text = _dtAllUsers.Rows.Count.ToString();



        }      

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShowUserDetails frm = new FormShowUserDetails((int)dgvUsers.CurrentRow.Cells[0].Value);

           frm.ShowDialog();
        }
        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddEditUser frm = new FormAddEditUser();
            
            frm.ShowDialog();

            FormShowAllUsers_Load(null, null);
        }

     
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormAddEditUser frm = new FormAddEditUser((int)dgvUsers.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            FormShowAllUsers_Load(null,null);
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;

                if (clsUserData.DeleteUser(UserID))
                {
                    MessageBox.Show("User has been Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormShowAllUsers_Load(null,null);    
                }
                else
                MessageBox.Show("User is not deleted due to data connected to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is not Implemented Yet!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void sendPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is not Implemented Yet!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            FormChangePassword frm = new FormChangePassword(UserID);

            frm.ShowDialog();
           
        }

        private void txtFilter1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.Text == "Person ID" || cbFilters.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgvUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormShowUserDetails Frm1 = new FormShowUserDetails((int)dgvUsers.CurrentRow.Cells[0].Value);
            Frm1.ShowDialog();
        }
    }
}
