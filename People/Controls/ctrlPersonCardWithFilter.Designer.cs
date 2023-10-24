namespace DVLDWinForm
{
    partial class ctrlPersonCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label19 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.btnSearchPerson = new System.Windows.Forms.Button();
            this.txtFilterValue = new System.Windows.Forms.MaskedTextBox();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonCard1 = new DVLDWinForm.ctrlPersonCard();
            this.gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 25);
            this.label19.TabIndex = 19;
            this.label19.Text = "Find By:";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.Silver;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "NationalNo.",
            "PersonID"});
            this.cbFilterBy.Location = new System.Drawing.Point(96, 42);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(197, 24);
            this.cbFilterBy.TabIndex = 21;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewPerson.Image = global::DVLDWinForm.Properties.Resources.Add_Person_40;
            this.btnAddNewPerson.Location = new System.Drawing.Point(638, 23);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(75, 61);
            this.btnAddNewPerson.TabIndex = 23;
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.Image = global::DVLDWinForm.Properties.Resources.SearchPerson;
            this.btnSearchPerson.Location = new System.Drawing.Point(532, 25);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.Size = new System.Drawing.Size(75, 61);
            this.btnSearchPerson.TabIndex = 22;
            this.btnSearchPerson.UseVisualStyleBackColor = true;
            this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(315, 44);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(184, 22);
            this.txtFilterValue.TabIndex = 24;
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            this.txtFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterValue_Validating);
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.btnAddNewPerson);
            this.gbFilters.Controls.Add(this.txtFilterValue);
            this.gbFilters.Controls.Add(this.btnSearchPerson);
            this.gbFilters.Controls.Add(this.label19);
            this.gbFilters.Controls.Add(this.cbFilterBy);
            this.gbFilters.Location = new System.Drawing.Point(18, 3);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(864, 100);
            this.gbFilters.TabIndex = 25;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filter";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(18, 131);
            this.ctrlPersonCard1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(924, 380);
            this.ctrlPersonCard1.TabIndex = 26;
            // 
            // ctrlPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.gbFilters);
            this.Name = "ctrlPersonCardWithFilter";
            this.Size = new System.Drawing.Size(1059, 595);
            this.Load += new System.EventHandler(this.ctrlPersonCardWithFilter_Load);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Button btnSearchPerson;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.MaskedTextBox txtFilterValue;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ctrlPersonCard ctrlPersonCard1;
    }
}
