using System;
using System.Collections.ObjectModel;
using pjsip4net.Calls;
using pjsip4net.Core.Data.Events;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;

namespace pjsip4net.Interfaces
{
    public interface ICallManager
    {
        ReadOnlyCollection<ICall> Calls { get; }
        uint MaxCalls { get; set; }
        event EventHandler<EventArgs<ICall>> IncomingCall;
        event EventHandler<CallStateChangedEventArgs> CallStateChanged;
        event EventHandler<DtmfEventArgs> IncomingDtmfDigit;
        event EventHandler<RingEventArgs> Ring;
        event EventHandler<CallTransferEventArgs> CallTransfer;
        event EventHandler<CallRedirectedEventArgs> CallRedirected;
        ICall MakeCall(string destinationUri);
        ICall MakeCall(IAccount account, string destinationUri);
        void HangupAll();
        ICall GetCallById(int id);
    }

    internal interface ICallManagerInternal : ICallManager, IInitializable
    {
        IBasicApiProvider BasicApiProvider { get; }
        ICallApiProvider CallApiProvider { get; }
        IMediaApiProvider MediaApiProvider { get; }

        void RaiseCallStateChanged(ICallInternal call);
        void RaiseRingEvent(ICallInternal call, bool ringOn);
        void TerminateCall(ICallInternal call);
        void OnCallState(CallStateChanged e);
        void OnIncomingCall(IncomingCallRecieved e);
        void OnCallMediaState(CallMediaStateChanged e);
        void OnStreamDestroyed(StreamDestroyed e);
        void OnDtmfDigit(DtmfRecieved e);
        void OnCallTransfer(CallTransferRequested e);
        void OnCallTransferStatus(CallTransferStatusChanged e);
    }
}