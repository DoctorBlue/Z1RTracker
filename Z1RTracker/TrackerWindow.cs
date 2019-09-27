using System;
using System.Diagnostics;
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
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ActiveControl = null;
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

        private void HandleShopItemPictureMouseDown(object sender, MouseEventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            if (picture == null) return;
            string[] shopItems = new[] { "", "Arrow", "Bomb", "Candle", "Key", "Meat" };
            string currentShopItem = picture.Tag?.ToString() ?? "";
            switch (e.Button)
            {
                case MouseButtons.Left:
                {
                    int newIndex = Array.IndexOf(shopItems, currentShopItem) + 1;
                    string newShopItem = newIndex >= shopItems.Length ? shopItems[0] : shopItems[newIndex];
                    SetShopItem(picture, newShopItem);
                    break;
                }
                case MouseButtons.Right:
                {
                    int newIndex = Array.IndexOf(shopItems, currentShopItem) - 1;
                    string newShopItem = newIndex < 0 ? shopItems.Last() : shopItems[newIndex];
                    SetShopItem(picture, newShopItem);
                    break;
                }
                case MouseButtons.Middle:
                    picture.ImageLocation = "";
                    picture.Tag = "";
                    break;
            }
        }

        private void SetShopItem(PictureBox picture, string newShopItem)
        {
            picture.ImageLocation = newShopItem.Length > 0 ? $".\\Images\\ShopItems\\{newShopItem}.gif" : newShopItem;
            picture.Tag = newShopItem;
        }

        private void SourceLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var linkLabel = sender as LinkLabel;
            if (sender == null) return;
            Process.Start("explorer.exe", linkLabel.Text);
        }
    }
}
