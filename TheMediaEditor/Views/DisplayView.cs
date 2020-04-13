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

        public DisplayView()
        {
            InitializeComponent();
        }

        public void Initialise(ExecuteDelegate execute, Action<Size> retrieveImage, Action<bool> flip, Action<int> rotate)
        {
            // SET _execute:
            _execute = execute;

            // REQUEST image:
            ICommand getImage = new Command<Size>(retrieveImage, this.PicturePanel.Size);
            _execute(getImage);

            _flip = flip;
            _rotate = rotate;
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
            //throw new NotImplementedException();
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
            ICommand rotate = new Command<int>(_rotate, RotationTrackBar.Value);
            _execute(rotate);
        }

        private void FlipButton_Click(object sender, EventArgs e)
        {
            ICommand flip = new Command<bool>(_flip, FlipCheckBox.Checked);
            _execute(flip);
        }

        private void ScaleButton_Click(object sender, EventArgs e)
        {

        }
    }
}
