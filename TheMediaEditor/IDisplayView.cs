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
        /// <param name="execute">The execute delegate - used to execute commands</param>
        /// <param name="methods">The actions that perform any kind of image processing</param>
        /// <param name="save">The action for saving the image</param>
        void Initialise(ExecuteDelegate execute, EditActions methods, Action save);
    }
}