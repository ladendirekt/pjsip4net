using System;
using AutoMapper;
using pjsip4net.Core.Data;

namespace pjsip.Interop.Services
{
    public class CallInfoConverter : ITypeConverter<pjsua_call_info, CallInfo>
    {
        #region Implementation of ITypeConverter<pjsua_call_info,CallInfo>

        public CallInfo Convert(ResolutionContext context)
        {
            var x = (pjsua_call_info) context.SourceValue;
            var rx = (CallInfo) context.DestinationValue ?? new CallInfo();

            rx.AccId = x.acc_id;
            rx.CallId = x.call_id;
            rx.ConfSlot = x.conf_slot;
            rx.ConnectDuration = x.connect_duration;
            rx.Id = x.id;
            rx.LastStatus = (SipStatusCode) x.last_status;
            rx.LastStatusText = x.last_status_text;
            rx.LocalContact = x.local_contact;
            rx.LocalInfo = x.local_info;
            rx.MediaDir = (MediaDirection) x.media_dir;
            rx.MediaStatus = (CallMediaState) x.media_status;
            rx.RemoteContact = x.remote_contact;
            rx.RemoteInfo = x.remote_info;
            rx.Role = (SipRole) x.role;
            rx.State = (InviteState) x.state;
            rx.StateText = x.state_text;
            rx.TotalDuration = x.total_duration;
            return rx;
        }

        #endregion
    }
}