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


        /// <summary>
        /// Setup the DisplayView to be added (the image editor window)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SetupDisplayView(object sender, EventArgs args)
        {
            // Create a DisplayView Form:
            var displayView = (_factoryLocator.Get<Form>() as IFactory<Form>).Create<DisplayView>() as DisplayView;

            // Set the IImageModel to be the one in the Dictionary with the Key = indexSelected:
            var imageModel = _collectionData.GetImageModel(GetModelIndex(sender));

            // Subscribe to ImageEdited events:
            (imageModel as IEditImageEventPublisher).Subscribe(displayView.OnImageEdited);

            // Get the Interface IModelEdits containing the methods used to edit the images:
            var modelEdits = (imageModel as IModelEdits);

            // Initialise new DisplayView, passing in Commands:
            displayView.Initialise(ExecuteCommand, GetEditActions(modelEdits), imageModel.SaveAs);

            // Show the DisplayView: 
            displayView.Show();
        }

        private EditActions GetEditActions(IModelEdits modelEdits)
        {
            // Create the EditActions class:
            var editActions = (_factoryLocator.Get<EditActions>() as IFactory<EditActions>).Create<EditActions>();

            // Set all the Actions wanted (not setting an action won't break the app anymore):
            editActions.ResizeAction = modelEdits.Resize;
            editActions.RotateAction = modelEdits.Rotate;
            editActions.FlipAction = modelEdits.Flip;
            editActions.ContrastAction = modelEdits.Contrast;
            editActions.BrightnessAction = modelEdits.Brightness;
            editActions.SaturationAction = modelEdits.Saturation;
            editActions.RemoveFilter = modelEdits.FilterOriginal;
            editActions.BlackWhiteFilter = modelEdits.FilterBlackWhite;
            editActions.ComicFilter = modelEdits.FilterComic;
            editActions.LomoFilter = modelEdits.FilterLomograph;
            editActions.SepiaFilter = modelEdits.FilterSepia;
            editActions.InvertFilter = modelEdits.FilterInvert;
            editActions.ResetEdits = modelEdits.ResetEdits;

            // Return the class with the properties set:
            return editActions;
        }

        private int GetModelIndex(object o)
        {
            // Convert the object into a panel:
            var panel = o as Panel;

            // Declare an int to store the index selected (image) into:
            int indexSelected;

            // Try to parse the tag of the button into an int and assign the value to indexSelected:
            Int32.TryParse(panel.Tag.ToString(), out indexSelected);

            // Return the converted value
            return indexSelected;
        }
     }
}