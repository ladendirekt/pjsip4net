using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using pjsip.Interop.Interfaces;
using pjsip4net.Core;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Utils;

namespace pjsip.Interop.Services
{
    public class AutoMappingMapper : IMapper
    {
        private readonly IMappingEngine _engine;
        private readonly IContainer _container;

        public AutoMappingMapper(IMappingEngine engine, IContainer container)
        {
            Helper.GuardNotNull(engine);
            Helper.GuardNotNull(container);
            //sigh! shouldn't you write a naming convention, buddy?

            //todo: need two profiles one for pjsua->pjsip4net & the other for pjsip4net->pjsua
            _engine = engine;
            _container = container;
            //Mapper.Initialize(c =>
            //                      {
            //                          c.AddProfile(new Pjsip4net2PjsuaProfile());
            //                          c.AddProfile(new Pjsua2Pjsip4netProfile());
            //                      });
            Mapper.CreateMap<UaConfig, pjsua_config>()//.WithProfile("pjsip4net2pjsua")
                .ForMember(x => x.cb, cx => cx.Ignore())
                .ForMember(x => x.cred_info, cx => cx.MapFrom(x => x.Credentials
                               .Select(c => c.ToPjsipCredentialsInfo()).GrowWithDefaultTo(8).ToArray()))
                .ForMember(x => x.cred_count, cx => cx.MapFrom(x => (uint) x.Credentials.Where(x1 => !string.IsNullOrEmpty(x1.UserName)).Count()))
                .ForMember(x => x.force_lr, cx => cx.MapFrom(x => Convert.ToInt32(x.ForceLooseRoute)))
                .ForMember(x => x.hangup_forked_call, cx => cx.MapFrom(x => Convert.ToInt32(x.HangupForkedCall)))
                .ForMember(x => x.max_calls, cx => cx.MapFrom(x => x.MaxCalls))
                .ForMember(x => x.nameserver, cx => cx.MapFrom(x => x.DnsServers
                    .Select(s => new pj_str_t(s)).GrowWithDefaultTo(4).ToArray()))
                .ForMember(x => x.nameserver_count, cx => cx.MapFrom(x => (uint) x.DnsServers.Where(x1 => !string.IsNullOrEmpty(x1)).Count()))
                .ForMember(x => x.nat_type_in_sdp, cx => cx.MapFrom(x => Convert.ToInt32(x.NatInSdp)))
                .ForMember(x => x.outbound_proxy, cx => cx.MapFrom(x => x.OutboundProxies
                    .Select(s => new pj_str_t(s)).GrowWithDefaultTo(4).ToArray()))
                .ForMember(x => x.outbound_proxy_cnt, cx => cx.MapFrom(x => (uint) x.OutboundProxies.Where(x1 => !string.IsNullOrEmpty(x1)).Count()))
                .ForMember(x => x.require_100rel, cx => cx.MapFrom(x => Convert.ToInt32(x.Require100Rel)))
                .ForMember(x => x.require_timer, cx => cx.Ignore())
                .ForMember(x => x.srtp_secure_signaling, cx => cx.MapFrom(x => x.SecureSignalling))
                .ForMember(x => x.stun_domain, cx => cx.MapFrom(x => new pj_str_t(x.StunDomain)))
                .ForMember(x => x.stun_host, cx => cx.MapFrom(x => new pj_str_t(x.StunHost)))
                .ForMember(x => x.stun_ignore_failure, cx => cx.MapFrom(x => Convert.ToInt32(x.StunIgnoreFailure)))
                .ForMember(x => x.stun_srv, cx => cx.MapFrom(x => x.StunServers
                    .Select(s => new pj_str_t(s)).GrowWithDefaultTo(8).ToArray()))
                .ForMember(x => x.stun_srv_cnt, cx => cx.MapFrom(x => (uint) x.StunServers.Count))
                .ForMember(x => x.thread_cnt, cx => cx.MapFrom(x => x.ThreadCount))
                .ForMember(x => x.timer_setting, cx => cx.Ignore())
                .ForMember(x => x.use_srtp, cx => cx.MapFrom(x => (pjmedia_srtp_use) x.UseSrtp))
                .ForMember(x => x.user_agent, cx => cx.MapFrom(x => new pj_str_t(x.UserAgent)));
            Mapper.CreateMap<pjsua_config, UaConfig>()
                .ForMember(x => x.Credentials,
                           cx => cx.MapFrom(x => x.cred_info.Where(c => !string.IsNullOrEmpty(c.username))
                               .Select(c => c.ToNetworkCredential()).ToList()))
                .ForMember(x => x.ForceLooseRoute, cx => cx.MapFrom(x => x.force_lr))
                .ForMember(x => x.HangupForkedCall, cx => cx.MapFrom(x => Convert.ToBoolean(x.hangup_forked_call)))
                .ForMember(x => x.MaxCalls, cx => cx.MapFrom(x => x.max_calls))
                .ForMember(x => x.DnsServers, cx => cx.MapFrom(x => x.nameserver.Select(s => (string) s)
                    .Where(s => !string.IsNullOrEmpty(s)).ToList()))
                .ForMember(x => x.NatInSdp, cx => cx.MapFrom(x => Convert.ToBoolean(x.nat_type_in_sdp)))
                .ForMember(x => x.OutboundProxies,
                           cx => cx.MapFrom(x => x.outbound_proxy.Select(s => (string) s)
                               .Where(s => !string.IsNullOrEmpty(s)).ToList()))
                .ForMember(x => x.Require100Rel, cx => cx.MapFrom(x => Convert.ToBoolean(x.require_100rel)))
                .ForMember(x => x.SecureSignalling, cx => cx.MapFrom(x => x.srtp_secure_signaling))
                .ForMember(x => x.StunDomain, cx => cx.MapFrom(x => (string) x.stun_domain))
                .ForMember(x => x.StunHost, cx => cx.MapFrom(x => (string) x.stun_host))
                .ForMember(x => x.StunIgnoreFailure, cx => cx.MapFrom(x => Convert.ToBoolean(x.stun_ignore_failure)))
                .ForMember(x => x.StunServers, cx => cx.MapFrom(x => x.stun_srv.Select(s => (string) s)
                    .Where(s => !string.IsNullOrEmpty(s)).ToList()))
                .ForMember(x => x.ThreadCount, cx => cx.MapFrom(x => x.thread_cnt))
                .ForMember(x => x.UseSrtp, cx => cx.MapFrom(x => (SrtpRequirement) x.use_srtp))
                .ForMember(x => x.UserAgent, cx => cx.MapFrom(x => (string) x.user_agent))
                .ForMember(x => x.AutoAnswer, cx => cx.Ignore())
                .ForMember(x => x.AutoConference, cx => cx.Ignore());

            Mapper.CreateMap<LoggingConfig, pjsua_logging_config>()
                .ForMember(x => x.AnonymousMember1, cx => cx.Ignore())
                .ForMember(x => x.console_level, cx => cx.Ignore())
                .ForMember(x => x.decor, cx => cx.Ignore())
                .ForMember(x => x.level, cx => cx.MapFrom(x => x.LogLevel))
                .ForMember(x => x.log_file_flags, cx => cx.Ignore())
                .ForMember(x => x.log_filename, cx => cx.Ignore())
                .ForMember(x => x.msg_logging, cx => cx.MapFrom(x => Convert.ToInt32(x.LogMessages)));
            Mapper.CreateMap<pjsua_logging_config, LoggingConfig>()
                .ForMember(x => x.LogLevel, cx => cx.MapFrom(x => x.level))
                .ForMember(x => x.LogMessages, cx => cx.MapFrom(x => Convert.ToBoolean(x.msg_logging)))
                .ForMember(x => x.TraceAndDebug, cx => cx.Ignore());

            Mapper.CreateMap<MediaConfig, pjsua_media_config>()//.WithProfile("pjsip4net2pjsua")
                .ForMember(x => x.audio_frame_ptime, cx => cx.MapFrom(x => x.AudioFramePtime))
                .ForMember(x => x.channel_count, cx => cx.MapFrom(x => x.ChannelCount))
                .ForMember(x => x.clock_rate, cx => cx.MapFrom(x => x.ClockRate))
                .ForMember(x => x.ec_options, cx => cx.MapFrom(x => x.EcOptions))
                .ForMember(x => x.ec_tail_len, cx => cx.MapFrom(x => x.EcTailLen))
                .ForMember(x => x.enable_ice, cx => cx.MapFrom(x => Convert.ToInt32(x.EnableICE)))
                .ForMember(x => x.enable_turn, cx => cx.MapFrom(x => Convert.ToInt32(x.EnableTurn)))
                .ForMember(x => x.has_ioqueue, cx => cx.MapFrom(x => Convert.ToInt32(x.HasIOQueue)))
                .ForMember(x => x.ice_max_host_cands, cx => cx.Ignore())
                .ForMember(x => x.ice_no_rtcp, cx => cx.MapFrom(x => Convert.ToInt32(x.ICENoRtcp)))
                .ForMember(x => x.ice_opt, cx => cx.Ignore())
                .ForMember(x => x.ilbc_mode, cx => cx.MapFrom(x => x.ILBCMode))
                .ForMember(x => x.jb_init, cx => cx.MapFrom(x => -1))
                .ForMember(x => x.jb_max, cx => cx.MapFrom(x => -1))
                .ForMember(x => x.jb_max_pre, cx => cx.MapFrom(x => -1))
                .ForMember(x => x.jb_min_pre, cx => cx.MapFrom(x => -1))
                .ForMember(x => x.max_media_ports, cx => cx.MapFrom(x => x.MaxMediaPorts))
                .ForMember(x => x.no_vad, cx => cx.MapFrom(x => Convert.ToInt32(!x.IsVadEnabled)))
                .ForMember(x => x.ptime, cx => cx.Ignore())
                .ForMember(x => x.quality, cx => cx.MapFrom(x => x.Quality))
                .ForMember(x => x.rx_drop_pct, cx => cx.Ignore())
                .ForMember(x => x.tx_drop_pct, cx => cx.Ignore())
                .ForMember(x => x.snd_auto_close_time, cx => cx.MapFrom(x => x.SoundDeviceAutoCloseTime.Milliseconds))
                .ForMember(x => x.snd_clock_rate, cx => cx.MapFrom(x => x.SndClockRate))
                .ForMember(x => x.snd_play_latency, cx => cx.Ignore())
                .ForMember(x => x.snd_rec_latency, cx => cx.Ignore())
                .ForMember(x => x.thread_cnt, cx => cx.MapFrom(x => x.ThreadCnt))
                .ForMember(x => x.turn_auth_cred, cx => cx.MapFrom(x => x.TurnAuthentication.ToStunAuthCredential()))
                .ForMember(x => x.turn_conn_type, cx => cx.MapFrom(x => (pj_turn_tp_type) x.TurnConnectionType))
                .ForMember(x => x.turn_server, cx => cx.MapFrom(x => new pj_str_t(x.TurnServer)));
            Mapper.CreateMap<pjsua_media_config, MediaConfig>()//.WithProfile("pjsua2pjsip4net")
                .ForMember(x => x.AudioFramePtime, cx => cx.MapFrom(x => x.audio_frame_ptime))
                .ForMember(x => x.ChannelCount, cx => cx.MapFrom(x => x.channel_count))
                .ForMember(x => x.ClockRate, cx => cx.MapFrom(x => x.clock_rate))
                .ForMember(x => x.EcOptions, cx => cx.MapFrom(x => x.ec_options))
                .ForMember(x => x.EcTailLen, cx => cx.MapFrom(x => x.ec_tail_len))
                .ForMember(x => x.EnableICE, cx => cx.MapFrom(x => Convert.ToBoolean(x.enable_ice)))
                .ForMember(x => x.EnableTurn, cx => cx.MapFrom(x => Convert.ToBoolean(x.enable_turn)))
                .ForMember(x => x.HasIOQueue, cx => cx.MapFrom(x => Convert.ToBoolean(x.has_ioqueue)))
                .ForMember(x => x.ICENoRtcp, cx => cx.MapFrom(x => Convert.ToBoolean(x.ice_no_rtcp)))
                .ForMember(x => x.ILBCMode, cx => cx.MapFrom(x => x.ilbc_mode))
                .ForMember(x => x.MaxMediaPorts, cx => cx.MapFrom(x => x.max_media_ports))
                .ForMember(x => x.IsVadEnabled, cx => cx.MapFrom(x => !Convert.ToBoolean(x.no_vad)))
                .ForMember(x => x.Quality, cx => cx.MapFrom(x => x.quality))
                .ForMember(x => x.SoundDeviceAutoCloseTime,
                           cx => cx.MapFrom(x => TimeSpan.FromMilliseconds(x.snd_auto_close_time)))
                .ForMember(x => x.SndClockRate, cx => cx.MapFrom(x => x.snd_clock_rate))
                .ForMember(x => x.ThreadCnt, cx => cx.MapFrom(x => x.thread_cnt))
                .ForMember(x => x.TurnAuthentication, cx => cx.MapFrom(x => x.turn_auth_cred.ToNetworkCredential()))
                .ForMember(x => x.TurnConnectionType, cx => cx.MapFrom(x => (TransportType) x.turn_conn_type))
                .ForMember(x => x.TurnServer, cx => cx.MapFrom(x => (string) x.turn_server))
                .ForMember(x => x.CaptureDeviceId, cx => cx.Ignore())
                .ForMember(x => x.PlaybackDeviceId, cx => cx.Ignore());

            Mapper.CreateMap<TransportConfig, pjsua_transport_config>()
                .ForMember(x => x.bound_addr, cx => cx.MapFrom(x => new pj_str_t(x.BoundAddress)))
                .ForMember(x => x.port, cx => cx.MapFrom(x => x.Port))
                .ForMember(x => x.public_addr, cx => cx.MapFrom(x => new pj_str_t(x.PublicAddress)))
                .ForMember(x => x.tls_setting, cx => cx.MapFrom(x => new pjsip_tls_setting()
                                                                         {
                                                                             ca_list_file = new pj_str_t(x.TlsSetting.CAListFile),
                                                                             cert_file = new pj_str_t(x.TlsSetting.CertFile),
                                                                             ciphers = new pj_str_t(x.TlsSetting.Ciphers),
                                                                             method = x.TlsSetting.Method,
                                                                             password = new pj_str_t(x.TlsSetting.Password),
                                                                             privkey_file = new pj_str_t(x.TlsSetting.PrivKeyFile),
                                                                             require_client_cert = Convert.ToInt32(x.TlsSetting.RequireClientCert),
                                                                             server_name = new pj_str_t(x.TlsSetting.ServerName)
                                                                         }));
            Mapper.CreateMap<pjsua_transport_config, TransportConfig>()
                .ForMember(x => x.BoundAddress, cx => cx.MapFrom(x => (string)x.bound_addr))
                .ForMember(x => x.Port, cx => cx.MapFrom(x => x.port))
                .ForMember(x => x.PublicAddress, cx => cx.MapFrom(x => (string)x.public_addr))
                .ForMember(x => x.TlsSetting, cx => cx.MapFrom(x => new TlsConfig()
                                                                        {
                                                                            CAListFile = x.tls_setting.ca_list_file,
                                                                            CertFile = x.tls_setting.cert_file,
                                                                            Ciphers = x.tls_setting.ciphers,
                                                                            Method = x.tls_setting.method,
                                                                            Password = x.tls_setting.password,
                                                                            PrivKeyFile = x.tls_setting.privkey_file,
                                                                            RequireClientCert = Convert.ToBoolean(x.tls_setting.require_client_cert),
                                                                            ServerName = x.tls_setting.server_name
                                                                        }));

            Mapper.CreateMap<BuddyConfig, pjsua_buddy_config>()
                .ForMember(x => x.subscribe, cx => cx.MapFrom(x => Convert.ToInt32(x.Subscribe)))
                .ForMember(x => x.uri, cx => cx.MapFrom(x => new pj_str_t(x.Uri)))
                .ForMember(x => x.user_data, cx => cx.Ignore());
            Mapper.CreateMap<pjsua_buddy_config, BuddyConfig>()
                .ForMember(x => x.Uri, cx => cx.MapFrom(x => (string) x.uri))
                .ForMember(x => x.Subscribe, cx => cx.MapFrom(x => Convert.ToBoolean(x.subscribe)));


            Mapper.CreateMap<AccountConfig, pjsua_acc_config>()
                .ConvertUsing(new Account2PjsuaConverter());
            Mapper.CreateMap<pjsua_acc_config, AccountConfig>()
                .ConvertUsing(new Pjsua2AccountConverter());

            Mapper.CreateMap<pjsua_transport_info, TransportInfo>()
                .ConvertUsing(new TransportInfoConverter());
            Mapper.CreateMap<pjsua_acc_info, AccountInfo>()
                .ConvertUsing(new AccountInfoConverter());
            Mapper.CreateMap<pjsua_call_info, CallInfo>()
                .ConvertUsing(new CallInfoConverter());
            Mapper.CreateMap<pjsua_conf_port_info, ConferencePortInfo>()//.WithProfile("pjsua2pjsip4net")
                .ForMember(x => x.Listeners, cx => cx.MapFrom(x => new List<int>(x.listeners)))
                .ForMember(x => x.SlotId, cx => cx.MapFrom(x => x.slot_id))
                .ForMember(x => x.ClockRate, cx => cx.MapFrom(x => x.clock_rate))
                .ForMember(x => x.ChannelCount, cx => cx.MapFrom(x => x.channel_count))
                .ForMember(x => x.SamplesPerFrame, cx => cx.MapFrom(x => x.samples_per_frame))
                .ForMember(x => x.BitsPerSample, cx => cx.MapFrom(x => x.bits_per_sample));
                //.ConvertUsing<ConferencePortInfoConverter>();
            Mapper.CreateMap<pjmedia_snd_dev_info, SoundDeviceInfo>()//.WithProfile("pjsua2pjsip4net")
                .ForMember(x => x.Id, cx => cx.Ignore())
                .ForMember(x => x.InputCount, cx => cx.MapFrom(x => x.input_count))
                .ForMember(x => x.OutputCount, cx => cx.MapFrom(x => x.output_count))
                .ForMember(x => x.DefaultSamplesPerSec, cx => cx.MapFrom(x => x.default_samples_per_sec));
                //.ConvertUsing<SoundDeviceInfoConverter>();
            Mapper.CreateMap<pjsua_codec_info, CodecInfo>()//.WithProfile("pjsua2pjsip4net")
                .ConstructUsing(pci => _container.Get<CodecInfo>())
                .ForMember(x => x.CodecId, cx => cx.MapFrom(x => x.buf_))
                .ForMember(x => x.Priority, cx => cx.MapFrom(x => x.priority));
            Mapper.CreateMap<pjsua_buddy_info, BuddyInfo>()//.WithProfile("pjsua2pjsip4net")
                .ForMember(x => x.Status, cx => cx.MapFrom(x => (BuddyStatus)x.status))
                .ForMember(x => x.SubState, cx => cx.MapFrom(x => (SubscriptionState)x.sub_state))
                .ForMember(x => x.StatusText, cx => cx.MapFrom(x => (string)x.status_text))
                .ForMember(x => x.MonitorPresence, cx => cx.MapFrom(x => Convert.ToBoolean(x.monitor_pres)))
                .ForMember(x => x.SubscriptionStateName, cx => cx.MapFrom(x => x.sub_state_name))
                .ForMember(x => x.SubTermReason, cx => cx.MapFrom(x => (string)x.sub_term_reason))
                .ForMember(x => x.Buffer, cx => cx.MapFrom(x => x.buf_))
                .ForMember(x => x.Rpid, cx => cx.MapFrom(x => new RpidElement()
                                                                  {
                                                                      Activity = (RpidActivity) x.rpid.activity,
                                                                      Id = x.rpid.id,
                                                                      Note = x.rpid.note
                                                                  }
                    ));
        }

        #region Implementation of IMapper

        public pjsua_config Map(UaConfig config, pjsua_config cfg)
        {
            return _engine.Map(config, cfg);
        }

        public UaConfig Map(pjsua_config cfg, UaConfig config)
        {
            return _engine.Map(cfg, config);
        }

        public pjsua_logging_config Map(LoggingConfig config, pjsua_logging_config cfg)
        {
            return _engine.Map(config, cfg);
        }

        public LoggingConfig Map(pjsua_logging_config cfg, LoggingConfig config)
        {
            return _engine.Map(cfg, config);
        }

        public pjsua_media_config Map(MediaConfig config, pjsua_media_config cfg)
        {
            return _engine.Map(config, cfg);
        }

        public MediaConfig Map(pjsua_media_config cfg, MediaConfig config)
        {
            return _engine.Map(cfg, config);
        }

        public pjsua_transport_config Map(TransportConfig config, pjsua_transport_config cfg)
        {
            return _engine.Map(config, cfg);
        }

        public TransportConfig Map(pjsua_transport_config cfg, TransportConfig config)
        {
            return _engine.Map(cfg, config);
        }

        public pjsua_acc_config Map(AccountConfig config, pjsua_acc_config cfg)
        {
            return _engine.Map(config, cfg);
        }

        public AccountConfig Map(pjsua_acc_config cfg, AccountConfig config)
        {
            return _engine.Map(cfg, config);
        }

        public pjsua_buddy_config Map(BuddyConfig config, pjsua_buddy_config cfg)
        {
            return _engine.Map(config, cfg);
        }

        public BuddyConfig Map(pjsua_buddy_config cfg, BuddyConfig config)
        {
            return _engine.Map(cfg, config);
        }

        public TransportInfo Map(pjsua_transport_info info)
        {
            return _engine.Map<pjsua_transport_info, TransportInfo>(info);
        }

        public AccountInfo Map(pjsua_acc_info info)
        {
            return _engine.Map<pjsua_acc_info, AccountInfo>(info);
        }

        public CallInfo Map(pjsua_call_info info)
        {
            return _engine.Map<pjsua_call_info, CallInfo>(info);
        }

        public ConferencePortInfo Map(pjsua_conf_port_info info)
        {
            return _engine.Map<pjsua_conf_port_info, ConferencePortInfo>(info);
        }

        public SoundDeviceInfo Map(pjmedia_snd_dev_info info)
        {
            return _engine.Map<pjmedia_snd_dev_info, SoundDeviceInfo>(info);
        }

        public CodecInfo Map(pjsua_codec_info info)
        {
            return _engine.Map<pjsua_codec_info, CodecInfo>(info);
        }

        public BuddyInfo Map(pjsua_buddy_info info)
        {
            return _engine.Map<pjsua_buddy_info, BuddyInfo>(info);
        }

        #endregion
    }
}