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

        public Controller()
        {
            // Instantiate _factoryLocator:
            _factoryLocator = new FactoryLocator();

            // Instantiate a CollectionData to store all images in, store it as an ICollectionData and call it _collectionData:
            _collectionData = (_factoryLocator.Get<ICollectionData>() as IFactory<ICollectionData>).Create<CollectionData>();

            var collectionView = new CollectionView(BrowseImages);

            _collectionData.Subscribe(collectionView.OnImageAdded);
            
            Application.Run(collectionView);
        }

        #region Delegate Implementations
        /// <summary>
        /// Implementation of the StrategyDelegate, (hence Strategy pattern), browses for new images.
        /// </summary>
        public void BrowseImages()
        {
            var imageBrowser = (_factoryLocator.Get<IImageBrowser>() as IFactory<IImageBrowser>).Create<ImageBrowser>();
            IList<string> imagePaths = imageBrowser.BrowseNewImages();

            if (imagePaths == null)
                return;

            foreach (var path in imagePaths)
            {
                Image imageFound = Bitmap.FromFile(Path.GetFullPath(path));
                _collectionData.AddImage(imageFound);
            }
        }
        #endregion
    }
}
