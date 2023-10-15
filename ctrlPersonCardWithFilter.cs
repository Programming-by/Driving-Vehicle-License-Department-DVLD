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

        public static int PersonID { get; set; }

        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
            AllPeople = new DataGridView();
        }

    
        public int GetPersonID()
        {
            return PersonID;
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
            _LoadData();
        }

        private void _LoadData()
        {
            if (int.TryParse(txtFound.Text, out int PersonID))
            {

            _Person = clsPersonData.Find(PersonID);

             

            }
            //else
            //{
            //    _Person = clsPersonData.Find(txtFound.Text);
            //}

            if (_Person == null)
            {
                MessageBox.Show("Person is not found");
                return;
            }
            _Country = clsCountryData.Find(_Person.NationalityCountryID);


            PersonID = _Person.PersonID;

            lblPersonID.Text = _Person.PersonID.ToString();
            lblName.Text = _Person.FullName();
            lblNationalNo.Text = _Person.NationalNo;
            if (_Person.Gendor == 0)
            {
                lblGendor.Text = "Male";
            }
            else
            {
                lblGendor.Text = "Female";
            }
            lblEmail.Text = _Person.Email;
            lblAddress.Text = _Person.Address;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToString();
            lblPhone.Text = _Person.Phone;
            lblCountry.Text = _Country.CountryName;

            //if (pbImage.BackgroundImage != null)
            //{
            //    pbImage.Image = Image.FromFile(_Person.ImagePath);
            //    pbImage.BackgroundImage = null;
            //    pbImage.SizeMode = PictureBoxSizeMode.Zoom;

            //}



        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            FormAddEditPerson frm = new FormAddEditPerson(-1);

            frm.GetAllPeople(AllPeople);

            frm.ShowDialog();
        }


        //private void _GetDataViewData(DataView dtFilteredView)
        //{

        //     _Person = clsPersonData.Find(_Person.PersonID);

        //    for (int i = 0; i < dtFilteredView.Count; i++)
        //    {
        //        lblPersonID.Text = dtFilteredView[i][0].ToString();
        //        lblNationalNo.Text = dtFilteredView[i][1].ToString();
        //        lblName.Text = dtFilteredView[i][2].ToString() + " " + dtFilteredView[i][3] + " " +  dtFilteredView[i][4] + " " + dtFilteredView[i][5];
        //        lblGendor.Text = dtFilteredView[i][6].ToString();
        //        lblDateOfBirth.Text = dtFilteredView[i][7].ToString();
        //        lblCountry.Text = dtFilteredView[i][8].ToString();
        //        lblPhone.Text = dtFilteredView[i][9].ToString();
        //        lblEmail.Text = dtFilteredView[i][10].ToString();
        //    }




        //}


        //private void txtFound_TextChanged(object sender, EventArgs e)
        //{
        //    //if (cbFilters.Text == "PersonID")
        //    //{
        //    //    PersonID = Convert.ToInt32(txtFound.Text);

        //    //}
        //    //else if (cbFilters.Text == "NationalNo.")
        //    //{

        //    //} else
        //    //{
        //    //    Text = txtFound.Text;

        //    //}


        //    DataTable dtFiltered = clsPersonData.GetAllPeople();
        //    DataView dtFilteredView = dtFiltered.DefaultView;
        //    switch (cbFilters.Text)
        //    {
        //        case "PersonID":
        //            if (txtFound.Text == "")
        //            {
        //                dtFilteredView.RowFilter = string.Empty;

        //            }
        //            else
        //            {
        //                dtFilteredView.RowFilter = $"PersonID='{txtFound.Text}'";
        //            }

        //            break;
        //        case "NationalNo.":
        //            dtFilteredView.RowFilter = $"NationalNo='{txtFound.Text}'";

        //            break;
        //        case "FirstName":
        //            dtFilteredView.RowFilter = $"FirstName='{txtFound.Text}'";
        //            break;
        //        case "SecondName":

        //            dtFilteredView.RowFilter = $"SecondName='{txtFound.Text}'";
        //            break;
        //        case "ThirdName":
        //            dtFilteredView.RowFilter = $"ThirdName='{txtFound.Text}'";
        //            break;
        //        case "LastName":
        //            dtFilteredView.RowFilter = $"LastName='{txtFound.Text}'";
        //            break;
        //        case "Nationality":
        //            dtFilteredView.RowFilter = $"Nationality='{txtFound.Text}'";
        //            break;
        //        case "Gendor":
        //            dtFilteredView.RowFilter = $"Gendor='{txtFound.Text}'";
        //            break;
        //        case "Phone":
        //            dtFilteredView.RowFilter = $"Phone='{txtFound.Text}'";
        //            break;
        //        case "Email":
        //            dtFilteredView.RowFilter = $"Email='{txtFound.Text}'";
        //            break;
        //        default:
        //            break;
        //    }
        //    _GetDataViewData(dtFilteredView);

        //}

        //private void linkLabel1EditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //      FormAddEditPerson frm = new FormAddEditPerson(_Person.PersonID);

        //    frm.GetAllPeople(AllPeople);

        //       frm.ShowDialog();
        //}
    }
}
