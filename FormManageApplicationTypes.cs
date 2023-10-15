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
    public partial class FormManageApplicationTypes : Form
    {
        public FormManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _RefreshApplicationTypes()
        {
            dgvAllPeople.DataSource = clsApplicationTypesData.GetAllApplicationTypes();
        }

        private void _CountAllApplicationTypes()
        {
            lblApplicationTypesCount.Text = clsApplicationTypesData.CountApplicationTypes().ToString();
        }

        private void FormManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _RefreshApplicationTypes();
            _CountAllApplicationTypes();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdateApplicationType frm = new FormUpdateApplicationType((int)dgvAllPeople.CurrentRow.Cells[0].Value, (string)dgvAllPeople.CurrentRow.Cells[1].Value, (decimal)dgvAllPeople.CurrentRow.Cells[2].Value);

            frm.ShowDialog();

            _RefreshApplicationTypes();
        }
    }
}
