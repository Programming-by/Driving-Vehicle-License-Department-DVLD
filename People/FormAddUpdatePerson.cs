using DVLDBusinessLayer;
using DVLDWinForm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Collections;
using System.Reflection;
using DVLDClasses;


namespace DVLDWinForm
{
 
    public partial class FormAddUpdatePerson : Form
    {

        public delegate void DataBackEventHandler(object sender , int PersonID);

        public event DataBackEventHandler DataBack; 
        public enum enMode { AddNew = 0 , Update = 1}
        public enum enGendor { Male = 0 , Female = 1 }

        enMode _Mode;


        int _PersonID = -1;

        clsPersonData _Person;

        public FormAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public FormAddUpdatePerson(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;

            _Mode = enMode.Update;
        }

        private void _ResetDefaultValues()
        {

            _FillCountriesInComboBox();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                _Person = new clsPersonData();

            }
            else
            {
                lblTitle.Text = "Update Person";
            }

            if(rbMale.Checked)
            {
                pbPersonImage.Image = Resources.Male_512;
            }
            else
            {
                pbPersonImage.Image = Resources.Female_512;
            }

            lblRemoveImage.Visible = (pbPersonImage.ImageLocation != null);

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);

            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            cbCountries.SelectedIndex = cbCountries.FindString("Jordan");


            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            rbMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";


        }
        private void _FillCountriesInComboBox()
        {
            DataTable dtCountries = clsCountryData.GetAllCountries();
            
                foreach (DataRow row in dtCountries.Rows)
                    cbCountries.Items.Add(row["CountryName"]);

        }

        private void _LoadData()
        {

            _Person = clsPersonData.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("This form will be closed because No Person with ID = " + _PersonID);
                this.Close();
                return;
            }

            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            if(_Person.Gendor == 0)
            {
                rbMale.Checked = true;
            }
            else
            {
               rbFemale.Checked = true;
            }

            txtAddress.Text = _Person.Address;
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            cbCountries.SelectedIndex = cbCountries.FindString(_Person.CountryInfo.CountryName);

            if (_Person.ImagePath != "")
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;
            }

              lblRemoveImage.Visible = (_Person.ImagePath != "");

        }
        private void FormAddEditPerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if(_Mode == enMode.Update)
            _LoadData();   
        }

 
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }  
     
        private bool _HandlePersonImage()
        {
            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    } catch (Exception ex)
                    {

                    }
                }


                if (pbPersonImage.ImageLocation != null)
                {
                    string sourceFile = pbPersonImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref sourceFile))
                    {
                        pbPersonImage.ImageLocation = sourceFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }



            }


            return true;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_HandlePersonImage())
                return;

            int NationalityCountryID = clsCountryData.Find(cbCountries.Text).ID;

            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.NationalNo = txtNationalNo.Text;
            _Person.Email = txtEmail.Text;
            _Person.Phone = txtPhone.Text;
            _Person.Address = txtAddress.Text;
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            if (rbMale.Checked)
            {
                _Person.Gendor = (byte) enGendor.Male;
            } else
            {
                _Person.Gendor = (byte) enGendor.Female;
            }

            _Person.NationalityCountryID = NationalityCountryID;

            if (pbPersonImage.ImageLocation != null)
            {
                _Person.ImagePath = pbPersonImage.ImageLocation;
            } else
            {
                _Person.ImagePath = "";
            }


            if (_Person.Save())
            {
                lblPersonID.Text = _Person.PersonID.ToString();
                _Mode = enMode.Update;
                lblTitle.Text = "Update Person";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this,_Person.PersonID);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void lblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string selectedPath = openFileDialog1.FileName;
                pbPersonImage.Load(selectedPath);
                lblRemoveImage.Visible = true;
            }
        }
        private void linkLabelRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;

            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image =  Resources.Female_512;

            lblRemoveImage.Visible = false;
        }
        private void rbMale_Click(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Male_512;

        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Female_512;
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox Temp = ((TextBox)sender);

            if (string.IsNullOrEmpty(Temp.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");

            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, "");
            }
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
                return;

            if (!clsValidation.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }
        }
        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {

        }

    }
}
