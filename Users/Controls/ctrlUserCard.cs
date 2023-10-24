﻿using DVLDBusinessLayer;
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

namespace DVLDWinForm
{
    public partial class ctrlUserCard : UserControl
    {
        clsUserData _User;
        private int _UserID = -1;
        public int UserID
        {
            get { return _UserID; }
        }

        public ctrlUserCard()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int UserID)
        {
            _UserID = UserID;
           _User = clsUserData.FindByUserID(UserID);

            if (_User == null)
            {
                ResetUserInfo();

                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();


        }
        private void _FillUserInfo()
        {
            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);
            lblUserID.Text   = _User.UserID.ToString();
            lblUserName.Text = _User.UserName.ToString();
            if (_User.IsActive)
                lblIsActive.Text = "Yes";
            else
                lblIsActive.Text = "No";
        }
        public void ResetUserInfo()
        {
            _UserID = -1;
            lblUserID.Text   = "[????]";
            lblUserName.Text = "[????]";
            lblIsActive.Text = "[????]";
        }
        private void linkLabel1EditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAddUpdatePerson frm = new FormAddUpdatePerson(ctrlPersonCard1.PersonID);

            frm.ShowDialog();

            ctrlPersonCard1.LoadPersonInfo(ctrlPersonCard1.PersonID);
        }

    }
}
