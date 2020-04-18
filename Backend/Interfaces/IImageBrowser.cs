using System.Collections.Generic;

namespace Backend
{
    public interface IImageBrowser
    {
        /// <summary>
        /// Browse for new images with the Windows Explorer limiting the number and size of files a user can upload.
        /// </summary>
        /// <returns> A list of strings containing the path for each image selected</returns>
        IList<string> BrowseNewImages();
    }
}
