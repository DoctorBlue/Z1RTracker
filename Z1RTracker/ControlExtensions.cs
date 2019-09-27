using System.Windows.Forms;

namespace Z1RTracker
{
    public static class ControlExtensions
    {
        public static DungeonBlockers TagBlocker(this Control control)
        {
            return (DungeonBlockers)control?.Tag;
        }
    }
}
