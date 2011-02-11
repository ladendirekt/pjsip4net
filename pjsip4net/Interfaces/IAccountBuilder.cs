namespace pjsip4net.Interfaces
{
    /// <summary>
    /// Provides fluent API for account creation.
    /// </summary>
    public interface IAccountBuilder
    {
        /// <summary>
        /// Sets a name of account to register with.
        /// </summary>
        /// <remarks>Similar to e-mail extension.</remarks>
        IAccountBuilder WithExtension(string extension);
        /// <summary>
        /// Sets a password to register with.
        /// </summary>
        IAccountBuilder WithPassword(string password);
        /// <summary>
        /// Name of sip registrar domain.
        /// </summary>
        /// <remarks>Similar to e-mail domain.</remarks>
        IAccountBuilder At(string domain);
        /// <summary>
        /// Network port to connect to.
        /// </summary>
        IAccountBuilder Through(string port);
        /// <summary>
        /// Signalling transport to use to connect to server.
        /// </summary>
        IAccountBuilder Via(IVoIPTransport transport);
        /// <summary>
        /// Mark this account as default for user agent.
        /// </summary>
        IAccountBuilder Default();
        /// <summary>
        /// Publish presence after account registered.
        /// </summary>
        IAccountBuilder PublishingPresence();
        /// <summary>
        /// Set registration timeout.
        /// </summary>
        /// <param name="registrationTimeout"></param>
        IAccountBuilder WithRegistrationTimeout(uint registrationTimeout);
        /// <summary>
        /// Go-go gadget account.
        /// </summary>
        IAccount Register();
    }
}