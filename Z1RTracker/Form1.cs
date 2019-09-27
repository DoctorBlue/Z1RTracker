using System.Drawing;
using System.Windows.Forms;

namespace Z1RTracker
{
    public partial class TrackerWindow : Form
    {
        public TrackerWindow()
        {
            InitializeComponent();
            this.Text = "Z1R Tracker";
            this.ForeColor = Color.Maroon;
            BackColor = Color.DarkOliveGreen;
        }
    }
}
