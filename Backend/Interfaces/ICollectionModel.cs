using System.Drawing;
using System.Windows.Forms;

namespace Backend
{
    /// <summary>
    /// Interface for CollectionModel
    /// </summary>
    public interface ICollectionModel
    {
        /// <summary>
        /// Inject a reference to the factory locator service
        /// </summary>
        /// <param name="locator">The factory locator service</param>
        void InjectFactory(IServiceLocator locator);

        /// <summary>
        /// Get the value in the Dictionary ImageModel by proving the key
        /// </summary>
        /// <param name="index">The key in the Dictionary</param>
        /// <returns>The ImageModel in the Dictionary</returns>
        IImageModel GetImageModel(int index);

        /// <summary>
        /// Browse for new images 
        /// </summary>
        void BrowseImages();

        /// <summary>
        /// Add a new image model  
        /// </summary>
        /// <param name="imageToAdd">The image to send as a parameter to the model</param>
        void AddImageModel(Image imageToAdd);

        /// <summary>
        /// Add a panel control to the flow panel 
        /// </summary>
        /// <param name="panelImage">The image to add as the panels' background image</param>
        /// <param name="tag">The tag to give to the panel</param>
        /// <returns>The created panel</returns>
        Panel SetupNewPanel(Image panelImage, int tag);
    }
}