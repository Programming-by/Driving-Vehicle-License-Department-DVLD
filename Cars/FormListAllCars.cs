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

namespace DVLDWinForm.Cars
{
    public partial class FormListAllCars : Form
    {
        public FormListAllCars()
        {
            InitializeComponent();
        }

        private static DataTable _dtAllCarDetails = clsCarDetail.GetAllCarDetails();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormListAllCars_Load(object sender, EventArgs e)
        {

            dgvCars.DataSource = _dtAllCarDetails;
            cbFilters.SelectedIndex = 0;
            lblCarDetailsCount.Text = _dtAllCarDetails.Rows.Count.ToString();


            if (dgvCars.Rows.Count > 0)
            {
            dgvCars.Columns[0].HeaderText = "Car Details ID";
            dgvCars.Columns[0].Width = 110;

            dgvCars.Columns[1].HeaderText = "Make Name";
            dgvCars.Columns[1].Width = 170;


            dgvCars.Columns[2].HeaderText = "Model Name";
            dgvCars.Columns[2].Width = 170;

            dgvCars.Columns[3].HeaderText = "Year";
            dgvCars.Columns[3].Width = 140;


            dgvCars.Columns[4].HeaderText = "Sub Model Name";
            dgvCars.Columns[4].Width = 170;

            dgvCars.Columns[5].HeaderText = "Body";
            dgvCars.Columns[5].Width = 170;

            dgvCars.Columns[6].HeaderText = "Vehicle";
            dgvCars.Columns[6].Width = 170;

            dgvCars.Columns[7].HeaderText = "Drive Type Name";
            dgvCars.Columns[7].Width = 170;

            dgvCars.Columns[8].HeaderText = "Engine";
            dgvCars.Columns[8].Width = 170;

            dgvCars.Columns[9].HeaderText = "Fuel Type";
            dgvCars.Columns[9].Width = 170;

            lblCarDetailsCount.Text = _dtAllCarDetails.Rows.Count.ToString();
        }

        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter1.Visible = (cbFilters.Text != "None");

            if (txtFilter1.Visible)
                txtFilter1.Text = "";
            txtFilter1.Focus();

        }

        private void txtFilter1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNewCarDetails_Click(object sender, EventArgs e)
        {
            FormAddEditCar frm = new FormAddEditCar();

            frm.ShowDialog();

            FormListAllCars_Load(null,null);
        }

        private void addNewCarDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddEditCar frm = new FormAddEditCar();

            frm.ShowDialog();

            FormListAllCars_Load(null, null);
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddEditCar frm = new FormAddEditCar((long)dgvCars.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            FormListAllCars_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Car [" + (long)dgvCars.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsCarDetail.DeleteCarDetails((long)dgvCars.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Car Details Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormListAllCars_Load(null, null);
                }
                else
                    MessageBox.Show("Car Details was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtFilter1_TextChanged_1(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilters.Text)
            {
                case "MakeName":
                    FilterColumn = "MakeName";
                    break;
                case "ModelName":
                    FilterColumn = "ModelName";

                    break;
                case "Year":
                    FilterColumn = "Year";

                    break;
                case "SubModelName":

                    FilterColumn = "SubModelName";
                    break;
                case "BodyName":
                    FilterColumn = "BodyName";
                    break;
                case "VehicleName":
                    FilterColumn = "VehicleName";

                    break;
                case "DriveTypeName":
                    FilterColumn = "DriveTypeName";
                    break;
                case "Engine":
                    FilterColumn = "Engine";
                    break;
                case "FuelTypeName":
                    FilterColumn = "FuelTypeName";

                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilter1.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllCarDetails.DefaultView.RowFilter = "";
                lblCarDetailsCount.Text = _dtAllCarDetails.Rows.Count.ToString();
                return;
            }

                _dtAllCarDetails.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter1.Text.Trim());
                lblCarDetailsCount.Text = _dtAllCarDetails.Rows.Count.ToString();

        }
    }
}
