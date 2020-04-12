using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class ImageEventArgs : EventArgs
    {
        /// <summary>
        /// Property to hold the updated image (if any)
        /// </summary>
        public Image image { get; }

        public ImageEventArgs(Image data)
        {
            this.image = data;
        }
    }
}
