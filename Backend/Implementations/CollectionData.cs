using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Backend
{
    /// <summary>
    /// CollectionData class. Contains logic for the user to be able to browse new images and add controls
    /// </summary>
    public class CollectionData : ICollectionData, IAddImageEventPublisher
    {
        // DECLARE an event for storing images added event handlers, call it _controlAddedEvent:
        private event EventHandler<ImageAddedEventArgs> _controlAddedEvent;

        // DECLARE a IServiceLocator to store a reference to the FactoryLocator, call it _factories:
        private IServiceLocator _factories;

        // DECLARE a Dictionary<int, IImageModel> to store all image data and logic, call it _currentModels:
        private IDictionary<int, IImageModel> _currentModels;

        #region IMPLEMENTATION of ICollectionData
        /// <summary>
        /// Inject a reference to the factory locator service
        /// </summary>
        /// <param name="locator">The factory locator service</param>
        public void InjectFactory(IServiceLocator locator)
        {
            // Initialise _factories:
            _factories = locator;

            // Initialise the _currentModels Dictionary:
            _currentModels = new Dictionary<int, IImageModel>();
        }

        /// <summary>
        /// Gets the IImageModel Value by providing the Key
        /// </summary>
        /// <param name="key">The key of the dictionary</param>
        /// <returns>The IImageModel associated with this key</returns>
        public IImageModel GetImageModel(int key) => _currentModels[key];

        /// <summary>
        /// Browses for images. Calls AddControl for each image added
        /// </summary>
        public void BrowseImages()
        {
            // Instantiates an IImageBrowser to browse for new Images:
            var imageBrowser = (_factories.Get<IImageBrowser>() as IFactory<IImageBrowser>).Create<ImageBrowser>();
            // Declare a List of strings that will hold the path for each of the Images found:
            var imagePaths = imageBrowser.BrowseNewImages();

            // Iterate through the List containing the path for each of the images selected:
            foreach (var path in imagePaths)
            {
                // Create an Drawing.Image from the path:
                var imageFound = Bitmap.FromFile(Path.GetFullPath(path));

                // Add a control (panel) to the flow panel using the image as the background:
                AddControl(imageFound);
            }
        }

        /// <summary>
        /// Add a panel control to the flow panel 
        /// </summary>
        /// <param name="imageToAdd">The image to set as the panel's background image</param>
        public void AddControl(Image imageToAdd)
        {
            // Create an ImageModel:
            var imageModel = (_factories.Get<IImageModel>() as IFactory<IImageModel>).Create<ImageModel>();
            // Create an ImageEditor:
            var imageEditor = (_factories.Get<IImageEditor>() as IFactory<IImageEditor>).Create<ImageEditor>();

            // The current size of _currentModels Dictionary:
            var count = _currentModels.Count;
            // Add the new ImageModel to the Dictionary with the count as the Key:
            _currentModels.Add(count, imageModel);

            // Initialise the ImageModel, passing in the ImageEditor and the ImageSaver:
            imageModel.Initialise(imageToAdd, imageEditor, (_factories.Get<IImageSaver>() as IFactory<IImageSaver>).Create<ImageSaver>());

            // Create a new panel:
            var panel = new Panel();
            // Create a new Size:
            var size = new Size(150, 150);
            // Set the panel tag to be the count of the dictionary (before adding the model, so it starts at 0):
            panel.Tag = count;
            // Set the panel size to be the previously created Size: 
            panel.Size = size;
            // Set the panel BackgroundImage to be the image passed in as a parameter, resizing it to fix the size of the panel:
            panel.BackgroundImage = imageEditor.ProcessImage(imageToAdd, im => im.Resize(size));
            // Set the panel BackgroundImageLayout to be Center, so that the image is centered in the panel:
            panel.BackgroundImageLayout = ImageLayout.Center;
            // Set the panel BackColor to be BlanchedAlmond:
            panel.BackColor = Color.BlanchedAlmond;

            // Call the event for when a control is added, passing in the newly created panel:
            OnControlAddedEvent(panel);
        }
        #endregion

        #region Implementation of IAddImageEventPublisher
        /// <summary>
        /// Subscribe a listener to added image events
        /// </summary>
        /// <param name="listener">reference to the listener method</param>
        public void Subscribe(EventHandler<ImageAddedEventArgs> listener)
        {
            // Add the listener to the EventHandler:
            _controlAddedEvent += listener;
        }
        #endregion

        #region internal methods
        /// <summary>
        /// Called when an image is edited (Rotated, Flipped, Resized)
        /// </summary>
        /// <param name="image">The image</param>
        /// <param name="overrideOriginal"></param>
        protected virtual void OnControlAddedEvent(Panel panelAdded)
        {
            // If someone is subscribed to the event, call it:
            if (_controlAddedEvent != null)
                _controlAddedEvent(this, new ImageAddedEventArgs(panelAdded));
        }
        #endregion

    }
}