using System;
using System.IO;
using pjsip4net.Core;
using pjsip4net.Core.Data;
using pjsip4net.Core.Data.Events;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.Media
{
    public class WavPlayer : Resource, IWavPlayer
    {
        #region Private Data

        private ConferencePortInfo _mediaInfo;
        private readonly IMediaApiProvider _mediaApi;
        private IDisposable _subscription;

        #endregion

        #region Properties

        public string File { get; private set; }

        public int ConferencePortId
        {
            get { return Id != -1 ? _mediaApi.GetPlayerConfPort(Id) : -1; }
        }

        public ConferencePortInfo ConferenceSlot
        {
            get
            {
                if (Id != -1 && ConferencePortId != -1)
                    if (_mediaInfo == null)
                        _mediaInfo = _mediaApi.GetPortInfo(ConferencePortId);
                return _mediaInfo;
            }
        }

        public int Id { get; private set; }

        public event EventHandler<EventArgs> Completed = delegate { };

        #endregion

        #region Methods

        public WavPlayer(IMediaApiProvider mediaApi, IEventsProvider eventsProvider)
        {
            Id = -1;
            Helper.GuardNotNull(mediaApi);
            Helper.GuardNotNull(eventsProvider);
            _mediaApi = mediaApi;
            _subscription = eventsProvider.SubscribeTemporarilly<PlayerCompleted>(OnPlayerEof);
        }

        public void Start(string file, bool loop)
        {
            GuardDisposed();
            ValidFileNameTemplate.Check(file);

            var filename = Path.GetFullPath(file);
            File = file;
            Id = _mediaApi.CreatePlayerAndGetId(filename, loop ? 0u : 1u);
        }

        public void SetPosition(uint position)
        {
            GuardDisposed();
            _mediaApi.SetPlayerPosition(Id, position);
        }

        protected override void CleanUp()
        {
            _subscription.Dispose();
            try
            {
                _mediaApi.DestroyPlayer(Id);
            }
            finally
            {
                _mediaInfo = null;
                Id = -1;
            }
        }

        private void OnPlayerEof(PlayerCompleted @event)
        {
            if (@event.Id == Id)
                Completed(this, EventArgs.Empty);
        }

        #endregion

        #region Implementation of IDisposable

        public void Dispose()
        {
            Dispose(true);
        }

        #endregion

        #region Implementation of IEquatable<IIdentifiable<WavPlayer>>

        public bool Equals(IIdentifiable<IWavPlayer> other)
        {
            return EqualsTemplate.Equals(this, other);
        }

        bool IIdentifiable<IWavPlayer>.DataEquals(IWavPlayer other)
        {
            return ConferencePortId.Equals(other.ConferencePortId);
        }

        #endregion
    }
}