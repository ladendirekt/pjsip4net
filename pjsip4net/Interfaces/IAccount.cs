using System;
using System.Collections.Generic;
using System.Net;
using pjsip4net.Accounts;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;

namespace pjsip4net.Interfaces
{
    public interface IAccount : IInitializable
    {
        int Id { get; }
        string AccountId { get; set; }
        NetworkCredential Credential { get; set; }
        SrtpRequirement UseSrtp { get; set; }
        int SecureSignaling { get; set; }
        int Priority { get; set; }
        string RegistrarUri { get; set; }
        string RegistrarDomain { get; }
        string RegistrarPort { get; }
        bool PublishPresence { get; set; }
        ICollection<string> Proxies { get; }
        uint RegistrationTimeout { get; set; }
        uint KeepAliveInterval { get; set; }
        bool? IsOnline { get; }
        string OnlineStatusText { get; }
        bool IsRegistered { get; }
        bool? IsDefault { get; }
        string Uri { get; }
        bool? HasRegistration { get; }
        int? Expires { get; }
        SipStatusCode? StatusCode { get; }
        string StatusText { get; }
        IVoIPTransport Transport { get; set; }

        void SetConfig(AccountConfig config);
        void PublishOnline(string note);
        void RenewRegistration();
        void Unregister();
    }

    internal interface IAccountInternal : IAccount, IResource
    {
        AccountConfig Config { get; }
        bool IsInUse { get; }
        bool IsLocal { get; set; }

        IDisposable Lock();
        void HandleStateChanged();
        void SetId(int id);
        void SetTransport(IVoIPTransport transport);
        AccountStateChangedEventArgs GetEventArgs();
        AccountInfo GetAccountInfo();
    }
}