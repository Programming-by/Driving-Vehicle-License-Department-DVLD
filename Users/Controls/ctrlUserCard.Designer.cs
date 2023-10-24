namespace DVLDWinForm
{
    partial class ctrlUserCard
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
            this.gbLoginInformation = new System.Windows.Forms.GroupBox();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ctrlPersonCard1 = new DVLDWinForm.ctrlPersonCard();
            this.gbLoginInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLoginInformation
            // 
            this.gbLoginInformation.Controls.Add(this.lblIsActive);
            this.gbLoginInformation.Controls.Add(this.lblUserName);
            this.gbLoginInformation.Controls.Add(this.lblUserID);
            this.gbLoginInformation.Controls.Add(this.label21);
            this.gbLoginInformation.Controls.Add(this.label20);
            this.gbLoginInformation.Controls.Add(this.label19);
            this.gbLoginInformation.Location = new System.Drawing.Point(25, 407);
            this.gbLoginInformation.Name = "gbLoginInformation";
            this.gbLoginInformation.Size = new System.Drawing.Size(853, 100);
            this.gbLoginInformation.TabIndex = 5;
            this.gbLoginInformation.TabStop = false;
            this.gbLoginInformation.Text = "Login Information";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.Location = new System.Drawing.Point(664, 41);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(48, 25);
            this.lblIsActive.TabIndex = 23;
            this.lblIsActive.Text = "???";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(433, 41);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(48, 25);
            this.lblUserName.TabIndex = 22;
            this.lblUserName.Text = "???";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(129, 41);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(48, 25);
            this.lblUserID.TabIndex = 19;
            this.lblUserID.Text = "???";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(556, 41);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 25);
            this.label21.TabIndex = 21;
            this.label21.Text = "Is Active:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(310, 41);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(117, 25);
            this.label20.TabIndex = 20;
            this.label20.Text = "Username:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(32, 41);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 25);
            this.label19.TabIndex = 19;
            this.label19.Text = "User ID:";
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(3, 0);
            this.ctrlPersonCard1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(924, 380);
            this.ctrlPersonCard1.TabIndex = 6;
            // 
            // ctrlUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.gbLoginInformation);
            this.Name = "ctrlUserCard";
            this.Size = new System.Drawing.Size(967, 549);
            this.gbLoginInformation.ResumeLayout(false);
            this.gbLoginInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbLoginInformation;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private ctrlPersonCard ctrlPersonCard1;
    }
}
