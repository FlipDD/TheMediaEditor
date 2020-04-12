using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    class ImageData : IInternalEventPublisher
    {
        // DECLARE a Image to store an images in, call it _image:
        private Image _image;

        // DECLARE an IImageEditor, call it _imageEditor:
        private IImageEditor _imageEditor;

        // DECLARE an event for storing note event handlers, call it _imageEvent:
        private event EventHandler<ImageEventArgs> _imageEvent;

        #region Implementation of IDataElement
        public void Initialise(Image image, IImageEditor imageEditor)
        {
            // Assign parameters to data:
            _image = image;
            _imageEditor = imageEditor;
        }

        /// <summary>
        /// Retrieve the image, scaled to a specific size.
        /// </summary>
        /// <param name="rqdImageSize">The required size that the returned image should be scaled to</param>
        /// <returns>The image</returns>
        public void FlipImage(bool flip)
        {
            // SCALE _image and fire event:
            OnNewImageInput(_imageEditor.Flip(_image, true));
        }
        #endregion

        #region Implementation of IEventPublisher
        /// <summary>
        /// Subscribe a listener to note events
        /// </summary>
        /// <param name="listener">reference to the listener method</param>
        public void Subscribe(EventHandler<ImageEventArgs> listener)
        {
            _imageEvent += listener;
        }

        /// <summary>
        /// Unsubscribe a listener from note events
        /// </summary>
        /// <param name="listener">reference to the listener method</param>
        public void Unsubscribe(EventHandler<ImageEventArgs> listener)
        {
            _imageEvent -= listener;
        }
        #endregion

        #region Implementation of IDisposable
        public void Dispose()
        {
            // Manually dispose of _image:
            _image.Dispose();
        }
        #endregion

        #region private methods
        /// <summary>
        /// Called when a new image input is received
        /// </summary>
        /// <param name="data"></param>
        private void OnNewImageInput(Image data)
        {
            ImageEventArgs imageArgs = new ImageEventArgs(data);
            _imageEvent(this, imageArgs);
        }
        #endregion
    }
}
