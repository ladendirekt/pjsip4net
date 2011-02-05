using System;
using System.Runtime.InteropServices;
using pjsip.Interop.Interfaces;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;

namespace pjsip.Interop.ApiProviders
{
    public class CallApiProvider_1_4 : ICallApiProvider
    {
        private IMapper _mapper;

        public CallApiProvider_1_4(IMapper mapper)
        {
            Helper.GuardNotNull(mapper);
            _mapper = mapper;
        }

        #region Implementation of ICallApiProvider

        public uint GetMaxAllowedCalls()
        {
            return PJSUA_DLL.Calls.pjsua_call_get_max_count();
        }

        public int MakeCallAndGetId(int accId, string dstUri, uint options)
        {
            int id = NativeConstants.PJSUA_INVALID_ID;
            var d = new pj_str_t(dstUri);
            Helper.GuardError(PJSUA_DLL.Calls.pjsua_call_make_call(accId, ref d, options, IntPtr.Zero, null, ref id));
            return id;
        }

        public bool IsCallActive(int callId)
        {
            return PJSUA_DLL.Calls.pjsua_call_is_active(callId);
        }

        public bool CallHasMedia(int callId)
        {
            return PJSUA_DLL.Calls.pjsua_call_has_media(callId);
        }

        public int GetConfPort(int callId)
        {
            return PJSUA_DLL.Calls.pjsua_call_get_conf_port(callId);
        }

        public CallInfo GetInfo(int callId)
        {
            var info = new pjsua_call_info();
            Helper.GuardError(PJSUA_DLL.Calls.pjsua_call_get_info(callId, ref info));
            return _mapper.Map(info);
        }

        public void AnswerCall(int callId, SipStatusCode code, string reason)
        {
            var r = new pj_str_t(reason);
            Helper.GuardError(PJSUA_DLL.Calls.pjsua_call_answer(callId, (uint) code, ref r, null));
        }

        public void HangupCall(int callId, SipStatusCode code, string reason)
        {
            var r = new pj_str_t(reason);
            Helper.GuardError(PJSUA_DLL.Calls.pjsua_call_hangup(callId, (uint) code, ref r, null));
        }

        public void ProcessCallRedirect(int callId, RedirectOption cmd)
        {
            Helper.GuardError(PJSUA_DLL.Calls.pjsua_call_process_redirect(callId, (pjsip_redirect_op) cmd));
        }

        public void PutCallOnHold(int callId)
        {
            Helper.GuardError(PJSUA_DLL.Calls.pjsua_call_set_hold(callId, null));
        }

        public void ReinviteCall(int callId, bool unhold)
        {
            Helper.GuardError(PJSUA_DLL.Calls.pjsua_call_reinvite(callId, Convert.ToInt32(unhold), null));
        }

        public void DialDtmf(int callId, string digits)
        {
            var d = new pj_str_t(digits);
            Helper.GuardError(PJSUA_DLL.Calls.pjsua_call_dial_dtmf(callId, ref d));
        }

        public void SendIm(int callId, string mime_type, string content)
        {
            var m = new pj_str_t(mime_type);
            var c = new pj_str_t(content);
            Helper.GuardError(PJSUA_DLL.Calls.pjsua_call_send_im(callId, ref m, ref c, null, IntPtr.Zero));
        }

        public void SendTypingInd(int callId, bool isTyping)
        {
            Helper.GuardError(PJSUA_DLL.Calls.pjsua_call_send_typing_ind(callId, Convert.ToInt32(isTyping), null));
        }

        public void HangupAll()
        {
            PJSUA_DLL.Calls.pjsua_call_hangup_all();
        }

        public string Dump(int callId, bool withMedia, uint maxlen, string indent)
        {
            IntPtr ptr = IntPtr.Zero;
            try
            {
                ptr = Marshal.AllocHGlobal((int) maxlen);
                Helper.GuardError(PJSUA_DLL.Calls.pjsua_call_dump(callId, Convert.ToInt32(withMedia), ptr, maxlen,
                                                                  indent));
                return Marshal.PtrToStringAnsi(ptr, withMedia ? 2000 : 1000);
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }
        }

        #endregion
    }
}