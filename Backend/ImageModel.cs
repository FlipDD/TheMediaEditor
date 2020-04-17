using ImageProcessor.Imaging.Filters.Photo;
using System;
using System.Drawing;

namespace Backend
{
    public class ImageModel : IImageModel, IEditImageEventPublisher
    {
        private event EventHandler<ImageModelEventArgs> _imageChangedEvent;

        private IImageEditor _imageEditor;

        private IImageSaver _imageSaver;

        private Image _image;

        public void Initialise(Image currentImage, IImageEditor imageEditor, IImageSaver imageSaver)
        {
            _image = currentImage;
            _imageEditor = imageEditor;
            _imageSaver = imageSaver;
        }

        #region Processing the image
        public void Resize(Size size)
        {
            // SCALE _image and fire event:
            OnImageChanged(_imageEditor.ProcessImage(_image, im => im.Resize(size)), false);
            OnScaleChanged(size.Width, size.Height);
        }

        public void Rotate(int degrees)
        {
            // Rotate _image and fire event:
            OnImageChanged(_imageEditor.ProcessImage(_image, im => im.Rotate(degrees)), true);

        }
        public void Flip(bool flipVertically)
        {
            // FLIP _image and fire event:
            OnImageChanged(_imageEditor.ProcessImage(_image, im => im.Flip(flipVertically)), true);
        }

        public void Filter(int id)
        {
            IMatrixFilter filterType = MatrixFilters.Comic;
            switch (id)
            {
                case 1:
                    filterType = MatrixFilters.BlackWhite;
                    break;
            }
            // Filter _image and fire event:
            OnImageChanged(_imageEditor.ProcessImage(_image, im => im.Filter(filterType)), false);
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

        protected virtual void OnImageChanged(Image image, bool overrideOriginal)
        {
            // Update the image in this class:
            // TODO: Explain this
            if (overrideOriginal)
                _image = image;

            // Only call it if there are any subscribers:
            if (_imageChangedEvent != null)
                _imageChangedEvent(this, new ImageModelEventArgs(image));
        }

        protected virtual void OnScaleChanged(int width, int height)
        {
            // Only call it if there are any subscribers:
            if (_imageChangedEvent != null)
                _imageChangedEvent(this, new ImageModelEventArgs(width, height));
        }
    }
}
