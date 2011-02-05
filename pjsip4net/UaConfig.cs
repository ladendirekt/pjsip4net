//using System;
//using System.Collections.Generic;
//using pjsip.Interop;
//using pjsip4net.Accounts;
//using pjsip4net.Core.Interfaces;
//using pjsip4net.Core.Utils;
//using pjsip4net.Transport;
//using pjsip4net.Utils;

namespace pjsip4net
{
    //public class UaConfig : Initializable
    //{
    //    private readonly PjstrArrayWrapper _dnsServers;
    //    private readonly PjstrArrayWrapper _outboundProxies;
    //    private readonly PjstrArrayWrapper _stunServers;
    //    private readonly List<IVoIPTransport> _transports = new List<IVoIPTransport>();
    //    private List<Account> _accounts = new List<Account>();

    //    private bool _autoAnswer;

    //    private bool _autoConference;
    //    internal pjsua_config _config = new pjsua_config();

    //    internal UaConfig()
    //    {
    //        SipUserAgent.Instance.ApiFactory.GetBasicApi().pjsua_config_default(_config);
    //        _config.user_agent = new pj_str_t("DoxWox user agent on pjsua pills");
    //        _dnsServers = new PjstrArrayWrapper(_config.nameserver);
    //        _outboundProxies = new PjstrArrayWrapper(_config.outbound_proxy);
    //        _stunServers = new PjstrArrayWrapper(_config.stun_srv);
    //    }

    //    public bool AutoAnswer
    //    {
    //        get { return _autoAnswer; }
    //        set
    //        {
    //            GuardNotInitializing();
    //            _autoAnswer = value;
    //        }
    //    }

    //    public bool AutoConference
    //    {
    //        get { return _autoConference; }
    //        set
    //        {
    //            GuardNotInitializing();
    //            _autoConference = value;
    //        }
    //    }

    //    public uint MaxCalls
    //    {
    //        get { return _config.max_calls; }
    //        set
    //        {
    //            GuardNotInitializing();
    //            _config.max_calls = value;
    //        }
    //    }

    //    public string StunDomain
    //    {
    //        get { return _config.stun_domain; }
    //        set
    //        {
    //            GuardNotInitializing();
    //            _config.stun_domain = new pj_str_t(value);
    //        }
    //    }

    //    public string StunHost
    //    {
    //        get { return _config.stun_host; }
    //        set
    //        {
    //            GuardNotInitializing();
    //            _config.stun_host = new pj_str_t(value);
    //        }
    //    }

    //    public ICollection<string> StunServers
    //    {
    //        get { return _stunServers; }
    //    }

    //    public bool ForceLooseRoute
    //    {
    //        get { return Convert.ToBoolean(_config.force_lr); }
    //        set
    //        {
    //            GuardNotInitializing();
    //            _config.force_lr = Convert.ToInt32(value);
    //        }
    //    }

    //    public bool NatInSdp
    //    {
    //        get { return Convert.ToBoolean(_config.nat_type_in_sdp); }
    //        set
    //        {
    //            GuardNotInitializing();
    //            _config.nat_type_in_sdp = Convert.ToInt32(value);
    //        }
    //    }

    //    public bool Require100Rel
    //    {
    //        get { return _config.require_100rel == 1; }
    //        set
    //        {
    //            GuardNotInitializing();
    //            _config.require_100rel = Convert.ToInt32(value);
    //        }
    //    }

    //    public SrtpRequirement UseSrtp
    //    {
    //        get { return (SrtpRequirement) _config.use_srtp; }
    //        set
    //        {
    //            GuardNotInitializing();
    //            _config.use_srtp = (pjmedia_srtp_use) value;
    //        }
    //    }

    //    /// <summary>
    //    /// Specify whether SRTP requires secure signaling to be used. This option is only used when use_srtp option above is non-zero.
    //    /// Valid values are: 0: SRTP does not require secure signaling 1: SRTP requires secure transport such as Tls 2: SRTP requires secure end-to-end transport (SIPS)
    //    /// </summary>
    //    public int SecureSignalling
    //    {
    //        get { return _config.srtp_secure_signaling; }
    //        set
    //        {
    //            GuardNotInitializing();
    //            _config.srtp_secure_signaling = value;
    //        }
    //    }

    //    public ICollection<string> DnsServers
    //    {
    //        get { return _dnsServers; }
    //    }

    //    public ICollection<string> OutboundProxies
    //    {
    //        get { return _outboundProxies; }
    //    }

    //    public IList<IVoIPTransport> Transports
    //    {
    //        get { return _transports.AsReadOnly(); }
    //    }

    //    public override void BeginInit()
    //    {
    //        base.BeginInit();
    //        _dnsServers.BeginInit();
    //        _outboundProxies.BeginInit();
    //        _stunServers.BeginInit();
    //    }

    //    public override void EndInit()
    //    {
    //        base.EndInit();
    //        Helper.GuardInRange(1u, (uint) NativeConstants.PJSUA_MAX_CALLS, MaxCalls);
    //        //validate other params (NatinSdp...)
    //        _config.outbound_proxy_cnt = (uint) _outboundProxies.Count;
    //        _config.nameserver_count = (uint) _dnsServers.Count;
    //        _config.stun_srv_cnt = (uint) _stunServers.Count;
    //        _dnsServers.EndInit();
    //        _outboundProxies.EndInit();
    //        _stunServers.EndInit();
    //    }

    //    public void RegisterTransport(IVoIPTransport transport)
    //    {
    //        GuardNotInitializing();
    //        Helper.GuardNotNull(transport);

    //        if (_transports.Exists(t => t.Equals(transport)))
    //            throw new InvalidOperationException("Transport with the same settings already specified");

    //        _transports.Add(transport);
    //    }

    //    public void UnregisterTransport(VoIPTransport transport)
    //    {
    //        Helper.GuardNotNull(transport);
    //        if (_transports.Contains(transport))
    //            _transports.Remove(transport);
    //    }

    //    public void SetPreConfiguredAccounts(IEnumerable<Account> accounts)
    //    {
    //        GuardNotInitializing();
    //        Helper.GuardNotNull(accounts);

    //        _accounts = new List<Account>(accounts);
    //    }

    //    public IList<Account> GetPreConfiguredAccounts()
    //    {
    //        return _accounts.AsReadOnly();
    //    }
    //}
}