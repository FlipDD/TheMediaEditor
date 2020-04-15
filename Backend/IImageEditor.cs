using ImageProcessor;
using System;
using System.Drawing;

namespace Backend
{
    public interface IImageEditor
    {
        Image ProcessImage(Image image, Func<ImageFactory, ImageFactory> process);
    }
}
