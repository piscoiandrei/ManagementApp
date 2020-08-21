using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ManagementApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
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

        private void regButton_Click(object sender, EventArgs e)
        {
            Hide();
            new RegisterForm().ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTb.Text, pw = pwTb.Text;
            if (email.Contains("@") == false || email.Contains(".") == false)
            {
                MessageBox.Show("Invalid email");
                clearText();
            }
            else
            {
                bool ok = new DbCon().Login(email,pw);
                if(ok == true)
                {
                    Global.loginTime = DateTime.Now;
                    Hide();
                    new MainMenu().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login Process Failed");
                    clearText();
                }
            }
        }

        void clearText()
        {
            emailTb.Text = pwTb.Text = "";
        }

    }
}
