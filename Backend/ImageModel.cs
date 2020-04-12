using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    class ImageModel : IEventPublisher, IImageModel
    {
        // DECLARE a IServiceLocator to store a reference to the FactoryLocator, call it _factories:
        private IServiceLocator _factories;

        // DECLARE a List<String> to store a list of path+filename for all available image assets, call it _imageNames:
        private IList<String> _imageNames;

        // DECLARE a Dictionary<int,ImageData> to store all data in, call it _data:
        private IDictionary<int, ImageData> _data;

        // DECLARE an int to act as a circular counter index into _imageNames:
        private int _cCounter = 0;

        #region IMPLEMENTATION of INoteData
        /// <summary>
        /// Inject a reference to the factory locator service
        /// </summary>
        /// <param name="locator">The factory locator service</param>
        public void InjectFactory(IServiceLocator locator)
        {
            // Initialise _factories:
            _factories = locator;

            // Get reference to _data:
            _data = (_factories.Get<IDictionary<int, ImageData>>() as IFactory<IDictionary<int, ImageData>>).Create<Dictionary<int, ImageData>>();
        }

        /// <summary>
        /// Add a new note
        /// </summary>
        /// <param name="key">unique key of new note</param>
        public void AddItem(Image image)
        {
            // Add new element in _data with given key:
            int lastIndex = _data.Count - 1;
            _data.Add(lastIndex, (_factories.Get<ImageData>() as IFactory<ImageData>).Create<ImageData>());

            // Initialise new element:
            _data[lastIndex].Initialise(image,(_factories.Get<IImageEditor>() as IFactory<IImageEditor>).Create<ImageEditor>());

        }

        ///// <summary>
        ///// Retrieve the IImageData pointed to by key.
        ///// </summary>
        ///// <param name="key">The key to the IImageData</param>
        ///// <returns></returns>
        //public IImageData RetrieveItem(int key)
        //{
        //    return _data[key];
        //}
        #endregion

        #region IMPLEMENTATION of IEventPublisher
        /// <summary>
        /// Subscribe a listener to note events
        /// </summary>
        /// <param name="key">key to the note</param>
        /// <param name="listener">reference to the listener method</param>
        public void Subscribe(int key, EventHandler<ImageEventArgs> listener)
        {
            // Subscribe listener to _data[key]:
            (_data[key] as IInternalEventPublisher).Subscribe(listener);
        }

        /// <summary>
        /// Unsubscribe a listener from note events
        /// </summary>
        /// <param name="key">key to the note</param>
        /// <param name="listener">reference to the listener method</param>
        public void Unsubscribe(int key, EventHandler<ImageEventArgs> listener)
        {
            // Unsubscribe listener from _data[key]:
            (_data[key] as IInternalEventPublisher).Unsubscribe(listener);
        }
        #endregion

        #region Private methods
        private int CircularCounter(int maxValue)
        {
            _cCounter++;
            if (_cCounter == maxValue)
            {
                _cCounter = 0;
            }

            return _cCounter;
        }
        #endregion
    }
}
