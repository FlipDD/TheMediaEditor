using System.Drawing;

namespace Backend
{
    public interface IImageEditor
    {
        /// <summary>
        /// Scale an image to fit specified size
        /// </summary>
        /// <param name="image">The original image to be scaled</param>
        /// <param name="size">The size required for the returned image</param>
        /// <returns>The scaled image</returns>
        Image Resize(Image image, Size size);

        /// <summary>
        /// Crop an image
        /// </summary>
        /// <param name="image">The original image to be cropped</param>
        /// <param name="left">How much to cut on the left side of the image</param>
        /// <param name="top">How much to cut on the top side of the image</param>
        /// <param name="right">How much to cut on the right side of the image</param>
        /// <param name="bottom">How much to cut on the bottom side of the image</param>
        /// <param name="isModePercentage">Which cropping mode we should use. By default it'll be percentage mode (as opposed to pixel)</param>
        /// <returns>The cropped image</returns>
        Image Crop(Image image, float left, float top, float right, float bottom, bool isModePercentage = true);

        /// <summary>
        /// Flips an image (horizontally or vertically)
        /// </summary>
        /// <param name="image">The original image to be flipped</param>
        /// <param name="flipVertically">If the image should be flipped vertically. Otherwise, flip it horizontally.</param>
        /// <returns>The flipped image</returns>
        Image Flip(Image image, bool flipVertically);
    }
}
