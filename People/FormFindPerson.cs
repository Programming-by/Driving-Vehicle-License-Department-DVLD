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
    public partial class FormFindPerson : Form
    {
        public FormFindPerson()
        {
            InitializeComponent();
        }

        public delegate void DataBackEventHandler(object sender, int PersonID);

        public event DataBackEventHandler DataBack; 

        private void btnClose_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this,ctrlPersonCardWithFilter1.PersonID);
        }
    }
}
