namespace ManagementApp
{
    partial class MainMenu
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
            this.myTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myTasksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urgentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nonurgentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastDeadlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskIHaveAppointedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oldestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastDeadlineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openManagerViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.unfullfilledPanel = new System.Windows.Forms.Panel();
            this.progressPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.completedPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.redPanel1 = new ManagementApp.Custom_Controls.RedPanel();
            this.yellowPanel1 = new ManagementApp.Custom_Controls.YellowPanel();
            this.greenPanel1 = new ManagementApp.Custom_Controls.GreenPanel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.progressPanel.SuspendLayout();
            this.completedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myTasksToolStripMenuItem,
            this.allTasksToolStripMenuItem,
            this.addTaskToolStripMenuItem,
            this.openManagerViewToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.refreshToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1500, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myTasksToolStripMenuItem
            // 
            this.myTasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myTasksToolStripMenuItem1,
            this.taskIHaveAppointedToolStripMenuItem});
            this.myTasksToolStripMenuItem.Name = "myTasksToolStripMenuItem";
            this.myTasksToolStripMenuItem.Size = new System.Drawing.Size(45, 19);
            this.myTasksToolStripMenuItem.Text = "Filter";
            // 
            // myTasksToolStripMenuItem1
            // 
            this.myTasksToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByToolStripMenuItem,
            this.pastDeadlineToolStripMenuItem});
            this.myTasksToolStripMenuItem1.Name = "myTasksToolStripMenuItem1";
            this.myTasksToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.myTasksToolStripMenuItem1.Text = "My tasks";
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urgentToolStripMenuItem,
            this.nonurgentToolStripMenuItem});
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.sortByToolStripMenuItem.Text = "Sort by";
            // 
            // urgentToolStripMenuItem
            // 
            this.urgentToolStripMenuItem.Name = "urgentToolStripMenuItem";
            this.urgentToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.urgentToolStripMenuItem.Text = "Urgent";
            this.urgentToolStripMenuItem.Click += new System.EventHandler(this.urgentToolStripMenuItem_Click);
            // 
            // nonurgentToolStripMenuItem
            // 
            this.nonurgentToolStripMenuItem.Name = "nonurgentToolStripMenuItem";
            this.nonurgentToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.nonurgentToolStripMenuItem.Text = "Nonurgent";
            this.nonurgentToolStripMenuItem.Click += new System.EventHandler(this.nonurgentToolStripMenuItem_Click);
            // 
            // pastDeadlineToolStripMenuItem
            // 
            this.pastDeadlineToolStripMenuItem.Name = "pastDeadlineToolStripMenuItem";
            this.pastDeadlineToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.pastDeadlineToolStripMenuItem.Text = "Past Deadline";
            this.pastDeadlineToolStripMenuItem.Click += new System.EventHandler(this.pastDeadlineToolStripMenuItem_Click_1);
            // 
            // taskIHaveAppointedToolStripMenuItem
            // 
            this.taskIHaveAppointedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByToolStripMenuItem1,
            this.pastDeadlineToolStripMenuItem1});
            this.taskIHaveAppointedToolStripMenuItem.Name = "taskIHaveAppointedToolStripMenuItem";
            this.taskIHaveAppointedToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.taskIHaveAppointedToolStripMenuItem.Text = "Task I have appointed";
            // 
            // sortByToolStripMenuItem1
            // 
            this.sortByToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oldestToolStripMenuItem,
            this.newestToolStripMenuItem});
            this.sortByToolStripMenuItem1.Name = "sortByToolStripMenuItem1";
            this.sortByToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.sortByToolStripMenuItem1.Text = "Sort by appointment date";
            // 
            // oldestToolStripMenuItem
            // 
            this.oldestToolStripMenuItem.Name = "oldestToolStripMenuItem";
            this.oldestToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.oldestToolStripMenuItem.Text = "Oldest";
            this.oldestToolStripMenuItem.Click += new System.EventHandler(this.oldestToolStripMenuItem_Click_1);
            // 
            // newestToolStripMenuItem
            // 
            this.newestToolStripMenuItem.Name = "newestToolStripMenuItem";
            this.newestToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.newestToolStripMenuItem.Text = "Newest";
            this.newestToolStripMenuItem.Click += new System.EventHandler(this.newestToolStripMenuItem_Click_1);
            // 
            // pastDeadlineToolStripMenuItem1
            // 
            this.pastDeadlineToolStripMenuItem1.Name = "pastDeadlineToolStripMenuItem1";
            this.pastDeadlineToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.pastDeadlineToolStripMenuItem1.Text = "Past Deadline";
            this.pastDeadlineToolStripMenuItem1.Click += new System.EventHandler(this.pastDeadlineToolStripMenuItem1_Click);
            // 
            // allTasksToolStripMenuItem
            // 
            this.allTasksToolStripMenuItem.Name = "allTasksToolStripMenuItem";
            this.allTasksToolStripMenuItem.Size = new System.Drawing.Size(101, 19);
            this.allTasksToolStripMenuItem.Text = "Display all tasks";
            this.allTasksToolStripMenuItem.Click += new System.EventHandler(this.allTasksToolStripMenuItem_Click);
            // 
            // addTaskToolStripMenuItem
            // 
            this.addTaskToolStripMenuItem.Name = "addTaskToolStripMenuItem";
            this.addTaskToolStripMenuItem.Size = new System.Drawing.Size(66, 19);
            this.addTaskToolStripMenuItem.Text = "Add Task";
            this.addTaskToolStripMenuItem.Click += new System.EventHandler(this.addTaskToolStripMenuItem_Click);
            // 
            // openManagerViewToolStripMenuItem
            // 
            this.openManagerViewToolStripMenuItem.Name = "openManagerViewToolStripMenuItem";
            this.openManagerViewToolStripMenuItem.Size = new System.Drawing.Size(126, 19);
            this.openManagerViewToolStripMenuItem.Text = "Open Manager View";
            this.openManagerViewToolStripMenuItem.Click += new System.EventHandler(this.openManagerViewToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 19);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(58, 19);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.refreshToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 35);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.Location = new System.Drawing.Point(1186, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Completed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(688, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "In Progress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(186, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unfullfilled";
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.PaleGreen;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(1000, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(500, 35);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.MistyRose;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(500, 35);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // unfullfilledPanel
            // 
            this.unfullfilledPanel.BackColor = System.Drawing.Color.White;
            this.unfullfilledPanel.Location = new System.Drawing.Point(0, 60);
            this.unfullfilledPanel.Name = "unfullfilledPanel";
            this.unfullfilledPanel.Size = new System.Drawing.Size(500, 731);
            this.unfullfilledPanel.TabIndex = 2;
            // 
            // progressPanel
            // 
            this.progressPanel.BackColor = System.Drawing.Color.White;
            this.progressPanel.Controls.Add(this.panel4);
            this.progressPanel.Location = new System.Drawing.Point(500, 60);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(500, 731);
            this.progressPanel.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(501, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 114);
            this.panel4.TabIndex = 4;
            // 
            // completedPanel
            // 
            this.completedPanel.BackColor = System.Drawing.Color.White;
            this.completedPanel.Controls.Add(this.panel6);
            this.completedPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.completedPanel.Location = new System.Drawing.Point(1000, 60);
            this.completedPanel.Name = "completedPanel";
            this.completedPanel.Size = new System.Drawing.Size(500, 731);
            this.completedPanel.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(501, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(500, 114);
            this.panel6.TabIndex = 4;
            // 
            // redPanel1
            // 
            this.redPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            this.redPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.redPanel1.Location = new System.Drawing.Point(0, 0);
            this.redPanel1.Name = "redPanel1";
            this.redPanel1.Size = new System.Drawing.Size(455, 220);
            this.redPanel1.TabIndex = 0;
            // 
            // yellowPanel1
            // 
            this.yellowPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.yellowPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yellowPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.yellowPanel1.Location = new System.Drawing.Point(0, 0);
            this.yellowPanel1.Name = "yellowPanel1";
            this.yellowPanel1.Size = new System.Drawing.Size(455, 220);
            this.yellowPanel1.TabIndex = 0;
            // 
            // greenPanel1
            // 
            this.greenPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.greenPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greenPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.greenPanel1.Location = new System.Drawing.Point(0, 0);
            this.greenPanel1.Name = "greenPanel1";
            this.greenPanel1.Size = new System.Drawing.Size(455, 220);
            this.greenPanel1.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 791);
            this.Controls.Add(this.progressPanel);
            this.Controls.Add(this.completedPanel);
            this.Controls.Add(this.unfullfilledPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu - insert_email_here";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.progressPanel.ResumeLayout(false);
            this.completedPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem allTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openManagerViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel unfullfilledPanel;
        private System.Windows.Forms.Panel progressPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel completedPanel;
        private System.Windows.Forms.Panel panel6;
        private Custom_Controls.RedPanel redPanel1;
        private Custom_Controls.YellowPanel yellowPanel1;
        private Custom_Controls.GreenPanel greenPanel1;
        private System.Windows.Forms.ToolStripMenuItem myTasksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urgentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nonurgentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastDeadlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskIHaveAppointedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oldestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastDeadlineToolStripMenuItem1;
    }
}

