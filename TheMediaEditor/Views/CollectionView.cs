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

        /// <summary>
        /// Constructor for objects of type CollectionView.
        /// </summary>
        /// <param name="browseImages">A reference to the StrategyDelegate</param>
        public CollectionView(StrategyDelegate browseImages)
        {
            // Base Form initializations:
            InitializeComponent();

            _browseImages = browseImages;
        }

        //public void OnNewImages(object source, EventArgs args)
        //{
        //    int lastIndex = ThumbnailsFlowPanel.Controls.Count - 1;

        //    Button button = new Button();
        //    button.Tag = lastIndex;
        //    button.Size = new Size(150, 150);
        //    //button.Image = args.thumbnailImages[lastIndex];
        //    ThumbnailsFlowPanel.Controls.Add(button);
        //}


        #region Implementation of IEventListener
        public void OnImageAdded(object source, ImageAddedEventArgs args)
        {
            Button button = new Button();
            button.Tag = args.index;
            button.Size = new Size(150, 150);
            button.Image = args.image;
            button.BackColor = Color.BlanchedAlmond;
            ThumbnailsFlowPanel.Controls.Add(button);
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
