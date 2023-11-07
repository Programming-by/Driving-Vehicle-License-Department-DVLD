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
using System.Windows.Forms;
using static DVLDBusinessLayer.clsTestType;

namespace DVLDWinForm.Tests.Controls
{
    public partial class ctrlScheduledTest : UserControl
    {

        private clsTestType.enTestType _TestTypeID ;
        private int _TestID = -1;

        private clsLocalDrivingLicenseApplications _LocalDrivingLicenseApplications;

        public int TestAppointmentID
        {
            get { return _TestAppointmentID; }
        }
        public int TestID
        {
            get { return _TestID; }
        }

        public clsTestType.enTestType TestTypeID
        {
            get
            {
                return _TestTypeID;
            }
            set
            {
                _TestTypeID = value;

                switch (_TestTypeID)
                {

                    case clsTestType.enTestType.VisionTest:
                        {
                            gbTestType.Text = "Vision Test";
                            pbTestTypeImage.Image = Resources.Vision_512;
                            break;
                        }

                    case clsTestType.enTestType.WrittenTest:
                        {
                            gbTestType.Text = "Written Test";
                            pbTestTypeImage.Image = Resources.Written_Test_512;
                            break;
                        }
                    case clsTestType.enTestType.StreetTest:
                        {
                            gbTestType.Text = "Street Test";
                            pbTestTypeImage.Image = Resources.driving_test_512;
                            break;


                        }
                }
            }
        }

        private int _TestAppointmentID = -1;
        private int _LocalDrivingLicenseApplicationID = -1;
        private clsTestAppointment _TestAppointment;

        public void LoadInfo(int AppointmentID)
        {
            _TestAppointmentID=AppointmentID;

            _TestAppointment = clsTestAppointment.Find(_TestAppointmentID);
            if (_TestAppointment == null)
            {
                MessageBox.Show("Error: No Test Appointment with ID = " + _TestAppointment.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _TestAppointmentID = -1;
                return;
            }
            _TestID = _TestAppointment.TestID;
            _LocalDrivingLicenseApplicationID = _TestAppointment.LocalDrivingLicenseApplicationID;
            _LocalDrivingLicenseApplications = clsLocalDrivingLicenseApplications.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);

            if ( _LocalDrivingLicenseApplications == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _LocalDrivingLicenseApplicationID.ToString(),
                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            lblLocalDrivingLicenseAppID.Text = _TestAppointment.LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClass.Text = _LocalDrivingLicenseApplications.LicenseClassInfo.ClassName;
            lblFullName.Text = _LocalDrivingLicenseApplications.PersonFullName;
            lblTrial.Text = _LocalDrivingLicenseApplications.TotalTrialsPerTest(_TestTypeID).ToString();
            lblDate.Text = clsFormat.DateToShort(_TestAppointment.AppointmentDate);
            lblFees.Text = _TestAppointment.PaidFees.ToString();



        }


        public ctrlScheduledTest()
        {
            InitializeComponent();
        }

  
    }
}
