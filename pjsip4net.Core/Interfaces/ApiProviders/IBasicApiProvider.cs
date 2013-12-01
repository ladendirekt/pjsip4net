using pjsip4net.Core.Data;

namespace pjsip4net.Core.Interfaces.ApiProviders
{
    /// <summary>
    /// An abstraction of service enabling access to pjsua basic API <seealso cref="http://www.pjsip.org/pjsip/docs/html/group__PJSUA__LIB__BASE.htm"/>
    /// </summary>
    public interface IBasicApiProvider
    {
        UaConfig GetDefaultUaConfig();
        LoggingConfig GetDefaultLoggingConfig();
        void InitPjsua(UaConfig uaCfg, LoggingConfig logCfg, MediaConfig mediaCfg);
        void CreatePjsua();
        void Start();
        void Destroy();
        //int pjsua_handle_events(uint msec_timeout);
        //int pjsua_reconfigure_logging(pjsua_logging_config c);
        //int pjsua_detect_nat_type();
        //int pjsua_get_nat_type(ref pj_stun_nat_type type);
        void Dump(bool detail);
    }
}