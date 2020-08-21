namespace ManagementApp
{
    partial class RegisterForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.regButton = new ManagementApp.CustomButton();
            this.customButton2 = new ManagementApp.CustomButton();
            this.emailTb = new ManagementApp.CustomTextBox();
            this.pwTb = new ManagementApp.CustomTextBox();
            this.cpwTb = new ManagementApp.CustomTextBox();
            this.fnameTb = new ManagementApp.CustomTextBox();
            this.lnameTb = new ManagementApp.CustomTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Confirm Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "First name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Last name:";
            // 
            // regButton
            // 
            this.regButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.regButton.FlatAppearance.BorderSize = 0;
            this.regButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.regButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(187)))));
            this.regButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.regButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regButton.Location = new System.Drawing.Point(12, 204);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(407, 38);
            this.regButton.TabIndex = 16;
            this.regButton.Text = "Register";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(241)))));
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.customButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(187)))));
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Location = new System.Drawing.Point(12, 255);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(407, 25);
            this.customButton2.TabIndex = 17;
            this.customButton2.Text = "Back to Login";
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // emailTb
            // 
            this.emailTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.emailTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.emailTb.Location = new System.Drawing.Point(15, 76);
            this.emailTb.MaxLength = 50;
            this.emailTb.Multiline = true;
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(404, 18);
            this.emailTb.TabIndex = 18;
            // 
            // pwTb
            // 
            this.pwTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.pwTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.pwTb.Location = new System.Drawing.Point(15, 122);
            this.pwTb.MaxLength = 50;
            this.pwTb.Multiline = true;
            this.pwTb.Name = "pwTb";
            this.pwTb.PasswordChar = '*';
            this.pwTb.Size = new System.Drawing.Size(404, 18);
            this.pwTb.TabIndex = 19;
            // 
            // cpwTb
            // 
            this.cpwTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.cpwTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cpwTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cpwTb.Location = new System.Drawing.Point(15, 166);
            this.cpwTb.MaxLength = 50;
            this.cpwTb.Multiline = true;
            this.cpwTb.Name = "cpwTb";
            this.cpwTb.PasswordChar = '*';
            this.cpwTb.Size = new System.Drawing.Size(404, 18);
            this.cpwTb.TabIndex = 20;
            // 
            // fnameTb
            // 
            this.fnameTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.fnameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.fnameTb.Location = new System.Drawing.Point(15, 29);
            this.fnameTb.MaxLength = 50;
            this.fnameTb.Multiline = true;
            this.fnameTb.Name = "fnameTb";
            this.fnameTb.Size = new System.Drawing.Size(192, 18);
            this.fnameTb.TabIndex = 21;
            // 
            // lnameTb
            // 
            this.lnameTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.lnameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lnameTb.Location = new System.Drawing.Point(227, 29);
            this.lnameTb.MaxLength = 50;
            this.lnameTb.Multiline = true;
            this.lnameTb.Name = "lnameTb";
            this.lnameTb.Size = new System.Drawing.Size(192, 18);
            this.lnameTb.TabIndex = 22;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 284);
            this.Controls.Add(this.lnameTb);
            this.Controls.Add(this.fnameTb);
            this.Controls.Add(this.cpwTb);
            this.Controls.Add(this.pwTb);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private CustomButton regButton;
        private CustomButton customButton2;
        private CustomTextBox emailTb;
        private CustomTextBox pwTb;
        private CustomTextBox cpwTb;
        private CustomTextBox fnameTb;
        private CustomTextBox lnameTb;
    }
}