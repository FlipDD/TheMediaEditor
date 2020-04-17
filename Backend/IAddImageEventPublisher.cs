using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
