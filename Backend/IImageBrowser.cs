using System.Collections.Generic;

namespace Backend
{
    public interface IImageBrowser
    {
        /// <summary>
        /// Browse for new images with the Windows Explorer
        /// </summary>
        /// <returns>The path for each of the images selected</returns>
        IList<string> BrowseNewImages();
    }
}
