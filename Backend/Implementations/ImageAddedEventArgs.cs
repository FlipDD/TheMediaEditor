using System;
using System.Windows.Forms;

namespace Backend
{
    public class ImageAddedEventArgs : EventArgs
    {
        public Panel panel { get; }

        public ImageAddedEventArgs(Panel panelData)
        {
            panel = panelData;
        }
    }
}
