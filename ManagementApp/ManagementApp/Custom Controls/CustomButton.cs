using System.Drawing;
using System.Windows.Forms;

namespace ManagementApp
{
    public partial class CustomButton : Button
    {
        public CustomButton()
        {
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.FromArgb(204, 255, 221);
            FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 255, 187);
            FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 255, 153);
        }
    }
}
