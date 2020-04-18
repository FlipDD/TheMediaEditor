using System;

namespace Backend
{
    public interface IEditImageEventPublisher
    {
        /// <summary>
        /// Subscribe a listener to image events
        /// </summary>
        /// <param name="listener">reference to the listener method</param>
        void Subscribe(EventHandler<ImageModelEventArgs> listener);

        /// <summary>
        /// Unsubscribe a listener from image events
        /// </summary>
        /// <param name="listener">reference to the listener method</param>
        void Unsubscribe(EventHandler<ImageModelEventArgs> listener);
    }
}
