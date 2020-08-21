using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ManagementApp
{
    public partial class ManagerMenu : Form
    {
        public ManagerMenu()
        {
            InitializeComponent();
            init();
            DisplayUsers();
            DisplayLogs();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Global.logoutTime = DateTime.Now;
            int minutes = Convert.ToInt32(Global.logoutTime.Subtract(Global.loginTime).TotalMinutes);
            new DbCon().InsertLogTimes(Global.currentUser.EMAIL, Global.loginTime, Global.logoutTime,minutes);
            Application.Exit();
        }

        private void init()
        {
            Text = "Manager Menu - " + Global.currentUser.EMAIL + " ( " + Global.currentUser.FIRSTNAME + " " + Global.currentUser.LASTNAME + " ) ";
            menuStrip1.BackColor = Color.AliceBlue;
            MaximizeBox = false;
            this.Icon = new Icon(System.IO.Path.GetFullPath("icon.ico"));
            this.BackColor = Color.White;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Global.logoutTime = DateTime.Now;
            int minutes = Convert.ToInt32(Global.logoutTime.Subtract(Global.loginTime).TotalMinutes);
            new DbCon().InsertLogTimes(Global.currentUser.EMAIL, Global.loginTime, Global.logoutTime, minutes);
            new LoginForm().ShowDialog();
        }

        private void openMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new MainMenu().ShowDialog();
        }

        public void DisplayUsers()
        {
            dataGridView1.Rows.Clear();
            using (var con = new SqlConnection(Global.conStr))
            {
                using (var cmd = new SqlCommand("SELECT * FROM users", con))
                { 

                    con.Open();

                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            if (rdr != null)
                            {
                                dataGridView1.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), 
                                                       rdr[3].ToString(), rdr[4].ToString(), Convert.ToBoolean(rdr[5]));
                            }
                        }
                    }
                }
            }
        }

        public void DisplayLogs()
        {
            dataGridView2.Rows.Clear();
            using (var con = new SqlConnection(Global.conStr))
            {
                using (var cmd = new SqlCommand("SELECT * FROM logTimes", con))
                {

                    con.Open();

                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            if (rdr != null)
                            {
                                dataGridView2.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString());
                            }
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowid = e.RowIndex;
            if(rowid != -1)
            {
                idTb.Text = dataGridView1.Rows[rowid].Cells[0].Value.ToString();
                emailTb.Text = dataGridView1.Rows[rowid].Cells[1].Value.ToString();
                fnameTb.Text = dataGridView1.Rows[rowid].Cells[2].Value.ToString();
                lnameTb.Text = dataGridView1.Rows[rowid].Cells[3].Value.ToString();
                pwTb.Text = dataGridView1.Rows[rowid].Cells[4].Value.ToString();
                checkBox1.Checked = Convert.ToBoolean(dataGridView1.Rows[rowid].Cells[5].Value);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowid = e.RowIndex;
            if (rowid != -1)
            {
                MyUser u = new DbCon().SearchUserByEmail(dataGridView2.Rows[rowid].Cells[1].Value.ToString());
                idTb.Text = u.ID;
                fnameTb.Text = u.FIRSTNAME;
                lnameTb.Text = u.LASTNAME;
                emailTb.Text = u.EMAIL;
                pwTb.Text = u.PASSWORD;
                checkBox1.Checked = u.MANAGER;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(new DbCon().CheckUniqueEmail(emailTb.Text))
            {
                new DbCon().InsertUser(fnameTb.Text,lnameTb.Text, emailTb.Text, pwTb.Text, Convert.ToBoolean(checkBox1.CheckState));
                DisplayUsers();
                ClearAllTb();
            }
            else
            {
                MessageBox.Show("Email already exists!");
                emailTb.Text = "";
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            new DbCon().UpdateUser(idTb.Text, emailTb.Text, fnameTb.Text, lnameTb.Text, pwTb.Text, Convert.ToBoolean(checkBox1.CheckState));
            DisplayUsers();
            ClearAllTb();
        }

        private void ClearAllTb()
        {
            idTb.Clear();
            emailTb.Clear();
            pwTb.Clear();
            fnameTb.Clear();
            lnameTb.Clear();
            checkBox1.Checked = false;
        }

        private void refreshTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayLogs();
            DisplayUsers();
        }

        private void srcButton_Click(object sender, EventArgs e)
        {
            MyUser u = new DbCon().SearchUserByEmail(emailTb.Text);
            idTb.Text = u.ID;
            fnameTb.Text = u.FIRSTNAME;
            lnameTb.Text = u.LASTNAME;
            emailTb.Text = u.EMAIL;
            pwTb.Text = u.PASSWORD;
            checkBox1.Checked = u.MANAGER;
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            List<MyUser> list = new DbCon().SearchUserByFirstNameOrLastName(fnameTb.Text, lnameTb.Text);

            int i = 0;
            dataGridView1.Rows.Clear();
            foreach (var u in list)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = u.ID;
                dataGridView1.Rows[i].Cells[1].Value = u.EMAIL;
                dataGridView1.Rows[i].Cells[2].Value = u.FIRSTNAME;
                dataGridView1.Rows[i].Cells[3].Value = u.LASTNAME;
                dataGridView1.Rows[i].Cells[4].Value = u.PASSWORD;
                dataGridView1.Rows[i].Cells[5].Value = u.MANAGER;
                i++;
            }
            ClearAllTb();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            new DbCon().DeleteUser(idTb.Text);
            ClearAllTb();
            DisplayUsers();
        }
    }
}
