using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
