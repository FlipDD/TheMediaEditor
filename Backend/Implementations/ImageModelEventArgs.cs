using System;
using System.Drawing;

namespace Backend
{
    /// <summary>
    /// Class ImageModelEventArgs used to send arguments through events to the View to update data for rendering
    /// </summary>
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

        /// <summary>
        /// Constructor for ImageModelEventArgs that takes in the updated Image
        /// </summary>
        /// <param name="image">The image</param>
        public ImageModelEventArgs(Image image)
        {
            this.image = image;
        }

        /// <summary>
        /// Constructor for ImageModelEventArgs that takes in the updated image size
        /// </summary>
        /// <param name="width">The new width</param>
        /// <param name="height">The new height</param>
        public ImageModelEventArgs(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}