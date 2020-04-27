using ImageProcessor.Imaging.Filters.Photo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

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

        // DECLARE an int that will hold the value of the contrast, call it _currentContrast:
        private int _currentContrast;
        // DECLARE an int that will hold the value of the brightness, call it _currentBrightness:
        private int _currentBrightness;
        // DECLARE an int that will hold the value of the saturation, call it _currentSaturation:
        private int _currentSaturation;

        // DECLARE an int that will hold the amount in degrees the image was rotated, call it _currentDegrees:
        private int _currentDegrees;

        // DECLARE an IMatrixFilter that will hold the currentFilter being applied, call it _currentFilter:
        private IMatrixFilter _currentFilter;

        // DECLARE a boolean that will tell if a filter is being applied or not, call it _hasFilter:
        private bool _hasFilter;

        // DECLARE a List of Func<Image, Image> that will hold the current edit methods used, call it _currentEditFuncs:
        List<Func<Image, Image>> _currentEditFuncs;

        // DECLARE a boolean that will if the image was flipped vertically or horizontally, call it _currentFlip:
        private bool _currentFlip;

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

            // Instantiate imageData:

        }

        /// <summary>
        /// Save an image to a user specified path/filename
        /// </summary>
        public void SaveAs()
        {
            // Save the image passing in the method that applies the edits and returns the image:
            _imageSaver.SaveImage(ApplyEdits());
        }
        #endregion

        #region Implentation of IModelEdits
        /// <summary>
        /// Fires the event that updates the image on the view
        /// </summary>
        void EditImage()
        {
            // Fire the event that updates the image passing the method that applies the edits:
            OnImageChanged(ApplyEdits());
        }

        /// <summary>
        /// Applies all the edits inside the list of editing methods
        /// </summary>
        /// <returns></returns>
        Image ApplyEdits()
        {
            // Declare the image to be edited (using the original):
            Image newImage = _image;

            // Loop through the current edit functions and apply them to the newImage:
            _currentEditFuncs.ForEach(action => newImage = action.Invoke(newImage));

            // Return the now edited image:
            return newImage;
        }

        /// <summary>
        /// Scale and image
        /// </summary>
        /// <param name="size">The new size the image should be scaled to</param>
        public void Resize(Size size)
        {
            // Set the current size to be the size passed in:
            _currentSize = size;

            // Try to add the Resize Func to the _currentEdits list:
            AddNewFunc((image) => _imageEditor.ProcessImage(image, factory => factory.Resize(_currentSize)));

            // Fire the event that updates the size values on the UI:
            OnScaleChanged(size.Width, size.Height);
        }

        /// <summary>
        /// Rotate an image
        /// </summary>
        /// <param name="degrees">The amount the image should be rotate by (in degrees)</param>
        public void Rotate(int degrees)
        {
            // Set the current degrees to be the degrees passed in:
            _currentDegrees = degrees;

            // Try to add the Rotate Func to the _currentEdits list:
            AddNewFunc((image) => _imageEditor.ProcessImage(image, factory => factory.Rotate(_currentDegrees)));

            // Fire the event that updates the degrees value on the UI:
            OnDegreesChanged(_currentDegrees);
        }

        /// <summary>
        /// Flip an image
        /// </summary>
        /// <param name="flipVertically">If the image should be flipped vertically or horizontally</param>
        public void Flip(bool flipVertically)
        {
            // Set the current flip value:
            _currentFlip = flipVertically;

            // Try to add the Flip Func to the _currentEdits list:
            AddNewFunc((image) => _imageEditor.ProcessImage(image, factory => factory.Flip(_currentFlip)), true, false);
        }

        /// <summary>
        /// Applies a certain amount of contrast to an image
        /// </summary>
        /// <param name="percentage">The percentage of contrast to apply</param>
        public void Contrast(int percentage)
        {
            // Set the current contrast value:
            _currentContrast = percentage;

            // Try to add the Contrast Func to the _currentEdits list:
            AddNewFunc((image) => _imageEditor.ProcessImage(image, factory => factory.Contrast(_currentContrast)));
        }

        /// <summary>
        /// Applies a certain amount of brightness to an image
        /// </summary>
        /// <param name="percentage">The percentage of brightness to apply</param>
        public void Brightness(int percentage)
        {
            // Set the current brightness value:
            _currentBrightness = percentage;

            // Try to add the Brightness Func to the _currentEdits list:
            AddNewFunc((image) => _imageEditor.ProcessImage(image, factory => factory.Brightness(_currentBrightness)));
        }

        /// <summary>
        /// Applies a certain amount of saturation to an image
        /// </summary>
        /// <param name="percentage">The percentage of saturation to apply</param>
        public void Saturation(int percentage)
        {
            // Set the current saturation value:
            _currentSaturation = percentage;

            // Try to add the Saturation Func to the _currentEdits list:
            AddNewFunc((image) => _imageEditor.ProcessImage(image, factory => factory.Saturation(_currentSaturation)));
        }

        /// <summary>
        /// Filter an image applying a black and white
        /// </summary>
        public void ApplyFilter(IMatrixFilter filter)
        {
            // Set the filter value
            _currentFilter = filter;

            // Try to add the Filter Func to the _currentEdits list:
            AddNewFunc((image) => _imageEditor.ProcessImage(image, factory => factory.Filter(_currentFilter)), false, true);
        }

        /// <summary>
        /// Remove any filter the image might have
        /// </summary>
        public void FilterOriginal()
        {
            // If the image has a filter applied
            if (_hasFilter)
            {
                // Set the _hasFilter to false:
                _hasFilter = false;

                // Remove the filter method from the list (which is always the first)
                _currentEditFuncs.RemoveAt(0);

                // Edit the image:
                EditImage();
            }
        }

        /// <summary>
        /// Filter an image applying a black and white filter
        /// </summary>
        public void FilterBlackWhite()
        {
            ApplyFilter(MatrixFilters.BlackWhite);
        }

        /// <summary>
        /// Filter an image applying a comic filter
        /// </summary>
        public void FilterComic()
        {
            ApplyFilter(MatrixFilters.Comic);
        }

        /// <summary>
        /// Filter an image applying a lomograph filter
        /// </summary>
        public void FilterLomograph()
        {
            ApplyFilter(MatrixFilters.Lomograph);
        }

        /// <summary>
        /// Filter an image applying a sepia filter
        /// </summary>
        public void FilterSepia()
        {
            ApplyFilter(MatrixFilters.Sepia);
        }

        /// <summary>
        /// Filter an image applying an invert filter
        /// </summary>
        public void FilterInvert()
        {
            ApplyFilter(MatrixFilters.Invert);
        }

        /// <summary>
        /// Add a new function to the _currentEditFuncs list, which runs all of our editing methods
        /// </summary>
        /// <param name="newEditFunc">The type of processing to apply to the image</param>
        /// <param name="isFlip">If the function we're adding is .Flip</param>
        /// <param name="isFilter">If the function we're adding is .Filter (troublesome)</param>
        void AddNewFunc(Func<Image, Image> newEditFunc, bool isFlip = false, bool isFilter = false)
        {
            // Check if our method was already added
            bool containsAction = _currentEditFuncs.Contains(newEditFunc);

            // Add if we still haven't added our image editing method
            if (!containsAction)
            {
                // Needed since filter overrides resize, rotate and flip
                // So we check if we're adding a filter and put it in the first index of the list
                if (isFilter)
                {
                    // Set the has filter to true - so we know a filter is being applied
                    _hasFilter = true;
                    // Insert the filter method as the first member of the list
                    _currentEditFuncs.Insert(0, newEditFunc);
                }
                else
                {
                    // Add the new editing function to the list
                    _currentEditFuncs.Add(newEditFunc);
                }
            }
            else
            {
                // If the newEditFunc is the .Flip 
                if (isFlip)
                    // Remove it from the list
                    _currentEditFuncs.Remove(newEditFunc);
            }

            // Perform the image editing:
            EditImage();
        }

        /// <summary>
        /// Resets the editing made to the image
        /// </summary>
        public void ResetEdits()
        {
            // Delete all functions added to the list:
            _currentEditFuncs.Clear();

            // Fire event to update the image to be the original one:
            OnImageChanged(_image);
            // Fire event to update the values of width and height
            OnScaleChanged(_image.Width, _image.Height);
        }
        #endregion

        #region Implementation of IEditImageEventPublisher
        /// <summary>
        /// Subscribe a listener to image events
        /// </summary>
        /// <param name="listener">reference to the listener method</param>
        public void Subscribe(EventHandler<ImageModelEventArgs> listener)
        {
            // Subscribe to the event:
            _imageChangedEvent += listener;
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
            _imageChangedEvent?.Invoke(this, new ImageModelEventArgs(image));
        }

        protected virtual void OnScaleChanged(int width, int height)
        {
            // Only call it if there are any subscribers:
            _imageChangedEvent?.Invoke(this, new ImageModelEventArgs(width, height));
        }

        protected virtual void OnDegreesChanged(int degrees)
        {
            // Only call it if there are any subscribers:
            _imageChangedEvent?.Invoke(this, new ImageModelEventArgs(degrees));
        }
        #endregion
    }
}