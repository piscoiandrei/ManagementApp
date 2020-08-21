using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ManagementApp
{
    public partial class TaskForm : Form
    {
        List<MyUser> myUsers = new DbCon().GetAllUsers();

        public delegate void refreshPanels();
        public refreshPanels refreshPanelsInstance;

        public TaskForm()
        {
            InitializeComponent();
            init();
        }
      
        private void init()
        {
            MaximizeBox = false;
            this.Icon = new Icon(System.IO.Path.GetFullPath("icon.ico"));
            this.BackColor = Color.White;
            creatorTb.Text = Global.currentUser.FIRSTNAME + " " + Global.currentUser.LASTNAME;

            myUsers.Sort(delegate(MyUser x, MyUser y)
            {
                return x.EMAIL.CompareTo(y.EMAIL);
            });

            foreach(var u in myUsers)
            {
                comboBox1.Items.Add(u.EMAIL);
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "")
            {
                MessageBox.Show("The task is not appointed");
            }
            else
            {
                string id = "";
                foreach (var u in myUsers)
                {
                    if (comboBox1.Text == u.EMAIL)
                    {
                        id = u.ID;
                        break;
                    }
                }
                new DbCon().InsertTasksIntoTable("redTable",Global.currentUser.ID,id,taskTb.Text, notesTb.Text, DateTime.Now, dateTimePicker1.Value);
                
                MessageBox.Show("Task added successfully!");

                // calling delegte to refresh tasks

                if (refreshPanelsInstance != null)
                    refreshPanelsInstance();

                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var u in myUsers)
            {
                if(comboBox1.Text == u.EMAIL)
                {
                    namesTb.Text = u.FIRSTNAME + " " + u.LASTNAME;
                    break;
                }
            }
        }
    }
}
