using System.Collections.Generic;

namespace Backend
{
    /// <summary>
    /// ImageBrowser interface used to browse new images
    /// </summary>
    public interface IImageBrowser
    {
        /// <summary>
        /// Browse for new images with the Windows Explorer limiting the number and size of files a user can upload.
        /// </summary>
        /// <returns> A list of strings containing the path for each image selected</returns>
        IList<string> BrowseNewImages();
    }
}