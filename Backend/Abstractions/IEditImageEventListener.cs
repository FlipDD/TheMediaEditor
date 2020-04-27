namespace Backend
{
    /// <summary>
    /// An event listener. Listen to "ImageModel" events
    /// </summary>
    public interface IEditImageEventListener
    {
        /// <summary>
        /// The event to listen to
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"> The argument containing the image edited by the user and some of the editing parameters</param>
        void OnImageEdited(object source, ImageModelEventArgs args);
    }
}