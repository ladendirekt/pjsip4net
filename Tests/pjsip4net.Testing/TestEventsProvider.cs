using System;
using pjsip4net.Core.Interfaces.ApiProviders;

namespace pjsip4net.Testing
{
    public class TestEventsProvider : IEventsProvider
    {
        public void Subscribe<T>(Action<T> actOnEvent) where T : class
        {
        }
    }
}