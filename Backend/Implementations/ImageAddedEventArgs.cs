using System;
using System.Windows.Forms;

namespace Backend
{
    /// <summary>
    // Class ImageAddedEventArgs used to send arguments through events to the View to update the images updated
    /// </summary>
    public class ImageAddedEventArgs : EventArgs
    {
        /// <summary>
        /// Property to hold the new panel
        /// </summary>
        public Panel panel { get; }

        /// <summary>
        /// Constructor for objects of type ImageAddedEventArgs
        /// </summary>
        /// <param name="panelData">The panel added</param>
        public ImageAddedEventArgs(Panel panelData)
        {
            panel = panelData;
        }
    }
}