using System;

namespace Backend
{
    public interface IAddImageEventPublisher
    {
        /// <summary>
        /// Subscribe a listener to added image events
        /// </summary>
        /// <param name="listener">reference to the listener method</param>
        void Subscribe(EventHandler<ImageAddedEventArgs> listener);
    }
}
