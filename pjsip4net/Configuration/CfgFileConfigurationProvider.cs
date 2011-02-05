using System;
using System.Configuration;
using System.Linq;
using System.Net;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Utils;
using TransportType=pjsip4net.Core.TransportType;

namespace pjsip4net.Configuration
{
    public class CfgFileConfigurationProvider : IConfigurationProvider
    {
        private SipUserAgentSettingsSection _section;

        #region IConfigurationProvider Members

        public void Configure(IConfigurationContext context)
        {
            try
            {
                var config = context.Config;
                var mediaConfig = context.MediaConfig;
                var loggingConfig = context.LoggingConfig;
                var cfg = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                _section = (SipUserAgentSettingsSection) cfg.Sections["sipua"];
                if (_section != null)
                {
                    context.RegisterTransport(
                        new Tuple<TransportType, TransportConfig>(
                            (TransportType) Enum.Parse(typeof (TransportType), _section.Transport.TransportType, true),
                            new TransportConfig(){Port = (uint) _section.Transport.Port}));

                    config.UseSrtp = _section.SecureMedia;
                    config.SecureSignalling = _section.SecureSignaling;

                    if (_section.NetworkSettings != null)
                    {
                        config.NatInSdp = _section.NetworkSettings.NatInSdp;
                        config.ForceLooseRoute = _section.NetworkSettings.ForceLooseRoute;

                        if (_section.NetworkSettings.DnsServers != null)
                            for (int i = 0; i < _section.NetworkSettings.DnsServers.Count; i++)
                                if (!string.IsNullOrEmpty(_section.NetworkSettings.DnsServers[i].Address))
                                    config.DnsServers.Add(_section.NetworkSettings.DnsServers[i].Address);

                        if (_section.NetworkSettings.Proxies != null)
                            for (int i = 0; i < _section.NetworkSettings.Proxies.Count; i++)
                                if (!string.IsNullOrEmpty(_section.NetworkSettings.Proxies[i].Address))
                                    config.OutboundProxies.Add(_section.NetworkSettings.Proxies[i].Address);

                        if (_section.NetworkSettings.StunServers != null)
                            for (int i = 0; i < _section.NetworkSettings.StunServers.Count; i++)
                                if (!string.IsNullOrEmpty(_section.NetworkSettings.StunServers[i].Address))
                                    config.StunServers.Add(_section.NetworkSettings.StunServers[i].Address);

                        if (_section.NetworkSettings.Stun != null)
                        {
                            config.StunHost = _section.NetworkSettings.Stun.Address;
                        }

                        if (_section.NetworkSettings.Turn != null &&
                            _section.NetworkSettings.Turn.Enabled)
                        {
                            mediaConfig.EnableTurn = true;
                            mediaConfig.TurnServer = _section.NetworkSettings.Turn.Server;
                            TransportType tpType = TransportType.Udp;
                            switch (_section.NetworkSettings.Turn.TransportType)
                            {
                                case "udp":
                                    tpType = TransportType.Udp;
                                    break;
                                case "tcp":
                                    tpType = TransportType.Tcp;
                                    break;
                                case "tls":
                                    tpType = TransportType.Tls;
                                    break;
                            }
                            mediaConfig.TurnConnectionType = tpType;
                            mediaConfig.TurnAuthentication = new NetworkCredential
                                                                 {
                                                                     UserName = _section.NetworkSettings.Turn.UserName,
                                                                     Password = _section.NetworkSettings.Turn.Password,
                                                                     Domain = _section.NetworkSettings.Turn.Realm
                                                                 };
                        }

                        if (_section.NetworkSettings.ICE != null)
                        {
                            mediaConfig.EnableICE = _section.NetworkSettings.ICE.Enabled;
                            //mediaConfig.ICENoHostCandidates = _section.NetworkSettings.ICE.NoHostCandidates;
                            mediaConfig.ICENoRtcp = _section.NetworkSettings.ICE.NoRtcp;
                        }
                    }

                    mediaConfig.IsVadEnabled = _section.MediaConfig.IsVadEnabled;

                    config.AutoAnswer = _section.AutoAnswer;
                    config.AutoConference = _section.AutoConference;
                    config.MaxCalls = (uint) _section.MaxCalls;

                    loggingConfig.LogMessages = _section.LogMessages;
                    loggingConfig.LogLevel = (uint) _section.LogLevel;
                    loggingConfig.TraceAndDebug = _section.TraceAndDebug;

                    mediaConfig.CaptureDeviceId = _section.MediaConfig.CaptureDeviceId;
                    mediaConfig.PlaybackDeviceId = _section.MediaConfig.PlaybackDeviceId;

                    context.RegisterAccounts(
                        _section.Accounts.Cast<AccountElement>()
                            .Select(ae =>
                                        {
                                            var accCfg = new AccountConfig()
                                                             {
                                                                 Id = ae.AccountId,
                                                                 RegUri = ae.RegistrarUri,
                                                                 IsPublishEnabled = ae.PublishPresence,
                                                                 IsDefault = ae.IsDefault
                                                             };
                                            accCfg.Credentials.Add(new NetworkCredential(ae.UserName, ae.Password,
                                                                                         ae.Realm));
                                            return accCfg;
                                        }));
                }
            }
            catch (ConfigurationErrorsException) //error in config using default settings
            {
            }
        }

        //public void Store(UaConfig config, MediaConfig mediaConfig, LoggingConfig loggingConfig)
        //{
        //    var cfg = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        //    _section = _section ?? new SipUserAgentSettingsSection();

        //    if (config.Transports != null && config.Transports.Count > 0)
        //    {
        //        var tpt = config.Transports[0];
        //        switch (tpt.TransportType)
        //        {
        //            case TransportType.Udp:
        //                _section.Transport.TransportType = "udp";
        //                break;
        //            case TransportType.Tcp:
        //                _section.Transport.TransportType = "tcp";
        //                break;
        //            case TransportType.Tls:
        //                _section.Transport.TransportType = "tls";
        //                break;
        //        }
        //        _section.Transport.Port = (int) tpt.Port;
        //    }

        //    _section.AutoAnswer = config.AutoAnswer;
        //    _section.AutoConference = config.AutoConference;
        //    _section.MaxCalls = (int) config.MaxCalls;

        //    _section.LogLevel = (int) loggingConfig.LogLevel;
        //    _section.LogMessages = loggingConfig.LogMessages;
        //    _section.TraceAndDebug = loggingConfig.TraceAndDebug;

        //    _section.MediaConfig.CaptureDeviceId = mediaConfig.CaptureDeviceId;
        //    _section.MediaConfig.PlaybackDeviceId = mediaConfig.PlaybackDeviceId;

        //    _section.Accounts.Clear();

        //    foreach (Account account in config.GetPreConfiguredAccounts())
        //    {
        //        var element = new AccountElement
        //                          {
        //                              AccountId = account.AccountId,
        //                              RegistrarUri = account.RegistrarUri,
        //                              IsDefault = account.IsDefault ?? false
        //                          };
        //        if (account.Credential != null)
        //        {
        //            element.UserName = account.Credential.UserName;
        //            element.Password = account.Credential.Password;
        //            element.Realm = account.Credential.Domain;
        //        }
        //        _section.Accounts.Add(element);
        //    }

        //    _section.SecureMedia = config.UseSrtp;
        //    _section.SecureSignaling = config.SecureSignalling;

        //    //if (_section.NetworkSettings != null)
        //    {
        //        _section.NetworkSettings.NatInSdp = config.NatInSdp;
        //        _section.NetworkSettings.ForceLooseRoute = config.ForceLooseRoute;

        //        if (config.DnsServers.Count > 0)
        //            foreach (string dns in config.DnsServers)
        //                if (!string.IsNullOrEmpty(dns))
        //                    _section.NetworkSettings.DnsServers.Add(new DnsServerElement {Address = dns});

        //        if (config.OutboundProxies.Count > 0)
        //            foreach (string proxy in config.OutboundProxies)
        //                if (!string.IsNullOrEmpty(proxy))
        //                    _section.NetworkSettings.Proxies.Add(new ProxyElement {Address = proxy});

        //        if (!string.IsNullOrEmpty(config.StunDomain) ||
        //            !string.IsNullOrEmpty(config.StunHost))
        //        {
        //            _section.NetworkSettings.Stun.Address = string.IsNullOrEmpty(config.StunDomain)
        //                                                        ? config.StunHost
        //                                                        : config.StunDomain;
        //        }

        //        if (!string.IsNullOrEmpty(mediaConfig.TurnServer))
        //        {
        //            _section.NetworkSettings.Turn.Server = mediaConfig.TurnServer;
        //            _section.NetworkSettings.Turn.TransportType =
        //                mediaConfig.TurnConnectionType.ToString().ToLowerInvariant();
        //            _section.NetworkSettings.Turn.Enabled = true;
        //        }
        //        else _section.NetworkSettings.Turn.Enabled = false;

        //        if (config.StunServers.Count > 0)
        //            foreach (string stunServer in config.StunServers)
        //                if (!string.IsNullOrEmpty(stunServer))
        //                    _section.NetworkSettings.StunServers.Add(new StunElement {Address = stunServer});

        //        if (!string.IsNullOrEmpty(config.StunHost))
        //            _section.NetworkSettings.Stun.Address = config.StunHost;

        //        //todo: add turn 
        //        //if (_section.NetworkSettings.ICE != null)
        //        {
        //            _section.NetworkSettings.ICE.Enabled = mediaConfig.EnableICE;
        //            //_section.NetworkSettings.ICE.NoHostCandidates = mediaConfig.ICENoHostCandidates;
        //            _section.NetworkSettings.ICE.NoRtcp = mediaConfig.ICENoRtcp;
        //        }
        //    }

        //    var section = (SipUserAgentSettingsSection) cfg.Sections["sipua"];
        //    if (section == null)
        //        cfg.Sections.Add("sipua", _section);
        //    else section.Copy(_section);
        //    cfg.Save(ConfigurationSaveMode.Full);
        //}

        #endregion
    }
}