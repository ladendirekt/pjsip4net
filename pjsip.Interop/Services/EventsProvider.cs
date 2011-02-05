using System;
using Magnum.Pipeline;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;

namespace pjsip.Interop.Services
{
    public class EventsProvider : IEventsProvider
    {
        private Pipe _eventsPipe;
        private ISubscriptionScope _scope;

        public EventsProvider(Pipe eventsPipe)
        {
            Helper.GuardNotNull(eventsPipe);
            _eventsPipe = eventsPipe;
            _scope = _eventsPipe.NewSubscriptionScope();
        }

        #region Implementation of IEventsProvider

        public void Subscribe<T>(Action<T> actOnEvent) where T : class
        {
            _scope.Subscribe(new DelegatingConsumer<T>(actOnEvent));
        }

        #endregion
    }
}