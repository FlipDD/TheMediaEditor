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
        /// Constructor for objects of type FishyNote.
        /// </summary>
        /// <param name="execute">the command executor delegate</param>
        /// <param name="retrieveImage">action to be executed to retrieve an image</param>
        /// <param name="replaceText">action to be executed to replace the note text</param>
        /// <param name="retrieveText">action to be executed to retrieve note text</param>
        /// <param name="deleteMe">command to be executed to delete form</param>
        void Initialise(ExecuteDelegate execute, Action<Size> retrieveImage, Action<bool> flip, Action<int> rotate);
    }
}
