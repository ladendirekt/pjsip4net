using System;
using pjsip4net.Core.Interfaces;

namespace pjsip4net.Interfaces
{
    public interface ISipUserAgent : IDisposable
    {
        IImManager ImManager { get; }
        ICallManager CallManager { get; }
        IAccountManager AccountManager { get; }
        IMediaManager MediaManager { get; }

        event EventHandler<LogEventArgs> Log;

        ISipUserAgent Start();
        void DumpInfo(bool detail);
        void Destroy();
    }

    internal interface ISipUserAgentInternal : ISipUserAgent
    {
        IContainer Container { get; }

        void SetManagers(IImManager imManager, ICallManager callManager, IAccountManager accountManager,
                         IMediaManager mediaManager);
    }
}