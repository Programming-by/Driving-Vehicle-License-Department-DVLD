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
    public partial class FormManageTestTypes : Form
    {
        public FormManageTestTypes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _RefreshTestTypes()
        {
            dgvAllPeople.DataSource = clsTestTypesData.GetAllTestTypes();
        }

        private void _CountTestTypes()
        {
            lblTestTypesCount.Text = clsTestTypesData.CountTestTypes().ToString();
        }

        private void FormManageTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshTestTypes();
            _CountTestTypes();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdateTestType frm = new FormUpdateTestType((int)dgvAllPeople.CurrentRow.Cells[0].Value, (string)dgvAllPeople.CurrentRow.Cells[1].Value, (string)dgvAllPeople.CurrentRow.Cells[2].Value, (decimal)dgvAllPeople.CurrentRow.Cells[3].Value);
            
            frm.ShowDialog();

            _RefreshTestTypes();
        }
    }
}
