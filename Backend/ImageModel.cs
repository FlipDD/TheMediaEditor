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
        public event EventHandler<ImageModelEventArgs> _imageChangedEvent;

        private IImageEditor _imageEditor;

        private Image _currentImage;

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
        //public Image GetEditedImage() => _editedImage;

        public void ResizeImage(Size size)
        {
            // SCALE _image and fire event:
            OnImageChanged(_imageEditor.Resize(_currentImage, size));
        }

        public void Subscribe(EventHandler<ImageModelEventArgs> listener)
        {
            _imageChangedEvent += listener;
        }

        public void Unsubscribe(EventHandler<ImageModelEventArgs> listener)
        {
            _imageChangedEvent -= listener;
        }

        protected virtual void OnImageChanged(Image image)
        {
            // Only call it if there are any subscribers:
            if (_imageChangedEvent != null)
                _imageChangedEvent(this, new ImageModelEventArgs(image));
        }
    }
}
