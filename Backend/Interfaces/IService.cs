namespace Backend
{
    /// <summary>
    /// Most abstract abstraction of a service, so they can be kept together in a single container.  Client will need to downcast to required type. 
    /// </summary>
    public interface IService
    {
        // does nothing, downcast to an implementing interface.
    }
}