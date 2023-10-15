namespace DVLDWinForm
{
    partial class FormUpdateTestType
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTestTypeID = new System.Windows.Forms.Label();
            this.txtTestTypeFees = new System.Windows.Forms.TextBox();
            this.txtTestTypeTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTestTypeDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(301, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 39);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(186, 427);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 39);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // lblTestTypeID
            // 
            this.lblTestTypeID.AutoSize = true;
            this.lblTestTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestTypeID.Location = new System.Drawing.Point(265, 137);
            this.lblTestTypeID.Name = "lblTestTypeID";
            this.lblTestTypeID.Size = new System.Drawing.Size(52, 29);
            this.lblTestTypeID.TabIndex = 45;
            this.lblTestTypeID.Text = "???";
            // 
            // txtTestTypeFees
            // 
            this.txtTestTypeFees.Location = new System.Drawing.Point(186, 352);
            this.txtTestTypeFees.Multiline = true;
            this.txtTestTypeFees.Name = "txtTestTypeFees";
            this.txtTestTypeFees.Size = new System.Drawing.Size(236, 31);
            this.txtTestTypeFees.TabIndex = 44;
            // 
            // txtTestTypeTitle
            // 
            this.txtTestTypeTitle.Location = new System.Drawing.Point(186, 195);
            this.txtTestTypeTitle.Multiline = true;
            this.txtTestTypeTitle.Name = "txtTestTypeTitle";
            this.txtTestTypeTitle.Size = new System.Drawing.Size(236, 31);
            this.txtTestTypeTitle.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 42;
            this.label4.Text = "Fees:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 41;
            this.label3.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 29);
            this.label2.TabIndex = 40;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(194, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "Update Test Types";
            // 
            // txtTestTypeDescription
            // 
            this.txtTestTypeDescription.Location = new System.Drawing.Point(186, 269);
            this.txtTestTypeDescription.Multiline = true;
            this.txtTestTypeDescription.Name = "txtTestTypeDescription";
            this.txtTestTypeDescription.Size = new System.Drawing.Size(236, 31);
            this.txtTestTypeDescription.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-5, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 29);
            this.label5.TabIndex = 49;
            this.label5.Text = "Description:";
            // 
            // FormUpdateTestType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 478);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTestTypeDescription);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTestTypeID);
            this.Controls.Add(this.txtTestTypeFees);
            this.Controls.Add(this.txtTestTypeTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateTestType";
            this.Text = "FormUpdateTestType";
            this.Load += new System.EventHandler(this.FormUpdateTestType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTestTypeID;
        private System.Windows.Forms.TextBox txtTestTypeFees;
        private System.Windows.Forms.TextBox txtTestTypeTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTestTypeDescription;
        private System.Windows.Forms.Label label5;
    }
}