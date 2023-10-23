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
    public partial class ctrlPersonCardWithFilter : UserControl
    {

        public event Action<int> OnPersonSelected;

        protected virtual void PersonSelected(int PersonID)
        {
            Action <int> handler = OnPersonSelected;

            if (handler != null)
            {
                handler(PersonID);
            }
        }


        private bool _ShowAddPerson;

        public bool ShowAddPerson
        {
            get { return _ShowAddPerson; }

            set
            {

                _ShowAddPerson = value;
                btnAddNewPerson.Visible = _ShowAddPerson;

            }
        }

        private bool _FilterEnabled;

        public bool FilterEnabled
        {
            get { return _FilterEnabled; }

            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }

        }

        private int _PersonID = -1;

        public int PersonID
        {

            get { return ctrlPersonCard1.PersonID; }

        }

        public clsPersonData SelectedPersonInfo
        {
            get { return ctrlPersonCard1.SelectedPersonInfo; }
        }


        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }
        
        public void LoadPersonInfo(int PersonID)
        {
            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = PersonID.ToString();
            FindNow();

        }

        public void FindNow()
        {
            switch(cbFilterBy.SelectedText)
            {
                case "PersonID":
                    ctrlPersonCard1.LoadPersonInfo(int.Parse(txtFilterValue.Text));
                    break;

                case "NationalNo.":
                    ctrlPersonCard1.LoadPersonInfo(txtFilterValue.Text);
                    break;
            }

            if (OnPersonSelected != null && FilterEnabled)
            {
                PersonSelected(ctrlPersonCard1.PersonID);
            }
        }
        
        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FindNow();
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required!");

            } else
            {
                errorProvider1.SetError(txtFilterValue, "");
            }
        }
        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            FormAddUpdatePerson frm1 = new FormAddUpdatePerson();

            frm1.DataBack += DataBackEvent;

            frm1.ShowDialog();
        }

        private void DataBackEvent(object sender , int PersonID)
        {
            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = PersonID.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonID);
        }

        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                btnSearchPerson.PerformClick();
            }
         

            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

