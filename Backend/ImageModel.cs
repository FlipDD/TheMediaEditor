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

        private Image _image;

        public void Initialise(Image currentImage, IImageEditor imageEditor)
        {
            _image = currentImage;
            _imageEditor = imageEditor;
        }

        public void Crop()
        {

        }

        public void SetCurrentImage(Image image)
        {
            _image = image;
        }

        public Image GetCurrentImage() => _image;

        #region Edits
        public void Resize(Size size)
        {
            // SCALE _image and fire event:
            OnImageChanged(_imageEditor.Resize(_image, size), false);
        }

        public void Flip(bool flipVertically)
        {
            // FLIP _image and fire event:
            OnImageChanged(_imageEditor.Flip(_image, flipVertically), true);
        }

        public void Rotate(int degrees)
        {
            // Rotate _image and fire event:
            OnImageChanged(_imageEditor.Rotate(_image, degrees), false);
        }
        #endregion

        public void Subscribe(EventHandler<ImageModelEventArgs> listener)
        {
            _imageChangedEvent += listener;
        }

        public void Unsubscribe(EventHandler<ImageModelEventArgs> listener)
        {
            _imageChangedEvent -= listener;
        }

        protected virtual void OnImageChanged(Image image, bool saveOriginal)
        {
            // Update the image in this class:
            // TODO: Explain this
            if (saveOriginal)
                _image = image;

            // Only call it if there are any subscribers:
            if (_imageChangedEvent != null)
                _imageChangedEvent(this, new ImageModelEventArgs(image));
        }

        protected virtual void OnFlipBoxChecked(bool flipCheck)
        {

        }
    }
}
