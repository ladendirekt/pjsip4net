using System;

namespace pjsip4net.Core.Interfaces.ApiProviders
{
    public interface IEventsProvider
    {
        void Subscribe<T>(Action<T> actOnEvent) where T : class;
    }
}