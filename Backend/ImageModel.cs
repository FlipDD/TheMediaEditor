using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class ImageModel : IImageModel
    {
        public event EventHandler<ImageModelEventArgs> ImageChanged;

        private IImageEditor _imageEditor;

        private Image _currentImage;
        private Image _editedImage;

        //public ImageModel(IImageEditor imageEditor, Image currentImage)
        //{
        //    _imageEditor = imageEditor;
        //    _currentImage = currentImage;
        //}

        public void Initialise(Image currentImage, IImageEditor imageEditor)
        {
            _currentImage = currentImage;
            _imageEditor = imageEditor;
        }

        public void Crop()
        {

        }

        public void SetCurrentImage(Image image)
        {
            _currentImage = image;
        }

        public Image GetCurrentImage() => _currentImage;
        public Image GetEditedImage() => _editedImage;

        protected virtual void OnImageChanged(Image image)
        {
            // Only call it if there are any subscribers:
            if (ImageChanged != null)
                ImageChanged(this, new ImageModelEventArgs(image));
        }
    }
}
