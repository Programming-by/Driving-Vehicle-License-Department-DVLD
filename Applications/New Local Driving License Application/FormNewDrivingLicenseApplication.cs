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
using DVLDClasses;


namespace DVLDWinForm
{
    public partial class FormNewDrivingLicenseApplication : Form
    {
        clsLocalDrivingLicenseApplications _ApplicationFound;
        public enum enMode { AddNew = 0, Update = 1 }

        enMode _Mode;

        int _LocalDrivingLicenseApplicationID = -1;
        clsLocalDrivingLicenseApplications _Application;

        private const int Fees = 15;
        public FormNewDrivingLicenseApplication()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public FormNewDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _Mode = enMode.Update;
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "New Local Driving License Application";
                this.Text = "New Local Driving License Application";
                _Application = new clsLocalDrivingLicenseApplications();
                tbApplicationInfo.Enabled = false;
            } else
            {
                lblTitle.Text = "Update Local Driving License Application";
                this.Text = "Update Local Driving License Application";
                tbApplicationInfo.Enabled = true;
                btnSave.Enabled = true;

            }


            lblAppID.Text   =  "[???]";
            lblAppDate.Text = DateTime.Now.ToShortDateString().ToString();
            lblAppFees.Text = Fees.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            _FillLicenseClassesInComboBox();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(_Mode == enMode.Update)
            {
                tbApplicationInfo.Enabled = true;
                btnSave.Enabled = true;
                tbApplicationInfo.SelectedTab = tbApplicationInfo.TabPages["tpApplicationInfo"];
            }

        }


        private void _FillLicenseClassesInComboBox()
        {
            DataTable dtLicenseClasses = clsLicenseClassData.GetAllLicenseClasses();
            foreach (DataRow row in dtLicenseClasses.Rows)
            {
                cbLicenseClasses.Items.Add(row["ClassName"]);
            }
            cbLicenseClasses.Text = "Class 3 - Ordinary driving license";
        }

        private void _LoadData()
        {
           //_Application = clsLocalDrivingLicenseApplications.Find(_LocalDrivingLicenseApplicationID);

           // if (_Application != null)
           // {
           //     MessageBox.Show("This form will be closed because No Application with ID = " + _LocalDrivingLicenseApplicationID);
           //     this.Close();
           //     return;
           // }

           // lblAppID.Text = _Application.LocalDrivingLicenseApplicationID.ToString();
           // lblAppDate.Text = _Application.ApplicationDate.ToString();
        }
        private void FormNewDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Application = new clsLocalDrivingLicenseApplications();
            _Application.ClassName = cbLicenseClasses.Text;
            _Application.NationalNo = clsGlobal.CurrentUser.PersonData.NationalNo;
            _Application.FullName = clsGlobal.CurrentUser.PersonData.FullName;
            _Application.ApplicationDate = Convert.ToDateTime(lblAppDate.Text);
            _Application.PassedTestCount = 0;
            _Application.Status = "New";


            _ApplicationFound = clsLocalDrivingLicenseApplications.Find(_Application.NationalNo);

            // if has no application save //
            // if has application check same class and show message
            // if has application check not same class and save

            if (_ApplicationFound == null)
            {
                if (_Application.Save())
                {
                    MessageBox.Show("Data Saved Successfully");
                }
            } else
            {

            if (_ApplicationFound.ClassName == _Application.ClassName && _ApplicationFound.Status == "New") {

                MessageBox.Show("Choose another License Class,the Selected Person Already have an active application for the selected class with id " + _ApplicationFound.LocalDrivingLicenseApplicationID);
                    return;
                } else
                {
                    if (_Application.Save())
                    {
                        MessageBox.Show("Data Saved Successfully");
                    }
                }
            }   
            //on save insert application 
            //on save again on same license class prevent him
            //if status is canceled you can use same licence class
        }
    }
}
