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
    public partial class FormTakeTest : Form
    {
        int _LocalDrivingLicenseApplicationID = -1;
        int _AppointmentID = -1;
        public FormTakeTest(int LocalDrivingLicenseApplicationID,int AppointmentID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _AppointmentID = AppointmentID;
        }

        private void FormTakeTest_Load(object sender, EventArgs e)
        {
            ctrlScheduledTest1.LoadInfo(_LocalDrivingLicenseApplicationID,_AppointmentID);
        }
    }
}
