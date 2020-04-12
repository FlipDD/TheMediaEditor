using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backend
{
    public class ImageBrowser : IImageBrowser
    {
        /// <summary>
        /// Browse for new images with the Windows Explorer
        /// </summary>
        /// <returns>a vector of strings containing the path for each image selected</returns>
        public IList<string> BrowseNewImages()
        {
            // Display a dialog box to prompt the user to select a file.
            // Create an instance with a using statement so it automatically
            // closes the stream and calls .Dispose(), which calls .Close().
            using (var fileDialog = new OpenFileDialog())
            {
                // Set the initial directory to look into
                string currentPath = Directory.GetCurrentDirectory();
                // Make it the one where the FishAssets are located.
                string newPath = Path.GetFullPath(Path.Combine(currentPath, @"..\..\FishAssets"));
                fileDialog.InitialDirectory = newPath;

                // Set the title of the File Dialog box
                fileDialog.Title = "Select Images";

                // Filter the results to only allow specific file types
                fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.btm, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.btm; *.png";

                // Enable multi select to allow multiple image selection
                fileDialog.Multiselect = true;

                // If we picked some Images, return them
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    return fileDialog.FileNames;
                }

                return null;
            }
        }
    }
}
