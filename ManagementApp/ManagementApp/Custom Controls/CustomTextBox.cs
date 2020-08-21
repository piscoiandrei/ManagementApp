using System.Drawing;
using System.Windows.Forms;

namespace ManagementApp
{
    public partial class CustomTextBox : TextBox
    {
        public CustomTextBox()
        {
            BackColor = Color.FromArgb(204, 255, 221);
            BorderStyle = BorderStyle.None;
            Font = new Font("Microsoft Sans Serif", 10.25f, FontStyle.Regular);
            MaxLength = 50;
            Multiline = true;
            Height = 18;
        }
    }
}
