using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public interface ICollectionData
    {
        void AddImage(Image imageToAdd);

        //TODO remove this
        void Subscribe(EventHandler<ImageAddedEventArgs> listener);
    }
}
