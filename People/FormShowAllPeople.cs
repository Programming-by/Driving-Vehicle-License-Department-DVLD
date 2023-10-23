using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;


namespace DVLDWinForm
{
    public partial class FormShowAllPeople : Form
    {
        public FormShowAllPeople()
        {
            InitializeComponent();
        }

        private static DataTable _dtAllPeople = clsPersonData.GetAllPeople();

        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GendorCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");
        private void _RefreshPeopleList()
        {
            _dtAllPeople = clsPersonData.GetAllPeople();

            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GendorCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");

            dgvPeople.DataSource = _dtPeople;
            lblPeopleCount.Text = _dtPeople.Rows.Count.ToString();
        }

        private void FormShowAllPeople_Load(object sender, EventArgs e)
        {
            dgvPeople.DataSource = _dtPeople;
            cbFilters.SelectedIndex = 0;
            lblPeopleCount.Text = _dtPeople.Rows.Count.ToString();

            if(dgvPeople.Rows.Count > 0)
            {
                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].Width = 110;

                dgvPeople.Columns[1].HeaderText = "National No.";
                dgvPeople.Columns[1].Width = 120;


                dgvPeople.Columns[2].HeaderText = "First Name";
                dgvPeople.Columns[2].Width = 120;

                dgvPeople.Columns[3].HeaderText = "Second Name";
                dgvPeople.Columns[3].Width = 140;


                dgvPeople.Columns[4].HeaderText = "Third Name";
                dgvPeople.Columns[4].Width = 120;

                dgvPeople.Columns[5].HeaderText = "Last Name";
                dgvPeople.Columns[5].Width = 120;

                dgvPeople.Columns[6].HeaderText = "Gendor";
                dgvPeople.Columns[6].Width = 120;

                dgvPeople.Columns[7].HeaderText = "Date Of Birth";
                dgvPeople.Columns[7].Width = 140;

                dgvPeople.Columns[8].HeaderText = "Nationality";
                dgvPeople.Columns[8].Width = 120;


                dgvPeople.Columns[9].HeaderText = "Phone";
                dgvPeople.Columns[9].Width = 120;


                dgvPeople.Columns[10].HeaderText = "Email";
                dgvPeople.Columns[10].Width = 170;




            }


        }
        private void txtFilter1_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilters.Text)
            {
                case "PersonID":
                    FilterColumn = "PersonID";
                    break;
                case "NationalNo.":
                    FilterColumn = "NationalNo";

                    break;
                case "FirstName":
                    FilterColumn = "FirstName";

                    break;
                case "SecondName":

                    FilterColumn = "SecondName";
                    break;
                case "ThirdName":
                    FilterColumn = "ThirdName";
                    break;
                case "LastName":
                    FilterColumn = "LastName";

                    break;
                case "Nationality":
                    FilterColumn = "CountryName";
                    break;
                case "Gendor":
                    FilterColumn = "GendorCaption";
                    break;
                case "Phone":
                    FilterColumn = "Phone";

                    break;
                case "Email":
                    FilterColumn = "Email";

                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilter1.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblPeopleCount.Text = _dtPeople.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PersonID")
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter1.Text.Trim());

            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter1.Text.Trim());

        }
        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter1.Visible = (cbFilters.Text != "None");

            if (txtFilter1.Visible)
                txtFilter1.Text = "";
                txtFilter1.Focus();
            
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            FormAddUpdatePerson frm = new FormAddUpdatePerson();


            frm.ShowDialog();

            _RefreshPeopleList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            FormShowPersonDetails frm = new FormShowPersonDetails(PersonID);
 
            frm.ShowDialog();
        }
        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddUpdatePerson frm = new FormAddUpdatePerson();


            frm.ShowDialog();

            

            _RefreshPeopleList();


        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddUpdatePerson frm = new FormAddUpdatePerson((int)dgvPeople.CurrentRow.Cells[0].Value);


            frm.ShowDialog();

            _RefreshPeopleList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + (int)dgvPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsPersonData.DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeopleList();
                }
                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void sendPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void dgvPeople_DoubleClick(object sender, EventArgs e)
        {
            FormShowPersonDetails frm = new FormShowPersonDetails((int)dgvPeople.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
        }

        private void txtFilter1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.Text == "PersonID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }

}
