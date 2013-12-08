using System;
using Magnum.Pipeline;
using Magnum.Pipeline.Segments;
using pjsip4net.Core.Interfaces;

namespace pjsip4net.Core
{
    public class EventsProvider : IEventsProvider
    {
        private readonly Pipe _eventsPipe;
        private readonly ISubscriptionScope _scope;

        public EventsProvider()
        {
            _eventsPipe = PipeSegment.Input(PipeSegment.End());;
            _scope = _eventsPipe.NewSubscriptionScope();
        }

        #region Implementation of IEventsProvider

        public void Publish<T>(T @event) where T : class
        {
            _eventsPipe.Send(@event);
        }

        public void Subscribe<T>(Action<T> actOnEvent) where T : class
        {
            _scope.Subscribe(new DelegatingConsumer<T>(actOnEvent));
        }

        #endregion
    }
}