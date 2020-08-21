using System.Windows.Forms;
using System.Drawing;

namespace ManagementApp.Custom_Controls
{
    public partial class GreenPanel : ParentPanel
    {
        Font font = Global.UniversalFont;

        public delegate void refreshPanel();
        public refreshPanel refreshPanelInstance;

        public GreenPanel()
        {
            BackColor = Global.green;

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

                        new DbCon().DeleteTaskFromTable("greenTable", this.ID);

                        this.Dispose();

                        if (refreshPanelInstance != null)
                            refreshPanelInstance();
                    }
                }
            };
            this.Controls.Add(delButton);
        }
    }
}
