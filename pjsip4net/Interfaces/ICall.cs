using System;
using pjsip4net.Calls;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;

namespace pjsip4net.Interfaces
{
    public interface ICall : IInitializable
    {
        int Id { get; }
        IAccount Account { get; }
        string DestinationUri { get; }
        bool IsIncoming { get; }
        bool IsActive { get; }
        bool HasMedia { get; }
        string LocalInfo { get; }
        string LocalContact { get; }
        string RemoteInfo { get; }
        string RemoteContact { get; }
        string DialogId { get; }
        string StateText { get; }
        SipStatusCode LastStatusCode { get; }
        string LastStatusText { get; }
        int ConferenceSlotId { get; }
        double RxLevel { get; set; }
        double TxLevel { get; set; }
        TimeSpan ConnectDuration { get; }
        TimeSpan TotalDuration { get; }

        void Answer(bool accept);
        void Answer(bool accept, string reason);
        void Hangup();
        void Hangup(string reason);
        void ConnectToConference();
        void DisconnectFromConference();
        void SendDtmf(string digits);
        void Hold();
        void ReleaseHold();
        string ToString(bool withMedia);
    }

    internal interface ICallInternal : ICall, IResource
    {
        InviteState InviteState { get; }
        CallMediaState MediaState { get; }
        InviteSession InviteSession { get; }
        void HandleInviteStateChanged();
        void HandleMediaStateChanged();
        void SetId(int id);
        void SetDestinationUri(string uri);
        void SetAccount(IAccountInternal account);
        void SetAsIncoming();
        CallInfo GetCallInfo();
    }
}