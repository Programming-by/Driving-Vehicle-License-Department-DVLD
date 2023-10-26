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

        public static DataTable _dtAllTestTypes;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        

        private void FormManageTestTypes_Load(object sender, EventArgs e)
        {
            _dtAllTestTypes = clsTestType.GetAllTestTypes();
            dgvTestTypes.DataSource = _dtAllTestTypes;
            lblTestTypesCount.Text = dgvTestTypes.Rows.Count.ToString();
            if (dgvTestTypes.Rows.Count > 0)
            {
                dgvTestTypes.Columns[0].HeaderText = "ID";
                dgvTestTypes.Columns[0].Width = 120;

                dgvTestTypes.Columns[1].HeaderText = "Title";
                dgvTestTypes.Columns[1].Width = 200;

                dgvTestTypes.Columns[2].HeaderText = "Description";
                dgvTestTypes.Columns[2].Width = 400;

                dgvTestTypes.Columns[3].HeaderText = "Fees";
                dgvTestTypes.Columns[3].Width = 100;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdateTestType frm = new FormUpdateTestType((clsTestType.enTestType)dgvTestTypes.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            FormManageTestTypes_Load(null, null);
        }
    }
}
