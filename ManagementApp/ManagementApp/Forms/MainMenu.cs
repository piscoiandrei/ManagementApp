using ManagementApp.Custom_Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ManagementApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            init();
            REFRESH();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Global.logoutTime = DateTime.Now;
            int minutes = Convert.ToInt32(Global.logoutTime.Subtract(Global.loginTime).TotalMinutes);
            new DbCon().InsertLogTimes(Global.currentUser.EMAIL, Global.loginTime, Global.logoutTime, minutes);
            Application.Exit();
        }

        private void init()
        {
            Text = "Main Menu - " + Global.currentUser.EMAIL + " ( " + Global.currentUser.FIRSTNAME + " " + Global.currentUser.LASTNAME + " ) ";
            MaximizeBox = false;
            this.Icon = new Icon(System.IO.Path.GetFullPath("icon.ico"));
            menuStrip1.BackColor = Color.AliceBlue;
            this.BackColor = Color.White;

        }

        private void openManagerViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.currentUser.MANAGER == true)
            {
                Hide();
                new ManagerMenu().ShowDialog();
            }
            else
            {
                MessageBox.Show("You don't have permission to access this form", "Access Denied");
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Global.logoutTime = DateTime.Now;
            int minutes = Convert.ToInt32(Global.logoutTime.Subtract(Global.loginTime).TotalMinutes);
            new DbCon().InsertLogTimes(Global.currentUser.EMAIL, Global.loginTime, Global.logoutTime, minutes);
            new LoginForm().ShowDialog();
        }

        private void addTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.currentUser.MANAGER == true)
            {
                var t = new TaskForm();
                t.refreshPanelsInstance += SimpleRefreshRed;
                t.ShowDialog();
            }
            else
            {
                MessageBox.Show("You don't have permission to access this form","Access Denied");
            }
        }
        public void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            REFRESH();
        }

        private void allTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REFRESH();
        }

        // REFRESH panels function
        public void REFRESH()  // deletes and populates into panels all the tasks
        {
         
            RefreshRedPanels("SELECT * FROM redTable");
            RefreshYellowPanels("SELECT * FROM yellowTable");
            RefreshGreenPanels("SELECT * FROM greenTable");

        }
        //ALL PANELS

        public void RefreshRedPanels(string commandString)
        {
            unfullfilledPanel.AutoScroll = true;
            unfullfilledPanel.HorizontalScroll.Enabled = false;

            unfullfilledPanel.Controls.Clear();


            using (var con = new SqlConnection(Global.conStr))
            {
                using (var cmd = new SqlCommand(commandString,con))
                {

                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        int y = 6;

                        while(reader.Read())
                        {
                            if (reader != null)
                            {
                                var PANEL = new RedPanel();

                                PANEL.ID = reader[0].ToString();
                                MyUser creator = new DbCon().SearchUserByID(reader[1].ToString());
                                MyUser appointedTo = new DbCon().SearchUserByID(reader[2].ToString());

                                PANEL.creatorID = creator.ID;
                                PANEL.appointedToID = appointedTo.ID;

                                PANEL.createdTb.Text = creator.FIRSTNAME + " " + creator.LASTNAME;
                                PANEL.appointedtoTb.Text = appointedTo.FIRSTNAME + " " + appointedTo.LASTNAME;

                                PANEL.taskTb.Text = reader[3].ToString();
                                PANEL.notesTb.Text = reader[4].ToString();
                                PANEL.dateTb.Text = Convert.ToDateTime(reader[5]).ToShortDateString();
                                PANEL.deadlineTb.Text = Convert.ToDateTime(reader[6]).ToShortDateString();

                                PANEL.Location = new Point(6, y);
                                y += 230;

                                PANEL.refreshPanelInstance += SimpleRefreshRed;

                                PANEL.affectedPanels += SimpleRefreshRed;
                                PANEL.affectedPanels += SimpleRefreshYellow;

                                unfullfilledPanel.Controls.Add(PANEL);
                            }
                        }
                    }

                }
            }
        }

        public void RefreshYellowPanels(string commandString)
        {
            progressPanel.AutoScroll = true;
            progressPanel.HorizontalScroll.Enabled = false;

            progressPanel.Controls.Clear();

            using (var con = new SqlConnection(Global.conStr))
            {
                using (var cmd = new SqlCommand(commandString, con))
                {

                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        int y = 6;

                        while (reader.Read())
                        {
                            if (reader != null)
                            {
                                var PANEL = new YellowPanel();

                                PANEL.ID = reader[0].ToString();
                                MyUser creator = new DbCon().SearchUserByID(reader[1].ToString());
                                MyUser appointedTo = new DbCon().SearchUserByID(reader[2].ToString());

                                PANEL.creatorID = creator.ID;
                                PANEL.appointedToID = appointedTo.ID;

                                PANEL.createdTb.Text = creator.FIRSTNAME + " " + creator.LASTNAME;
                                PANEL.appointedtoTb.Text = appointedTo.FIRSTNAME + " " + appointedTo.LASTNAME;

                                PANEL.taskTb.Text = reader[3].ToString();
                                PANEL.notesTb.Text = reader[4].ToString();
                                PANEL.dateTb.Text = Convert.ToDateTime(reader[5]).ToShortDateString();
                                PANEL.deadlineTb.Text = Convert.ToDateTime(reader[6]).ToShortDateString();

                                PANEL.Location = new Point(6, y);
                                y += 230;

                                PANEL.refreshPanelInstance += SimpleRefreshYellow;

                                PANEL.affectedPanels += SimpleRefreshYellow;
                                PANEL.affectedPanels += SimpleRefreshGreen;

                                progressPanel.Controls.Add(PANEL);
                            }
                        }
                    }

                }
            }
        }

        public void RefreshGreenPanels(string commandString)
        {
            completedPanel.AutoScroll = true;
            completedPanel.HorizontalScroll.Enabled = false;

            completedPanel.Controls.Clear();

            using (var con = new SqlConnection(Global.conStr))
            {
                using (var cmd = new SqlCommand(commandString, con))
                {

                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        int y = 6;

                        while (reader.Read())
                        {
                            if (reader != null)
                            {
                                var PANEL = new GreenPanel();

                                PANEL.ID = reader[0].ToString();
                                MyUser creator = new DbCon().SearchUserByID(reader[1].ToString());
                                MyUser appointedTo = new DbCon().SearchUserByID(reader[2].ToString());

                                PANEL.creatorID = creator.ID;
                                PANEL.appointedToID = appointedTo.ID;

                                PANEL.createdTb.Text = creator.FIRSTNAME + " " + creator.LASTNAME;
                                PANEL.appointedtoTb.Text = appointedTo.FIRSTNAME + " " + appointedTo.LASTNAME;

                                PANEL.taskTb.Text = reader[3].ToString();
                                PANEL.notesTb.Text = reader[4].ToString();
                                PANEL.dateTb.Text = Convert.ToDateTime(reader[5]).ToShortDateString();
                                PANEL.deadlineTb.Text = Convert.ToDateTime(reader[6]).ToShortDateString();

                                PANEL.Location = new Point(6, y);
                                y += 230;

                                PANEL.refreshPanelInstance += SimpleRefreshGreen;

                                completedPanel.Controls.Add(PANEL);
                            }
                        }
                    }

                }
            }
        }

        // for delegates
        public void SimpleRefreshRed()
        {
            RefreshRedPanels("SELECT * FROM redTable");
        }

        public void SimpleRefreshYellow()
        {
            RefreshYellowPanels("SELECT * FROM yellowTable");
        }

        public void SimpleRefreshGreen()
        {
            RefreshGreenPanels("SELECT * FROM greenTable");
        }


        // tool strip Data Access functions
        private void pastDeadlineToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RefreshRedPanels("SELECT * FROM redTable WHERE deadline < '"+DateTime.Now+"' AND appointedtoID = '"+Global.currentUser.ID+"'");
            RefreshYellowPanels("SELECT * FROM yellowTable WHERE deadline < '" + DateTime.Now + "' AND appointedtoID = '" + Global.currentUser.ID + "'");
            RefreshGreenPanels("SELECT * FROM greenTable WHERE deadline < '" + DateTime.Now + "' AND appointedtoID = '" + Global.currentUser.ID + "'");
        }

        private void urgentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshRedPanels("SELECT * FROM redTable WHERE appointedtoID = '" + Global.currentUser.ID + "' ORDER BY deadline ASC");
            RefreshYellowPanels("SELECT * FROM yellowTable WHERE appointedtoID = '" + Global.currentUser.ID + "'ORDER BY deadline ASC");
            RefreshGreenPanels("SELECT * FROM greenTable WHERE appointedtoID = '" + Global.currentUser.ID + "'ORDER BY deadline ASC");
        }

        private void nonurgentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshRedPanels("SELECT * FROM redTable WHERE appointedtoID = '" + Global.currentUser.ID + "' ORDER BY deadline DESC");
            RefreshYellowPanels("SELECT * FROM yellowTable WHERE appointedtoID = '" + Global.currentUser.ID + "'ORDER BY deadline DESC");
            RefreshGreenPanels("SELECT * FROM greenTable WHERE appointedtoID = '" + Global.currentUser.ID + "'ORDER BY deadline DESC");
        }


        private void oldestToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RefreshRedPanels("SELECT * FROM redTable WHERE creatorID = '" + Global.currentUser.ID + "' ORDER BY deadline ASC");
            RefreshYellowPanels("SELECT * FROM yellowTable WHERE creatorID = '" + Global.currentUser.ID + "'ORDER BY deadline ASC");
            RefreshGreenPanels("SELECT * FROM greenTable WHERE creatorID = '" + Global.currentUser.ID + "'ORDER BY deadline ASC");
        }
        private void newestToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RefreshRedPanels("SELECT * FROM redTable WHERE creatorID = '" + Global.currentUser.ID + "' ORDER BY deadline DESC");
            RefreshYellowPanels("SELECT * FROM yellowTable WHERE creatorID = '" + Global.currentUser.ID + "'ORDER BY deadline DESC");
            RefreshGreenPanels("SELECT * FROM greenTable WHERE creatorID = '" + Global.currentUser.ID + "'ORDER BY deadline DESC");
        }
        private void pastDeadlineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RefreshRedPanels("SELECT * FROM redTable WHERE deadline < '" + DateTime.Now + "' AND creatorID = '" + Global.currentUser.ID + "'");
            RefreshYellowPanels("SELECT * FROM yellowTable WHERE deadline < '" + DateTime.Now + "' AND creatorID = '" + Global.currentUser.ID + "'");
            RefreshGreenPanels("SELECT * FROM greenTable WHERE deadline < '" + DateTime.Now + "' AND creatorID = '" + Global.currentUser.ID + "'");
        }

    }
}
