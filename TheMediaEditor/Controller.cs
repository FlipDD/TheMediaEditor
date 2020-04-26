using Backend;
using System;
using System.Runtime.CompilerServices;
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

        // DECLARE an ICollectionData to store the image collect, call it _collectionData:
        private ICollectionData _collectionData;

        // DECLARE an EditMethods to store the image editing methods to use, call it _editMethods:
        private EditActions _editMethods;

        /// <summary>
        /// Constructor of the Controller class
        /// </summary>
        public Controller()
        {
            // Instantiate _factoryLocator:
            _factoryLocator = new FactoryLocator();

            // Instantiate a CollectionData to store all images in, store it as an ICollectionData and call it _collectionData:
            _collectionData = (_factoryLocator.Get<ICollectionData>() as IFactory<ICollectionData>).Create<CollectionData>();
            
            // Inject _factoryLocator through to collectionData:
            _collectionData.InjectFactory(_factoryLocator);

            // Declare a create a temporary CollectionView and pass in the strategy delegate and the action:
            var collectionView = new Views.CollectionView(_collectionData.BrowseImages, SetupDisplayView);

            // Subscribe to ImageAdded events:
            (_collectionData as IAddImageEventPublisher).Subscribe(collectionView.OnImageAdded);

            // Fire-up UI by instantiating CollectionView:
            Application.Run(collectionView);
        }

        /// <summary>
        /// Implementation of the ExecuteDelegate, for the Command Pattern
        /// </summary>
        /// <param name="command">The command to execute</param>
        public void ExecuteCommand(ICommand command)
        {
            // Execute the command passed
            command.Execute();
        }

        private void SetupEditingMethods()
        {

        }

        /// <summary>
        /// Setup the DisplayView to be added (the image editor window)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SetupDisplayView(object sender, EventArgs args)
        {
            // Convert the object into a panel:
            var panel = sender as Panel;

            // Declare an int to store the index selected (image) into:
            int indexSelected;
            // Try to parse the tag of the button into an int and assign the value to indexSelected:
            if (!Int32.TryParse(panel.Tag.ToString(), out indexSelected))
                return;

            // Create a DisplayView Form:
            var displayView = (_factoryLocator.Get<Form>() as IFactory<Form>).Create<DisplayView>() as DisplayView;

            // Set the IImageModel to be the one in the Dictionary with the Key = indexSelected:
            var imageModel = _collectionData.GetImageModel(indexSelected);

            // Subscribe to ImageEdited events:
            (imageModel as IEditImageEventPublisher).Subscribe(displayView.OnImageEdited);

            // Get the Interface IModelEdits containing the methods used to edit the images:
            var modelEdits = (imageModel as IModelEdits);

            _editMethods = (_factoryLocator.Get<EditActions>() as IFactory<EditActions>).Create<EditActions>();
            _editMethods.ResizeAction = modelEdits.Resize;
            _editMethods.FlipAction = modelEdits.Flip;
            
            // Initialise new DisplayView, passing in Commands:
            displayView.Initialise(ExecuteCommand, _editMethods, imageModel.SaveAs);

            // Show the DisplayView: 
            displayView.Show();
        }
     }
}