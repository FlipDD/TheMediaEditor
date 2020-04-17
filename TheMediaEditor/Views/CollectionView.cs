using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;

namespace TheMediaEditor.Views
{
    public partial class CollectionView : Form, IAddImageEventListener
    {
        // DECLARE a StrategyDelegate to be used for browsing new images, call it _browseImages:
        private StrategyDelegate _browseImages;

        // DECLARE an Action to be assigned to the Event of double clicking a panel:
        private Action<object, EventArgs> _openImageEditor;

        /// <summary>
        /// Constructor for objects of type CollectionView.
        /// </summary>
        /// <param name="browseImages">A reference to the StrategyDelegate</param>
        /// <param name="openImageEditor">A reference to the openImageEditor Action</param>
        public CollectionView(StrategyDelegate browseImages, Action<object, EventArgs> openImageEditor)
        {
            // Base Form initializations:
            InitializeComponent();

            _browseImages = browseImages;
            _openImageEditor = openImageEditor;
        }

        #region Implementation of IEventListener
        public void OnImageAdded(object source, ImageAddedEventArgs args)
        {
            // Check for new panel data:
            if (args.panel != null)
            {
                // Add the Event for when the user double clicks the panel:
                args.panel.DoubleClick += new System.EventHandler(_openImageEditor);
                // Adds the panel to the "ThumbnailsFlowPanel":
                ThumbnailsFlowPanel.Controls.Add(args.panel);
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
