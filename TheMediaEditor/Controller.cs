using Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheMediaEditor.Views;
using System.Drawing;
using System.IO;

namespace TheMediaEditor
{
    /// <summary>
    /// The top-level class for the MediaEditor app.
    /// </summary>
    class Controller
    {
        // DECLARE an IServiceLocator to refer to the factory locator, call it _factoryLocator:
        IServiceLocator _factoryLocator;

        // DECLARE an ICollectionData to store the collection, call it _collectionData:
        private ICollectionData _collectionData;

        private DisplayView _displayView;

        public Controller()
        {
            // Instantiate _factoryLocator:
            _factoryLocator = new FactoryLocator();

            // Instantiate a CollectionData to store all images in, store it as an ICollectionData and call it _collectionData:
            _collectionData = (_factoryLocator.Get<ICollectionData>() as IFactory<ICollectionData>).Create<CollectionData>();
            // Inject _factoryLocator through to collectionData:
            _collectionData.InjectFactory(_factoryLocator);

            var collectionView = new CollectionView(BrowseImages, ShowDisplayView);

            _collectionData.Subscribe(collectionView.OnImageAdded);
            
            Application.Run(collectionView);
        }

        /// <summary>
        /// Implementation of the ExecuteDelegate, for the Command Pattern
        /// </summary>
        /// <param name="command"></param>
        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
        }

        #region Delegate Implementations
        /// <summary>
        /// Implementation of the StrategyDelegate, browses for new images.
        /// </summary>
        public void BrowseImages()
        {
            var imageBrowser = (_factoryLocator.Get<IImageBrowser>() as IFactory<IImageBrowser>).Create<ImageBrowser>();
            IList<string> imagePaths = imageBrowser.BrowseNewImages();

            foreach (var path in imagePaths)
            {
                Image imageFound = Bitmap.FromFile(Path.GetFullPath(path));
                _collectionData.AddControl(imageFound);
            }
        }
        #endregion

        private void ShowDisplayView(object sender, EventArgs args)
        {
            var panel = (Panel) sender;
            int indexSelected;
            if (!Int32.TryParse(panel.Tag.ToString(), out indexSelected))
                return;

            if (_displayView == null)
            {
                _displayView = (_factoryLocator.Get<Form>() as IFactory<Form>).Create<DisplayView>() as DisplayView;
                _displayView.Initialise(ExecuteCommand, _collectionData.GetImageModel(indexSelected));
            }

            Console.WriteLine(panel.Tag);
        }
    }
}
