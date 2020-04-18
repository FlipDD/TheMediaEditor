using ImageProcessor.Imaging.Filters.Photo;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Backend
{
    public class ImageModel : IImageModel, IEditImageEventPublisher
    {
        private event EventHandler<ImageModelEventArgs> _imageChangedEvent;

        private IImageEditor _imageEditor;

        private IImageSaver _imageSaver;

        private Image _image;

        private Size _currentSize;

        #region Implementation of IImageModel
        /// <summary>
        /// Constructor for objects of type ImageModel
        /// </summary>
        /// <param name="currentImage">The image associated with this model</param>
        /// <param name="imageEditor">The ImageEditor used to edit the image (Resize, Flip, Rotate)</param>
        /// <param name="imageSaver">The ImageSaver used to save the image to a specific path/filename</param>
        public void Initialise(Image currentImage, IImageEditor imageEditor, IImageSaver imageSaver)
        {
            _image = currentImage;
            _imageEditor = imageEditor;
            _imageSaver = imageSaver;
        }

        /// <summary>
        /// Scale and image
        /// </summary>
        /// <param name="size">The new size the image should be scaled to</param>
        public void Resize(Size size)
        {
            // SCALE _image and fire event:
            _currentSize = size;
            OnImageChanged(_imageEditor.ProcessImage(_image, im => im.Resize(size)), false);
            OnScaleChanged(size.Width, size.Height);
        }

        /// <summary>
        /// Rotate an image
        /// </summary>
        /// <param name="degrees">The amount the image should be rotate by (in degrees)</param>
        public void Rotate(int degrees)
        {
            // Rotate _image and fire event:
            OnImageChanged(_imageEditor.ProcessImage(_image, im => im.Rotate(degrees)), true);
        }

        /// <summary>
        /// Flip an image
        /// </summary>
        /// <param name="flipVertically">If the image should be flipped vertically or horizontally</param>
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

        /// <summary>
        /// Save an image to a user specified path/filename
        /// </summary>
        public void SaveAs()
        {
            _imageSaver.SaveImage(_image);
        }
        #endregion

        #region Implementation of IEditImageEventPublisher
        /// <summary>
        /// Subscribe a listener to image events
        /// </summary>
        /// <param name="listener">reference to the listener method</param>
        public void Subscribe(EventHandler<ImageModelEventArgs> listener)
        {
            _imageChangedEvent += listener;
        }

        /// <summary>
        /// Unsubscribe a listener to image events
        /// </summary>
        /// <param name="listener">reference to the listener method</param>
        public void Unsubscribe(EventHandler<ImageModelEventArgs> listener)
        {
            _imageChangedEvent -= listener;
        }
        #endregion

        #region private methods
        /// <summary>
        /// Called when an image is edited (Rotated, Flipped, Resized)
        /// </summary>
        /// <param name="image">The image</param>
        /// <param name="overrideOriginal"></param>
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
        #endregion
    }
}
