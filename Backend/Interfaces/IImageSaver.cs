using System.Drawing;

namespace Backend
{
    /// <summary>
    /// Interface for the ImageSaver used to save images to files
    /// </summary>
    public interface IImageSaver
    {
        /// <summary>
        /// Saves an image to a specified path with limited file type options.
        /// </summary>
        /// <param name="imageToSave"> The image to be saved </param>
        void SaveImage(Image imageToSave);
    }
}