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

        // DECLARE an EditActions that will be used to store all the actions used to edit the image, call it _editActions:
        private EditActions _editActions;

        // DECLARE an Action to be executed for saving images, call it _saveImage:
        private Action _saveImage;

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
        /// <param name="editActions"></param>
        /// <param name="save"></param>
        public void Initialise(ExecuteDelegate execute, EditActions editActions, Action save)
        {
            // SET _execute:
            _execute = execute;

            // SET _editActions
            _editActions = editActions;

            // SET _saveImage to save:
            _saveImage = save;

            // Resize the image to fit the picture box
            ICommand resizeImage = new Command<Size>(_editActions.ResizeAction, this.PictureBox.Size);
            _execute(resizeImage);
        }

        public void OnImageEdited(object source, ImageModelEventArgs args)
        {
            // Check for new image data:
            if (args.Img != null)
            {
                // Update the Image in picturePanel:
                PictureBox.Image = args.Img;

                //BWPictureBox.Image = args.image;
            }

            // Check for new size data:
            if (args.Width != 0 || args.Height != 0)
            {
                // Update the value of the NumsUpDown in the ToolsLayoutPanel:
                WidthNumUpDown.Value = args.Width;
                HeightNumUpDown.Value = args.Height;
            }

            //// Check for new rotation data:
            //if (args.degrees != 0)
            //{
            //    // Update the value of the ValueLabel in the ToolsLayoutPanel:
            //    ValueLabel.Text = args.degrees.ToString() + "°"; // CONVERSION TOO SLOW? //
            //}
        }

        /// <summary>
        /// Callback for when the window is resized
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImageViewer_Resize(object sender, EventArgs e)
        {
            // Call ResizeAction:
            ICommand resizeImage = new Command<Size>(_editActions.ResizeAction, this.PictureBox.Size);
            _execute(resizeImage);
        }

        /// <summary>
        /// Callback for when the value of the width changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WidthNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            // Call ResizeAction with the values of the NumUpDown of width and height:
            ICommand resizeImage = new Command<Size>(_editActions.ResizeAction, 
                new Size((int) WidthNumUpDown.Value, (int) HeightNumUpDown.Value));
            _execute(resizeImage);
        }

        /// <summary>
        /// Callback for when the value of the height changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            // Call ResizeAction with the values of the NumUpDown of width and height:
            ICommand resizeImage = new Command<Size>(_editActions.ResizeAction, 
                new Size((int) WidthNumUpDown.Value, (int) HeightNumUpDown.Value));
            _execute(resizeImage);
        }

        /// <summary>
        /// Callback for when the value of the track bar changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RotationTrackBar_ValueChanged(object sender, EventArgs e)
        {
            // Call RotateAction passing in the current value of the track bar:
            ICommand rotateImage = new Command<int>(_editActions.RotateAction, RotationTrackBar.Value);
            _execute(rotateImage);
        }

        /// <summary>
        /// Callback for when the FlipHorizontalButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlipHorizontalButton_Click(object sender, EventArgs e)
        {
            // Call FlipAction to flip horizontally (bool false):
            ICommand flipImage = new Command<bool>(_editActions.FlipAction, false);
            _execute(flipImage);
        }

        /// <summary>
        /// Callback for when the FlipVerticallButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlipVerticalButton_Click(object sender, EventArgs e)
        {
            // Call FlipAction to flip vertically (bool true):
            ICommand flipImage = new Command<bool>(_editActions.FlipAction, true);
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
            _execute(new Command(_editActions.RemoveFilter));
        }

        /// <summary>
        /// Callback for when the BWButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BWButton_Click(object sender, EventArgs e)
        {
            // Apply a black and white filter to the image:
            _execute(new Command(_editActions.BlackWhiteFilter));
        }

        /// <summary>
        /// Callback for when the ComicButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComicButton_Click(object sender, EventArgs e)
        {
            // Apply a comic filter to the image:
            _execute(new Command(_editActions.ComicFilter));
        }

        /// <summary>
        /// Callback for when the LomoButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LomoButton_Click(object sender, EventArgs e)
        {
            // Apply a lomography filter to the image:
            _execute(new Command(_editActions.ComicFilter));
        }

        /// <summary>
        /// Callback for when the SepiaButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SepiaButton_Click(object sender, EventArgs e)
        {
            // Apply a lomography filter to the image:
            _execute(new Command(_editActions.SepiaFilter));
        }

        /// <summary>
        /// Callback for when the InvertButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvertButton_Click(object sender, EventArgs e)
        {
            // Apply an invert filter to the image:
            _execute(new Command(_editActions.InvertFilter));
        }

        /// <summary>
        /// Callback for when the ResetButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            // Reset all forms of editing made to the image:
            _execute(new Command(_editActions.ResetEdits));
        }

        /// <summary>
        /// Callback for the value of the ContrastTrackBar changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContrastTrackBar_ValueChanged(object sender, EventArgs e)
        {
            // Apply contrast to the image depending on the value of the track bar
            ICommand constractImage = new Command<int>(_editActions.ContrastAction, ContrastTrackBar.Value);
            _execute(constractImage);
        }

        /// <summary>
        /// Callback for the value of the BrightnessTrackBar changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrightnessTrackBar_ValueChanged(object sender, EventArgs e)
        {
            // Apply brightness to the image depending on the value of the track bar
            ICommand constractImage = new Command<int>(_editActions.BrightnessAction, BrightnessTrackBar.Value);
            _execute(constractImage);
        }

        /// <summary>
        /// Callback for the value of the SaturationTrackBar changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaturationTrackBar_ValueChanged(object sender, EventArgs e)
        {
            // Apply saturation to the image depending on the value of the track bar
            ICommand saturationImage = new Command<int>(_editActions.SaturationAction, SaturationTrackBar.Value);
            _execute(saturationImage);
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
