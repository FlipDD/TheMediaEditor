using System;

namespace Backend
{
    public class ImageClickedEventArgs : EventArgs
    {
        public int index { get; }

        public ImageClickedEventArgs(int index)
        {
            this.index = index;
        }
    }
}
