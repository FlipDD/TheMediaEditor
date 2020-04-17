using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Backend
{
    public class CollectionData : ICollectionData, IAddImageEventPublisher
    {
        // DECLARE a IServiceLocator to store a reference to the FactoryLocator, call it _factories:
        private IServiceLocator _factories;

        private IDictionary<int, IImageModel> _currentModels;

        private IImageEditor _imageEditor;

        private event EventHandler<ImageAddedEventArgs> _controlAddedEvent;

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

            // Get reference to _imageEditor:
            _imageEditor = (_factories.Get<IImageEditor>() as IFactory<IImageEditor>).Create<ImageEditor>();
        }
        #endregion

        public IImageModel GetImageModel(int index) => _currentModels[index];

        public void BrowseImages()
        {
            var imageBrowser = (_factories.Get<IImageBrowser>() as IFactory<IImageBrowser>).Create<ImageBrowser>();
            IList<string> imagePaths = imageBrowser.BrowseNewImages();

            foreach (var path in imagePaths)
            {
                Image imageFound = Bitmap.FromFile(Path.GetFullPath(path));
                AddControl(imageFound);
            }
        }

        public void AddControl(Image imageToAdd)
        {
            int index = _currentModels.Count;
            IImageModel imageModel = (_factories.Get<IImageModel>() as IFactory<IImageModel>).Create<ImageModel>();
            imageModel.Initialise(imageToAdd, _imageEditor);

            _currentModels.Add(index, imageModel);

            var panel = new Panel();
            var size = new Size(150, 150);
            panel.Tag = index;
            panel.Size = size;
            panel.BackgroundImage = _imageEditor.ProcessImage(imageToAdd, im => im.Resize(size));
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
