using pjsip4net.Core.Data;

namespace pjsip4net.Core.Interfaces.ApiProviders
{
    public interface IBasicApiProvider
    {
        UaConfig GetDefaultUaConfig();
        LoggingConfig GetDefaultLoggingConfig();
        //void pjsua_config_default(pjsua_config cfg);
        void InitPjsua(UaConfig uaCfg, LoggingConfig logCfg, MediaConfig mediaCfg);
        //void pjsua_logging_config_default(pjsua_logging_config cfg);
        //void pjsua_msg_data_init(pjsua_msg_data msg_data);
        void CreatePjsua();
        void Start();
        void Destroy();
        //int pjsua_handle_events(uint msec_timeout);
        //int pjsua_reconfigure_logging(pjsua_logging_config c);
        //int pjsua_detect_nat_type();
        //int pjsua_get_nat_type(ref pj_stun_nat_type type);
        //int pjsua_verify_sip_url(string url);
        //void pjsua_perror(string sender, string title, int status);
        void Dump(bool detail);
    }
}