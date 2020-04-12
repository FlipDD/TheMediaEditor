using Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheMediaEditor.Views;
using Backend;
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

        // DECLARE a IDictionary<int, Form> to store new images in, call it _images:
        private IDictionary<int, Form> _images;
       
        private IImageModel _imageModel;

        // DECLARE an int to store the value for the next noteKey, call it _nextNoteKey, set it to 0:
        int _nextImageKey = 0;

        public Controller()
        {
            // Instantiate _factoryLocator:
            _factoryLocator = new FactoryLocator();

            // Instantiate _images:
            _images = new Dictionary<int, Form>();

            // Instantiate a NoteData to store all note image in, store it as an IImageModel and call it noteData:
            _imageModel = (_factoryLocator.Get<IImageModel>() as IFactory<IImageModel>).Create<ImageModel>();

            // Inject _factoryLocator through to noteData:
            _imageModel.InjectFactory(_factoryLocator);

            Application.Run(new CollectionView(BrowseImages));
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
                _imageModel.AddItem(imageFound);


                _nextImageKey++;
            }
        }


        //TODO
        public void OpenImageEditor()
        {
            // Add new FishyNote and assign its noteKey:
            DisplayView note = (_factoryLocator.Get<Form>() as IFactory<Form>).Create<DisplayView>() as DisplayView;
            _images.Add(_nextImageKey, note);

            // Show the new note: 
            _images[_nextImageKey].Show();
        }

        #endregion
    }
}
