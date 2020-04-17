namespace Backend
{
    public interface IServiceLocator
    {
        /// <summary>
        /// Return a concrete factory for creating a given Type.
        /// </summary>
        /// <typeparam name="T">The type of the abstraction (ie abstract class or interface) of the required factory</typeparam>
        /// <returns></returns>
        IService Get<T>() where T : class;
    }
}
