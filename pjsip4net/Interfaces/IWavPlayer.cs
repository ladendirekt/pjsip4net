using System;
using pjsip4net.Core.Interfaces;

namespace pjsip4net.Interfaces
{
    public interface IWavPlayer : IFileSourceMedia, IIdentifiable<IWavPlayer>, IDisposable
    {
        void Start(string file, bool loop);
        void SetPosition(uint position);
        event EventHandler<EventArgs> Completed;
    }
}