﻿using ImageProcessor;
using System;
using System.Drawing;
using System.IO;

namespace Backend
{
    class ImageEditor : IImageEditor
    {
        /// <summary>
        /// Process an image (apply an edit)
        /// </summary>
        /// <param name="image">The original image to be processed</param>
        /// <param name="process">The image processing to apply (.Resize, .Rotate or .Flip)</param>
        /// <returns>The processed image</returns>
        public Image ProcessImage(Image image, Func<ImageFactory, ImageFactory> process)
        {
            // Create an ImageFactory to process the image, call it imageFactory:
            using (var imageFactory = new ImageFactory(preserveExifData: true))
            {
                // Create a MemoryStream to temporarily store the processed image, call it imageStream:
                using (var imageStream = new MemoryStream())
                {
                    // Create an ImageFactory to store the result of loading:
                    ImageFactory loadResult = imageFactory.Load(image);
                    // Create an ImageFactory to store the result of the processing
                    // the process() will be a Func delegate that receives and returns an
                    // ImageFactory, which will be use to call the specified processing method:
                    ImageFactory processResult = process(loadResult);

                    // Save the result into the stream:
                    processResult.Save(imageStream);

                    // Return the processed image
                    return Image.FromStream(imageStream);
                }
            }
        }
    }
}
