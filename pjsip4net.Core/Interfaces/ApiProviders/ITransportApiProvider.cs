using pjsip4net.Core.Data;

namespace pjsip4net.Core.Interfaces.ApiProviders
{
    /// <summary>
    /// An abstraction of service enabling access to pjsua transport API <seealso cref="http://www.pjsip.org/pjsip/docs/html/group__PJSUA__LIB__TRANSPORT.htm"/>
    /// </summary>
    public interface ITransportApiProvider
    {
        //void pjsua_transport_config_default(pjsua_transport_config cfg);
        TransportConfig GetDefaultConfig();
        //int pjsua_transport_create(pjsip_transport_type_e type, pjsua_transport_config cfg, ref int p_id);
        int CreateTransportAndGetId(TransportType type, TransportConfig cfg);
        //int pjsua_enum_transports(int[] id, ref uint count);
        TransportInfo GetTransportInfo(int id);
        //int pjsua_transport_get_info(int id, pjsua_transport_info info);
        //int pjsua_transport_set_enable(int id, int enabled);
        //int pjsua_transport_close(int id, int force);
        void CloseTransport(int id);
        void ForceCloseTransport(int id);
    }
}