namespace pjsip4net.Interfaces
{
    public interface IAccountBuilder
    {
        IAccountBuilder WithExtension(string extension);
        IAccountBuilder WithPassword(string password);
        IAccountBuilder At(string domain);
        IAccountBuilder Through(string port);
        IAccountBuilder Via(IVoIPTransport transport);
        IAccountBuilder Default();
        IAccountBuilder PublishingPresence();
        IAccountBuilder WithRegistrationTimeout(uint registrationTimeout);
        IAccount Register();
    }
}