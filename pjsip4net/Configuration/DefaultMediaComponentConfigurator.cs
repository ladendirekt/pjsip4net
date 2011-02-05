using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;
using pjsip4net.Media;

namespace pjsip4net.Configuration
{
    public class DefaultMediaComponentConfigurator : IConfigureComponents
    {
        public void Configure(IContainer container)
        {
            Helper.GuardNotNull(container);
            container.RegisterAsSingleton<IConferenceBridge, DefaultConferenceBridge>();
            container.RegisterAsSingleton<IMediaManager, DefaultMediaManager>();
            container.RegisterAsSingleton(container.Get<IMediaManager>() as IMediaManagerInternal);
            container.Register<CodecInfo, CodecInfo>();
            container.Register<WavPlayer, WavPlayer>();
        }
    }
}