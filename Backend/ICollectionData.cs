using System;
using System.Drawing;

namespace Backend
{
    public interface ICollectionData
    {
        void InjectFactory(IServiceLocator locator);
        void AddControl(Image imageToAdd);

        void BrowseImages();

        IImageModel GetImageModel(int index);
    }
}
