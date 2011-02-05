using System;
using System.Collections.ObjectModel;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.IM;

namespace pjsip4net.Interfaces
{
    public interface IImManager : IDisposable, IInitializable
    {
        ReadOnlyCollection<IBuddy> Buddies { get; }
        event EventHandler<BuddyStateChangedEventArgs> BuddyStateChanged;
        event EventHandler<PagerEventArgs> IncomingMessage;
        event EventHandler<TypingEventArgs> TypingAlert;
        event EventHandler<NatEventArgs> NatDetected;
        
        IBuddy GetBuddyById(int id);
        void SendMessage(IAccount account, string body, string to);
        void SendMessageInDialog(ICall dialog, string body);
        void SendTyping(IAccount account, string to, bool isTyping);
        void SendTypingInDialog(ICall dialog, bool isTyping);
        void DumpSubscription(bool verbose);
    }

    internal interface IImManagerInternal : IImManager
    {
        IIMApiProvider Provider { get; }

        void RegisterBuddy(IBuddyInternal buddy);
        void UnregisterBuddy(IBuddyInternal buddy);
    }
}