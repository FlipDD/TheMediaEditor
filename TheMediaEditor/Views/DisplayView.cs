using Backend;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheMediaEditor
{
    /// <summary>
    /// A View to hold the Image selected and the buttons to perform image editing and saving the result
    /// </summary>
    public partial class DisplayView : Form, IDisplayView, IEditImageEventListener
    {
        // DECLARE a ExecuteDelegate to store the delegate to be called to issue a command:
        private ExecuteDelegate _execute;

        // DECLARE an Action<Size> to store the action to be executed when the image is resized, call it _resizeAction:
        private Action<Size> _resizeAction;

        // DECLARE an Action<int> to store the action to be executed when the image is rotated, call it _rotateAction:
        private Action<int> _rotateAction;

        // DECLARE an Action<bool> to store the action to be executed when the image is flipped, call it _flipAction:
        private Action<bool> _flipAction;

        // DECLARE a StrategyDelegate to be used when we remove the filters of the image, call it _removeFilter:
        private StrategyDelegate _removeFilter;
        // DECLARE a StrategyDelegate to be used when we apply a black and white filter to the image, call it _blackWhiteFilter:
        private StrategyDelegate _blackWhiteFilter;
        // DECLARE a StrategyDelegate to be used when we apply a comic filter to the image, call it _comicFilter:
        private StrategyDelegate _comicFilter;
        // DECLARE a StrategyDelegate to be used when we apply a lomography filter to the image, call it _lomoFilter:
        private StrategyDelegate _lomoFilter;
        // DECLARE a StrategyDelegate to be used when we apply a sepia filter to the image, call it _sepiaFilter:
        private StrategyDelegate _sepiaFilter;
        // DECLARE a StrategyDelegate to be used when we apply an invert filter to the image, call it _invertFilter:
        private StrategyDelegate _invertFilter;

        // DECLARE a StrategyDelegate to be used when the image is reseted to its original state, call it _resetAction:
        private StrategyDelegate _resetEdits;

        // DECLARE a StrategyDelegate to be used for saving images, call it _saveImage:
        private StrategyDelegate _saveImage;

        /// <summary>
        /// Initialize the controls of this View 
        /// </summary>
        public DisplayView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor for objects of type DisplayView
        /// </summary>
        /// <param name="execute"></param>
        /// <param name="resize"></param>
        /// <param name="flip"></param>
        /// <param name="rotate"></param>
        /// <param name="filter"></param>
        /// <param name="save"></param>
        public void Initialise(ExecuteDelegate execute, Action<Size> resize, Action<bool> flip, Action<int> rotate,
           StrategyDelegate filterOriginal, StrategyDelegate filterBlackWhite, StrategyDelegate filterComic, 
           StrategyDelegate filterLomo, StrategyDelegate filterSepia, StrategyDelegate filterInvert,
           StrategyDelegate reset, StrategyDelegate save)
        {
            // SET _execute:
            _execute = execute;

            // SET _resizeAction to resize:
            _resizeAction += resize;
            // SET _flipAction to flip:
            _flipAction += flip;
            // SET _rotateAction to rotate:
            _rotateAction += rotate;

            // SET _resetAction to reset:
            _resetEdits += reset;

            // SET _saveImage to save:
            _saveImage = save;

            // SET _removeFilter to filterOriginal:
            _removeFilter = filterOriginal;
            // SET _blackWhiteFilter to filterBlackWhite:
            _blackWhiteFilter = filterBlackWhite;
            // SET _comicFilter to filterComic:
            _comicFilter = filterComic;
            // SET _lomoFilter to filterLomo:
            _lomoFilter = filterLomo;
            // SET _sepiaFilter to filterSepia:
            _sepiaFilter = filterSepia;
            // SET _invertFilter to filterInvert:
            _invertFilter = filterInvert;

            // Resize the image to fit the picture box
            ICommand resizeImage = new Command<Size>(_resizeAction, this.PictureBox.Size);
            _execute(resizeImage);
        }

        public void OnImageEdited(object source, ImageModelEventArgs args)
        {
            // Check for new image data:
            if (args.image != null)
            {
                // Update the Image in picturePanel:
                PictureBox.Image = args.image;

                //BWPictureBox.Image = args.image;
            }

            // Check for new size data:
            if (args.width != 0 || args.height != 0)
            {
                // Update the value of the NumsUpDown in the ToolsLayoutPanel:
                WidthNumUpDown.Value = args.width;
                HeightNumUpDown.Value = args.height;
            }
        }

        /// <summary>
        /// Callback for when the window is resized
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImageViewer_Resize(object sender, EventArgs e)
        {
            // Call _resizeAction:
            ICommand resizeImage = new Command<Size>(_resizeAction, this.PictureBox.Size);
            _execute(resizeImage);
        }

        /// <summary>
        /// Callback for when the value of the width changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WidthNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            // Call _resizeAction with the values of the NumUpDown of width and height:
            ICommand resizeImage = new Command<Size>(_resizeAction, new Size((int) WidthNumUpDown.Value, (int) HeightNumUpDown.Value));
            _execute(resizeImage);
        }

        /// <summary>
        /// Callback for when the value of the height changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            // Call _resizeAction with the values of the NumUpDown of width and height:
            ICommand resizeImage = new Command<Size>(_resizeAction, new Size((int) WidthNumUpDown.Value, (int) HeightNumUpDown.Value));
            _execute(resizeImage);
        }

        /// <summary>
        /// Callback for when the value of the track bar changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RotationTrackBar_ValueChanged(object sender, EventArgs e)
        {
            // Call _rotateAction passing in the current value of the track bar:
            ICommand rotateImage = new Command<int>(_rotateAction, RotationTrackBar.Value);
            _execute(rotateImage);
        }

        /// <summary>
        /// Callback for when the FlipHorizontalButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlipHorizontalButton_Click(object sender, EventArgs e)
        {
            // Call _flipAction to flip horizontally (bool false):
            ICommand flipImage = new Command<bool>(_flipAction, false);
            _execute(flipImage);
        }

        /// <summary>
        /// Callback for when the FlipVerticallButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlipVerticalButton_Click(object sender, EventArgs e)
        {
            // Call _flipAction to flip vertically (bool true):
            ICommand flipImage = new Command<bool>(_flipAction, true);
            _execute(flipImage);
        }

        /// <summary>
        /// Callback for when the OriginalButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OriginalButton_Click(object sender, EventArgs e)
        {
            // Remove any filters from the image:
            _removeFilter();
        }

        /// <summary>
        /// Callback for when the BWButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BWButton_Click(object sender, EventArgs e)
        {
            // Apply a black and white filter to the image:
            _blackWhiteFilter();
        }

        /// <summary>
        /// Callback for when the ComicButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComicButton_Click(object sender, EventArgs e)
        {
            // Apply a comic filter to the image:
            _comicFilter();
        }

        /// <summary>
        /// Callback for when the LomoButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LomoButton_Click(object sender, EventArgs e)
        {
            // Apply a lomography filter to the image:
            _lomoFilter();
        }

        /// <summary>
        /// Callback for when the SepiaButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SepiaButton_Click(object sender, EventArgs e)
        {
            // Apply a lomography filter to the image:
            _sepiaFilter();
        }

        /// <summary>
        /// Callback for when the InvertButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvertButton_Click(object sender, EventArgs e)
        {
            // Apply an invert filter to the image:
            _invertFilter();
        }

        /// <summary>
        /// Callback for when the ResetButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            // Reset all forms of editing made to the image:
            _resetEdits();
        }

        /// <summary>
        /// Callback for when the SaveButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Save the image to a file with a provided path/filename:
            _saveImage();
        }

        /// <summary>
        /// Callback for when the user tries to close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayView_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Show a message asking if the user is sure the window should be closed:
            if (MessageBox.Show("Are you sure you want to close the editor?", 
                "Close window", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
