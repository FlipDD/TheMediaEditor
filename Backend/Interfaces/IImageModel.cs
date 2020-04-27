using ImageProcessor.Imaging.Filters.Photo;
using System.Drawing;

namespace Backend
{
    /// <summary>
    /// Interface for the ImageModel
    /// </summary>
    public interface IImageModel
    {
        /// <summary>
        /// Constructor for objects of type ImageModel
        /// </summary>
        /// <param name="currentImage">The image associated with this model</param>
        /// <param name="imageEditor">The ImageEditor used to edit the image (Resize, Flip, Rotate)</param>
        /// <param name="imageSaver">The ImageSaver used to save the image to a specific path/filename</param>
        void Initialise(Image currentImage, IImageEditor imageEditor, IImageSaver imageSaver);

        /// <summary>
        /// Save an image to a user specified path/filename
        /// </summary>
        void SaveAs();
    }
}