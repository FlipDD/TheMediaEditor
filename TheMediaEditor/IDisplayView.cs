using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMediaEditor
{
    public interface IDisplayView
    {
        /// <summary>
        /// Constructor for objects of type DisplayView
        /// </summary>
        /// <param name="execute"></param>
        /// <param name="retrieveImage"></param>
        /// <param name="flip"></param>
        /// <param name="rotate"></param>
        void Initialise(ExecuteDelegate execute, Action<Size> retrieveImage, Action<bool> flip, Action<int> rotate, Action<int> filter, StrategyDelegate save);
    }
}
