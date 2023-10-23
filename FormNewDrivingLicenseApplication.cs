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
        clsLocalDrivingLicenseApplications _Application;
        clsLocalDrivingLicenseApplications _ApplicationFound;

        private int _Counter;
        public FormNewDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1 < tabControl1.TabCount) ?
                    tabControl1.SelectedIndex + 1 : tabControl1.SelectedIndex;
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

        private void FormNewDrivingLicenseApplication_Load(object sender, EventArgs e)
        {

            lblDate.Text = DateTime.Now.ToShortDateString().ToString();
            _FillLicenseClassesInComboBox();
            lblApplicationFees.Text = "15";
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Application = new clsLocalDrivingLicenseApplications();
            _Application.ClassName = cbLicenseClasses.Text;
            _Application.NationalNo = clsGlobal.CurrentUser.PersonData.NationalNo;
            _Application.FullName = clsGlobal.CurrentUser.PersonData.FullName;
            _Application.ApplicationDate = Convert.ToDateTime(lblDate.Text);
            _Application.PassedTestCount = 0;
            _Application.Status = "New";

            // _Counter++;

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
