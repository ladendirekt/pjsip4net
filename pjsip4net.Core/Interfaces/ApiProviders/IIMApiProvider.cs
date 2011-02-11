using System;
using pjsip4net.Core.Data;

namespace pjsip4net.Core.Interfaces.ApiProviders
{
    /// <summary>
    /// An abstraction of service enabling access to pjsua im API <seealso cref="http://www.pjsip.org/pjsip/docs/html/group__PJSUA__LIB__BUDDY.htm"/>
    /// </summary>
    public interface IIMApiProvider
    {
        BuddyConfig GetDefaultConfig();
        //uint pjsua_get_buddy_count();
        //bool pjsua_buddy_is_valid(int buddy_id);
        //int pjsua_enum_buddies(int[] ids, ref uint count);
        //int pjsua_buddy_find(ref pj_str_t uri);
        BuddyInfo GetInfo(int buddyId);
        //int pjsua_buddy_set_user_data(int buddy_id, IntPtr user_data);
        //IntPtr pjsua_buddy_get_user_data(int buddy_id);
        int AddBuddyAndGetId(BuddyConfig buddyCfg);
        void DeleteBuddy(int buddyId);
        void SubscribeBuddyPresence(int buddyId);
        void UnsubscribeBuddyPresence(int buddyId);
        void UpdatePresence(int buddyId);
        //int pjsua_pres_notify(int acc_id, IntPtr srv_pres, pjsip_evsub_state state,
        //                      ref pj_str_t state_str, ref pj_str_t reason, int with_body, pjsua_msg_data msg_data);

        void DumpPresence(bool verbose);
        void SendIm(int accId, string to, string mimeType, string content);
        void SendIsTyping(int accId, string to);
        void SendIsNotTyping(int accId, string to);
    }
}