using System;
using System.Windows.Forms;
using System.Drawing;

namespace ManagementApp.Custom_Controls
{
    public partial class RedPanel : ParentPanel
    {
        Font font = Global.UniversalFont;

        public delegate void refreshPanel();
        public refreshPanel refreshPanelInstance;

        public delegate void refreshAffectedPanels();
        public refreshAffectedPanels affectedPanels;

        public RedPanel()
        {
            BackColor = Global.red;

            // delete this panel button
            var delButton = new Button();
            delButton.Parent = this;
            delButton.Font = font;
            delButton.FlatStyle = FlatStyle.Flat;
            delButton.FlatAppearance.BorderSize = 0;
            delButton.BackColor = Color.LightCoral;
            delButton.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            delButton.FlatAppearance.MouseDownBackColor = Color.Red;
            delButton.Text = "Delete";
            delButton.Size = new Size(109, 27);
            delButton.Location = new Point(3, 188);

            delButton.Click += (s, e) =>
            {
                if (Global.currentUser.MANAGER == false)
                {
                    MessageBox.Show("You can't delete tasks.", "Access Denied", MessageBoxButtons.OK);
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Do you really want to delete this task?", "Delete Task", MessageBoxButtons.YesNo);

                    if (dialog == DialogResult.Yes)
                    {

                        new DbCon().DeleteTaskFromTable("redTable", this.ID);

                        this.Dispose();

                        if (refreshPanelInstance!= null)
                            refreshPanelInstance();
                    }
                }
            };
            this.Controls.Add(delButton);

            // move to next column button

            var beginButton = new Button();
            beginButton.Parent = this;
            beginButton.Font = font;
            beginButton.FlatStyle = FlatStyle.Flat;
            beginButton.FlatAppearance.BorderSize = 1;
            beginButton.BackColor = Color.White;
            beginButton.Text = "Begin Task";
            beginButton.Size = new Size(196, 28);
            beginButton.Location = new Point(251, 187);

            beginButton.Click += (s, e) =>
            {
                // granting permission to begin the task to the one appointed to do the task and to the task creator
                if(Global.currentUser.ID == this.appointedToID || Global.currentUser.ID == this.creatorID)
                {
                    var connection = new DbCon();
                    connection.DeleteTaskFromTable("redTable", this.ID);

                    connection.InsertTasksIntoTable(
                        "yellowTable", 
                        this.creatorID,
                        this.appointedToID,
                        this.taskTb.Text, 
                        this.notesTb.Text,
                        Convert.ToDateTime(this.dateTb.Text),
                        Convert.ToDateTime(this.deadlineTb.Text)
                        );

                    this.Dispose();

                    if (affectedPanels != null)
                        affectedPanels();
                }
                else
                {
                    MessageBox.Show("You are not appointed to fullfill the task", "Access Denied");
                }
            };
            this.Controls.Add(beginButton);
        }
    }
}
