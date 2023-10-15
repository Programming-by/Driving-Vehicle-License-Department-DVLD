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
    public partial class FormUpdateApplicationType : Form
    {
        int _ApplicationTypeID;
        string _ApplicationTypeTitle;
        decimal _ApplicationFees;

        clsApplicationTypesData _ApplicationTypesData;
        public FormUpdateApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            InitializeComponent();

            _ApplicationTypeID = ApplicationTypeID;
            _ApplicationTypeTitle = ApplicationTypeTitle;
            _ApplicationFees = ApplicationFees;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {

            _ApplicationTypesData = clsApplicationTypesData.Find(_ApplicationTypeID);


            if (_ApplicationTypesData == null)
            {
                MessageBox.Show("Application Does not Exist");
                return;
            }

            _ApplicationTypeTitle = txtApplicationTitle.Text;
            _ApplicationFees = Convert.ToDecimal(txtApplicationFees.Text);

            if (clsApplicationTypesData.UpdateApplicationType(_ApplicationTypeID, _ApplicationTypeTitle, _ApplicationFees)) {

                MessageBox.Show("Data Saved Successfully");
                
            }

        }

        private void _LoadData()
        {
            lblApplicationTypeID.Text = _ApplicationTypeID.ToString();
            txtApplicationTitle.Text = _ApplicationTypeTitle.ToString();
            txtApplicationFees.Text = _ApplicationFees.ToString();

        }
        private void FormUpdateApplicationType_Load(object sender, EventArgs e)
        {

            _LoadData();
        }
   
    
    }
}
