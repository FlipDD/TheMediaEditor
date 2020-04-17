using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Backend
{
    public class ImageBrowser : IImageBrowser
    {
        /// <summary>
        /// Browse for new images with the Windows Explorer
        /// </summary>
        /// <returns> A list of strings containing the path for each image selected</returns>
        public IList<string> BrowseNewImages()
        {
            // Create the list of string used to store the selected images (file paths) selected:
            IList<string> filePaths = new List<string>();

            // Display a dialog box to prompt the user to select a file.
            // Create an instance with a using statement so it automatically
            // closes the stream and calls .Dispose(), which calls .Close():
            using (var fileDialog = new OpenFileDialog())
            {
                // Set the initial directory to look into
                string currentPath = Directory.GetCurrentDirectory();
                // Make it the one where the FishAssets are located:
                string newPath = Path.GetFullPath(Path.Combine(currentPath, @"..\..\FishAssets"));
                fileDialog.InitialDirectory = newPath;

                // Set the title of the File Dialog box:
                fileDialog.Title = "Select Images";

                // Filter the results to only allow specific file types:
                fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.btm, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.btm; *.png";

                // Enable multi select to allow multiple image selection:
                fileDialog.Multiselect = true;

                // If we selected Images, assign their paths to filePaths:
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePaths = fileDialog.FileNames;
                }

                // Return the list containing (or not) the file paths:
                return filePaths;
            }
        }
    }
}
