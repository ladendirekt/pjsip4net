using System;
using pjsip.Interop.Interfaces;
using pjsip4net.Core;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;

namespace pjsip.Interop.ApiProviders
{
    public class TransportApiProvider_1_4 : ITransportApiProvider
    {
        private IMapper _mapper;

        public TransportApiProvider_1_4(IMapper mapper)
        {
            Helper.GuardNotNull(mapper);
            _mapper = mapper;
        }

        #region Implementation of ITransportApiProvider

        public TransportConfig GetDefaultConfig()
        {
            var cfg = new pjsua_transport_config();
            PJSUA_DLL.Transport.pjsua_transport_config_default(cfg);
            return _mapper.Map(cfg, new TransportConfig());
        }

        public int CreateTransportAndGetId(TransportType type, TransportConfig cfg)
        {
            int id = NativeConstants.PJSUA_INVALID_ID;
            Helper.GuardError(PJSUA_DLL.Transport.pjsua_transport_create(type.ToPjSipTransportType(),
                                                                         _mapper.Map(cfg, new pjsua_transport_config()),
                                                                         ref id));
            return id;
        }

        public TransportInfo GetTransportInfo(int id)
        {
            var info = new pjsua_transport_info();
            Helper.GuardError(PJSUA_DLL.Transport.pjsua_transport_get_info(id, info));
            return _mapper.Map(info);
        }

        public void CloseTransport(int id)
        {
            Helper.GuardError(PJSUA_DLL.Transport.pjsua_transport_close(id, 0));
        }

        public void ForceCloseTransport(int id)
        {
            Helper.GuardError(PJSUA_DLL.Transport.pjsua_transport_close(id, 1));
        }

        #endregion
    }
}