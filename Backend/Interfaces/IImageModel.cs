using System.Drawing;

namespace Backend
{
    public interface IImageModel
    {
        void Initialise(Image currentImage, IImageEditor imageEditor, IImageSaver imageSaver);

        void Resize(Size size);

        void Rotate(int degrees);

        void Flip(bool flipVertically);

        void Filter(int id);

        void SaveAs();
    }
}
