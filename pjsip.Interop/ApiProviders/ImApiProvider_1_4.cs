using System;
using pjsip.Interop.Interfaces;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;

namespace pjsip.Interop.ApiProviders
{
    public class ImApiProvider_1_4 : IIMApiProvider
    {
        private IMapper _mapper;

        public ImApiProvider_1_4(IMapper mapper)
        {
            Helper.GuardNotNull(mapper);
            _mapper = mapper;
        }

        #region Implementation of IIMApiProvider

        public BuddyConfig GetDefaultConfig()
        {
            var cfg = new pjsua_buddy_config();
            PJSUA_DLL.IM.pjsua_buddy_config_default(cfg);
            return _mapper.Map(cfg, new BuddyConfig());
        }

        public BuddyInfo GetInfo(int buddyId)
        {
            Helper.GuardPositiveInt(buddyId);
            var info = new pjsua_buddy_info();
            Helper.GuardError(PJSUA_DLL.IM.pjsua_buddy_get_info(buddyId, ref info));
            return _mapper.Map(info);
        }

        public int AddBuddyAndGetId(BuddyConfig buddyCfg)
        {
            Helper.GuardNotNull(buddyCfg);
            var id = NativeConstants.PJSUA_INVALID_ID;
            Helper.GuardError(PJSUA_DLL.IM.pjsua_buddy_add(_mapper.Map(buddyCfg, new pjsua_buddy_config()), ref id));
            return id;
        }

        public void DeleteBuddy(int buddyId)
        {
            Helper.GuardPositiveInt(buddyId);
            Helper.GuardError(PJSUA_DLL.IM.pjsua_buddy_del(buddyId));
        }

        public void SubscribeBuddyPresence(int buddyId)
        {
            Helper.GuardPositiveInt(buddyId);
            Helper.GuardError(PJSUA_DLL.IM.pjsua_buddy_subscribe_pres(buddyId, 1));
        }

        public void UnsubscribeBuddyPresence(int buddyId)
        {
            Helper.GuardPositiveInt(buddyId);
            Helper.GuardError(PJSUA_DLL.IM.pjsua_buddy_subscribe_pres(buddyId, 0));
        }

        public void UpdatePresence(int buddyId)
        {
            Helper.GuardPositiveInt(buddyId);
            Helper.GuardError(PJSUA_DLL.IM.pjsua_buddy_update_pres(buddyId));
        }

        public void DumpPresence(bool verbose)
        {
            PJSUA_DLL.IM.pjsua_pres_dump(Convert.ToInt32(verbose));
        }

        public void SendIm(int accId, string to, string mimeType, string content)
        {
            Helper.GuardPositiveInt(accId);
            var tto = new pj_str_t(to);
            var mime = new pj_str_t(mimeType);
            var cntnt = new pj_str_t(content);
            Helper.GuardError(PJSUA_DLL.IM.pjsua_im_send(accId, ref tto, ref mime, ref cntnt, null, IntPtr.Zero));
        }

        public void SendIsTyping(int accId, string to)
        {
            Helper.GuardPositiveInt(accId);
            var tto = new pj_str_t(to);
            Helper.GuardError(PJSUA_DLL.IM.pjsua_im_typing(accId, ref tto, 1, null));
        }

        public void SendIsNotTyping(int accId, string to)
        {
            Helper.GuardPositiveInt(accId);
            var tto = new pj_str_t(to);
            Helper.GuardError(PJSUA_DLL.IM.pjsua_im_typing(accId, ref tto, 0, null));
        }

        #endregion
    }
}