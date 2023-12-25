namespace DVLDWinForm.Cars
{
    partial class FormListAllCars
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
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCarDetailsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCarDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddNewCarDetails = new System.Windows.Forms.Button();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilter1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFilters
            // 
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "None",
            "MakeName",
            "ModelName",
            "Year",
            "SubModelName",
            "BodyName",
            "VehicleName",
            "DriveTypeName",
            "Engine",
            "FuelTypeName"});
            this.cbFilters.Location = new System.Drawing.Point(179, 70);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(168, 24);
            this.cbFilters.TabIndex = 44;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 43;
            this.label3.Text = "Filter By:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1078, 429);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 47);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCarDetailsCount
            // 
            this.lblCarDetailsCount.AutoSize = true;
            this.lblCarDetailsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarDetailsCount.Location = new System.Drawing.Point(174, 437);
            this.lblCarDetailsCount.Name = "lblCarDetailsCount";
            this.lblCarDetailsCount.Size = new System.Drawing.Size(23, 25);
            this.lblCarDetailsCount.TabIndex = 41;
            this.lblCarDetailsCount.Text = "#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "# Records: ";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // addNewCarDetailsToolStripMenuItem
            // 
            this.addNewCarDetailsToolStripMenuItem.Name = "addNewCarDetailsToolStripMenuItem";
            this.addNewCarDetailsToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.addNewCarDetailsToolStripMenuItem.Text = "Add New Car Details";
            this.addNewCarDetailsToolStripMenuItem.Click += new System.EventHandler(this.addNewCarDetailsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCarDetailsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(217, 76);
            // 
            // btnAddNewCarDetails
            // 
            this.btnAddNewCarDetails.Location = new System.Drawing.Point(1087, 42);
            this.btnAddNewCarDetails.Name = "btnAddNewCarDetails";
            this.btnAddNewCarDetails.Size = new System.Drawing.Size(111, 73);
            this.btnAddNewCarDetails.TabIndex = 39;
            this.btnAddNewCarDetails.UseVisualStyleBackColor = true;
            this.btnAddNewCarDetails.Click += new System.EventHandler(this.btnAddNewCarDetails_Click);
            // 
            // dgvCars
            // 
            this.dgvCars.AllowUserToAddRows = false;
            this.dgvCars.AllowUserToDeleteRows = false;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCars.Location = new System.Drawing.Point(52, 121);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.ReadOnly = true;
            this.dgvCars.RowHeadersWidth = 51;
            this.dgvCars.RowTemplate.Height = 24;
            this.dgvCars.Size = new System.Drawing.Size(1146, 295);
            this.dgvCars.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(633, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "Manage Cars";
            // 
            // txtFilter1
            // 
            this.txtFilter1.Location = new System.Drawing.Point(374, 72);
            this.txtFilter1.Name = "txtFilter1";
            this.txtFilter1.Size = new System.Drawing.Size(191, 22);
            this.txtFilter1.TabIndex = 45;
            this.txtFilter1.TextChanged += new System.EventHandler(this.txtFilter1_TextChanged_1);
            // 
            // FormListAllCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 485);
            this.Controls.Add(this.txtFilter1);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCarDetailsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNewCarDetails);
            this.Controls.Add(this.dgvCars);
            this.Controls.Add(this.label1);
            this.Name = "FormListAllCars";
            this.Text = "FormListAllCars";
            this.Load += new System.EventHandler(this.FormListAllCars_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCarDetailsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCarDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAddNewCarDetails;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilter1;
    }
}