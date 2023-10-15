namespace DVLDWinForm
{
    partial class FormUpdateApplicationType
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApplicationTitle = new System.Windows.Forms.TextBox();
            this.txtApplicationFees = new System.Windows.Forms.TextBox();
            this.lblApplicationTypeID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(198, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "Update Application Types";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "Fees:";
            // 
            // txtApplicationTitle
            // 
            this.txtApplicationTitle.Location = new System.Drawing.Point(234, 228);
            this.txtApplicationTitle.Multiline = true;
            this.txtApplicationTitle.Name = "txtApplicationTitle";
            this.txtApplicationTitle.Size = new System.Drawing.Size(236, 31);
            this.txtApplicationTitle.TabIndex = 34;
            // 
            // txtApplicationFees
            // 
            this.txtApplicationFees.Location = new System.Drawing.Point(234, 293);
            this.txtApplicationFees.Multiline = true;
            this.txtApplicationFees.Name = "txtApplicationFees";
            this.txtApplicationFees.Size = new System.Drawing.Size(236, 31);
            this.txtApplicationFees.TabIndex = 35;
            // 
            // lblApplicationTypeID
            // 
            this.lblApplicationTypeID.AutoSize = true;
            this.lblApplicationTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationTypeID.Location = new System.Drawing.Point(244, 149);
            this.lblApplicationTypeID.Name = "lblApplicationTypeID";
            this.lblApplicationTypeID.Size = new System.Drawing.Size(52, 29);
            this.lblApplicationTypeID.TabIndex = 36;
            this.lblApplicationTypeID.Text = "???";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(234, 359);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 39);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(349, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 39);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormUpdateApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblApplicationTypeID);
            this.Controls.Add(this.txtApplicationFees);
            this.Controls.Add(this.txtApplicationTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateApplicationType";
            this.Text = "Update Application Type";
            this.Load += new System.EventHandler(this.FormUpdateApplicationType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApplicationTitle;
        private System.Windows.Forms.TextBox txtApplicationFees;
        private System.Windows.Forms.Label lblApplicationTypeID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}