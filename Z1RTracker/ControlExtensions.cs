using System.Windows.Forms;

namespace Z1RTracker
{
    public static class ControlExtensions
    {
        public static string TagString(this Control control) => control?.Tag.ToString() ?? "";
    }
}
