using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Backend
{
    /// <summary>
    /// CollectionModel class. Contains logic for the user to be able to browse new images and add controls
    /// </summary>
    public class CollectionModel : ICollectionModel, IAddImageEventPublisher
    {
        // DECLARE an event for storing images added event handlers, call it _controlAddedEvent:
        private event EventHandler<ImageAddedEventArgs> _controlAddedEvent;

        // DECLARE a IServiceLocator to store a reference to the FactoryLocator, call it _factories:
        private IServiceLocator _factories;

        // DECLARE a Dictionary<int, IImageModel> to store all image data and logic, call it _currentModels:
        private IDictionary<int, IImageModel> _currentModels;

        #region IMPLEMENTATION of ICollectionModel
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

                // Add a image model and the associated flow panel using the image as the background:
                AddImageModel(imageFound);
            }
        }

        /// <summary>
        /// Add a new image model  
        /// </summary>
        /// <param name="imageToAdd">The image to send as a parameter to the model</param>
        public void AddImageModel(Image imageToAdd)
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
            imageModel.Initialise(imageToAdd, imageEditor,
                (_factories.Get<IImageSaver>() as IFactory<IImageSaver>).Create<ImageSaver>()
                _factories.Get<IImageData>() as IFactory<IImageData>).Create<ImageData>());

            // Initialise a new panel to send to the View:
            var panel = SetupNewPanel(imageEditor.ProcessImage(imageToAdd, im => im.Resize(new Size(150, 150))), count);

            // Call the event for when a control is added, passing in the newly created panel:
            OnControlAddedEvent(panel);
        }

        /// <summary>
        /// Add a panel control to the flow panel 
        /// </summary>
        /// <param name="panelImage">The image to add as the panels' background image</param>
        /// <param name="tag">The tag to give to the panel</param>
        /// <returns>The created panel</returns>
        public Panel SetupNewPanel(Image panelImage, int tag)
        {
            // Create a new panel:
            var panel = new Panel();
            // Set the panel tag to be the count of the dictionary (before adding the model, so it starts at 0):
            panel.Tag = tag;
            // Set the panel size to be the size of the image: 
            panel.Size = panelImage.Size;
            // Set the panel BackgroundImage to be the image passed in as a parameter, resizing it to fix the size of the panel:
            panel.BackgroundImage = panelImage;
            // Set the panel BackgroundImageLayout to be Center, so that the image is centered in the panel:
            panel.BackgroundImageLayout = ImageLayout.Center;
            // Set the panel BackColor to be BlanchedAlmond:
            panel.BackColor = Color.BlanchedAlmond;

            // Return the created panel
            return panel;
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
            _controlAddedEvent?.Invoke(this, new ImageAddedEventArgs(panelAdded));
        }
        #endregion

    }
}