using ImageProcessor.Imaging.Filters.Photo;
using System;
using System.Collections.Generic;
using System.Drawing;

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

        // DECLARE a Size that will hold the current size of the image, call it _currentSize:
        private Size _currentSize;

        // DECLARE an int that will hold the amount in degrees the image was rotated, call it _currentDegrees:
        private int _currentDegrees;

        // DECLARE an IMatrixFilter that will hold the currentFilter being applied, call it _currentFilter:
        private IMatrixFilter _currentFilter;

        // DECLARE a boolean that will tell if a filter is being applied or not, call it _hasFilter:
        private bool _hasFilter;

        // DECLARE a List of Func<Image, Image> that will hold the current edit methods used, call it _currentEditFuncs:
        List<Func<Image, Image>> _currentEditFuncs;


        #region Implementation of IImageModel
        /// <summary>
        /// Constructor for objects of type ImageModel
        /// </summary>
        /// <param name="currentImage">The image associated with this model</param>
        /// <param name="imageEditor">The ImageEditor used to edit the image (Resize, Flip, Rotate)</param>
        /// <param name="imageSaver">The ImageSaver used to save the image to a specific path/filename</param>
        public void Initialise(Image currentImage, IImageEditor imageEditor, IImageSaver imageSaver)
        {
            // SET the parameters
            _image = currentImage;
            _imageEditor = imageEditor;
            _imageSaver = imageSaver;

            // Initialize the List:
            _currentEditFuncs = new List<Func<Image, Image>>();
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
        /// Runs all the image editing methods in the _currentEditFuncs list
        /// </summary>
        void EditImage()
        {
            // Declare the image to be edited (using the original):
            Image newImage = _image;

            //newImage = _imageEditor.ProcessImage(newImage, factory => factory.Filter(MatrixFilters.BlackWhite));
            // Loop through the current edit functions and apply them to the newImage:
            _currentEditFuncs.ForEach(action => newImage = action.Invoke(newImage));

            // Fire the event passing in the now edited image:
            OnImageChanged(newImage);
        }

        /// <summary>
        /// Scale and image
        /// </summary>
        /// <param name="size">The new size the image should be scaled to</param>
        public void Resize(Size size)
        {
            // Set the current size to be the size passed in:
            _currentSize = size;

            // SCALE _image and fire event:
            AddNewFunc((image) => _imageEditor.ProcessImage(image, factory => factory.Resize(_currentSize)));

            EditImage();
            OnImageChanged(size.Width, size.Height);
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
            AddNewFunc((image) => _imageEditor.ProcessImage(image, factory => factory.Rotate(_currentDegrees)));

            EditImage();
        }

        /// <summary>
        /// Add a new function to the _currentEditFuncs list, which runs all of our editing methods
        /// </summary>
        /// <param name="newEditFunc">The type of processing to apply to the image</param>
        /// <param name="isFilter">If the function we're adding is .Filter (troublesome)</param>
        void AddNewFunc(Func<Image, Image> newEditFunc, bool isFilter = false)
        {
            // Check if our method was already added
            bool containsAction = _currentEditFuncs.Contains(newEditFunc);

            // Add if we still haven't added our image editing method
            if (!containsAction)
            {
                // Needed since filter overrides resize, rotate and flip
                // So we check if we're adding a filter and put it in the first index of the list
                if (!isFilter)
                {
                    // Add the new editing function to the list
                    _currentEditFuncs.Add(newEditFunc);
                }
                else
                {
                    // Set the has filter to true - so we know a filter is being applied
                    _hasFilter = true;
                    // Insert the filter method as the first member of the list
                    _currentEditFuncs.Insert(0, newEditFunc);
                }
            }
        }

        /// <summary>
        /// Flip an image
        /// </summary>
        /// <param name="flipVertically">If the image should be flipped vertically or horizontally</param>
        public void Flip(bool flipVertically)
        {
            //_currentFlip = flipVertically;

            // FLIP _image and fire event:
            AddNewFunc((image) => _imageEditor.ProcessImage(image, factory => factory.Flip(flipVertically)));

            EditImage();

            OnImageChanged(_image);
        }

        public void FilterOriginal()
        {
            if (_hasFilter)
            {
                _hasFilter = false;
                _currentEditFuncs.RemoveAt(0);
                EditImage();
            }
        }

        /// <summary>
        /// Filter an image
        /// </summary>
        public void FilterBlackWhite()
        {
            ApplyFilter(MatrixFilters.BlackWhite);
        }

        public void FilterComic()
        {
            ApplyFilter(MatrixFilters.Comic);
        }

        public void FilterLomograph()
        {
            ApplyFilter(MatrixFilters.Lomograph);
        }

        public void FilterSepia()
        {
            ApplyFilter(MatrixFilters.Sepia);
        }

        public void FilterInvert()
        {
            ApplyFilter(MatrixFilters.Invert);
        }

        public void ApplyFilter(IMatrixFilter filter)
        {
            _currentFilter = filter;
            AddNewFunc((image) => _imageEditor.ProcessImage(image, factory => factory.Filter(_currentFilter)), true);

            EditImage();
        }

        /// <summary>
        /// Resets the editing made to the image
        /// </summary>
        public void ResetEdits()
        {
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

        protected virtual void OnImageChanged(int width, int height)
        {
            // Only call it if there are any subscribers:
            _imageChangedEvent?.Invoke(this, new ImageModelEventArgs(width, height));
        }
        #endregion
    }
}
