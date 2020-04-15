using Backend;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheMediaEditor
{
    public partial class DisplayView : Form, IDisplayView
    {
        // DECLARE a ExecuteDelegate to store the delegate to be called to issue a command:
        private ExecuteDelegate _execute;

        private Action<bool> _flip;

        private Action<int> _rotate;

        private Action<Size> _resize;
        
        private Action<int, int, int, int> _crop;

        public DisplayView()
        {
            InitializeComponent();
        }

        public void Initialise(ExecuteDelegate execute, Action<Size> resize, Action<bool> flip, Action<int> rotate)
        {
            // SET _execute:
            _execute = execute;

            _resize = resize;
            _flip = flip;
            _rotate = rotate;

            ICommand resizeImage = new Command<Size>(_resize, this.PictureBox.Size);
            _execute(resizeImage);
        }

        // TODO: region Implementation of IEventListener
        // Updates the current image being displayed
        public void OnImageChanged(object source, ImageModelEventArgs args)
        {
            // Check for new image data:
            if (args.image != null)
            {
                // Update the Image in picturePanel:
                PictureBox.Image = args.image;
            }

            if (args.width != 0)
                WidthNumUpDown.Value = args.width;
            if (args.height != 0)
                HeightNumUpDown.Value = args.height;
        }

        public void OnScaleChanged(object source, ImageModelEventArgs args)
        {
            //if (args.width != 0)
            //    WidthNumUpDown.Value = args.width;
            //if (args.height != 0)
            //    HeightNumUpDown.Value = args.height;
        }

        public void OnCropChanged(object source, ImageModelEventArgs args)
        {
            if (args.width != 0)
                WidthNumUpDown.Value = args.width;
            if (args.height != 0)
                HeightNumUpDown.Value = args.height;
        }

        private void ImageViewer_Resize(object sender, EventArgs e)
        {
            ICommand resizeImage = new Command<Size>(_resize, this.PictureBox.Size);
            _execute(resizeImage);
        }

        private void WidthNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            ICommand resizeImage = new Command<Size>(_resize, new Size((int)WidthNumUpDown.Value, (int)HeightNumUpDown.Value));
            _execute(resizeImage);
        }

        private void HeightNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            ICommand resizeImage = new Command<Size>(
                _resize, new Size(
                (int) WidthNumUpDown.Value,
                (int) HeightNumUpDown.Value));
            _execute(resizeImage);
        }

        private void RotationTrackBar_ValueChanged(object sender, EventArgs e)
        {
            ICommand rotateImage = new Command<int>(_rotate, RotationTrackBar.Value);
            _execute(rotateImage);
        }

        private void FlipHorizontalButton_Click(object sender, EventArgs e)
        {
            ICommand flipImage = new Command<bool>(_flip, false);
            _execute(flipImage);
        }

        private void FlipVerticalButton_Click(object sender, EventArgs e)
        {
            ICommand flipImage = new Command<bool>(_flip, true);
            _execute(flipImage);
        }
    }
}
