﻿using ImageProcessor;
using System;
using System.Drawing;

namespace Backend
{
    public interface IImageEditor
    {
        /// <summary>
        /// Process an image (apply an edit)
        /// </summary>
        /// <param name="image">The original image to be processed</param>
        /// <param name="process">The image processing to apply (.Resize, .Rotate or .Flip)</param>
        /// <returns>The processed image</returns>
        Image ProcessImage(Image image, Func<ImageFactory, ImageFactory> process);
    }
}
