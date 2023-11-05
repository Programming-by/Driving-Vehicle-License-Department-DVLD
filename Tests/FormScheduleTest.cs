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

namespace DVLDWinForm.Tests
{
    public partial class FormScheduleTest : Form
    {

        int _LocalLicenseApplicationID;

        clsTestType.enTestType _TestTypeID;

        int _AppointmentID = -1;
        public FormScheduleTest(int LocalLicenseApplicationID, clsTestType.enTestType TestTypeID, int AppointmentID = -1)
        {
            InitializeComponent();
            _LocalLicenseApplicationID = LocalLicenseApplicationID;
            _TestTypeID = TestTypeID;
            _AppointmentID = AppointmentID;
      }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormScheduleTest_Load(object sender, EventArgs e)
        {
            ctrlScheduleTest1.TestTypeID = _TestTypeID;
            ctrlScheduleTest1.LoadInfo(_LocalLicenseApplicationID,_AppointmentID);
        }
    }
}
