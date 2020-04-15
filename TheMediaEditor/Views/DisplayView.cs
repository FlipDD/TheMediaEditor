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

        public DisplayView()
        {
            InitializeComponent();
        }

        public void Initialise(ExecuteDelegate execute, Action<Size> retrieveImage, Action<bool> flip, Action<int> rotate)
        {
            // SET _execute:
            _execute = execute;

            _flip = flip;
            _rotate = rotate;
            _resize = retrieveImage;

            ICommand resizeImage = new Command<Size>(_resize, this.PicturePanel.Size);
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
                PicturePanel.BackgroundImage = args.image;
            }
        }

        private void ImageViewer_Resize(object sender, EventArgs e)
        {
            ICommand resizeImage = new Command<Size>(_resize, this.PicturePanel.Size);
            _execute(resizeImage);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {

        }

        private void CropButton_Click(object sender, EventArgs e)
        {

        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            ICommand rotateImage = new Command<int>(_rotate, RotationTrackBar.Value);
            _execute(rotateImage);
        }

        //private void FlipButton_Click(object sender, EventArgs e)
        //{
        //    ICommand flipImage = new Command<bool>(_flip, FlipCheckBox.Checked);
        //    _execute(flipImage);
        //}

        private void ScaleButton_Click(object sender, EventArgs e)
        {
            ICommand resizeImage = new Command<Size>(_resize, this.PicturePanel.Size);
            _execute(resizeImage);
        }

        private void RotationTrackBar_ValueChanged(object sender, EventArgs e)
        {
            ICommand rotateImage = new Command<int>(_rotate, RotationTrackBar.Value);
            _execute(rotateImage);
        }
    }
}
