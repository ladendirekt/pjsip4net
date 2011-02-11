namespace pjsip4net.Core.Interfaces
{
    /// <summary>
    /// An abstraction of services configurator.
    /// </summary>
    public interface IConfigureComponents
    {
        void Configure(IContainer container);
    }
}