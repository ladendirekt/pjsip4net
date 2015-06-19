using System;
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
        InviteState InviteState { get; }
        CallMediaState MediaState { get; }

        void Answer(bool accept);
        void Answer(bool accept, string reason);
        void Hangup();
        void Hangup(string reason);
        void ConnectToConference();
        void DisconnectFromConference();
        void SendDtmf(string digits);
        void Hold();
        void ReleaseHold();
        void Transfer(string destinationUri);
        string ToString(bool withMedia);
        /// <summary>
        /// This function start to record, the call is running in the moment of the execute, Throw Exception if it fail to init record
        /// </summary>
        /// <param name="path">Name File to Record call</param>
        void RecordTo(string path);
        
    }
}