namespace Backend
{
    public interface IEditImageEventListener
    {
        void OnImageEdited(object source, ImageModelEventArgs args);
    }
}
