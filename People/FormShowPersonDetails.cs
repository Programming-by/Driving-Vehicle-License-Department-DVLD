﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWinForm
{
    public partial class FormShowPersonDetails : Form
    {
        public FormShowPersonDetails(int PersonID)
        {
            InitializeComponent();

            ctrlPersonCard1.LoadPersonInfo(PersonID);
        }

        public FormShowPersonDetails(string NationalNo)
        {
            InitializeComponent();

            ctrlPersonCard1.LoadPersonInfo(NationalNo);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }


    }
}
