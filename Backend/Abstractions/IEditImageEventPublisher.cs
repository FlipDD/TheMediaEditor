using System;

namespace Backend
{
    /// <summary>
    /// An event publisher. Allows subscription to ImageModel events (editing images and those parameters)
    /// </summary>
    public interface IEditImageEventPublisher
    {
        /// <summary>
        /// Subscribe a listener to image events
        /// </summary>
        /// <param name="listener">reference to the listener method</param>
        void Subscribe(EventHandler<ImageModelEventArgs> listener);
    }
}