using AutoMapper;
using Magnum.Pipeline;
using Magnum.Pipeline.Segments;
using pjsip.Interop.ApiProviders;
using pjsip.Interop.Interfaces;
using pjsip.Interop.Services;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;

namespace pjsip.Interop
{
// ReSharper disable InconsistentNaming
    public class Version_1_4_ComponentConfigurator : IConfigureApi
// ReSharper restore InconsistentNaming
    {
        #region Implementation of IConfigureComponents

        public void Configure(IContainer container)
        {
            Helper.GuardNotNull(container);
            RegisterApplicationServices(container);
            RegisterMappingServices(container);
            RegisterVoIPServices(container);
        }

        #endregion

        private void RegisterApplicationServices(IContainer container)
        {
            var pipe = PipeSegment.Input(PipeSegment.End());
            container.RegisterAsSingleton((Pipe)pipe);
            container.RegisterAsSingleton<IEventsProvider, EventsProvider>();
        }

        private void RegisterMappingServices(IContainer container)
        {
            container
                .RegisterAsSingleton(Mapper.Engine)
                .RegisterAsSingleton<IMapper, AutoMappingMapper>();
        }

        private void RegisterVoIPServices(IContainer container)
        {
            container.RegisterAsSingleton<IBasicApiProvider, BasicApiProvider_1_4>()
                .RegisterAsSingleton<IAccountApiProvider, AccountApiProvider_1_4>()
                .RegisterAsSingleton<ITransportApiProvider, TransportApiProvider_1_4>()
                .RegisterAsSingleton<ICallApiProvider, CallApiProvider_1_4>()
                .RegisterAsSingleton<IIMApiProvider, ImApiProvider_1_4>()
                .RegisterAsSingleton<IMediaApiProvider, MediaApiProvider_1_4>();
        }
    }
}