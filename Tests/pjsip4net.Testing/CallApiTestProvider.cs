using System;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces.ApiProviders;

namespace pjsip4net.Testing
{
    public class CallApiTestProvider : ICallApiProvider
    {
        public uint GetMaxAllowedCalls()
        {
            return 1;
        }

        public int MakeCallAndGetId(int accId, string dstUri, uint options)
        {
            return 0;
        }

        public bool IsCallActive(int callId)
        {
            return Convert.ToBoolean(new Random().Next(1));
        }

        public bool CallHasMedia(int callId)
        {
            return Convert.ToBoolean(new Random().Next(1));
        }

        public int GetConfPort(int callId)
        {
            return 0;
        }

        public CallInfo GetInfo(int callId)
        {
            throw new System.NotImplementedException();
        }

        public void AnswerCall(int callId, SipStatusCode code, string reason)
        {
            throw new System.NotImplementedException();
        }

        public void HangupCall(int callId, SipStatusCode code, string reason)
        {
            throw new System.NotImplementedException();
        }

        public void ProcessCallRedirect(int callId, RedirectOption cmd)
        {
            throw new System.NotImplementedException();
        }

        public void PutCallOnHold(int callId)
        {
            throw new System.NotImplementedException();
        }

        public void ReinviteCall(int callId, bool unhold)
        {
            throw new System.NotImplementedException();
        }

        public void TransferCall(int callId, string destination)
        {
            throw new System.NotImplementedException();
        }

        public void DialDtmf(int callId, string digits)
        {
            throw new System.NotImplementedException();
        }

        public void SendIm(int callId, string mime_type, string content)
        {
            throw new System.NotImplementedException();
        }

        public void SendTypingInd(int callId, bool isTyping)
        {
            throw new System.NotImplementedException();
        }

        public void HangupAll()
        {
            throw new System.NotImplementedException();
        }

        public string Dump(int callId, bool withMedia, uint maxlen, string indent)
        {
            throw new System.NotImplementedException();
        }
    }
}