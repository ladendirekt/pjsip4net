using System;
using pjsip4net.Core.Interfaces;

namespace pjsip4net.Interfaces
{
    public interface IWavRecorder : IFileSourceMedia, IIdentifiable<IWavRecorder>, IDisposable
    {
        void Start(string fileName);
    }
}
