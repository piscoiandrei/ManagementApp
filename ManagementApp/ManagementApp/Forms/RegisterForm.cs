using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ManagementApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            init();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Application.Exit();
        }
        private void init()
        {
            MaximizeBox = false;
            this.Icon = new Icon(System.IO.Path.GetFullPath("icon.ico"));
            this.BackColor = Color.White;
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            Hide();
            new LoginForm().ShowDialog();
        }

        private void regButton_Click(object sender, EventArgs e)
        {

            if (emailTb.Text.Contains("@") == false || emailTb.Text.Contains(".") == false)
            {
                MessageBox.Show("Please enter a valid email.");
                emailTb.Text = "";
            }
            else
            {
                if (cpwTb.Text != pwTb.Text)
                {
                    MessageBox.Show("Your passwords do not match.");
                    cpwTb.Text = pwTb.Text = "";
                }
                else
                {
                    if (new DbCon().CheckUniqueEmail(emailTb.Text) == false)
                    {
                        MessageBox.Show("Email already exists");
                        emailTb.Text = "";
                    }
                    else
                    {
                        new DbCon().InsertUser(fnameTb.Text, lnameTb.Text, emailTb.Text, pwTb.Text, false);
                        MessageBox.Show("Account created successfully, you will be redirected to log in.");
                        Hide();
                        new LoginForm().ShowDialog();
                    }
                }
            }
        }
    }
}
