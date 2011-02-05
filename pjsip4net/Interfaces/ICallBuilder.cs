namespace pjsip4net.Interfaces
{
    public interface ICallBuilder
    {
        ICallBuilder To(string extension);
        ICallBuilder At(string domain);
        ICallBuilder Through(string port);
        ICallBuilder From(IAccount account);
        ICall Call();
    }
}