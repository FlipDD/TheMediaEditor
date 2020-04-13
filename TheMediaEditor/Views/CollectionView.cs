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
    public partial class CollectionView : Form
    {
        // DECLARE a StrategyDelegate to be used for browsing new images, call it _browseImages:
        private StrategyDelegate _browseImages;

        private Action<object, EventArgs> _openImageEditor;

        /// <summary>
        /// Constructor for objects of type CollectionView.
        /// </summary>
        /// <param name="browseImages">A reference to the StrategyDelegate</param>
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
            if (args.panel != null)
            {
                args.panel.DoubleClick += new System.EventHandler(_openImageEditor);
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
