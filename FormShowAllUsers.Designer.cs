namespace DVLDWinForm
{
    partial class FormShowAllUsers
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
            this.txtFilter1 = new System.Windows.Forms.MaskedTextBox();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPeopleCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sendPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAllPeople = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsersCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbActiveOrNot = new System.Windows.Forms.ComboBox();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilter1
            // 
            this.txtFilter1.Location = new System.Drawing.Point(247, 109);
            this.txtFilter1.Name = "txtFilter1";
            this.txtFilter1.Size = new System.Drawing.Size(149, 22);
            this.txtFilter1.TabIndex = 36;
            this.txtFilter1.Visible = false;
            this.txtFilter1.TextChanged += new System.EventHandler(this.txtFilter1_TextChanged);
            // 
            // cbFilters
            // 
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "None",
            "User ID",
            "UserName",
            "Person ID",
            "Full Name",
            "Is Active"});
            this.cbFilters.Location = new System.Drawing.Point(39, 107);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(168, 24);
            this.cbFilters.TabIndex = 35;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-172, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "Filter By:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1065, 465);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 47);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPeopleCount
            // 
            this.lblPeopleCount.AutoSize = true;
            this.lblPeopleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleCount.Location = new System.Drawing.Point(-60, 453);
            this.lblPeopleCount.Name = "lblPeopleCount";
            this.lblPeopleCount.Size = new System.Drawing.Size(23, 25);
            this.lblPeopleCount.TabIndex = 32;
            this.lblPeopleCount.Text = "#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-177, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "# Records: ";
            // 
            // sendPhoneToolStripMenuItem
            // 
            this.sendPhoneToolStripMenuItem.Name = "sendPhoneToolStripMenuItem";
            this.sendPhoneToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.sendPhoneToolStripMenuItem.Text = "Phone Call";
            this.sendPhoneToolStripMenuItem.Click += new System.EventHandler(this.sendPhoneToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.addNewPersonToolStripMenuItem.Text = "Add New User";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.sendEmailToolStripMenuItem,
            this.sendPhoneToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 200);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // dgvAllPeople
            // 
            this.dgvAllPeople.AllowUserToAddRows = false;
            this.dgvAllPeople.AllowUserToDeleteRows = false;
            this.dgvAllPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPeople.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllPeople.Location = new System.Drawing.Point(39, 151);
            this.dgvAllPeople.Name = "dgvAllPeople";
            this.dgvAllPeople.ReadOnly = true;
            this.dgvAllPeople.RowHeadersWidth = 51;
            this.dgvAllPeople.RowTemplate.Height = 24;
            this.dgvAllPeople.Size = new System.Drawing.Size(1146, 295);
            this.dgvAllPeople.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(554, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Manage Users";
            // 
            // lblUsersCount
            // 
            this.lblUsersCount.AutoSize = true;
            this.lblUsersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersCount.Location = new System.Drawing.Point(151, 550);
            this.lblUsersCount.Name = "lblUsersCount";
            this.lblUsersCount.Size = new System.Drawing.Size(23, 25);
            this.lblUsersCount.TabIndex = 38;
            this.lblUsersCount.Text = "#";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 550);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "# Records: ";
            // 
            // cbActiveOrNot
            // 
            this.cbActiveOrNot.FormattingEnabled = true;
            this.cbActiveOrNot.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbActiveOrNot.Location = new System.Drawing.Point(247, 109);
            this.cbActiveOrNot.Name = "cbActiveOrNot";
            this.cbActiveOrNot.Size = new System.Drawing.Size(168, 24);
            this.cbActiveOrNot.TabIndex = 39;
            this.cbActiveOrNot.Visible = false;
            this.cbActiveOrNot.SelectedIndexChanged += new System.EventHandler(this.cbActiveOrNot_SelectedIndexChanged);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Image = global::DVLDWinForm.Properties.Resources.Add_New_User_721;
            this.btnAddNewUser.Location = new System.Drawing.Point(1074, 58);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(111, 73);
            this.btnAddNewUser.TabIndex = 30;
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLDWinForm.Properties.Resources.Users_2_400;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(543, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 101);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // FormShowAllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 584);
            this.Controls.Add(this.cbActiveOrNot);
            this.Controls.Add(this.lblUsersCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFilter1);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPeopleCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvAllPeople);
            this.Controls.Add(this.label1);
            this.Name = "FormShowAllUsers";
            this.Text = "FormShowAllUsers";
            this.Load += new System.EventHandler(this.FormShowAllUsers_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtFilter1;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPeopleCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem sendPhoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvAllPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsersCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbActiveOrNot;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}