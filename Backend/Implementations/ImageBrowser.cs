using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Backend
{
    /// <summary>
    /// Class ImageBrowser used to browse for new images and limit how many images are added
    /// </summary>
    public class ImageBrowser : IImageBrowser
    {
        // DECLARE a constant string to be used in a MessageBox if the application is occupying to much memory, call it __processTooBigMessage:
        private const string _processTooBigMessage = "You can't add any more images! The images added are " +
            "occupying too much space in memory. Consider using smaller images or adding less next time.";

        // DECLARE a constant string to be used to limit the type of files (images) a user can search for, call it _filterTypes:
        private const string _filterTypes = "Image files (*.jpg, *.jpeg, *.gif, *.bmp, *.png) | *.jpg; *.jpeg; *.gif; *.bmp; *.png";

        // DECLARE a constant string to be used in a MessageBox in case the files selected exceed 30MB, call it _filesTooBigMessage:
        private const string _filesTooBigMessage = "The files selected are more than 30MB. Please select smaller files or less at a time";

        /// <summary>
        /// Browse for new images with the Windows Explorer limiting the number and size of files a user can upload.
        /// </summary>
        /// <returns> A list of strings containing the path for each image selected</returns>
        public IList<string> BrowseNewImages()
        {
            // Create and initialise the list of strings used to store the selected images (file paths) selected:
            IList<string> filePaths = new List<string>();

            // Make sure the program is not occupying too much memory in RAM
            // Create a Process and set it to the currently active process:
            var currentProc = Process.GetCurrentProcess();
            // Create a float and set it to the current memory being occupied, in Megabytes (divide by 1000000):
            var processSize = currentProc.PrivateMemorySize64 / 1000000f;

            // If the processSize is bigger than 4GB:
            if (processSize > 4000)
            {
                // Show a MessageBox warning the user that he added too many (or too big) images:
                MessageBox.Show(_processTooBigMessage);

                // Return the empty list, don't go any further in the method:
                return filePaths;
            }

            // Display a dialog box to prompt the user to select a file.
            // Create an instance with a using statement so it automatically
            // closes the stream and calls .Dispose(), which calls .Close():
            using (var fileDialog = new OpenFileDialog())
            {
                // Set the initial directory to look into
                var currentPath = Directory.GetCurrentDirectory();
                // Make it the one where the FishAssets are located:
                var newPath = Path.GetFullPath(Path.Combine(currentPath, @"..\..\FishAssets"));
                fileDialog.InitialDirectory = newPath;

                // Set the title of the File Dialog box:
                fileDialog.Title = "Select Images";

                // Filter the results to only allow specific file types:
                fileDialog.Filter = _filterTypes;

                // Enable multi select to allow multiple image selection:
                fileDialog.Multiselect = true;

                // If we selected Images, assign their paths to filePaths:
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    // IEnumerable<long> to store the size of each file:
                    var filesSize = fileDialog.FileNames.Select(file => new FileInfo(file).Length);
                    // Float to store the size in Megabytes (divide by 1e+6):
                    var filesSizeSum = filesSize.Sum() / 1000000f;

                    // Show a message box if the size of all files selected exceed 20MB. Don't assign it to the filePaths list if they do:
                    if (filesSizeSum > 30)
                        MessageBox.Show(_filesTooBigMessage);
                    // Assign the list of file paths to filePaths:
                    else
                        filePaths = fileDialog.FileNames;
                }

                // Return the list containing (or not, if there was a problem) the file paths:
                return filePaths;
            }
        }
    }
}
