using System;
using System.ComponentModel;

namespace pjsip4net.Core.Interfaces
{
    public interface IInitializable : ISupportInitialize
    {
        bool IsInitialized { get; }
        IDisposable InitializationScope();
    }
}