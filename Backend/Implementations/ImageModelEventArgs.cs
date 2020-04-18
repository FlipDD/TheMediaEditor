using System;
using System.Drawing;

namespace Backend
{
    public class ImageModelEventArgs : EventArgs
    {
        /// <summary>
        /// Property to hold the updated image (if any)
        /// </summary>
        public Image image { get; }

        /// <summary>
        /// Property to hold the updated width (if any)
        /// </summary>
        public int width { get; }
        /// <summary>
        /// Property to hold the updated height (if any)
        /// </summary>
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
