using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Backend
{
    /// <summary>
    /// Class ImageSaver, used to save Drawing.Image to a specific path
    /// </summary>
    class ImageSaver : IImageSaver
    {
        // DECLARE a constant string to be used to limit the type of files (images) a user can save as, call it _fileTypes:
        private const string _fileTypes = "Png Image (.png)|*.png|Bitmap Image (.bmp)|*.bmp|JPEG Image (.jpeg)|*.jpeg|Gif Image (.gif)|*.gif";

        /// <summary>
        /// Saves an image to a specified path with limited file type options.
        /// </summary>
        /// <param name="imageToSave"> The image to be saved </param>
        public void SaveImage(Image imageToSave)
        {
            // Display a dialog box to prompt the user to save the image
            // Create an instance with a using statement (try/finally type)
            using (var saveDialog = new SaveFileDialog())
            {
                // Filter the results to only allow specific file types:
                saveDialog.Filter = _fileTypes;

                // Set the initial directory to look into, make it the user's Desktop:
                saveDialog.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);

                // Ask for confirmation in case the user trying to overwrite another file with this saving method:
                saveDialog.OverwritePrompt = true;

                // If the user saved an image:
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Check which type of file the user saved it to:
                    switch (saveDialog.FilterIndex)
                    {
                        // If the user selected the PNG file type, save it as a PNG:
                        case 1:
                            imageToSave.Save(saveDialog.FileName, ImageFormat.Png);
                            break;
                        // If the user selected the BMP file type, save it as a BMP:
                        case 2:
                            imageToSave.Save(saveDialog.FileName, ImageFormat.Bmp);
                            break;
                        // If the user selected the JPEG file type, save it as a JPEG:
                        case 3:
                            imageToSave.Save(saveDialog.FileName, ImageFormat.Jpeg);
                            break;
                        // If the user selected the GIF file type, save it as a GIF:
                        case 4:
                            imageToSave.Save(saveDialog.FileName, ImageFormat.Gif);
                            break;
                    }
                }
            }
        }
    }
}