using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;
using pjsip4net.IM;

namespace pjsip4net.Interfaces
{
    public interface IBuddy : IInitializable
    {
        int Id { get; }
        string Uri { get; set; }
        bool Subscribe { get; set; }
        string Contact { get; }
        BuddyStatus Status { get; }
        string StatusText { get; }
        bool MonitoringPresence { get; }
        BuddyActivity Activity { get; }
        string ActivityNote { get; }
        void UpdatePresenceState();
        void Unregister();
    }

    internal interface IBuddyInternal : IBuddy, IResource
    {
        BuddyConfig Config { get; }
        BuddyInfo GetInfo();
        BuddyStateChangedEventArgs GetEventArgs();
        void SetId(int id);
    }
}