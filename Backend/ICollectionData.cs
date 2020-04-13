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
        void InjectFactory(IServiceLocator locator);
        void AddControl(Image imageToAdd);

        IImageModel GetImageModel(int index);

        //TODO remove this
        void Subscribe(EventHandler<ImageAddedEventArgs> listener);
    }
}
