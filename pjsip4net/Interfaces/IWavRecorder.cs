using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pjsip4net.Core.Interfaces;

namespace pjsip4net.Interfaces
{
    public interface IWavRecorder : IFileSourceMedia, IIdentifiable<IWavRecorder>, IDisposable
    {
        void Start(string fileName);
    }
}
