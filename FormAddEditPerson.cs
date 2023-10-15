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

namespace DVLDWinForm
{
 
    public partial class FormAddEditPerson : Form
    {

        string backupDir = @"c:\DVLD-People-Images\";
        public string NewImageName = "";

        public enum enMode { AddNew = 0 , Update = 1}

        enMode _Mode;

        int _PersonID;

       public DataGridView AllPeople { get; set; }

        clsPersonData _Person;


        public FormAddEditPerson(int PersonID)
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

        private void _ShowDateOver18Years()
        {
            DateTime TodayDate = DateTime.Now;

            DateTime DateOf18 = new DateTime(TodayDate.Year - 18,TodayDate.Month,TodayDate.Day);
          
            dateTimePicker1.MaxDate = DateOf18;
        }

        private void _LoadData()
        {

            _FillCountriesInComboBox();
            _ShowDateOver18Years();

            rbMale.Checked = true;

            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Person";

                _Person = new clsPersonData();
                return;
            }

            _Person = clsPersonData.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _PersonID);
                this.Close();
                return;
            }


            lblMode.Text = "Edit Person ID = " + _PersonID;
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;

            if (_Person.ThirdName != "")
            {
             txtThirdName.Text = _Person.ThirdName;
            } 

            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            dateTimePicker1.Value = _Person.DateOfBirth;
            if(_Person.Gendor == 0)
            {
                rbMale.Checked = true;
            }
            else
            {
                rbMale.Checked = false;
            }

            txtPhone.Text = _Person.Phone;
            if (txtEmail.Text != null)
            {
                txtEmail.Text = _Person.Email;
            }
            cbCountries.SelectedIndex = cbCountries.FindString(clsCountryData.Find(_Person.NationalityCountryID).CountryName);

            if (_Person.ImagePath != "")
            {
                 pbImage.Load(_Person.ImagePath + ".png");

            }
            

            txtAddress.Text = _Person.Address;

            linkLabelRemove.Visible = _Person.ImagePath != "";

        }

        private void _FillCountriesInComboBox()
        {
            DataTable dtCountries = clsCountryData.GetAllCountries();
            
                foreach (DataRow row in dtCountries.Rows)
                    cbCountries.Items.Add(row["CountryName"]);

                cbCountries.SelectedItem = "Jordan";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddEditPerson_Load(object sender, EventArgs e)
        {
            _LoadData();   
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            pbImage.Image = Image.FromFile(@"C:\person_boy.png");

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            pbImage.Image = Image.FromFile(@"C:\person_girl.png");
        }

        private void CheckIfNationalNoExist(CancelEventArgs e)
        {
            AllPeople.DataSource = clsPersonData.GetAllPeople();

            string NationalNo = "";

            foreach (DataGridViewRow row in AllPeople.Rows)
            {
                NationalNo = row.Cells["NationalNo"].Value.ToString().ToLower();
                if (txtNationalNo.Text.ToLower() == NationalNo) { 
                    e.Cancel = true;
                    txtNationalNo.Focus();
                    errorProvider1.SetError(txtNationalNo, "National No. is used for another person!");
                    break;
                } 
            }
            if (txtNationalNo.Text.ToLower() != NationalNo)
            {
                e.Cancel = false;
                 errorProvider1.SetError(txtNationalNo, "");

            }
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            CheckIfNationalNoExist(e);

            
        }
        public static bool isValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {

            if (!isValidEmail(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
            }
        }

        private void linkLabelSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            linkLabelRemove.Visible = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string selectedPath = openFileDialog1.FileName;

                pbImage.Load(selectedPath);
            }

        }

        private void linkLabelRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (rbMale.Checked)
            {
                pbImage.Image = Image.FromFile(@"C:\person_boy.png");
            } else
            {
                pbImage.Image =  Image.FromFile(@"C:\person_girl.png");
            }
            linkLabelRemove.Visible = false;

        }



        private void _SaveImageToFile(Guid ImageID)
        {

             NewImageName = ImageID.ToString() + ".png";


            string previousDirectory = pbImage.ImageLocation;

            string ImageName = previousDirectory.Split('\\').Last(); // get image name

            int count = previousDirectory.Length - ImageName.Length; 
            previousDirectory = previousDirectory.Substring(0, count); // get folder name
            File.Copy(Path.Combine(previousDirectory,ImageName), Path.Combine(backupDir, NewImageName), true);


           // string ImageToDelete = _Person.ImagePath;

          //  File.Delete(ImageToDelete + ".png");

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Guid ImageID = Guid.NewGuid();

            int CountryID = clsCountryData.Find(cbCountries.Text).CountryID;

            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            if(txtThirdName.Text != null){
            _Person.ThirdName = txtThirdName.Text;
            } else
            {
                _Person.ThirdName = "";
            }
            _Person.LastName = txtLastName.Text;
            _Person.NationalNo = txtNationalNo.Text;
            _Person.DateOfBirth = dateTimePicker1.Value;
            if (rbMale.Checked)
            {
                _Person.Gendor = 0;
            } else
            {
                _Person.Gendor = 1;
            }

            _Person.Phone = txtPhone.Text;


            if (txtEmail.Text != null)
            {
                _Person.Email = txtEmail.Text;
            }
            else
            {
                _Person.Email = "";
            }

            _Person.NationalityCountryID = CountryID;

            _Person.ImagePath = backupDir + ImageID;
            _Person.Address = txtAddress.Text;

            if (_Person.Save())
            {

                _SaveImageToFile(ImageID);

                MessageBox.Show("Data Saved Successfully");
            }
            else
            {
                MessageBox.Show("Failed To Save");

            }


        }

       
    }
}
