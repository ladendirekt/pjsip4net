using System;
using pjsip4net.Core.Data;
using pjsip4net.Core.Data.Events;

namespace pjsip4net.Core.Interfaces.ApiProviders
{
    public interface IAccountApiProvider
    {
        AccountConfig GetDefaultConfig();
        //void pjsua_acc_config_default(pjsua_acc_config cfg);
        //uint pjsua_acc_get_count();
        bool IsValidAccount(int accId);
        void SetDefaultAccount(int accId);
        int GetDefaultAccountId();
        int AddAccountAndGetId(AccountConfig accCfg, bool isDefault);
        int AddLocalAccountAndGetId(int transportId, bool isDefault);
        //int pjsua_acc_set_user_data(int accId, IntPtr user_data);
        //IntPtr pjsua_acc_get_user_data(int acc_id);
        void DeleteAccount(int accId);
        //int pjsua_acc_modify(int acc_id, pjsua_acc_config acc_cfg);
        void SetAccountOnlineStatus(int accId, bool isOnline);
        void SetAccountOnlineStatus(int accId, bool isOnline, RpidElement pr);
        void SetAccountRegistration(int accId, bool renew);
        AccountInfo GetInfo(int accId);
        //int pjsua_enum_accs(int[] ids, ref uint count);
        //int pjsua_acc_enum_info(pjsua_acc_info[] info, ref uint count);
        int GetBestSuitingAccountIdForUrl(string url);
        void SetTransport(int accId, int tpId);
    }
}