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
        /// <param name="methods"></param>
        /// <param name="save"></param>
        void Initialise(ExecuteDelegate execute, EditActions methods, Action save);
    }
}