using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class ThumbnailsEventArgs : EventArgs
    {
        public IList<Image> thumbnailImages { get; }

        public ThumbnailsEventArgs(Image image)
        {
            thumbnailImages.Add(image);
        }
    }
}
