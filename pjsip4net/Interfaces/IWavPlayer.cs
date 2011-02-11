using pjsip4net.Core.Data;

namespace pjsip4net.Interfaces
{
    public interface IWavPlayer
    {
        string File { get; }
        ConferencePortInfo ConferenceSlot { get; }
    }
}