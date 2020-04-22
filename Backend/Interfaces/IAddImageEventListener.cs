namespace Backend
{
    /// <summary>
    /// An event listener. Listen to "ImageAdded" events
    /// </summary>
    public interface IAddImageEventListener
    {
        /// <summary>
        /// The event to listen to
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"> The argument containing the image added by the user </param>
        void OnImageAdded(object source, ImageAddedEventArgs args);
    }
}