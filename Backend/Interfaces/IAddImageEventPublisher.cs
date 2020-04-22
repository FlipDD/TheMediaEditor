using System;

namespace Backend
{
    /// <summary>
    /// An event publisher. Allows subscription to ImageAdded events
    /// </summary>
    public interface IAddImageEventPublisher
    {
        /// <summary>
        /// Subscribe a listener to added image events
        /// </summary>
        /// <param name="listener">reference to the listener method</param>
        void Subscribe(EventHandler<ImageAddedEventArgs> listener);
    }
}