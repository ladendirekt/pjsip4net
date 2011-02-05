using System;
using AutoMapper;
using pjsip4net.Core.Data;

namespace pjsip.Interop.Services
{
    public class AccountInfoConverter : ITypeConverter<pjsua_acc_info, AccountInfo>
    {
        #region Implementation of ITypeConverter<pjsua_acc_info,AccountInfo>

        public AccountInfo Convert(ResolutionContext context)
        {
            var x = (pjsua_acc_info) context.SourceValue;
            var rx = (AccountInfo) context.DestinationValue ?? new AccountInfo();

            rx.AccUri = x.acc_uri;
            rx.Expires = x.expires;
            rx.HasRegistration = x.has_registration;
            rx.Id = x.id;
            rx.IsDefault = x.is_default;
            rx.OnlineStatus = x.online_status;
            rx.OnlineStatusText = x.online_status_text;
            rx.Rpid = new RpidElement()
                          {
                              Activity = (RpidActivity) x.rpid.activity,
                              Id = x.rpid.id,
                              Note = x.rpid.note
                          };
            rx.Status = (SipStatusCode) x.status;
            rx.StatusText = x.status_text;
            return rx;
        }

        #endregion
    }
}