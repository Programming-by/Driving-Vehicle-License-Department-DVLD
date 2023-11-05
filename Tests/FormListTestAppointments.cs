using DVLDBusinessLayer;
using DVLDWinForm.Properties;
using DVLDWinForm.Tests.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWinForm.Tests
{
    public partial class FormListTestAppointments : Form
    {
        private DataTable _dtLicenseTestAppointments;
        private int _LocalDrivingLicenseApplicationID = -1;
        clsTestType.enTestType _TestType = clsTestType.enTestType.VisionTest;
         
        public FormListTestAppointments(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestType)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestType = TestType;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadTestTypeImageAndTitle()
        {
            switch (_TestType)
            {

                case clsTestType.enTestType.VisionTest:
                    lblTitle.Text = "Vision Test Appointments";
                    this.Text = "Vision Test Appointments";
                    pbTestTypeImage.Image = Resources.Vision_512;
                    break;
                case clsTestType.enTestType.WrittenTest:
                    lblTitle.Text = "Written Test Appointments";
                    this.Text     = "Written Test Appointments";
                    pbTestTypeImage.Image = Resources.Written_Test_512;

                    break;
                case clsTestType.enTestType.StreetTest:
                    lblTitle.Text = "Street Test Appointments";
                    this.Text     = "Street Test Appointments";
                    pbTestTypeImage.Image = Resources.driving_test_512;
                    break;
            }

        }
        private void FormListTestAppointments_Load(object sender, EventArgs e)
        {
            _LoadTestTypeImageAndTitle();
            ctrlDrivingLicenseApplicationInfo1.LoadApplicationInfoByLocalDrivingAppID(_LocalDrivingLicenseApplicationID);
            _dtLicenseTestAppointments = clsTestAppointment.GetApplicationTestAppointmentsPerTestType(_LocalDrivingLicenseApplicationID,_TestType);
            dgvLicenseTestAppointments.DataSource = _dtLicenseTestAppointments;
            lblRecordsCount.Text = dgvLicenseTestAppointments.Rows.Count.ToString();
            
            if (dgvLicenseTestAppointments.Rows.Count > 0)
            {
                dgvLicenseTestAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvLicenseTestAppointments.Columns[0].Width = 150;

                dgvLicenseTestAppointments.Columns[1].HeaderText = "Appointment Date";
                dgvLicenseTestAppointments.Columns[1].Width = 200;

                dgvLicenseTestAppointments.Columns[2].HeaderText = "Paid Fees";
                dgvLicenseTestAppointments.Columns[2].Width = 150;

                dgvLicenseTestAppointments.Columns[3].HeaderText = "is Locked";
                dgvLicenseTestAppointments.Columns[3].Width = 100;
            }


        }

        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplications LocalDrivingLicenseApplications = clsLocalDrivingLicenseApplications.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);

            if (LocalDrivingLicenseApplications.IsThereAnActiveScheduledTest(_TestType))
            {
                MessageBox.Show("Person Already have an active appointment for this Test,you can't add new appointment","Not allowed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            //clsTest LastTest = localDrivingLicenseApplication.GetLastTestPerTestType(_TestType);

            //if (LastTest == null)
            //{
            //    frmScheduleTest frm1 = new frmScheduleTest(_LocalDrivingLicenseApplicationID, _TestType);
            //    frm1.ShowDialog();
            //    frmListTestAppointments_Load(null, null);
            //    return;
            //}


            //if (LastTest.TestResult == true)
            //{
            //    MessageBox.Show("This person already passed this test before, you can only retake faild test", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //FormScheduleTest frm2 = new FormScheduleTest
            //    (LastTest.TestAppointmentInfo.LocalDrivingLicenseApplicationID, _TestType);
            //frm2.ShowDialog();
            //FormListTestAppointments_Load(null, null);

            FormScheduleTest frm2 = new FormScheduleTest
            (_LocalDrivingLicenseApplicationID, _TestType);
            frm2.ShowDialog();
            FormListTestAppointments_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int) dgvLicenseTestAppointments.CurrentRow.Cells[0].Value;
            FormScheduleTest frm = new FormScheduleTest(_LocalDrivingLicenseApplicationID,_TestType,TestAppointmentID);

            frm.ShowDialog();


            FormListTestAppointments_Load(null, null);
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvLicenseTestAppointments.CurrentRow.Cells[0].Value;

            FormTakeTest frm = new FormTakeTest(_LocalDrivingLicenseApplicationID, TestAppointmentID);

            frm.ShowDialog();

            FormListTestAppointments_Load(null, null);

        }
    }
}
