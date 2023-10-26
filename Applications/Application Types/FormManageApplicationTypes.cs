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

        public static DataTable _dtAllApplicationTypes;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void FormManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _dtAllApplicationTypes = clsApplicationTypesData.GetAllApplicationTypes();
            dgvApplicationTypes.DataSource = _dtAllApplicationTypes;

            lblApplicationTypesCount.Text = dgvApplicationTypes.Rows.Count.ToString();
            if (dgvApplicationTypes.Rows.Count > 0)
            {
                dgvApplicationTypes.Columns[0].HeaderText = "ID";
                dgvApplicationTypes.Columns[0].Width = 110;

                dgvApplicationTypes.Columns[1].HeaderText = "Title";
                dgvApplicationTypes.Columns[1].Width = 400;


                dgvApplicationTypes.Columns[2].HeaderText = "Fees";
                dgvApplicationTypes.Columns[2].Width = 110;
            }

         }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdateApplicationType frm = new FormUpdateApplicationType((int)dgvApplicationTypes.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            FormManageApplicationTypes_Load(null,null);

        }
    }
}
