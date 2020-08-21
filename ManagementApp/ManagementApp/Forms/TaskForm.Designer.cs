namespace ManagementApp
{
    partial class TaskForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.namesTb = new ManagementApp.CustomTextBox();
            this.customButton1 = new ManagementApp.CustomButton();
            this.notesTb = new ManagementApp.CustomTextBox();
            this.taskTb = new ManagementApp.CustomTextBox();
            this.creatorTb = new ManagementApp.CustomTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Created by:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(336, 25);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Appoint to:  (choose by email)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Task:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Notes:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 397);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 23);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pick a deadline:";
            // 
            // namesTb
            // 
            this.namesTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.namesTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namesTb.Enabled = false;
            this.namesTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.namesTb.Location = new System.Drawing.Point(12, 115);
            this.namesTb.MaxLength = 50;
            this.namesTb.Multiline = true;
            this.namesTb.Name = "namesTb";
            this.namesTb.ReadOnly = true;
            this.namesTb.Size = new System.Drawing.Size(336, 18);
            this.namesTb.TabIndex = 11;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.customButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(187)))));
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Location = new System.Drawing.Point(12, 448);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(339, 48);
            this.customButton1.TabIndex = 10;
            this.customButton1.Text = "Add";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // notesTb
            // 
            this.notesTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.notesTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notesTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.notesTb.Location = new System.Drawing.Point(12, 241);
            this.notesTb.MaxLength = 2000;
            this.notesTb.Multiline = true;
            this.notesTb.Name = "notesTb";
            this.notesTb.Size = new System.Drawing.Size(339, 120);
            this.notesTb.TabIndex = 6;
            // 
            // taskTb
            // 
            this.taskTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.taskTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.taskTb.Location = new System.Drawing.Point(12, 180);
            this.taskTb.MaxLength = 50;
            this.taskTb.Multiline = true;
            this.taskTb.Name = "taskTb";
            this.taskTb.Size = new System.Drawing.Size(339, 18);
            this.taskTb.TabIndex = 4;
            // 
            // creatorTb
            // 
            this.creatorTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.creatorTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.creatorTb.Enabled = false;
            this.creatorTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.creatorTb.Location = new System.Drawing.Point(12, 27);
            this.creatorTb.MaxLength = 50;
            this.creatorTb.Multiline = true;
            this.creatorTb.Name = "creatorTb";
            this.creatorTb.ReadOnly = true;
            this.creatorTb.Size = new System.Drawing.Size(239, 18);
            this.creatorTb.TabIndex = 0;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 507);
            this.Controls.Add(this.namesTb);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.notesTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.taskTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.creatorTb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomTextBox creatorTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private CustomTextBox taskTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomTextBox notesTb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private CustomButton customButton1;
        private CustomTextBox namesTb;
    }
}