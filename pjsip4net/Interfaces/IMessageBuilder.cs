using pjsip4net.Accounts;
using pjsip4net.Calls;

namespace pjsip4net.Interfaces
{
    public interface IMessageBuilder
    {
        IMessageBuilder To(string extension);
        IMessageBuilder At(string domain);
        IMessageBuilder Through(string port);
        IMessageBuilder WithBody(string body);
        IMessageBuilder From(IAccount account);
        IMessageBuilder InDialogOf(ICall call);
        void Send();
        void SendTyping();
        void SendFinishedTyping();
    }
}