using Backend;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheMediaEditor
{
    public partial class DisplayView : Form, IDisplayView, IEditImageEventListener
    {
        // DECLARE a ExecuteDelegate to store the delegate to be called to issue a command:
        private ExecuteDelegate _execute;

        // DECLARE an Action<Size> to store the action to be executed when image is resized, call it _resizeAction:
        private Action<Size> _resizeAction;

        // DECLARE an Action<int> to store the action to be executed when image is rotated, call it _rotateAction:
        private Action<int> _rotateAction;

        // DECLARE an Action<bool> to store the action to be executed when image is flipped, call it _flipAction:
        private Action<bool> _flipAction;

        // DECLARE an Action<int> to store the action to be executed when we apply a filter to the image, call it _filterAction:
        private Action<int> _filterAction;

        // DECLARE a StrategyDelegate to be used for saving images, call it _saveImage:
        private StrategyDelegate _saveImage;

        public DisplayView() => InitializeComponent();

        public void Initialise(ExecuteDelegate execute, Action<Size> resize, Action<bool> flip, Action<int> rotate, Action<int> filter, StrategyDelegate save)
        {
            // SET _execute:
            _execute = execute;

            // SET _resizeAction to resize
            _resizeAction += resize;
            // SET _flipAction to flip
            _flipAction += flip;
            // SET _rotateAction to rotate
            _rotateAction += rotate;

            _saveImage = save;

            _filterAction = filter;

            ICommand filterImage = new Command<int>(_filterAction, 1);
            _execute(filterImage);

            // Resize the image to fit the picture box
            ICommand resizeImage = new Command<Size>(_resizeAction, this.PictureBox.Size);
            _execute(resizeImage);
        }

        // TODO: region Implementation of IEventListener
        // Updates the current image being displayed
        public void OnImageEdited(object source, ImageModelEventArgs args)
        {
            // Check for new image data:
            if (args.image != null)
            {
                // Update the Image in picturePanel:
                PictureBox.Image = args.image;

                BWPictureBox.Image = args.image;
            }

            // Check for new size data:
            if (args.width != 0 || args.height != 0)
            {
                // Update the value of the NumsUpDown in the ToolsLayoutPanel:
                WidthNumUpDown.Value = args.width;
                HeightNumUpDown.Value = args.height;

            }
        }

        private void ImageViewer_Resize(object sender, EventArgs e)
        {
            // Call _resizeAction:
            ICommand resizeImage = new Command<Size>(_resizeAction, this.PictureBox.Size);
            _execute(resizeImage);
        }

        private void WidthNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            // Call _resizeAction:
            ICommand resizeImage = new Command<Size>(_resizeAction, new Size((int) WidthNumUpDown.Value, (int) HeightNumUpDown.Value));
            _execute(resizeImage);
        }

        private void HeightNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            // Call _resizeAction:
            ICommand resizeImage = new Command<Size>(_resizeAction, new Size((int) WidthNumUpDown.Value, (int) HeightNumUpDown.Value));
            _execute(resizeImage);
        }

        private void RotationTrackBar_ValueChanged(object sender, EventArgs e)
        {
            ICommand rotateImage = new Command<int>(_rotateAction, RotationTrackBar.Value);
            _execute(rotateImage);
        }

        private void FlipHorizontalButton_Click(object sender, EventArgs e)
        {
            ICommand flipImage = new Command<bool>(_flipAction, false);
            _execute(flipImage);
        }

        private void FlipVerticalButton_Click(object sender, EventArgs e)
        {
            ICommand flipImage = new Command<bool>(_flipAction, true);
            _execute(flipImage);
        }

        private void DisplayView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the editor?", "Close window", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _saveImage();
        }
    }
}
