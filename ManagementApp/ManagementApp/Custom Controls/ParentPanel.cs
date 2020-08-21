using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ManagementApp.Custom_Controls
{
    public partial class ParentPanel : Panel
    {
        Font font = Global.UniversalFont;

        public TextBox createdTb = new TextBox();
        public TextBox appointedtoTb = new TextBox();
        public TextBox taskTb = new TextBox();
        public TextBox notesTb = new TextBox();
        public TextBox dateTb = new TextBox();
        public TextBox deadlineTb = new TextBox();

        public string ID;
        public string creatorID;
        public string appointedToID;
        public ParentPanel()
        {
            Font = font;
            Size = new Size(455, 220);
            BorderStyle = BorderStyle.FixedSingle;
            // adding labels 
            List<Point> list = new List<Point>();
            list.Add(new Point(3, 6));
            list.Add(new Point(3, 36));
            list.Add(new Point(3, 65));
            list.Add(new Point(3, 93));
            list.Add(new Point(3, 159));
            list.Add(new Point(247, 160));

            List<string> texts = new List<string>();
            texts.Add("Created by:");
            texts.Add("Appointed to:");
            texts.Add("Task:");
            texts.Add("Notes:");
            texts.Add("Date:");
            texts.Add("Deadline:");

            for (int i = 0; i < 6; i++)
            {
                Label l = new Label();
                l.Parent = this;
                l.Font = font;
                l.Text = texts[i];
                l.Location = list[i];
                l.BackColor = Color.Transparent;
                l.AutoSize = true;
                this.Controls.Add(l);
                l.SendToBack();
            }

            // adding tb

            createdTb.Parent = this;
            createdTb.BorderStyle = BorderStyle.Fixed3D;
            createdTb.Size = new Size(356, 23);
            createdTb.Location = new Point(91, 6);
            createdTb.ReadOnly = true;
            createdTb.Font = font;
            createdTb.BringToFront();
            createdTb.BackColor = Color.White;
            this.Controls.Add(createdTb);

            appointedtoTb.Parent = this;
            appointedtoTb.BorderStyle = BorderStyle.Fixed3D;
            appointedtoTb.Size = new Size(347, 23);
            appointedtoTb.Location = new Point(100, 35);
            appointedtoTb.ReadOnly = true;
            appointedtoTb.Font = font;
            appointedtoTb.BringToFront();
            appointedtoTb.BackColor = Color.White;
            this.Controls.Add(appointedtoTb);

            taskTb.Parent = this;
            taskTb.BorderStyle = BorderStyle.Fixed3D;
            taskTb.Size = new Size(395, 23);
            taskTb.Location = new Point(52, 64);
            taskTb.ReadOnly = true;
            taskTb.Font = font;
            taskTb.BringToFront();
            taskTb.BackColor = Color.White;
            this.Controls.Add(taskTb);

            notesTb.Parent = this;
            notesTb.BorderStyle = BorderStyle.Fixed3D;
            notesTb.Multiline = true;
            notesTb.ScrollBars = ScrollBars.Vertical;
            notesTb.Size = new Size(395, 60);
            notesTb.Location = new Point(52, 91);
            notesTb.ReadOnly = true;
            notesTb.Font = font;
            notesTb.BringToFront();
            notesTb.BackColor = Color.White;
            this.Controls.Add(notesTb);

            dateTb.Parent = this;
            dateTb.BorderStyle = BorderStyle.Fixed3D;
            dateTb.Size = new Size(116, 23);
            dateTb.Location = new Point(52, 157);
            dateTb.ReadOnly = true;
            dateTb.Font = font;
            dateTb.BringToFront();
            dateTb.BackColor = Color.White;
            this.Controls.Add(dateTb);

            deadlineTb.Parent = this;
            deadlineTb.BorderStyle = BorderStyle.Fixed3D;
            deadlineTb.Size = new Size(130, 23);
            deadlineTb.Location = new Point(317, 157);
            deadlineTb.ReadOnly = true;
            deadlineTb.Font = font;
            deadlineTb.BringToFront();
            deadlineTb.BackColor = Color.White;
            this.Controls.Add(deadlineTb);

        }
    }
}
