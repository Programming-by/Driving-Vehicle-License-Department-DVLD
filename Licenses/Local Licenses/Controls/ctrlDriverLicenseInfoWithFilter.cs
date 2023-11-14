using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace  DVLDWinForm.Licenses.Local_Licenses.Controls
{
    public partial class ctrlDriverLicenseInfoWithFilter : UserControl
    {
        public ctrlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtLicenseID.Text != "" && int.TryParse(txtLicenseID.Text, out int LicenseID))
                ctrlDriverLicenseInfo1.LoadInfo(LicenseID);
            else
                MessageBox.Show("Please enter valid licence id");
        }
    }
}
