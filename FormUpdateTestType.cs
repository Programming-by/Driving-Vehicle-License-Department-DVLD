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

namespace DVLDWinForm
{
    public partial class FormUpdateTestType : Form
    {
        int _TestTypeID;
        string _TestTypeTitle;
        string _TestTypeDescription;
        decimal _TestTypeFees;

        clsTestTypesData _TestTypeData;
        public FormUpdateTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            InitializeComponent();

            _TestTypeID = TestTypeID;
            _TestTypeTitle = TestTypeTitle;
            _TestTypeDescription = TestTypeDescription;
            _TestTypeFees = TestTypeFees;
        }
        private void _LoadData()
        {
            lblTestTypeID.Text = _TestTypeID.ToString();
            txtTestTypeTitle.Text = _TestTypeTitle.ToString();
            txtTestTypeDescription.Text = _TestTypeDescription.ToString();
            txtTestTypeFees.Text = _TestTypeFees.ToString();

        }
        private void FormUpdateTestType_Load(object sender, EventArgs e)
        {

            _LoadData();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            _TestTypeData = clsTestTypesData.Find(_TestTypeID);


            if (_TestTypeData == null)
            {
                MessageBox.Show("Test Type Does not Exist");
                return;
            }

            _TestTypeTitle = txtTestTypeTitle.Text;
            _TestTypeDescription = txtTestTypeDescription.Text;
            _TestTypeFees = Convert.ToDecimal(txtTestTypeFees.Text);

            if (clsTestTypesData.UpdateTestType(_TestTypeID, _TestTypeTitle, _TestTypeDescription, _TestTypeFees))
            {

                MessageBox.Show("Data Saved Successfully");
                

            }
        }
    }
}
