using System;
using pjsip.Interop.Interfaces;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;

namespace pjsip.Interop.ApiProviders
{
    public class AccountApiProvider_1_4 : IAccountApiProvider
    {
        private IMapper _mapper;

        public AccountApiProvider_1_4(IMapper mapper)
        {
            Helper.GuardNotNull(mapper);
            _mapper = mapper;
        }

        #region Implementation of IAccountApiProvider

        public AccountConfig GetDefaultConfig()
        {
            var cfg = new pjsua_acc_config();
            PJSUA_DLL.Accounts.pjsua_acc_config_default(cfg);
            return _mapper.Map(cfg, new AccountConfig());
        }

        public bool IsValidAccount(int accId)
        {
            return PJSUA_DLL.Accounts.pjsua_acc_is_valid(accId);
        }

        public void SetDefaultAccount(int accId)
        {
            Helper.GuardError(PJSUA_DLL.Accounts.pjsua_acc_set_default(accId));
        }

        public int GetDefaultAccountId()
        {
            return PJSUA_DLL.Accounts.pjsua_acc_get_default();
        }

        public int AddAccountAndGetId(AccountConfig accCfg, bool isDefault)
        {
            int id = NativeConstants.PJSUA_INVALID_ID;
            var cfg = new pjsua_acc_config();
            PJSUA_DLL.Accounts.pjsua_acc_config_default(cfg);
            cfg = _mapper.Map(accCfg, cfg);
            Helper.GuardError(PJSUA_DLL.Accounts.pjsua_acc_add(cfg, Convert.ToInt32(isDefault), ref id));
            return id;
        }

        public int AddLocalAccountAndGetId(int transportId, bool isDefault)
        {
            int id = NativeConstants.PJSUA_INVALID_ID;
            Helper.GuardError(PJSUA_DLL.Accounts.pjsua_acc_add_local(transportId, Convert.ToInt32(isDefault), ref id));
            return id;
        }

        public void DeleteAccount(int accId)
        {
            Helper.GuardError(PJSUA_DLL.Accounts.pjsua_acc_del(accId));
        }

        public void SetAccountOnlineStatus(int accId, bool isOnline)
        {
            Helper.GuardError(PJSUA_DLL.Accounts.pjsua_acc_set_online_status(accId, Convert.ToInt32(isOnline)));
        }

        public void SetAccountOnlineStatus(int accId, bool isOnline, RpidElement pr)
        {
            Helper.GuardPositiveInt(accId);
            Helper.GuardNotNull(pr);
            var prpr = new pjrpid_element()
                           {
                               activity = (pjrpid_activity) pr.Activity,
                               id = new pj_str_t(pr.Id),
                               note = new pj_str_t(pr.Note),
                           };
            Helper.GuardError(PJSUA_DLL.Accounts.pjsua_acc_set_online_status2(accId, Convert.ToInt32(isOnline), ref prpr));
        }

        public void SetAccountRegistration(int accId, bool renew)
        {
            Helper.GuardError(PJSUA_DLL.Accounts.pjsua_acc_set_registration(accId, Convert.ToInt32(renew)));
        }

        public AccountInfo GetInfo(int accId)
        {
            var info = new pjsua_acc_info();
            Helper.GuardError(PJSUA_DLL.Accounts.pjsua_acc_get_info(accId, ref info));
            return _mapper.Map(info);
        }

        public int GetBestSuitingAccountIdForUrl(string url)
        {
            var uri = new pj_str_t(url);
            return PJSUA_DLL.Accounts.pjsua_acc_find_for_outgoing(ref uri);
        }

        public void SetTransport(int accId, int tpId)
        {
            Helper.GuardError(PJSUA_DLL.Accounts.pjsua_acc_set_transport(accId, tpId));
        }

        #endregion
    }
}