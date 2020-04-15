using ImageProcessor;
using ImageProcessor.Imaging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    class ImageEditor : IImageEditor
    {
        public Image ProcessImage(Image image, Func<ImageFactory, ImageFactory> process)
        {
            using (var imageFactory = new ImageFactory(preserveExifData: true))
            {
                using (var imageStream = new MemoryStream())
                {
                    ImageFactory loadResult = imageFactory.Load(image);
                    ImageFactory processResult = process(loadResult);
                    processResult.Save(imageStream);

                    imageStream.Position = 0;
                    return Image.FromStream(imageStream);
                }
            }
        }
    }
}
