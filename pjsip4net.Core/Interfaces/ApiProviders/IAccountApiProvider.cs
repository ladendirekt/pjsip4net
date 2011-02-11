using pjsip4net.Core.Data;

namespace pjsip4net.Core.Interfaces.ApiProviders
{
    /// <summary>
    /// An abstraction of service enabling access to pjsua account API <seealso cref="http://www.pjsip.org/pjsip/docs/html/group__PJSUA__LIB__ACC.htm"/>
    /// </summary>
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