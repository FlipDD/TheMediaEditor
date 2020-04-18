using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Backend
{
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
        #endregion

        public IImageModel GetImageModel(int index) => _currentModels[index];

        public void BrowseImages()
        {
            var imageBrowser = (_factories.Get<IImageBrowser>() as IFactory<IImageBrowser>).Create<ImageBrowser>();
            var imagePaths = imageBrowser.BrowseNewImages();

            foreach (var path in imagePaths)
            {
                var imageFound = Bitmap.FromFile(Path.GetFullPath(path));
                AddControl(imageFound);
            }
        }

        public void AddControl(Image imageToAdd)
        {
            var imageModel = (_factories.Get<IImageModel>() as IFactory<IImageModel>).Create<ImageModel>();
            var imageEditor = (_factories.Get<IImageEditor>() as IFactory<IImageEditor>).Create<ImageEditor>();
            var index = _currentModels.Count;
            _currentModels.Add(index, imageModel);

            imageModel.Initialise(imageToAdd, imageEditor, (_factories.Get<IImageSaver>() as IFactory<IImageSaver>).Create<ImageSaver>());

            var panel = new Panel();
            var size = new Size(150, 150);
            panel.Tag = index;
            panel.Size = size;
            panel.BackgroundImage = imageEditor.ProcessImage(imageToAdd, im => im.Resize(size));
            panel.BackgroundImageLayout = ImageLayout.Center;
            panel.BackColor = Color.BlanchedAlmond;

            OnControlAddedEvent(panel);
        }

        protected virtual void OnControlAddedEvent(Panel panelAdded)
        {
            if (_controlAddedEvent != null)
                _controlAddedEvent(this, new ImageAddedEventArgs(panelAdded));
        }

        public void Subscribe(EventHandler<ImageAddedEventArgs> listener)
        {
            _controlAddedEvent += listener;
        }
    }
}
