using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public interface IEventPublisher
    {
        /// <summary>
        /// Subscribe a listener to note events
        /// </summary>
        /// <param name="key">key to the note</param>
        /// <param name="listener">reference to the listener method</param>
        void Subscribe(int key, EventHandler<ImageEventArgs> listener);

        /// <summary>
        /// Unsubscribe a listener from note events
        /// </summary>
        /// <param name="key">key to the note</param>
        /// <param name="listener">reference to the listener method</param>
        void Unsubscribe(int key, EventHandler<ImageEventArgs> listener);
    }
}
