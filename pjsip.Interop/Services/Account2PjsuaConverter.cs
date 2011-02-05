using System;
using System.Linq;
using AutoMapper;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;

namespace pjsip.Interop.Services
{
    public class Account2PjsuaConverter : ITypeConverter<AccountConfig, pjsua_acc_config>
    {
        #region Implementation of ITypeConverter<AccountConfig,pjsua_acc_config>

        public pjsua_acc_config Convert(ResolutionContext context)
        {
            var x = (AccountConfig) context.SourceValue;
            var rx = (pjsua_acc_config) context.DestinationValue ?? new pjsua_acc_config();

            rx.allow_contact_rewrite = System.Convert.ToInt32(x.AllowContactRewrite);
            rx.contact_params = new pj_str_t(x.ContactParams);
            rx.contact_uri_params = new pj_str_t(x.ContactUriParams);
            rx.cred_count = (uint) x.Credentials.Where(x1 => !string.IsNullOrEmpty(x1.UserName)).Count();
            rx.cred_info = x.Credentials.Select(c => c.ToPjsipCredentialsInfo()).GrowWithDefaultTo(8).ToArray();
            rx.force_contact = new pj_str_t(x.ForceContact);
            rx.id = new pj_str_t(x.Id);
            rx.ka_data = new pj_str_t(x.KaData);
            rx.ka_interval = x.KaInterval;
            rx.pidf_tuple_id = new pj_str_t(x.PidfTupleId);
            rx.priority = x.Priority;
            rx.proxy_cnt = (uint) x.Proxy.Where(x1 => !string.IsNullOrEmpty(x1)).Count();//make always 
            rx.proxy = x.Proxy.Select(s => new pj_str_t(s)).GrowWithDefaultTo(8).ToArray();
            rx.publish_enabled = System.Convert.ToInt32(x.IsPublishEnabled);
            rx.reg_timeout = x.RegTimeout;
            rx.reg_uri = new pj_str_t(x.RegUri);
            rx.require_100rel = System.Convert.ToInt32(x.Require100Rel);
            rx.require_timer = System.Convert.ToInt32(x.RequireTimer);
            rx.srtp_secure_signaling = x.SrtpSecureSignaling;
            //rx.timer_setting = x.
            rx.transport_id = x.TransportId;
            rx.use_srtp = (pjmedia_srtp_use) x.UseSrtp;
            return rx;
        }

        #endregion
    }

    public class Pjsua2AccountConverter : ITypeConverter<pjsua_acc_config, AccountConfig>
    {
        #region Implementation of ITypeConverter<AccountConfig,pjsua_acc_config>

        public AccountConfig Convert(ResolutionContext context)
        {
            var x = (pjsua_acc_config)context.SourceValue;
            var rx = (AccountConfig) context.DestinationValue ?? new AccountConfig();

            rx.AllowContactRewrite = System.Convert.ToBoolean(x.allow_contact_rewrite);
            rx.ContactParams = x.contact_params;
            rx.ContactUriParams = x.contact_uri_params;
            rx.Credentials = x.cred_info.Select(c => c.ToNetworkCredential()).ToList();
            rx.ForceContact = x.force_contact;
            rx.Id = x.id;
            rx.KaData = x.ka_data;
            rx.KaInterval = x.ka_interval;
            rx.PidfTupleId = x.pidf_tuple_id;
            rx.Priority = x.priority;
            rx.Proxy = x.proxy.Select(s => (string) s).ToList();
            rx.IsPublishEnabled = System.Convert.ToBoolean(x.publish_enabled);
            rx.RegTimeout = x.reg_timeout;
            rx.RegUri = x.reg_uri;
            rx.Require100Rel = System.Convert.ToBoolean(x.require_100rel);
            rx.RequireTimer = System.Convert.ToBoolean(x.require_timer);
            rx.SrtpSecureSignaling = x.srtp_secure_signaling;
            //rx.timer_setting = x.T
            rx.TransportId = x.transport_id;
            rx.UseSrtp = (SrtpRequirement) x.use_srtp;
            return rx;
        }

        #endregion
    }
}