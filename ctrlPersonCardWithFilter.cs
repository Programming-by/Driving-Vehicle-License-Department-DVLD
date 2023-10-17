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
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        clsPersonData _Person;
        clsCountryData _Country;

        public static DataGridView AllPeople { get; set; }

        public static int _PersonID { get; set; }

        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
            AllPeople = new DataGridView();
        }

    
        public int GetPersonID()
        {
            return _PersonID;
        }

        public string GetFoundText()
        {
            return txtFound.Text;
        }

        public static void GetAllPeople(DataGridView dgvAllPeople)
        {
            AllPeople = dgvAllPeople;

        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            _GetDataViewData();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            FormAddEditPerson frm = new FormAddEditPerson(-1);

            frm.GetAllPeople(AllPeople);

            frm.ShowDialog();
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (cbFilters.Text == "NationalNo.")
            {
                txtFound.Mask = "L99999";
            } else if (cbFilters.Text == "PersonID")
              {
                txtFound.Mask = "99999";
              }
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
        }

        private void _GetDataViewData()
        {
            DataTable dtFiltered = clsPersonData.GetAllPeopleWithAllData();
            DataView dtFilteredView = dtFiltered.DefaultView;
            for (int i = 0;i < dtFilteredView.Count;i++)
            {
                _PersonID = (int) dtFilteredView[i][0];
                lblPersonID.Text = dtFilteredView[i][0].ToString();
                lblNationalNo.Text = dtFilteredView[i][1].ToString();
                lblName.Text = dtFilteredView[i][2].ToString() + " " + dtFilteredView[i][3].ToString() + " " + dtFilteredView[i][4].ToString() + dtFilteredView[i][5];
                lblGendor.Text = dtFilteredView[i][6].ToString();
                lblAddress.Text = dtFilteredView[i][7].ToString();
                lblDateOfBirth.Text = dtFilteredView[i][8].ToString();
                lblCountry.Text = dtFilteredView[i][9].ToString();
                lblPhone.Text = dtFilteredView[i][10].ToString();
                lblEmail.Text = dtFilteredView[i][11].ToString();

            }

        }

        private void linkLabel1EditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAddEditPerson frm = new FormAddEditPerson(_PersonID);

            frm.GetAllPeople(AllPeople);

            frm.ShowDialog();
        }
    }
}

