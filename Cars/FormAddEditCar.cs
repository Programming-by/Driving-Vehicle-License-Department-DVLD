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
    public partial class FormAddEditCar : Form
    {
        enum enMode { AddNew = 0 , Update = 1};

        enMode Mode;
        public FormAddEditCar()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        long _CarDetailsID = -1;

        private clsCarDetail _CarDetails;
        public FormAddEditCar(long CarDetailsID)
        {
            InitializeComponent();
            _CarDetailsID = CarDetailsID;

            Mode = enMode.Update;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _FillVehicleNames()
        {
            DataTable dtVehicles = clsVehicle.GetAllVehicles();

            foreach (DataRow row in dtVehicles.Rows)
            {
                cbVehicleName.Items.Add(row["VehicleName"]);
            }
            cbVehicleName.SelectedIndex = 0;
        }
        private void _FillMakeNames()
        {
            DataTable dtMakes = clsMake.GetAllMakes();

            foreach (DataRow row in dtMakes.Rows)
            {
                cbMake.Items.Add(row["MakeName"]);
            }
            cbMake.SelectedIndex = 0;
        }
        private void _FillModelNames()
        {
            DataTable dtModels = clsModel.GetAllModels();

            foreach (DataRow row in dtModels.Rows)
            {
                cbModel.Items.Add(row["ModelName"]);
            }
            cbModel.SelectedIndex = 0;  
        }
        private void _FillSubModelNames()
        {
            DataTable dtSubModels = clsSubmodel.GetAllSubModels();

            foreach (DataRow row in dtSubModels.Rows)
            {
                cbSubModel.Items.Add(row["SubModelName"]);
            }
            cbSubModel.SelectedIndex = 0;
        }
        private void _FillBodyNames()
        {
            DataTable dtBodies = clsBody.GetAllBodies();

            foreach (DataRow row in dtBodies.Rows)
            {
                cbBody.Items.Add(row["BodyName"]);
            }
            cbBody.SelectedIndex = 0;
        }
        private void _FillDriveTypeNames()
        {
            DataTable dtDriveTypes = clsDriveType.GetAllDriveTypes();

            foreach (DataRow row in dtDriveTypes.Rows)
            {
                cbDriverType.Items.Add(row["DriveTypeName"]);
            }
            cbDriverType.SelectedIndex = 0;
        }
        private void _FillFuelTypeNames()
        {
            DataTable dtFuelTypes = clsFuelType.GetAllFuelTypes();

            foreach (DataRow row in dtFuelTypes.Rows)
            {
                cbFuelType.Items.Add(row["FuelTypeName"]);
            }
            cbFuelType.SelectedIndex = 0;
        }
        private void _FillEngineList()
        {
            DataTable dtEngines = clsEngine.GetAllEngines();

            foreach (DataRow row in dtEngines.Rows)
            {
                cbEngine.Items.Add(row["Engine"]);
            }
            cbEngine.SelectedIndex = 0;
        }
        private void _FillYearList()
        {
            DataTable dtYears= clsYear.GetAllYears();

            foreach (DataRow row in dtYears.Rows)
            {
                cbYear.Items.Add(row["Year"]);
            }
            cbYear.SelectedIndex = cbYear.Items.Count - 1;
        }
        private void _FillComboBoxes()
        {
            _FillVehicleNames();
            _FillMakeNames();
            _FillModelNames();
            _FillSubModelNames();
            _FillBodyNames();
            _FillDriveTypeNames();
            _FillFuelTypeNames();
            _FillEngineList();
            _FillYearList();
        }
        private void _ResetDefaultValues()
        {
            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Car";
                this.Text = "Add New Car";
                _CarDetails = new clsCarDetail();
            } else
            {
                lblTitle.Text = "Update Car";
                this.Text = "Update Car";
            }
            chkAvailableForRent.Checked = true;
        }
        private void _LoadData()
        {

        }
        private void FormAddEditCar_Load(object sender, EventArgs e)
        {
            _FillComboBoxes();
            numericNumberOfDoors.Value = 2;
            _ResetDefaultValues();
            if (Mode == enMode.Update)
                _LoadData();

        }

        private void txtRentalPricePerDay_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRentalPricePerDay.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtRentalPricePerDay,"Rental Price Per Day cannot be empty");
            } else
                errorProvider1.SetError(txtRentalPricePerDay, "");

        }

        private void txtPlateNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlateNumber.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPlateNumber, "Plate Number cannot be empty");
            }
            else
                errorProvider1.SetError(txtPlateNumber, "");
        }

        private void txtMileage_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMileage.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtMileage, "Mileage cannot be empty");
            }
            else
                errorProvider1.SetError(txtMileage, "");
        }

        private void txtRentalPricePerDay_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtMileage_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int VehicleID = clsVehicle.Find(cbVehicleName.Text).VehicleID;
            int MakeID = clsMake.Find(cbMake.Text).MakeID;
            int ModelID = clsModel.Find(cbModel.Text).ModelID;
            int SubmodelID = clsSubmodel.Find(cbSubModel.Text).SubModelID;
            int BodyID = clsBody.Find(cbBody.Text).BodyID;
            int DriveTypeID = clsDriveType.Find(cbDriverType.Text).DriveTypeID;
            int FuelTypeID = clsFuelType.Find(cbFuelType.Text).FuelTypeID;
            int EngineID = clsEngine.Find(cbEngine.Text).EngineID;
            int YearID = clsYear.Find(cbYear.Text).YearID;
            _CarDetails.VehicleID = VehicleID;   
            _CarDetails.MakeID = MakeID;
            _CarDetails.ModelID = ModelID;
            _CarDetails.SubmodelID = SubmodelID;
            _CarDetails.BodyID = BodyID;
            _CarDetails.DriveTypeID = DriveTypeID;
            _CarDetails.FuelTypeID = FuelTypeID;
            _CarDetails.EngineID = EngineID;
            _CarDetails.YearID = YearID;

             _CarDetails.RentalPricePerDay = int.Parse(txtRentalPricePerDay.Text);

             _CarDetails.NumberOfDoors = (short) numericNumberOfDoors.Value;

             _CarDetails.PlateNumber = txtPlateNumber.Text;

            _CarDetails.Mileage = decimal.Parse(txtMileage.Text);



            if (_CarDetails.Save())
            {
                lblVehicleID.Text = _CarDetails.CarDetailID.ToString();
                Mode = enMode.Update;
                lblTitle.Text = "Update Car";
                this.Text = "Update Car";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }


    }
