using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class CollectionData : ICollectionData
    {
        private IDictionary<int, Image> _currentImages = new Dictionary<int, Image>();

        public event EventHandler<ImageAddedEventArgs> ImageAdded;

        public void AddImage(Image imageToAdd)
        {
            int index = _currentImages.Count;
            _currentImages.Add(index, imageToAdd);

            OnImageAdded(index - 1, imageToAdd);
        }

        protected virtual void OnImageAdded(int index, Image imageAdded)
        {
            if (ImageAdded != null)
                ImageAdded(this, new ImageAddedEventArgs(index, imageAdded));
        }

        public void Subscribe(EventHandler<ImageAddedEventArgs> listener)
        {
            ImageAdded += listener;
        }
    }
}
