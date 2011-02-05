namespace pjsip4net
{
    public class TypingEventArgs : PagerEventArgs
    {
        public TypingEventArgs(string from, string to, string contact, int callId, bool isTyping)
            : base(from, to, contact, null, callId, null)
        {
            IsTyping = isTyping;
        }

        public bool IsTyping { get; private set; }
    }
}