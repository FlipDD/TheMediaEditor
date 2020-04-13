using ImageProcessor;
using ImageProcessor.Imaging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    class ImageEditor : IImageEditor
    {
//        public Image CloneViaStream(Image image,
//       Func<TypeFromImageFactoryLoad, TypeForSaveCall> populateStream)
//        {
//            using (var imageFactory = new ImageFactory(preserveExifData: true))
//            {
//                using (var imageStream = new MemoryStream())
//                {
//                    TypeFromImageFactoryLoad loadResult = imageFactory.Load(image);
//                    TypeForSaveCall processResult = process(loadResult);
//                    processResult.Save(imageStream);

//                    imageStream.Position = 0;
//                    return Image.FromStream(imageStream);
//                }
//            }
//        }

//        var resultResize = CloneViaStream(image,
//     funcParam1 => funcParam1.Resize(new Size(width, height)));

//        var cropLayer = ...
//var resultCrop = CloneViaStream(image,
//     loadResult => loadResult.Crop(cropLayer)));


        /// <summary>
        /// Scale an image to fit specified size
        /// </summary>
        /// <param name="image">The original image to be scaled</param>
        /// <param name="size">The size required for the returned image</param>
        /// <returns>The scaled image</returns>
        public Image Resize(Image image, Size size)
        {
            // Create a Image to be returned after being scaled, call it resizedImage:
            Image resizedImage;

            // Create an ImageFactory to process the image, call it imageFactory:
            using (var imageFactory = new ImageFactory(preserveExifData: true))
            {
                // Create a MemoryStream to temporarily store the processed image, call it imageStream:
                using (var imageStream = new MemoryStream())
                {
                    // Scale the image using the ImageProcessor library
                    // Load the image to be resized, resize it and save it to the MemoryStream:
                    imageFactory.Load(image)
                                .Resize(size)
                                .Save(imageStream);

                    // Assign the processed image to the previously declared resizedImage:
                    resizedImage = Image.FromStream(imageStream);
                }
            }

            // Return the resized image:
            return resizedImage;
        }

        public static Func<Image, Size, Image> funcImageFactory = (image, size) =>
        {
            using (var imageFactory = new ImageFactory(preserveExifData: true))
            {
                // Create a MemoryStream to temporarily store the processed image, call it imageStream:
                using (var imageStream = new MemoryStream())
                {
                    // Scale the image using the ImageProcessor library
                    // Load the image to be resized, resize it and save it to the MemoryStream:
                    imageFactory.Load(image)
                                .Resize(size)
                                .Save(imageStream);
                    // Assign the processed image to the previously declared resizedImage:
                    var resizedImage = Image.FromStream(imageStream);
                    return resizedImage;
                }
            }
        };

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
        public Image Crop(Image image, float left, float top, float right, float bottom, bool isModePercentage = true)
        {
            // Create a Image to be returned after being cropped, call it croppedImage:
            Image croppedImage;

            // Create a CropMode to specify what cropping method to use (Percentage or Pixels), call it cropMode
            // If isModePercentage = true we use CropMode.Percentage, otherwise use CropMode.Pixels:
            var cropMode = isModePercentage ? CropMode.Percentage : CropMode.Pixels;

            // Create a CropLayer to specify how and how much the image should be cropped, call it cropLayer:
            var cropLayer = new CropLayer(left, top, right, bottom, cropMode);

            // Create an ImageFactory to process the image, call it imageFactory:
            using (ImageFactory imageFactory = new ImageFactory(preserveExifData: true))
            {
                // Create a MemoryStream to temporarily store the processed image, call it imageStream:
                using (MemoryStream imageStream = new MemoryStream())
                {
                    // Crop the image using the ImageProcessor library
                    // Load the image to be cropped, crop it and save it to the MemoryStream:
                    imageFactory.Load(image)
                                .Crop(cropLayer)
                                .Save(imageStream);

                    // Assign the processed image to the previously declared croppedImage:
                    croppedImage = Image.FromStream(imageStream);
                }
            }

            // Return the cropped image:
            return croppedImage;
        }

        /// <summary>
        /// Flips an image (horizontally or vertically)
        /// </summary>
        /// <param name="image">The original image to be flipped</param>
        /// <param name="flipVertically">If the image should be flipped vertically. Otherwise, flip it horizontally</param>
        /// <returns>The flipped image</returns>
        public Image Flip(Image image, bool flipVertically)
        {
            // Create a Image to be returned after being flipped, call it flippedImage:
            Image flippedImage;

            // Create an ImageFactory to process the image, call it imageFactory:
            using (ImageFactory imageFactory = new ImageFactory(preserveExifData: true))
            {
                // Create a MemoryStream to temporarily store the processed image, call it imageStream:
                using (MemoryStream imageStream = new MemoryStream())
                {
                    // Flip the image using the ImageProcessor library
                    // Load the image to be flipped, flip it and save it to the MemoryStream:
                    imageFactory.Load(image)
                                .Flip(flipVertically)
                                .Save(imageStream);

                    // Assign the processed image to the previously declared flippedImage:
                    flippedImage = Image.FromStream(imageStream);
                }
            }

            // Return the flipped image:
            return flippedImage;
        }

        /// <summary>
        /// Rotates an image
        /// </summary>
        /// <param name="image">The original image to be rotated</param>
        /// <param name="degrees">How much the image should be rotated (in degrees)</param>
        /// <returns>The rotated image</returns>
        public Image Rotate(Image image, int degrees)
        {
            // Create a Image to be returned after being flipped, call it flippedImage:
            Image rotatedImage;

            // Create an ImageFactory to process the image, call it imageFactory:
            using (ImageFactory imageFactory = new ImageFactory(preserveExifData: true))
            {
                // Create a MemoryStream to temporarily store the processed image, call it imageStream:
                using (MemoryStream imageStream = new MemoryStream())
                {
                    // Flip the image using the ImageProcessor library
                    // Load the image to be flipped, flip it and save it to the MemoryStream:
                    imageFactory.Load(image)
                                .Rotate(degrees)
                                .Save(imageStream);

                    // Assign the processed image to the previously declared flippedImage:
                    rotatedImage = Image.FromStream(imageStream);
                }
            }

            // Return the flipped image:
            return rotatedImage;
        }

        // TODO: Add filter images?
    }
}
