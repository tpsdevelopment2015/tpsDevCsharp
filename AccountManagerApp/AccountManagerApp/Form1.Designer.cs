namespace AccountManagerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acctNameLbl = new System.Windows.Forms.Label();
            this.acctNameListBox = new System.Windows.Forms.ListBox();
            this.addAcctBtn = new System.Windows.Forms.Button();
            this.deleteAcctBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.acctInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.notesGroupBox = new System.Windows.Forms.GroupBox();
            this.notesTxtBox = new System.Windows.Forms.RichTextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.userNameTxtBox = new System.Windows.Forms.TextBox();
            this.acctNumberTxtBox = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.acctNoLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.acctInfoGroupBox.SuspendLayout();
            this.notesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAccountToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.addAccountToolStripMenuItem.Text = "Add Account";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.printToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyAccountToolStripMenuItem,
            this.deleteAccountToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // modifyAccountToolStripMenuItem
            // 
            this.modifyAccountToolStripMenuItem.Name = "modifyAccountToolStripMenuItem";
            this.modifyAccountToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.modifyAccountToolStripMenuItem.Text = "Edit Account Info";
            this.modifyAccountToolStripMenuItem.Click += new System.EventHandler(this.modifyAccountToolStripMenuItem_Click);
            // 
            // deleteAccountToolStripMenuItem
            // 
            this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.deleteAccountToolStripMenuItem.Text = "Delete Account";
            this.deleteAccountToolStripMenuItem.ToolTipText = "Permanently Delete Account";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About ";
            // 
            // acctNameLbl
            // 
            this.acctNameLbl.AutoSize = true;
            this.acctNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctNameLbl.Location = new System.Drawing.Point(12, 91);
            this.acctNameLbl.Name = "acctNameLbl";
            this.acctNameLbl.Size = new System.Drawing.Size(112, 17);
            this.acctNameLbl.TabIndex = 1;
            this.acctNameLbl.Text = "Account Name";
            this.acctNameLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // acctNameListBox
            // 
            this.acctNameListBox.AllowDrop = true;
            this.acctNameListBox.FormattingEnabled = true;
            this.acctNameListBox.ItemHeight = 16;
            this.acctNameListBox.Location = new System.Drawing.Point(130, 88);
            this.acctNameListBox.Name = "acctNameListBox";
            this.acctNameListBox.Size = new System.Drawing.Size(223, 20);
            this.acctNameListBox.TabIndex = 2;
            // 
            // addAcctBtn
            // 
            this.addAcctBtn.BackColor = System.Drawing.Color.Yellow;
            this.addAcctBtn.Location = new System.Drawing.Point(12, 45);
            this.addAcctBtn.Name = "addAcctBtn";
            this.addAcctBtn.Size = new System.Drawing.Size(76, 23);
            this.addAcctBtn.TabIndex = 3;
            this.addAcctBtn.Text = "Add Icon";
            this.addAcctBtn.UseVisualStyleBackColor = false;
            // 
            // deleteAcctBtn
            // 
            this.deleteAcctBtn.BackColor = System.Drawing.Color.Red;
            this.deleteAcctBtn.Location = new System.Drawing.Point(645, 45);
            this.deleteAcctBtn.Name = "deleteAcctBtn";
            this.deleteAcctBtn.Size = new System.Drawing.Size(108, 23);
            this.deleteAcctBtn.TabIndex = 4;
            this.deleteAcctBtn.Text = "Delete Acct";
            this.deleteAcctBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.editBtn.Location = new System.Drawing.Point(94, 45);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "Edit Acct";
            this.editBtn.UseVisualStyleBackColor = false;
            // 
            // acctInfoGroupBox
            // 
            this.acctInfoGroupBox.Controls.Add(this.notesGroupBox);
            this.acctInfoGroupBox.Controls.Add(this.passwordTxtBox);
            this.acctInfoGroupBox.Controls.Add(this.userNameTxtBox);
            this.acctInfoGroupBox.Controls.Add(this.acctNumberTxtBox);
            this.acctInfoGroupBox.Controls.Add(this.passwordLbl);
            this.acctInfoGroupBox.Controls.Add(this.userNameLbl);
            this.acctInfoGroupBox.Controls.Add(this.acctNoLbl);
            this.acctInfoGroupBox.Location = new System.Drawing.Point(15, 128);
            this.acctInfoGroupBox.Name = "acctInfoGroupBox";
            this.acctInfoGroupBox.Size = new System.Drawing.Size(738, 485);
            this.acctInfoGroupBox.TabIndex = 6;
            this.acctInfoGroupBox.TabStop = false;
            this.acctInfoGroupBox.Text = "Account Information";
            // 
            // notesGroupBox
            // 
            this.notesGroupBox.Controls.Add(this.notesTxtBox);
            this.notesGroupBox.Location = new System.Drawing.Point(9, 110);
            this.notesGroupBox.Name = "notesGroupBox";
            this.notesGroupBox.Size = new System.Drawing.Size(712, 357);
            this.notesGroupBox.TabIndex = 6;
            this.notesGroupBox.TabStop = false;
            this.notesGroupBox.Text = "Notes";
            // 
            // notesTxtBox
            // 
            this.notesTxtBox.Location = new System.Drawing.Point(13, 21);
            this.notesTxtBox.Name = "notesTxtBox";
            this.notesTxtBox.Size = new System.Drawing.Size(699, 329);
            this.notesTxtBox.TabIndex = 0;
            this.notesTxtBox.Text = "";
            this.notesTxtBox.TextChanged += new System.EventHandler(this.notesTxtBox_TextChanged);
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(352, 73);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(127, 22);
            this.passwordTxtBox.TabIndex = 5;
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.Location = new System.Drawing.Point(122, 73);
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.Size = new System.Drawing.Size(136, 22);
            this.userNameTxtBox.TabIndex = 4;
            // 
            // acctNumberTxtBox
            // 
            this.acctNumberTxtBox.Location = new System.Drawing.Point(122, 32);
            this.acctNumberTxtBox.Name = "acctNumberTxtBox";
            this.acctNumberTxtBox.Size = new System.Drawing.Size(357, 22);
            this.acctNumberTxtBox.TabIndex = 3;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(264, 76);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(82, 17);
            this.passwordLbl.TabIndex = 2;
            this.passwordLbl.Text = "Password:";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.Location = new System.Drawing.Point(23, 76);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(93, 17);
            this.userNameLbl.TabIndex = 1;
            this.userNameLbl.Text = "User Name:";
            // 
            // acctNoLbl
            // 
            this.acctNoLbl.AutoSize = true;
            this.acctNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctNoLbl.Location = new System.Drawing.Point(6, 37);
            this.acctNoLbl.Name = "acctNoLbl";
            this.acctNoLbl.Size = new System.Drawing.Size(110, 17);
            this.acctNoLbl.TabIndex = 0;
            this.acctNoLbl.Text = "Acct. Number:";
            this.acctNoLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Lime;
            this.saveBtn.Location = new System.Drawing.Point(175, 45);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 625);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.acctInfoGroupBox);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteAcctBtn);
            this.Controls.Add(this.addAcctBtn);
            this.Controls.Add(this.acctNameListBox);
            this.Controls.Add(this.acctNameLbl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Account Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.acctInfoGroupBox.ResumeLayout(false);
            this.acctInfoGroupBox.PerformLayout();
            this.notesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label acctNameLbl;
        private System.Windows.Forms.ListBox acctNameListBox;
        private System.Windows.Forms.Button addAcctBtn;
        private System.Windows.Forms.Button deleteAcctBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.GroupBox acctInfoGroupBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.TextBox userNameTxtBox;
        private System.Windows.Forms.TextBox acctNumberTxtBox;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label acctNoLbl;
        private System.Windows.Forms.GroupBox notesGroupBox;
        private System.Windows.Forms.RichTextBox notesTxtBox;
    }
}

