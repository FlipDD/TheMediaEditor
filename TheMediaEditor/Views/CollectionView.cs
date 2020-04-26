using Backend;
using System;
using System.Windows.Forms;

namespace TheMediaEditor.Views
{
    /// <summary>
    /// A View to hold the images the user loads into the program
    /// </summary>
    public partial class CollectionView : Form, IAddImageEventListener
    {
        // DECLARE a StrategyDelegate to be used for browsing new images, call it _browseImages:
        private Action _browseImages;

        // DECLARE an Action to be assigned to the Event of double clicking a panel:
        private Action<object, EventArgs> _openImageEditor;

        /// <summary>
        /// Constructor for objects of type CollectionView.
        /// </summary>
        /// <param name="browseImages">A reference to the StrategyDelegate</param>
        /// <param name="openImageEditor">A reference to the openImageEditor Action</param>
        public CollectionView(Action browseImages, Action<object, EventArgs> openImageEditor)
        {
            // Base Form initializations:
            InitializeComponent();

            //SET _browseImages to browseImages:
            _browseImages = browseImages;
            //SET _browseImages to browseImages:
            _openImageEditor = openImageEditor;
        }

        #region Implementation of IAddImageEventListener
        /// <summary>
        /// Callback for when images are added
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args">Argument containing the new panel added (if any)</param>
        public void OnImageAdded(object source, ImageAddedEventArgs args)
        {
            // Check for new panel data:
            if (args.PanelData != null)
            {
                // Add the Event for when the user double clicks the panel:
                args.PanelData.DoubleClick += new System.EventHandler(_openImageEditor);
                // Adds the panel to the "ThumbnailsFlowPanel":
                ThumbnailsFlowPanel.Controls.Add(args.PanelData);
            }
        }
        #endregion

        #region private methods
        /// <summary>
        /// Callback for when the LoadButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            // Call click event handler:
            _browseImages();
        }
        #endregion
    }
}
