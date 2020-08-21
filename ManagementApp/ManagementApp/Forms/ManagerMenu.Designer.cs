namespace ManagementApp
{
    partial class ManagerMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customButton1 = new ManagementApp.CustomButton();
            this.delButton = new ManagementApp.CustomButton();
            this.srcButton = new ManagementApp.CustomButton();
            this.idTb = new ManagementApp.CustomTextBox();
            this.updateButton = new ManagementApp.CustomButton();
            this.pwTb = new ManagementApp.CustomTextBox();
            this.lnameTb = new ManagementApp.CustomTextBox();
            this.fnameTb = new ManagementApp.CustomTextBox();
            this.addButton = new ManagementApp.CustomButton();
            this.emailTb = new ManagementApp.CustomTextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mng = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSpent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMainMenuToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.refreshTablesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1277, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openMainMenuToolStripMenuItem
            // 
            this.openMainMenuToolStripMenuItem.Name = "openMainMenuToolStripMenuItem";
            this.openMainMenuToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.openMainMenuToolStripMenuItem.Text = "Open Main Menu";
            this.openMainMenuToolStripMenuItem.Click += new System.EventHandler(this.openMainMenuToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // refreshTablesToolStripMenuItem
            // 
            this.refreshTablesToolStripMenuItem.Name = "refreshTablesToolStripMenuItem";
            this.refreshTablesToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.refreshTablesToolStripMenuItem.Text = "Refresh Tables";
            this.refreshTablesToolStripMenuItem.Click += new System.EventHandler(this.refreshTablesToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Email,
            this.fname,
            this.lname,
            this.pw,
            this.mng});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(852, 635);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LogID,
            this.emailLog,
            this.loginTime,
            this.logoutTime,
            this.timeSpent});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(852, 635);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(866, 671);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(858, 641);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users table";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(858, 641);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(867, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(867, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1072, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(868, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Password";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1182, 325);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 21);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "Manager";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(869, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "ID";
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.customButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(187)))));
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Location = new System.Drawing.Point(867, 541);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(404, 45);
            this.customButton1.TabIndex = 34;
            this.customButton1.Text = "Search by First or Last name";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.delButton.FlatAppearance.BorderSize = 0;
            this.delButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.delButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(187)))));
            this.delButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delButton.Location = new System.Drawing.Point(868, 615);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(403, 45);
            this.delButton.TabIndex = 33;
            this.delButton.Text = "Delete displayed User";
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // srcButton
            // 
            this.srcButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.srcButton.FlatAppearance.BorderSize = 0;
            this.srcButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.srcButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(187)))));
            this.srcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srcButton.Location = new System.Drawing.Point(868, 462);
            this.srcButton.Name = "srcButton";
            this.srcButton.Size = new System.Drawing.Size(404, 45);
            this.srcButton.TabIndex = 32;
            this.srcButton.Text = "Search by Email";
            this.srcButton.UseVisualStyleBackColor = false;
            this.srcButton.Click += new System.EventHandler(this.srcButton_Click);
            // 
            // idTb
            // 
            this.idTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.idTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTb.Enabled = false;
            this.idTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.idTb.Location = new System.Drawing.Point(868, 73);
            this.idTb.MaxLength = 50;
            this.idTb.Multiline = true;
            this.idTb.Name = "idTb";
            this.idTb.ReadOnly = true;
            this.idTb.Size = new System.Drawing.Size(404, 18);
            this.idTb.TabIndex = 30;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.updateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(187)))));
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Location = new System.Drawing.Point(868, 380);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(193, 48);
            this.updateButton.TabIndex = 28;
            this.updateButton.Text = "Update user";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // pwTb
            // 
            this.pwTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.pwTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.pwTb.Location = new System.Drawing.Point(868, 301);
            this.pwTb.MaxLength = 50;
            this.pwTb.Multiline = true;
            this.pwTb.Name = "pwTb";
            this.pwTb.Size = new System.Drawing.Size(404, 18);
            this.pwTb.TabIndex = 26;
            // 
            // lnameTb
            // 
            this.lnameTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.lnameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lnameTb.Location = new System.Drawing.Point(1075, 150);
            this.lnameTb.MaxLength = 50;
            this.lnameTb.Multiline = true;
            this.lnameTb.Name = "lnameTb";
            this.lnameTb.Size = new System.Drawing.Size(196, 18);
            this.lnameTb.TabIndex = 23;
            // 
            // fnameTb
            // 
            this.fnameTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.fnameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.fnameTb.Location = new System.Drawing.Point(867, 150);
            this.fnameTb.MaxLength = 50;
            this.fnameTb.Multiline = true;
            this.fnameTb.Name = "fnameTb";
            this.fnameTb.Size = new System.Drawing.Size(196, 18);
            this.fnameTb.TabIndex = 22;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(187)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(1083, 380);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(189, 48);
            this.addButton.TabIndex = 20;
            this.addButton.Text = "Add new user";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // emailTb
            // 
            this.emailTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.emailTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.emailTb.Location = new System.Drawing.Point(867, 224);
            this.emailTb.MaxLength = 50;
            this.emailTb.Multiline = true;
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(404, 18);
            this.emailTb.TabIndex = 19;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.HeaderText = "User ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // fname
            // 
            this.fname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.fname.HeaderText = "First Name";
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            this.fname.Width = 5;
            // 
            // lname
            // 
            this.lname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.lname.HeaderText = "Last Name";
            this.lname.Name = "lname";
            this.lname.ReadOnly = true;
            this.lname.Width = 5;
            // 
            // pw
            // 
            this.pw.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.pw.HeaderText = "Password";
            this.pw.Name = "pw";
            this.pw.ReadOnly = true;
            this.pw.Width = 5;
            // 
            // mng
            // 
            this.mng.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.mng.HeaderText = "Manager";
            this.mng.Name = "mng";
            this.mng.ReadOnly = true;
            this.mng.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mng.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.mng.Width = 89;
            // 
            // LogID
            // 
            this.LogID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LogID.HeaderText = "ID";
            this.LogID.Name = "LogID";
            this.LogID.ReadOnly = true;
            this.LogID.Width = 46;
            // 
            // emailLog
            // 
            this.emailLog.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailLog.HeaderText = "Email";
            this.emailLog.Name = "emailLog";
            this.emailLog.ReadOnly = true;
            // 
            // loginTime
            // 
            this.loginTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.loginTime.HeaderText = "Login Time";
            this.loginTime.Name = "loginTime";
            this.loginTime.ReadOnly = true;
            this.loginTime.Width = 5;
            // 
            // logoutTime
            // 
            this.logoutTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.logoutTime.HeaderText = "Logout Time";
            this.logoutTime.Name = "logoutTime";
            this.logoutTime.ReadOnly = true;
            this.logoutTime.Width = 5;
            // 
            // timeSpent
            // 
            this.timeSpent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.timeSpent.HeaderText = "Time spent (minutes)";
            this.timeSpent.Name = "timeSpent";
            this.timeSpent.ReadOnly = true;
            this.timeSpent.Width = 151;
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1277, 695);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.srcButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idTb);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pwTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnameTb);
            this.Controls.Add(this.fnameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openMainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private CustomTextBox emailTb;
        private CustomButton addButton;
        private System.Windows.Forms.Label label1;
        private CustomTextBox fnameTb;
        private CustomTextBox lnameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomTextBox pwTb;
        private CustomButton updateButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private CustomTextBox idTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem refreshTablesToolStripMenuItem;
        private CustomButton srcButton;
        private CustomButton delButton;
        private CustomButton customButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn pw;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mng;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn logoutTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSpent;
    }
}