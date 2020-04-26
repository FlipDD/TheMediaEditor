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
        /// <param name="resize"></param>
        /// <param name="flip"></param>
        /// <param name="rotate"></param>
        /// <param name="filterOriginal"></param>
        /// <param name="filterBlackWhite"></param>
        /// <param name="filterComic"></param>
        /// <param name="filterLomo"></param>
        /// <param name="filterSepia"></param>
        /// <param name="filterInvert"></param>
        /// <param name="reset"></param>
        /// <param name="save"></param>
        void Initialise(ExecuteDelegate execute, Action<Size> resize, Action<bool> flip, Action<int> rotate,
           StrategyDelegate filterOriginal, StrategyDelegate filterBlackWhite, StrategyDelegate filterComic,
           StrategyDelegate filterLomo, StrategyDelegate filterSepia, StrategyDelegate filterInvert,
           StrategyDelegate reset, StrategyDelegate save);
    }
}