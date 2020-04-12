using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    class ImageModel : IImageModel
    {
        public event EventHandler<ImageModelEventArgs> ImageChanged;

        private IImageEditor _imageEditor;

        private Image _currentImage;

        public ImageModel(IImageEditor imageEditor, Image currentImage)
        {
            _imageEditor = imageEditor;
            _currentImage = currentImage;
        }

        public void Crop()
        {

        }

        protected virtual void OnImageChanged(Image image)
        {
            // Only call it if there are any subscribers:
            if (ImageChanged != null)
                ImageChanged(this, new ImageModelEventArgs(image));
        }
    }
}
