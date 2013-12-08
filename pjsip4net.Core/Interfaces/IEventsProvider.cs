using System;

namespace pjsip4net.Core.Interfaces
{
    public interface IEventsProvider
    {
        void Publish<T>(T @event) where T : class;
        void Subscribe<T>(Action<T> actOnEvent) where T : class;
    }
}