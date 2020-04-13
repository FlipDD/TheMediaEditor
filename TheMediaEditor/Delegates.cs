using System.Drawing;

namespace TheMediaEditor
{
    /// <summary>
    /// Declare a generic delegate with no parameters and no return value to implement Strategy Pattern, call it StrategyDelegate.
    /// </summary>
    public delegate void StrategyDelegate();

    /// <summary>
    /// Declare a delegate that is used to execute commands, call it ExecuteDelegate.
    /// </summary>
    /// <param name="command"></param>
    public delegate void ExecuteDelegate(ICommand command);

    /// <summary>
    /// Declare a delegate for browsing images, call it BrowseTextDelegate
    /// </summary>
    /// <returns>The note text</returns>
    public delegate void BrowseImagesDelegate();

    /// <summary>
    /// Declare a delegate for retrieving an image, call it RetrieveImageDelegate
    /// </summary>
    /// <param name="size">The size that the image should be scaled to</param>
    /// <returns>The note text</returns>
    public delegate void RetrieveImageDelegate(Size size);
}
