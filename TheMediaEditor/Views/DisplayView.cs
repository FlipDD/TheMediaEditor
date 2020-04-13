using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheMediaEditor
{
    public partial class DisplayView : Form, IDisplayView
    {
        // DECLARE a ExecuteDelegate to store the delegate to be called to issue a command:
        private ExecuteDelegate _execute;

        public DisplayView()
        {
            InitializeComponent();
        }

        public void Initialise(ExecuteDelegate execute, Action<Size> retrieveImage)
        {
            // SET _execute:
            _execute = execute;

            // REQUEST image:
            ICommand getImage = new Command<Size>(retrieveImage, this.PicturePanel.Size);
            _execute(getImage);
        }

        private void ImageViewer_Resize(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
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

        private void FlipButton_Click(object sender, EventArgs e)
        {

        }

        private void ScaleButton_Click(object sender, EventArgs e)
        {

        }

        private void RotateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
