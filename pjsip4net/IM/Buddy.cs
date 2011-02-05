using System;
using pjsip4net.Core;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.IM
{
    internal class Buddy : Initializable, IBuddyInternal, IIdentifiable<IBuddy>
    {
        private readonly object _lock = new object();
        private readonly IImManagerInternal _manager;
        internal BuddyConfig _config;

        #region Properties

        public string Uri
        {
            get { return _config.Uri; }
            set
            {
                GuardNotInitializing();
                _config.Uri = value;
            }
        }

        public bool Subscribe
        {
            get { return _config.Subscribe; }
            set
            {
                GuardNotInitializing();
                _config.Subscribe = value;
            }
        }

        public string Contact
        {
            get { return GetInfo().Contact; }
        }

        public BuddyStatus Status
        {
            get { return GetInfo().Status; }
        }

        public string StatusText
        {
            get { return GetInfo().StatusText; }
        }

        public bool MonitoringPresence
        {
            get { return GetInfo().MonitorPresence; }
        }

        public BuddyActivity Activity
        {
            get { return (BuddyActivity) GetInfo().Rpid.Activity; }
        }

        public string ActivityNote
        {
            get { return GetInfo().Rpid.Note; }
        }

        public int Id { get; internal set; }

        #endregion

        #region Methods

        public Buddy(IImManagerInternal manager)
        {
            Helper.GuardNotNull(manager);
            _manager = manager;
            _config = _manager.Provider.GetDefaultConfig();
            Id = -1;
        }

        public override void EndInit()
        {
            base.EndInit();
            Helper.GuardIsTrue(new SipUriParser(Uri).IsValid);
        }

        public void UpdatePresenceState()
        {
            GuardDisposed();
            _manager.Provider.UpdatePresence(Id);
        }

        public void Unregister()
        {
            GuardDisposed();
            _manager.UnregisterBuddy(this);
        }

        protected override void CleanUp()
        {
            base.CleanUp();
            Id = -1;
        }

        public BuddyConfig Config
        {
            get { return _config; }
        }

        public BuddyInfo GetInfo()
        {
            GuardDisposed();
            //lock (_lock)
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

        public BuddyStateChangedEventArgs GetEventArgs()
        {
            var info = GetInfo();
            return new BuddyStateChangedEventArgs
                       {
                           Id = Id,
                           Uri = info.Uri,
                           StatusText = _isDisposed ? "" : info.StatusText,
                           Status = _isDisposed ? BuddyStatus.Unknown : info.Status,
                           Note = _isDisposed ? "unknown" : info.Rpid.Note
                       };
        }

        public void SetId(int id)
        {
            Helper.GuardPositiveInt(id);
            Id = id;
        }

        #endregion

        #region Implementation of IEquatable<IIdentifiable<IBuddy>>

        public bool Equals(IIdentifiable<IBuddy> other)
        {
            return EqualsTemplate.Equals(this, other);
        }

        bool IIdentifiable<IBuddy>.DataEquals(IBuddy other)
        {
            return Uri.Equals(other.Uri);
        }

        #endregion

        //public static BuddyBuilder Create()
        //{
        //    return new BuddyBuilder();
        //}
    }
}