using System;
using System.Drawing;

namespace TheMediaEditor
{
    /// <summary>
    /// Interface for the DisplayView form containing the constructor
    /// </summary>
    public interface IDisplayView
    {
        /// <summary>
        /// Constructor for objects of type DisplayView
        /// </summary>
        /// <param name="execute"></param>
        /// <param name="retrieveImage"></param>
        /// <param name="flip"></param>
        /// <param name="rotate"></param>
        void Initialise(ExecuteDelegate execute, Action<Size> resize, Action<bool> flip, Action<int> rotate, StrategyDelegate reset, StrategyDelegate save);
    }
}