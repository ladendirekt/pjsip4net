using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using Common.Logging;
using pjsip4net.Core;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.Accounts
{
    internal class Account : Initializable, IAccountInternal, IIdentifiable<IAccount>
    {
        private bool _isLocal;
        private readonly object _lock = new object();
        private readonly RegistrationSession _session;
        private AccountConfig _config;
        private uint _lockCount;
        private IVoIPTransport _transport;
        private ILog _logger = LogManager.GetLogger<IAccount>();

        private IAccountManagerInternal _manager;

        #region Properties

        public string AccountId
        {
            get
            {
                GuardDisposed();
                return _config.Id;
            }
            set
            {
                GuardDisposed();
                GuardNotInitializing();

                _config.Id = value;
            }
        }

        public NetworkCredential Credential
        {
            get
            {
                GuardDisposed();
                return _config.Credentials.Count > 0 ? _config.Credentials[0] : null;
            }
            set
            {
                GuardDisposed();
                GuardNotInitializing();
                if (value != null)
                {
                    if (_config.Credentials.Count == 0)
                        _config.Credentials.Add(value);
                    else
                        _config.Credentials[0] = value;
                }
                else _config.Credentials.Clear();
            }
        }

        public SrtpRequirement UseSrtp
        {
            get
            {
                GuardDisposed();
                return _config.UseSrtp;
            }
            set
            {
                GuardDisposed();
                GuardNotInitializing();
                _config.UseSrtp = value;
            }
        }

        public int SecureSignaling
        {
            get
            {
                GuardDisposed();
                return _config.SrtpSecureSignaling;
            }
            set
            {
                GuardDisposed();
                GuardNotInitializing();
                _config.SrtpSecureSignaling = value;
            }
        }

        bool IAccountInternal.IsLocal
        {
            get
            {
                GuardDisposed();
                return _isLocal;
            }
            set
            {
                _isLocal = value;
            }
        }

        public int Priority
        {
            get
            {
                GuardDisposed();
                return _config.Priority;
            }
            set
            {
                GuardDisposed();
                GuardNotInitializing();
                _config.Priority = value;
            }
        }

        public string RegistrarUri
        {
            get
            {
                GuardDisposed();
                return _config.RegUri;
            }
            set
            {
                GuardDisposed();
                GuardNotInitializing();
                var parser = new SipUriParser(value);
                Helper.GuardIsTrue(parser.IsValid);

                _config.RegUri = value;

                RegistrarDomain = parser.Domain;
                RegistrarPort = parser.Port;
            }
        }

        public string RegistrarDomain { get; internal set; }

        public string RegistrarPort { get; internal set; }

        public virtual IVoIPTransport Transport
        {
            get { return _transport; }
            set
            {
                GuardDisposed();
                _transport = value;
            }
        }

        public bool PublishPresence
        {
            get
            {
                GuardDisposed();
                return _config.IsPublishEnabled;
            }
            set
            {
                GuardDisposed();
                GuardNotInitializing();
                _config.IsPublishEnabled = value;
            }
        }

        public ICollection<string> Proxies
        {
            get
            {
                GuardDisposed();
                return _config.Proxy;
            }
        }

        public uint RegistrationTimeout
        {
            get
            {
                GuardDisposed();
                return _config.RegTimeout;
            }
            set
            {
                GuardDisposed();
                GuardNotInitializing();
                _config.RegTimeout = value;
            }
        }

        public uint KeepAliveInterval
        {
            get
            {
                GuardDisposed();
                return _config.KaInterval;
            }
            set
            {
                GuardDisposed();
                GuardNotInitializing();
                _config.KaInterval = value;
            }
        }

        public bool? IsOnline
        {
            get
            {
                GuardDisposed();
                var info = GetAccountInfo();
                return !Equals(info, null) ? (bool?) (info.OnlineStatus == 1) : null;
            }
        }

        public string OnlineStatusText
        {
            get
            {
                GuardDisposed();
                var info = GetAccountInfo();
                return !Equals(info, null) ? info.OnlineStatusText : "";
            }
        }

        public bool IsRegistered
        {
            get
            {
                GuardDisposed();
                return _session.IsRegistered;
            }
        }

        public bool? IsDefault
        {
            get
            {
                GuardDisposed();
                var info = GetAccountInfo();
                return !Equals(info, null) ? (bool?) (info.IsDefault == 1) : null;
            }
        }

        public string Uri
        {
            get
            {
                GuardDisposed();
                var info = GetAccountInfo();
                return !Equals(info, null) ? info.AccUri : "";
            }
        }

        public bool? HasRegistration
        {
            get
            {
                GuardDisposed();
                var info = GetAccountInfo();
                return !Equals(info, null) ? (bool?) (info.HasRegistration == 1) : null;
            }
        }

        public int? Expires
        {
            get
            {
                GuardDisposed();
                var info = GetAccountInfo();
                return !Equals(info, null) ? (int?) info.Expires : null;
            }
        }

        public SipStatusCode? StatusCode
        {
            get
            {
                GuardDisposed();
                var info = GetAccountInfo();
                return !Equals(info, null) ? (SipStatusCode?) info.Status : null;
            }
        }

        public string StatusText
        {
            get
            {
                GuardDisposed();
                var info = GetAccountInfo();
                return !Equals(info, null) ? info.StatusText : "";
            }
        }

        public AccountConfig Config
        {
            get { return _config; }
        }

        public bool IsInUse
        {
            get
            {
                lock (_lock)
                    return _lockCount != 0;
            }
        }

        public int Id { get; internal set; }

        #endregion

        #region Methods

        public Account(IAccountManagerInternal accountManager)
        {
            Helper.GuardNotNull(accountManager);
            _manager = accountManager;
            Id = -1;
            _session = new RegistrationSession(this);
            _session.StateChanged += delegate { OnRegistrationStateChanged(); }; 
        }

        public override void BeginInit()
        {
            base.BeginInit();
            _config = _manager.Provider.GetDefaultConfig();
        }

        public override void EndInit()
        {
            base.EndInit();
            Helper.GuardPositiveInt(Priority);
            if (!_isLocal)
            {
                Helper.GuardNotNullStr(AccountId);
                Helper.GuardNotNullStr(RegistrarUri);
                Helper.GuardIsTrue(new SipUriParser(AccountId).IsValid);
                Helper.GuardIsTrue(new SipUriParser(RegistrarUri).IsValid);
            }
        }

        public void SetConfig(AccountConfig config)
        {
            GuardNotInitializing();
            Helper.GuardNotNull(config);
            _config = config;
        }

        public void PublishOnline(string note)
        {
            GuardDisposed();
            GuardNotInitialized();
            if (!PublishPresence)
                return;
            _manager.Provider.SetAccountOnlineStatus(Id, true,
                                                     new RpidElement() {Activity = RpidActivity.Unknown, Note = note});
        }

        public void RenewRegistration()
        {
            GuardDisposed();
            GuardNotInitialized();
            if (!_session.IsRegistered && Id != -1 && !((IAccountInternal) this).IsLocal)
            {
                _manager.Provider.SetAccountRegistration(Id, true);
                _session.HandleStateChanged();
            }
        }

        public void Unregister()
        {
            GuardDisposed();
            GuardNotInitialized();
            _manager.UnregisterAccount(this);
        }

        public void HandleStateChanged()
        {
            _session.HandleStateChanged();
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public void SetTransport(IVoIPTransport transport)
        {
            Transport = transport;
        }

        protected void OnRegistrationStateChanged()
        {
            _manager.RaiseStateChanged(this);
        }

        public AccountInfo GetAccountInfo()
        {
            lock (_lock)
            {
                if (Id != -1)
                    try
                    {
                        return _manager.Provider.GetInfo(Id);
                    }
                    catch (PjsipErrorException)
                    {
                        return _manager.Provider.GetInfo(Id);
                    }
                return null;
            }
        }

        public AccountStateChangedEventArgs GetEventArgs()
        {
            var info = GetAccountInfo() ?? new AccountInfo();
            return new AccountStateChangedEventArgs
                       {
                           Id = Id,
                           Uri = _config.Id,
                           StatusText = _isDisposed ? "" : info.StatusText,
                           StatusCode = _isDisposed ? SipStatusCode.NotAcceptableAnywhere : info.Status
                       };
        }

        private void AddRef()
        {
            lock (_lock)
                _lockCount++;
        }

        private void Release()
        {
            lock (_lock)
                _lockCount--;
        }

        public virtual IDisposable Lock()
        {
            return new AccountLock(this);
        }

        protected override void CleanUp()
        {
            _logger.Debug("Account " + Id + " diposed");
            _session.Dispose();
        }

        #endregion

        #region Implementation of IEquatable<IIdentifiable<Account>>

        public bool Equals(IIdentifiable<IAccount> other)
        {
            return EqualsTemplate.Equals(this, other);
        }

        bool IIdentifiable<IAccount>.DataEquals(IAccount other)
        {
            return AccountId.Equals(other.AccountId);
        }

        #endregion

        #region Nested type: AccountLock

        private class AccountLock : IDisposable
        {
            private Account _owner;

            public AccountLock(Account owner)
            {
                Helper.GuardNotNull(owner);
                _owner = owner;
                _owner.AddRef();
            }

            #region IDisposable Members

            public void Dispose()
            {
                _owner.Release();
                _owner = null;
            }

            #endregion
        }

        #endregion
    }
}