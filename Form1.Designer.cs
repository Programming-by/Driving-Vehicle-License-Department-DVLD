namespace DVLDWinForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.currentUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.btnShowAllUsers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnShowAllPeople = new System.Windows.Forms.Button();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peopleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 28);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.peopleToolStripMenuItem.Text = "People";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnShowAllUsers);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnShowAllPeople);
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 96);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(194, 76);
            // 
            // currentUserInfoToolStripMenuItem
            // 
            this.currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            this.currentUserInfoToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.currentUserInfoToolStripMenuItem.Text = "Current User Info";
            this.currentUserInfoToolStripMenuItem.Click += new System.EventHandler(this.currentUserInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.manageTestTypesToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip2";
            this.contextMenuStrip3.Size = new System.Drawing.Size(255, 80);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(254, 24);
            this.toolStripMenuItem1.Text = "Manage Application Types";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // button2
            // 
            this.button2.ContextMenuStrip = this.contextMenuStrip3;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-13, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 96);
            this.button2.TabIndex = 3;
            this.button2.Text = "Applications";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnShowAllUsers
            // 
            this.btnShowAllUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAllUsers.Image")));
            this.btnShowAllUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAllUsers.Location = new System.Drawing.Point(288, 0);
            this.btnShowAllUsers.Name = "btnShowAllUsers";
            this.btnShowAllUsers.Size = new System.Drawing.Size(164, 96);
            this.btnShowAllUsers.TabIndex = 2;
            this.btnShowAllUsers.Text = "Users";
            this.btnShowAllUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowAllUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowAllUsers.UseVisualStyleBackColor = true;
            this.btnShowAllUsers.Click += new System.EventHandler(this.btnShowAllUsers_Click);
            // 
            // button1
            // 
            this.button1.ContextMenuStrip = this.contextMenuStrip2;
            this.button1.Image = global::DVLDWinForm.Properties.Resources.account_settings;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(445, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 96);
            this.button1.TabIndex = 1;
            this.button1.Text = "Account Settings";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnShowAllPeople
            // 
            this.btnShowAllPeople.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAllPeople.Image")));
            this.btnShowAllPeople.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAllPeople.Location = new System.Drawing.Point(118, 0);
            this.btnShowAllPeople.Name = "btnShowAllPeople";
            this.btnShowAllPeople.Size = new System.Drawing.Size(164, 96);
            this.btnShowAllPeople.TabIndex = 0;
            this.btnShowAllPeople.Text = "People";
            this.btnShowAllPeople.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowAllPeople.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowAllPeople.UseVisualStyleBackColor = true;
            this.btnShowAllPeople.Click += new System.EventHandler(this.btnShowAllPeople_Click);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowAllPeople;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Button btnShowAllUsers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
    }
}

