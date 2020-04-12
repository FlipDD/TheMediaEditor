using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    interface IInternalEventPublisher
    {
        /// <summary>
        /// Subscribe a listener to note events
        /// </summary>
        /// <param name="listener">reference to the listener method</param>
        void Subscribe(EventHandler<ImageEventArgs> listener);

        /// <summary>
        /// Unsubscribe a listener from note events
        /// </summary>
        /// <param name="listener">reference to the listener method</param>
        void Unsubscribe(EventHandler<ImageEventArgs> listener);
    }
}
