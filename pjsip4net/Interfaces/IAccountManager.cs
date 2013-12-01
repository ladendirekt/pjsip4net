using System;
using System.Collections.ObjectModel;
using pjsip4net.Accounts;
using pjsip4net.Core.Data.Events;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Interfaces.ApiProviders;

namespace pjsip4net.Interfaces
{
    /// <summary>
    /// Provides access to accounts registered with user agent.
    /// </summary>
    public interface IAccountManager
    {
        ReadOnlyCollection<IAccount> Accounts { get; }
        IAccount DefaultAccount { get; set; }
        event EventHandler<AccountStateChangedEventArgs> AccountStateChanged;

        IAccount Register(Func<IAccountBuilder, IAccount> builder);
        IAccount GetAccountById(int id);
    }

    internal interface IAccountManagerInternal : IAccountManager, IInitializable
    {
        IAccountApiProvider Provider { get; }

        void RegisterAccount(Account account, bool @default);
        void UnregisterAccount(Account account);
        void RaiseStateChanged(Account account);
        void OnRegistrationState(RegistrationStateChanged e);
        void UnRegisterAllAccounts();
        Account GetAccount(int id);
    }
}