﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWinForm.Licenses
{
    public partial class FormShowPersonLicenseHistory : Form
    {
        private int _PersonID = -1;

        public FormShowPersonLicenseHistory()
        {
            InitializeComponent();
        }
        public FormShowPersonLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormShowPersonLicenseHistory_Load(object sender, EventArgs e)
        {
            if (_PersonID != -1 )
            {

            ctrlPersonCardWithFilter1.LoadPersonInfo(_PersonID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;
            ctrlDriverLicenses1.LoadInfoByPersonID(_PersonID);

            } else
            {
                ctrlPersonCardWithFilter1.FilterEnabled = true;
                ctrlPersonCardWithFilter1.FilterFocus();

            }

        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            _PersonID = obj;
            if (_PersonID == -1 )
            {
                ctrlDriverLicenses1.Clear();
            }
            else
            ctrlDriverLicenses1.LoadInfoByPersonID(_PersonID);
        }
    }
}
