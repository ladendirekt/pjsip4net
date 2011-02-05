using pjsip4net.Core.Data;

namespace pjsip.Interop.Interfaces
{
    public interface IMapper
    {
        pjsua_config Map(UaConfig config, pjsua_config cfg);
        UaConfig Map(pjsua_config cfg, UaConfig config);
        pjsua_logging_config Map(LoggingConfig config, pjsua_logging_config cfg);
        LoggingConfig Map(pjsua_logging_config cfg, LoggingConfig config);
        pjsua_media_config Map(MediaConfig config, pjsua_media_config cfg);
        MediaConfig Map(pjsua_media_config cfg, MediaConfig config);
        pjsua_transport_config Map(TransportConfig config, pjsua_transport_config cfg);
        TransportConfig Map(pjsua_transport_config cfg, TransportConfig config);
        pjsua_acc_config Map(AccountConfig config, pjsua_acc_config cfg);
        AccountConfig Map(pjsua_acc_config cfg, AccountConfig config);
        pjsua_buddy_config Map(BuddyConfig config, pjsua_buddy_config cfg);
        BuddyConfig Map(pjsua_buddy_config cfg, BuddyConfig config);

        TransportInfo Map(pjsua_transport_info info);
        AccountInfo Map(pjsua_acc_info info);
        CallInfo Map(pjsua_call_info info);
        ConferencePortInfo Map(pjsua_conf_port_info info);
        SoundDeviceInfo Map(pjmedia_snd_dev_info info);
        CodecInfo Map(pjsua_codec_info info);
        BuddyInfo Map(pjsua_buddy_info info);
    }
}