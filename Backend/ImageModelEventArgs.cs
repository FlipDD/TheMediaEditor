using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class ImageModelEventArgs : EventArgs
    {
        /// <summary>
        /// Property to hold the updated image (if any)
        /// </summary>
        public Image image { get; }

        public int width { get; }
        public int height { get; }

        public ImageModelEventArgs(Image image)
        {
            this.image = image;
        }
        public ImageModelEventArgs(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
