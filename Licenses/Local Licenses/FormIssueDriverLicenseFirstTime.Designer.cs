﻿namespace DVLDWinForm.Licenses
{
    partial class FormIssueDriverLicenseFirstTime
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
            this.ctrlDrivingLicenseApplicationInfo1 = new DVLDWinForm.Applications.Local_Driving_License_Applications.Controls.ctrlDrivingLicenseApplicationInfo();
            this.ctrlApplicationBasicInfo1 = new DVLDWinForm.Applications.Controls.ctrlApplicationBasicInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnIssueLicense = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            this.ctrlDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            this.ctrlDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(1010, 433);
            this.ctrlDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // ctrlApplicationBasicInfo1
            // 
            this.ctrlApplicationBasicInfo1.Location = new System.Drawing.Point(341, 106);
            this.ctrlApplicationBasicInfo1.Name = "ctrlApplicationBasicInfo1";
            this.ctrlApplicationBasicInfo1.Size = new System.Drawing.Size(90, 16);
            this.ctrlApplicationBasicInfo1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 420);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 176;
            this.label1.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(150, 424);
            this.txtNotes.MaxLength = 500;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(783, 127);
            this.txtNotes.TabIndex = 175;
            // 
            // btnIssueLicense
            // 
            this.btnIssueLicense.Location = new System.Drawing.Point(698, 583);
            this.btnIssueLicense.Name = "btnIssueLicense";
            this.btnIssueLicense.Size = new System.Drawing.Size(217, 48);
            this.btnIssueLicense.TabIndex = 177;
            this.btnIssueLicense.Text = "Save";
            this.btnIssueLicense.UseVisualStyleBackColor = true;
            this.btnIssueLicense.Click += new System.EventHandler(this.btnIssueLicense_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(425, 583);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(217, 48);
            this.btnClose.TabIndex = 178;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormIssueDriverLicenseFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 654);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssueLicense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.ctrlApplicationBasicInfo1);
            this.Controls.Add(this.ctrlDrivingLicenseApplicationInfo1);
            this.Name = "FormIssueDriverLicenseFirstTime";
            this.Text = "\\\\\\\\\\\\\\\\\\\\\\";
            this.Load += new System.EventHandler(this.FormIssueDriverLicenseFirstTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Applications.Local_Driving_License_Applications.Controls.ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private Applications.Controls.ctrlApplicationBasicInfo ctrlApplicationBasicInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnIssueLicense;
        private System.Windows.Forms.Button btnClose;
    }
}