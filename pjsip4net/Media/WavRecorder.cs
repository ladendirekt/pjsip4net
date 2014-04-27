using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using pjsip4net.Core;
using pjsip4net.Interfaces;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;
using pjsip4net.Core.Interfaces;

namespace pjsip4net.Media
{
    public class WavRecorder:  Resource, IWavRecorder
    {
        private ConferencePortInfo _mediaInfo;
        private IMediaApiProvider _mediaApi;
        private string _fileName;

        public ConferencePortInfo ConferenceSlot
        {
            get 
            {
                if (Id != -1)
                    if (_mediaInfo == null)
                        _mediaInfo = _mediaApi.GetPortInfo(Id);
                return _mediaInfo;
            }
        }

        public string File
        {
            get { return _fileName; }
        }

        public WavRecorder(IMediaApiProvider mediaApiProvider)
        {
            Helper.GuardNotNull(mediaApiProvider);
            _mediaApi = mediaApiProvider;
        }

        public void Start(string fileName)
        {
            GuardDisposed();
            ValidFileNameTemplate.Check(fileName);
            UpdateFileNameWithPath(fileName);
            Id = _mediaApi.CreateRecorderAndGetId(File, 0, IntPtr.Zero, 0, 0);
        }

        private void UpdateFileNameWithPath(string fileName)
        {
            _fileName = Path.GetFullPath(fileName);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected override void CleanUp()
        {
            _mediaApi.DestroyRecorder(Id);
        }

        public int Id { get; private set; }

        public bool DataEquals(IWavRecorder other)
        {
            return File.Equals(other.File) && ConferenceSlot.Equals(other.ConferenceSlot);
        }

        public bool Equals(IIdentifiable<IWavRecorder> other)
        {
            return EqualsTemplate.Equals(this, other);
        }
    }
}
