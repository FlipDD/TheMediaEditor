using System.Drawing;

namespace Backend
{
    /// <summary>
    /// Interface for CollectionData
    /// </summary>
    public interface ICollectionData
    {
        /// <summary>
        /// Inject a reference to the factory locator service
        /// </summary>
        /// <param name="locator">The factory locator service</param>
        void InjectFactory(IServiceLocator locator);

        /// <summary>
        /// Adds a new control (Form.Panel)
        /// </summary>
        /// <param name="imageToAdd">The image to set as the panel's image</param>
        void AddControl(Image imageToAdd);

        /// <summary>
        /// Browse for new images 
        /// </summary>
        void BrowseImages();

        /// <summary>
        /// Get the value in the Dictionary ImageModel by proving the key
        /// </summary>
        /// <param name="index">The key in the Dictionary</param>
        /// <returns>The ImageModel in the Dictionary</returns>
        IImageModel GetImageModel(int index);
    }
}