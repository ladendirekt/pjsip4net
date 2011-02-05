namespace pjsip4net.Interfaces
{
    public interface IObjectFactory
    {
        T Create<T>();
    }
}