using System;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces.ApiProviders;

namespace pjsip4net.Testing
{
    public class AccountApiTestProvider : IAccountApiProvider
    {
        public AccountConfig GetDefaultConfig()
        {
            return new AccountConfig();
        }

        public bool IsValidAccount(int accId)
        {
            return Convert.ToBoolean(new Random().Next(1));
        }

        public void SetDefaultAccount(int accId)
        {
        }

        public int GetDefaultAccountId()
        {
            return 0;
        }

        public int AddAccountAndGetId(AccountConfig accCfg, bool isDefault)
        {
            return 0;
        }

        public int AddLocalAccountAndGetId(int transportId, bool isDefault)
        {
            return 0;
        }

        public void DeleteAccount(int accId)
        {
        }

        public void SetAccountOnlineStatus(int accId, bool isOnline)
        {
        }

        public void SetAccountOnlineStatus(int accId, bool isOnline, RpidElement pr)
        {
        }

        public void SetAccountRegistration(int accId, bool renew)
        {
        }

        public AccountInfo GetInfo(int accId)
        {
            return new AccountInfo();
        }

        public int GetBestSuitingAccountIdForUrl(string url)
        {
            return 0;
        }

        public void SetTransport(int accId, int tpId)
        {
        }
    }
}