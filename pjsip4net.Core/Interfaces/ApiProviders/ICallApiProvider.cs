using System;
using pjsip4net.Core.Data;

namespace pjsip4net.Core.Interfaces.ApiProviders
{
    public interface ICallApiProvider
    {
        uint GetMaxAllowedCalls();
        //uint pjsua_call_get_count();
        //int pjsua_enum_calls(int[] ids, ref uint count);
        int MakeCallAndGetId(int accId, string dstUri, uint options);
        bool IsCallActive(int callId);
        bool CallHasMedia(int callId);
        int GetConfPort(int callId);
        CallInfo GetInfo(int callId);
        //int pjsua_call_set_user_data(int call_id, IntPtr user_data);
        //IntPtr pjsua_call_get_user_data(int call_id);
        //int pjsua_call_get_rem_nat_type(int call_id, ref pj_stun_nat_type p_type);
        void AnswerCall(int callId, SipStatusCode code, string reason);
        void HangupCall(int callId, SipStatusCode code, string reason);
        void ProcessCallRedirect(int callId, RedirectOption cmd);
        void PutCallOnHold(int callId);
        void ReinviteCall(int callId, bool unhold);
        //int pjsua_call_update(int call_id, uint options, pjsua_msg_data msg_data);
        //int pjsua_call_xfer(int call_id, ref pj_str_t dest, pjsua_msg_data msg_data);
        //int pjsua_call_xfer_replaces(int call_id, int dest_call_id, uint options, pjsua_msg_data msg_data);
        void DialDtmf(int callId, string digits);
        void SendIm(int callId, string mime_type, string content);
        void SendTypingInd(int callId, bool isTyping);

        //int pjsua_call_send_request(int call_id,
        //                            ref pj_str_t method, pjsua_msg_data msg_data);

        void HangupAll();
        string Dump(int callId, bool withMedia, uint maxlen, string indent);


    }
}