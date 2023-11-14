namespace DVLDWinForm.Licenses
{
    partial class FormShowInternationalLicenseInfo
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
            this.ctrlDriverInternationalLicenseInfo1 = new DVLDWinForm.Licenses.Controls.ctrlDriverInternationalLicenseInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlDriverInternationalLicenseInfo1
            // 
            this.ctrlDriverInternationalLicenseInfo1.Location = new System.Drawing.Point(-3, 64);
            this.ctrlDriverInternationalLicenseInfo1.Name = "ctrlDriverInternationalLicenseInfo1";
            this.ctrlDriverInternationalLicenseInfo1.Size = new System.Drawing.Size(868, 276);
            this.ctrlDriverInternationalLicenseInfo1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(218, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "Driver International License Info";
            // 
            // FormShowInternationalLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlDriverInternationalLicenseInfo1);
            this.Name = "FormShowInternationalLicenseInfo";
            this.Text = "FormShowInternationalLicenseInfo";
            this.Load += new System.EventHandler(this.FormShowInternationalLicenseInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlDriverInternationalLicenseInfo ctrlDriverInternationalLicenseInfo1;
        private System.Windows.Forms.Label label1;
    }
}