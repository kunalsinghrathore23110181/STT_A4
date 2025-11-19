using System;

namespace EventPlayground1
{
    // Custom EventArgs to carry the selected color name
    public class ColorEventArgs : EventArgs
    {
        public string SelectedColor { get; }

        public ColorEventArgs(string colorName)
        {
            SelectedColor = colorName;
        }
    }
}
