namespace DVLDWinForm.Cars
{
    partial class FormAddEditCar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.chkAvailableForRent = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.cbMake = new System.Windows.Forms.ComboBox();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.cbSubModel = new System.Windows.Forms.ComboBox();
            this.cbBody = new System.Windows.Forms.ComboBox();
            this.cbDriverType = new System.Windows.Forms.ComboBox();
            this.cbFuelType = new System.Windows.Forms.ComboBox();
            this.txtRentalPricePerDay = new System.Windows.Forms.TextBox();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.numericNumberOfDoors = new System.Windows.Forms.NumericUpDown();
            this.cbEngine = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbVehicleName = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOfDoors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTitle.Location = new System.Drawing.Point(444, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(156, 29);
            this.lblTitle.TabIndex = 38;
            this.lblTitle.Text = "Add New Car";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(34, 108);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(118, 25);
            this.label19.TabIndex = 39;
            this.label19.Text = "Vehicle ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Vehicle Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Make:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Model:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 304);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "SubModel Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 344);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "Body:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 380);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 45;
            this.label7.Text = "Driver Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 425);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 25);
            this.label8.TabIndex = 46;
            this.label8.Text = "Fuel Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(577, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 25);
            this.label9.TabIndex = 47;
            this.label9.Text = "Engine:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(577, 169);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 25);
            this.label10.TabIndex = 48;
            this.label10.Text = "Rental Price Per Day:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(577, 220);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 25);
            this.label11.TabIndex = 49;
            this.label11.Text = "Number Of Doors:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(586, 261);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 25);
            this.label12.TabIndex = 50;
            this.label12.Text = "Plate Number:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(577, 308);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 25);
            this.label13.TabIndex = 51;
            this.label13.Text = "Mileage:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(577, 366);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 25);
            this.label14.TabIndex = 52;
            this.label14.Text = "Year:";
            // 
            // chkAvailableForRent
            // 
            this.chkAvailableForRent.AutoSize = true;
            this.chkAvailableForRent.Location = new System.Drawing.Point(813, 430);
            this.chkAvailableForRent.Name = "chkAvailableForRent";
            this.chkAvailableForRent.Size = new System.Drawing.Size(153, 20);
            this.chkAvailableForRent.TabIndex = 53;
            this.chkAvailableForRent.Text = "Is Available For Rent";
            this.chkAvailableForRent.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(504, 504);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 47);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(696, 504);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 47);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleID.Location = new System.Drawing.Point(215, 108);
            this.lblVehicleID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(48, 25);
            this.lblVehicleID.TabIndex = 56;
            this.lblVehicleID.Text = "???";
            // 
            // cbMake
            // 
            this.cbMake.FormattingEnabled = true;
            this.cbMake.Location = new System.Drawing.Point(220, 220);
            this.cbMake.Name = "cbMake";
            this.cbMake.Size = new System.Drawing.Size(211, 24);
            this.cbMake.TabIndex = 57;
            // 
            // cbModel
            // 
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(220, 261);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(211, 24);
            this.cbModel.TabIndex = 58;
            // 
            // cbSubModel
            // 
            this.cbSubModel.FormattingEnabled = true;
            this.cbSubModel.Location = new System.Drawing.Point(220, 308);
            this.cbSubModel.Name = "cbSubModel";
            this.cbSubModel.Size = new System.Drawing.Size(211, 24);
            this.cbSubModel.TabIndex = 59;
            // 
            // cbBody
            // 
            this.cbBody.FormattingEnabled = true;
            this.cbBody.Location = new System.Drawing.Point(220, 348);
            this.cbBody.Name = "cbBody";
            this.cbBody.Size = new System.Drawing.Size(211, 24);
            this.cbBody.TabIndex = 60;
            // 
            // cbDriverType
            // 
            this.cbDriverType.FormattingEnabled = true;
            this.cbDriverType.Location = new System.Drawing.Point(220, 384);
            this.cbDriverType.Name = "cbDriverType";
            this.cbDriverType.Size = new System.Drawing.Size(211, 24);
            this.cbDriverType.TabIndex = 61;
            // 
            // cbFuelType
            // 
            this.cbFuelType.FormattingEnabled = true;
            this.cbFuelType.Location = new System.Drawing.Point(220, 426);
            this.cbFuelType.Name = "cbFuelType";
            this.cbFuelType.Size = new System.Drawing.Size(211, 24);
            this.cbFuelType.TabIndex = 62;
            // 
            // txtRentalPricePerDay
            // 
            this.txtRentalPricePerDay.Location = new System.Drawing.Point(813, 173);
            this.txtRentalPricePerDay.Multiline = true;
            this.txtRentalPricePerDay.Name = "txtRentalPricePerDay";
            this.txtRentalPricePerDay.Size = new System.Drawing.Size(239, 35);
            this.txtRentalPricePerDay.TabIndex = 64;
            this.txtRentalPricePerDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRentalPricePerDay_KeyPress);
            this.txtRentalPricePerDay.Validating += new System.ComponentModel.CancelEventHandler(this.txtRentalPricePerDay_Validating);
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Location = new System.Drawing.Point(813, 265);
            this.txtPlateNumber.Multiline = true;
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(239, 35);
            this.txtPlateNumber.TabIndex = 65;
            this.txtPlateNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtPlateNumber_Validating);
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(813, 312);
            this.txtMileage.Multiline = true;
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(239, 35);
            this.txtMileage.TabIndex = 66;
            this.txtMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMileage_KeyPress);
            this.txtMileage.Validating += new System.ComponentModel.CancelEventHandler(this.txtMileage_Validating);
            // 
            // numericNumberOfDoors
            // 
            this.numericNumberOfDoors.Location = new System.Drawing.Point(813, 225);
            this.numericNumberOfDoors.Name = "numericNumberOfDoors";
            this.numericNumberOfDoors.Size = new System.Drawing.Size(239, 22);
            this.numericNumberOfDoors.TabIndex = 67;
            // 
            // cbEngine
            // 
            this.cbEngine.FormattingEnabled = true;
            this.cbEngine.Location = new System.Drawing.Point(813, 108);
            this.cbEngine.Name = "cbEngine";
            this.cbEngine.Size = new System.Drawing.Size(239, 24);
            this.cbEngine.TabIndex = 70;
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(813, 370);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(239, 24);
            this.cbYear.TabIndex = 71;
            // 
            // cbVehicleName
            // 
            this.cbVehicleName.FormattingEnabled = true;
            this.cbVehicleName.Location = new System.Drawing.Point(220, 169);
            this.cbVehicleName.Name = "cbVehicleName";
            this.cbVehicleName.Size = new System.Drawing.Size(211, 24);
            this.cbVehicleName.TabIndex = 72;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAddEditCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 563);
            this.Controls.Add(this.cbVehicleName);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.cbEngine);
            this.Controls.Add(this.numericNumberOfDoors);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.txtPlateNumber);
            this.Controls.Add(this.txtRentalPricePerDay);
            this.Controls.Add(this.cbFuelType);
            this.Controls.Add(this.cbDriverType);
            this.Controls.Add(this.cbBody);
            this.Controls.Add(this.cbSubModel);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.cbMake);
            this.Controls.Add(this.lblVehicleID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkAvailableForRent);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormAddEditCar";
            this.Text = "FormAddEditCar";
            this.Load += new System.EventHandler(this.FormAddEditCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOfDoors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkAvailableForRent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.ComboBox cbMake;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.ComboBox cbSubModel;
        private System.Windows.Forms.ComboBox cbBody;
        private System.Windows.Forms.ComboBox cbDriverType;
        private System.Windows.Forms.ComboBox cbFuelType;
        private System.Windows.Forms.TextBox txtRentalPricePerDay;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.NumericUpDown numericNumberOfDoors;
        private System.Windows.Forms.ComboBox cbEngine;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbVehicleName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}