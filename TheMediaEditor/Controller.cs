using Backend;
using System;
using System.Windows.Forms;

namespace TheMediaEditor
{
    /// <summary>
    /// The top-level class for the MediaEditor app.
    /// </summary>
    class Controller
    {
        // DECLARE an IServiceLocator to refer to the factory locator, call it _factoryLocator:
        private IServiceLocator _factoryLocator;

        // DECLARE a DisplayView to store the Form, call it _displayView:
        private DisplayView _displayView;

        // DECLARE an ICollectionData to store the image collect, call it _collectionData:
        private ICollectionData _collectionData;

        public Controller()
        {
            // Instantiate _factoryLocator:
            _factoryLocator = new FactoryLocator();

            // Instantiate a CollectionData to store all images in, store it as an ICollectionData and call it _collectionData:
            _collectionData = (_factoryLocator.Get<ICollectionData>() as IFactory<ICollectionData>).Create<CollectionData>();
            
            // Inject _factoryLocator through to collectionData:
            _collectionData.InjectFactory(_factoryLocator);

            var collectionView = new Views.CollectionView(_collectionData.BrowseImages, SetupDisplayView);

            (_collectionData as IAddImageEventPublisher).Subscribe(collectionView.OnImageAdded);

            // Fire-up UI by instantiating FishyNotes:
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

        private void SetupDisplayView(object sender, EventArgs args)
        {
            var panel = (Panel) sender;
            int indexSelected;
            if (!Int32.TryParse(panel.Tag.ToString(), out indexSelected))
                return;

            _displayView = (_factoryLocator.Get<Form>() as IFactory<Form>).Create<DisplayView>() as DisplayView;
            var imageModel = _collectionData.GetImageModel(indexSelected);

            // Subscribe new DisplayView to 'data-changed' events:
            (imageModel as IEditImageEventPublisher).Subscribe(_displayView.OnImageEdited);

            // Initialise new DisplayView:
            _displayView.Initialise(ExecuteCommand, imageModel.Resize, imageModel.Flip, imageModel.Rotate, imageModel.Filter);

            // Show the DisplayView: 
            _displayView.Show();
        }
     }
}
