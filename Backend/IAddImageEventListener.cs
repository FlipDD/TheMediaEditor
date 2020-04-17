namespace Backend
{
    public interface IAddImageEventListener
    {
        void OnImageAdded(object source, ImageAddedEventArgs args);
    }
}
