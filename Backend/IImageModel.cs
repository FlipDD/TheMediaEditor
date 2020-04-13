using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public interface IImageModel
    {
        void Initialise(Image currentImage, IImageEditor imageEditor);

        Image GetCurrentImage();

        void Resize(Size size);

        void Flip(bool flipVertically);

        void Rotate(int degrees);

        void Subscribe(EventHandler<ImageModelEventArgs> listener);

        void Unsubscribe(EventHandler<ImageModelEventArgs> listener);
    }
}
