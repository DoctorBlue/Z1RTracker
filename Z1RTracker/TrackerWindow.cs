using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Z1RTracker
{
    public partial class TrackerWindow : Form
    {
        public TrackerWindow()
        {
            InitializeComponent();
            Text = "Z1R Tracker";
            ForeColor = Color.Maroon;
            BackColor = Color.DarkOliveGreen;
        }

        private void HandleDungeonMouseDown(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            switch(e.Button)
            {
                case MouseButtons.Left:
                    Increment(button);
                    break;
                case MouseButtons.Right:
                    Decrement(button);
                    break;
                case MouseButtons.Middle:
                    Clear(button);
                    break;
            }
        }

        private void HandleDungeonBlockPictureMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Middle) return;
            DungeonBlockers blocker = (sender as Control).TagBlocker();
            Controls.OfType<Button>().Where(c => c.TagBlocker() == blocker).ToList().ForEach(Clear);
        }

        private void Increment(Button button)
        {
            if (button == null) return;
            if (int.TryParse(button.Text, out int currentNumber))
            {
                button.Text = currentNumber >= 8 ? "" : (++currentNumber).ToString();
            }
            else
            {
                button.Text = "1";
            }
        }

        private void Decrement(Button button)
        {
            if (button == null) return;
            if (int.TryParse(button.Text, out int currentNumber))
            {
                button.Text = currentNumber <= 1 ? "" : (--currentNumber).ToString();
            }
            else
            {
                button.Text = "8";
            }
        }

        private void Clear(Button button)
        {
            if (button == null) return;
            button.Text = "";
        }
    }
}
