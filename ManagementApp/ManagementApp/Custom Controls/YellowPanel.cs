using System;
using System.Windows.Forms;
using System.Drawing;

namespace ManagementApp.Custom_Controls
{
    public partial class YellowPanel : ParentPanel
    {
        Font font = Global.UniversalFont;

        public delegate void refreshPanel();
        public refreshPanel refreshPanelInstance;

        public delegate void refreshAffectedPanels();
        public refreshAffectedPanels affectedPanels;

        public YellowPanel()
        {
            BackColor = Global.yellow;

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

                        new DbCon().DeleteTaskFromTable("yellowTable", this.ID);

                        this.Dispose();

                        if (refreshPanelInstance != null)
                            refreshPanelInstance();
                    }
                }
            };
            this.Controls.Add(delButton);


            // move to next column button

            var completeButton = new Button();
            completeButton.Parent = this;
            completeButton.Font = font;
            completeButton.FlatStyle = FlatStyle.Flat;
            completeButton.FlatAppearance.BorderSize = 1;
            completeButton.BackColor = Color.White;
            completeButton.Text = "Complete Task";
            completeButton.Size = new Size(196, 28);
            completeButton.Location = new Point(251, 187);

            completeButton.Click += (s, e) =>
            {
                // granting permission to begin the task to the one appointed to do the task and to the task creator
                if (Global.currentUser.ID == this.appointedToID || Global.currentUser.ID == this.creatorID)
                {
                    var connection = new DbCon();
                    connection.DeleteTaskFromTable("yellowTable", this.ID);

                    connection.InsertTasksIntoTable(
                        "greenTable",
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
            this.Controls.Add(completeButton);
        }
    }
}
