using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces.ApiProviders;

namespace pjsip4net.Testing
{
    public class ImApiTestProvider : IIMApiProvider
    {
        public BuddyConfig GetDefaultConfig()
        {
            return new BuddyConfig();
        }

        public BuddyInfo GetInfo(int buddyId)
        {
            return new BuddyInfo();
        }

        public int AddBuddyAndGetId(BuddyConfig buddyCfg)
        {
            return 0;
        }

        public void DeleteBuddy(int buddyId)
        {
        }

        public void SubscribeBuddyPresence(int buddyId)
        {
        }

        public void UnsubscribeBuddyPresence(int buddyId)
        {
        }

        public void UpdatePresence(int buddyId)
        {
        }

        public void DumpPresence(bool verbose)
        {
        }

        public void SendIm(int accId, string to, string mimeType, string content)
        {
        }

        public void SendIsTyping(int accId, string to)
        {
        }

        public void SendIsNotTyping(int accId, string to)
        {
        }
    }
}