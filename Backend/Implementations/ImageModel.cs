using ImageProcessor.Imaging.Filters.Photo;
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Backend
{
    /// <summary>
    /// ImageModel class. Contains data and logic for the images
    /// </summary>
    public class ImageModel : IImageModel, IEditImageEventPublisher, IModelEdits
    {
        // DECLARE an EventHandler of ImageModelEventArgs to handle ImageModel events, call it _imageChangedEvent:
        private event EventHandler<ImageModelEventArgs> _imageChangedEvent;

        // DECLARE an IImageEditor to handle editing of images, call it _imageEditor: 
        private IImageEditor _imageEditor;

        // DECLARE an IImageSaver to handle the saving of images to a file, call it _imageSaver:
        private IImageSaver _imageSaver;

        // DECLARE an Image that will be edited by the user, call it _image:
        private Image _image;

        // DECLARE an Image that will be hold a copy of the original image, call it _originalImage:
        private Image _originalImage;

        // DECLARE a Size that will hold the current size of the image, call it _currentSize:
        private Size _currentSize;

        // DECLARE an int that will hold the amount in degrees the image was rotated, call it _currentDegrees:
        private int _currentDegrees;

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
            _originalImage = _image;
            _imageEditor = imageEditor;
            _imageSaver = imageSaver;
        }

        /// <summary>
        /// Save an image to a user specified path/filename
        /// </summary>
        public void SaveAs()
        {
            // Apply all the edits before saving the image using the stored values:
            _imageEditor.ProcessImage(_image, factory => factory.Resize(_currentSize).Rotate(_currentDegrees));

            // Save the image:
            _imageSaver.SaveImage(_image);
        }
        #endregion

        #region Implentation of IModelEdits
        /// <summary>
        /// Scale and image
        /// </summary>
        /// <param name="size">The new size the image should be scaled to</param>
        public void Resize(Size size)
        {
            // Set the current size to be the size passed in:
            _currentSize = size;

            // SCALE _image and fire event:
            OnImageChanged(_imageEditor
                .ProcessImage(_image, factory => factory
                .Resize(size)
                .Rotate(_currentDegrees)));
        }

        /// <summary>
        /// Rotate an image
        /// </summary>
        /// <param name="degrees">The amount the image should be rotate by (in degrees)</param>
        public void Rotate(int degrees)
        {
            // Set the current degrees to be the degrees passed in:
            _currentDegrees = degrees;

            // Rotate _image and fire event:
            OnImageChanged(_imageEditor
                .ProcessImage(_image, factory => factory
                .Rotate(degrees)
                .Resize(_currentSize)));
        }

        /// <summary>
        /// Flip an image
        /// </summary>
        /// <param name="flipVertically">If the image should be flipped vertically or horizontally</param>
        public void Flip(bool flipVertically)
        {
            // FLIP _image and fire event:
            OnImageChanged(_imageEditor
                .ProcessImage(_image, factory => factory
                .Flip(flipVertically)
                .Resize(_currentSize)
                .Rotate(_currentDegrees)));
        }

        /// <summary>
        /// Filter an image
        /// </summary>
        public void FilterBlackWhite()
        {
            // Filter _image and fire event:
            OnImageChanged(_imageEditor.ProcessImage(_image, factory => factory.Filter(MatrixFilters.BlackWhite)));
        }
        public void FilterComic()
        {
            OnImageChanged(_imageEditor.ProcessImage(_image, factory => factory.Filter(MatrixFilters.Comic)));
        }
        public void FilterLomograph()
        {
            OnImageChanged(_imageEditor.ProcessImage(_image, factory => factory.Filter(MatrixFilters.Lomograph)));
        }
        public void FilterSepia()
        {
            OnImageChanged(_imageEditor.ProcessImage(_image, factory => factory.Filter(MatrixFilters.Sepia)));
        }
        public void FilterInvert()
        {
            OnImageChanged(_imageEditor.ProcessImage(_image, factory => factory.Filter(MatrixFilters.Invert)));
        }

        /// <summary>
        /// Resets the editing made to the image
        /// </summary>
        public void ResetEdits()
        {
            // Set the _image to be the _originalImage, removing any edits previously made:
            _image = _originalImage;

            // Reset _image and fire event:
            OnImageChanged(_image);
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
        protected virtual void OnImageChanged(Image image)
        {
            // Only call it if there are any subscribers:
            if (_imageChangedEvent != null)
                _imageChangedEvent(this, new ImageModelEventArgs(image));
        }
        #endregion
    }
}
