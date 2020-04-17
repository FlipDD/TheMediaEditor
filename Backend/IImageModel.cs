using System;
using System.Drawing;

namespace Backend
{
    public interface IImageModel
    {
        void Initialise(Image currentImage, IImageEditor imageEditor);

        void Resize(Size size);

        void Flip(bool flipVertically);

        void Rotate(int degrees);

        void Filter(int id);
    }
}
