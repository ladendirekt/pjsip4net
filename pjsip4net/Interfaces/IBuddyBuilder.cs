using pjsip4net.Core;

namespace pjsip4net.Interfaces
{
    public interface IBuddyBuilder
    {
        IBuddyBuilder WithName(string name);
        IBuddyBuilder Through(string port);
        IBuddyBuilder At(string domain);
        IBuddyBuilder Via(TransportType transport);
        IBuddyBuilder Subscribing();
        IBuddy Register();
    }
}