using DVLDBusinessLayer;
using DVLDWinForm.Properties;
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
    public partial class ctrlPersonCard : UserControl
    {

       public static int PersonID { get; set; }
       public static DataGridView AllPeople { get; set; }

        

        clsPersonData _Person;
        public ctrlPersonCard()
        {
            InitializeComponent();

           
        }




        private void linkLabel1EditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAddEditPerson frm = new FormAddEditPerson(PersonID,AllPeople);

            frm.ShowDialog();

        }

        private void ctrlPersonCard_Load(object sender, EventArgs e)
        {
          _Person = clsPersonData.Find(PersonID);

            clsCountryData Country = clsCountryData.Find(_Person.NationalityCountryID);

            lblPersonID.Text = PersonID.ToString();
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
            lblCountry.Text = Country.CountryName;

            if (pbImage.BackgroundImage != null)
            {
             pbImage.Image =  Image.FromFile(_Person.ImagePath);
             pbImage.BackgroundImage = null;
                pbImage.SizeMode = PictureBoxSizeMode.Zoom;

            }
           


        }
    }
}
