using pjsip4net.Core.Interfaces;

namespace pjsip4net.Core.Configuration
{
    public class CoreComponentConfigurator : IConfigureComponents
    {
        public void Configure(IContainer container)
        {
            container.RegisterAsSingleton<IEventsProvider, EventsProvider>();
        }
    }
}