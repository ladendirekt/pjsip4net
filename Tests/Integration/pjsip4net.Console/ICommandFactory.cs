namespace pjsip4net.Console
{
    public interface ICommandFactory
    {
        ICommand Create(string cmd);
    }
}