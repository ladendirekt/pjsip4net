using pjsip4net.Core.Data;

namespace pjsip4net.Interfaces
{
    public interface IFileSourceMedia
    {
        string File { get; }
        int ConferencePortId { get; }
        ConferencePortInfo ConferenceSlot { get; }
    }
}
