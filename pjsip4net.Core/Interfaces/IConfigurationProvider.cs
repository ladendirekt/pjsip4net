namespace pjsip4net.Core.Interfaces
{
    /// <summary>
    /// An abstraction for external configuration provider.
    /// </summary>
    public interface IConfigurationProvider
    {
        void Configure(IConfigurationContext context);
    }
}