using DVLDBusinessLayer;
using DVLDClasses;
using DVLDWinForm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DVLDWinForm.Licenses.Controls
{
    public partial class ctrlDriverInternationalLicenseInfo : UserControl
    {
        private clsInternationalDrivingLicenseApplications _InternationalLicense;
        private int _InternationalLicenseID;

        public int InternationalLicenseID
        {
            get { return _InternationalLicenseID; }
        }

        public clsInternationalDrivingLicenseApplications SelectedLicenseInfo
        {
            get { return _InternationalLicense; }
        }
        public ctrlDriverInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        private void _LoadPersonImage()
        {
            if (_InternationalLicense.DriverInfo.PersonInfo.Gendor == 0)
            {
                pbPersonImage.Image = Resources.Male_512;
            }
            else
                pbPersonImage.Image = Resources.Female_512;

            string ImagePath = _InternationalLicense.DriverInfo.PersonInfo.ImagePath;
            if (ImagePath != null)
            {
                if (File.Exists(ImagePath))
                {
                    pbPersonImage.Load(ImagePath);
                }
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


        }


        public void LoadInfo(int InternationalLicenseID)
        {
            _InternationalLicenseID = InternationalLicenseID;

            _InternationalLicense = clsInternationalDrivingLicenseApplications.Find(_InternationalLicenseID);

            if (_InternationalLicense == null)
            {
                MessageBox.Show("Could not find International License ID = " + _InternationalLicenseID.ToString(),
             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _InternationalLicenseID = -1;
                return;
            }
            lblFullName.Text = _InternationalLicense.DriverInfo.PersonInfo.FullName;
            lblInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            lblLocalLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblNationalNo.Text = _InternationalLicense.DriverInfo.PersonInfo.NationalNo;
            lblGendor.Text = _InternationalLicense.DriverInfo.PersonInfo.Gendor == 0 ? "Male" : "Female";
            lblIssueDate.Text = clsFormat.DateToShort(_InternationalLicense.IssueDate);
            lblExpirationDate.Text = clsFormat.DateToShort(_InternationalLicense.ExpirationDate);
            lblApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
            lblIsActive.Text = _InternationalLicense.IsActive ? "Yes" : "No";
            lblDateOfBirth.Text = clsFormat.DateToShort(_InternationalLicense.DriverInfo.PersonInfo.DateOfBirth);
            lblDriverID.Text = _InternationalLicense.DriverID.ToString();

            _LoadPersonImage();

        }
    }
}
