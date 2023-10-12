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

        private void _RefreshPeopleList()
        {
            dgvAllPeople.DataSource = clsPersonData.GetAllPeople();
        }

        private void _CountAllPeople()
        {
            lblPeopleCount.Text = clsPersonData.CountPeople().ToString();
        }

        private void FormShowAllPeople_Load(object sender, EventArgs e)
        {
            _RefreshPeopleList();
            _CountAllPeople();
            cbFilters.SelectedIndex = 0;


        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            FormAddEditPerson frm = new FormAddEditPerson(-1, dgvAllPeople);

            frm.ShowDialog();

            _RefreshPeopleList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShowPersonDetails frm = new FormShowPersonDetails();

            ctrlPersonCard.PersonID = (int)dgvAllPeople.CurrentRow.Cells[0].Value;
            ctrlPersonCard.AllPeople = dgvAllPeople;

            frm.ShowDialog();
        }
        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddEditPerson frm = new FormAddEditPerson(-1, dgvAllPeople);

            frm.ShowDialog();

            _RefreshPeopleList();


        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddEditPerson frm = new FormAddEditPerson((int)dgvAllPeople.CurrentRow.Cells[0].Value, dgvAllPeople);

            frm.ShowDialog();

            _RefreshPeopleList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + (int)dgvAllPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsPersonData.DeletePerson((int)dgvAllPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeopleList();
                }
                else
                {
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is not Implemented Yet!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void sendPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is not Implemented Yet!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
          
         string[] NameAndNationality = {"FirstName","SecondName","ThirdName","LastName","Nationality" };


            if (cbFilters.Text != "None")
            {

             txtFilter1.Visible = true;
                txtFilter1.Text = "";

                if (cbFilters.Text == "PersonID")
                {
                    txtFilter1.Mask = "000999";
                }
                else if (cbFilters.Text == "NationalNo.")
                {
                    txtFilter1.Mask = "L9999";
                } else if (NameAndNationality.Contains(cbFilters.Text))
                {
                    txtFilter1.Mask = "LLLLLLLLLLLLLLLLLLLL"; 
                } 
                else if (cbFilters.Text == "Gendor")
                {
                    txtFilter1.Mask = "LLLLLL"; 

                } else if (cbFilters.Text == "Phone")
                {
                    txtFilter1.Mask = "000000999999";
                } 
            }
            else { 
            
                txtFilter1.Visible = false;
            }
            _RefreshPeopleList();
        }
        private void _GetDataViewData(DataView dtFilteredView)
        {
          
            dgvAllPeople.DataSource = dtFilteredView;

        }

        private void txtFilter1_TextChanged(object sender, EventArgs e)
        {

            DataTable dtFiltered = clsPersonData.GetAllPeople();
            DataView dtFilteredView = dtFiltered.DefaultView;
            switch (cbFilters.Text)
            {
                case "PersonID":
                    if (txtFilter1.Text == "")
                    {
                        dtFilteredView.RowFilter = string.Empty;

                    }
                    else
                    {
                        dtFilteredView.RowFilter = $"PersonID='{txtFilter1.Text}'";
                    }

                    break;
                case "NationalNo.":
                    dtFilteredView.RowFilter = $"NationalNo='{txtFilter1.Text}'";

                    break;
                case "FirstName":
                    dtFilteredView.RowFilter = $"FirstName='{txtFilter1.Text}'";
                    break;
                case "SecondName":

                    dtFilteredView.RowFilter = $"SecondName='{txtFilter1.Text}'";
                    break;
                case "ThirdName":
                    dtFilteredView.RowFilter = $"ThirdName='{txtFilter1.Text}'";
                    break;
                case "LastName":
                    dtFilteredView.RowFilter = $"LastName='{txtFilter1.Text}'";
                    break;
                case "Nationality":
                    dtFilteredView.RowFilter = $"Nationality='{txtFilter1.Text}'";
                    break;
                case "Gendor":
                    dtFilteredView.RowFilter = $"Gendor='{txtFilter1.Text}'";
                    break;
                case "Phone":
                    dtFilteredView.RowFilter = $"Phone='{txtFilter1.Text}'";
                    break;
                case "Email":
                    dtFilteredView.RowFilter = $"Email='{txtFilter1.Text}'";
                    break;
                default:
                    break;
            }
            _GetDataViewData(dtFilteredView);
        }
    }

}
