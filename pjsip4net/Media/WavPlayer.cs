using System;
using System.IO;
using pjsip4net.Core;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.Media
{
    public class WavPlayer : Resource, IWavPlayer, IIdentifiable<IWavPlayer>, IDisposable
    {
        #region Private Data

        private ConferencePortInfo _mediaInfo;
        private IMediaApiProvider _mediaApi;

        #endregion

        #region Properties

        public string File { get; private set; }

        public ConferencePortInfo ConferenceSlot
        {
            get
            {
                //GuardDisposed();
                if (Id != -1)
                    if (_mediaInfo == null)
                        _mediaInfo = _mediaApi.GetPortInfo(Id);
                return _mediaInfo;
            }
        }

        public int Id { get; private set; }

        #endregion

        #region Methods

        public WavPlayer(IMediaApiProvider mediaApi)
        {
            Id = -1;
            Helper.GuardNotNull(mediaApi);
            _mediaApi = mediaApi;
        }

        public void Start(string file, bool loop)
        {
            GuardDisposed();
            Helper.GuardNotNullStr(file);

            var filename = Path.GetFullPath(file);
            File = file;
            Id = _mediaApi.CreatePlayerAndGetId(filename, loop ? 1u : 0u);
        }

        public void SetPosition(uint position)
        {
            GuardDisposed();
            _mediaApi.SetPlayerPosition(Id, position);
        }

        protected override void CleanUp()
        {
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
            return File.Equals(other.File) && ConferenceSlot.Equals(other.ConferenceSlot);
        }

        #endregion
    }
}