using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backend
{
    public class CollectionData : ICollectionData
    {
        // DECLARE a IServiceLocator to store a reference to the FactoryLocator, call it _factories:
        private IServiceLocator _factories;

        private IDictionary<int, IImageModel> _currentModels = new Dictionary<int, IImageModel>();

        public event EventHandler<ImageAddedEventArgs> ControlAdded;


        private IImageEditor _imageEditor;

        #region IMPLEMENTATION of ICollectionData
        /// <summary>
        /// Inject a reference to the factory locator service
        /// </summary>
        /// <param name="locator">The factory locator service</param>
        public void InjectFactory(IServiceLocator locator)
        {
            // Initialise _factories:
            _factories = locator;

            // Get reference to _imageEditor:
            _imageEditor = (_factories.Get<IImageEditor>() as IFactory<IImageEditor>).Create<ImageEditor>();
        }
        #endregion

        public IImageModel GetImageModel(int index) => _currentModels[index];

        public void AddControl(Image imageToAdd)
        {
            int index = _currentModels.Count;
            IImageModel imageModel = (_factories.Get<IImageModel>() as IFactory<IImageModel>).Create<ImageModel>();
            imageModel.Initialise(imageToAdd, _imageEditor);

            _currentModels.Add(index, imageModel);

            var panel = new Panel();
            panel.Tag = index;
            panel.Size = new Size(150, 150);
            panel.BackgroundImage = _imageEditor.Resize(imageToAdd, 150, 150);
            panel.BackgroundImageLayout = ImageLayout.Center;
            panel.BackColor = Color.BlanchedAlmond;

            OnControlAdded(panel);
        }

        protected virtual void OnControlAdded(Panel panelAdded)
        {
            if (ControlAdded != null)
                ControlAdded(this, new ImageAddedEventArgs(panelAdded));
        }

        public void Subscribe(EventHandler<ImageAddedEventArgs> listener)
        {
            ControlAdded += listener;
        }
    }
}
