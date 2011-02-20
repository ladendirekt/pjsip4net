using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using pjsip4net.Core;
using pjsip4net.Core.Data.Events;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.Accounts
{
    internal class DefaultAccountManager : Initializable, IAccountManagerInternal
    {
        private static readonly object _lock = new object();
        private readonly SortedDictionary<int, IAccountInternal> _accounts;
        private Queue<Account> _deleting;
        private ILocalRegistry _localRegistry;
        private IAccountApiProvider _provider;
        private readonly IEventsProvider _eventsProvider;

        #region Properties

        public event EventHandler<AccountStateChangedEventArgs> AccountStateChanged = delegate { };

        public ReadOnlyCollection<IAccount> Accounts
        {
            get
            {
                lock (_lock)
                    return
                        new ReadOnlyCollection<IAccount>(
                            _accounts.Values.Where(t => !t.IsLocal).Cast<IAccount>().ToList());
            }
        }

        public IAccount DefaultAccount
        {
            get
            {
                try
                {
                    lock (_lock) 
                        return _accounts[_provider.GetDefaultAccountId()];
                }
                catch (Exception)
                {
                    return null;
                }
            }
            set
            {
                Helper.GuardNotNull(value);
                Helper.GuardPositiveInt(value.Id);
                if (_provider.IsValidAccount(value.Id))
                    _provider.SetDefaultAccount(value.Id);
            }
        }

        public IAccountApiProvider Provider
        {
            get { return _provider; }
        }

        #endregion

        #region Methods

        public void OnRegistrationState(RegistrationStateChanged e)
        {
            Account account = null;
            lock (_lock)
                if (_accounts.ContainsKey(e.Id) && _accounts[e.Id] != null)
                    account = (Account) _accounts[e.Id];
            if (account != null) account.HandleStateChanged();
        }

        public void RaiseStateChanged(IAccountInternal account)
        {
            AccountStateChanged(this, account.GetEventArgs());
        }

        public void RegisterAccount(IAccountInternal account, bool @default)
        {
            Helper.GuardNotNull(account);

            lock (_lock)
            {
                if (account.Transport == null) 
                    account.SetTransport(_localRegistry.SipTransport);
                int id = -1;
                if (account.IsLocal)
                    id = _provider.AddLocalAccountAndGetId(_localRegistry.SipTransport.Id, @default);
                else
                    id = _provider.AddAccountAndGetId(account.Config, @default);

                account.SetId(id);
                _accounts.Add(account.Id, account);
                account.HandleStateChanged();
            }
        }

        public void UnregisterAccount(IAccountInternal account)
        {
            if (account.IsInUse)
                throw new InvalidOperationException("Can't delete account as long as it's being used by other parties");

            lock (_lock)
                if (_accounts.ContainsKey(account.Id))
                {
                    //if (account.IsRegistered)
                    //    Helper.GuardError(PJSUA_DLL.Accounts.pjsua_acc_set_registration(account.Id, false));

                    //_deleting.Enqueue(account);//TODO raise events for accounts being deleted
                    _provider.DeleteAccount(account.Id);
                    _accounts.Remove(account.Id);
                    account.SetId(-1);
                    if (account.IsLocal)
                        account.HandleStateChanged();
                    account.InternalDispose();
                }
        }

        public IAccount Register(Func<IAccountBuilder, IAccount> builder)
        {
            Helper.GuardNotNull(builder);
            return builder(_localRegistry.Container.Get<IAccountBuilder>());
        }

        public IAccount GetAccountById(int id)
        {
            lock (_lock)
                if (_accounts.ContainsKey(id))
                    return _accounts[id];
            return null;
        }

        public void UnRegisterAllAccounts()
        {
            foreach (var account in _accounts.Values.ToList())
                UnregisterAccount(account);
            Thread.Sleep(1000);
        }

        public IAccountInternal GetAccount(int id)
        {
            lock (_lock)
                if (_accounts.ContainsKey(id))
                    return _accounts[id];
            return null;
        }

        public override void EndInit()
        {
            base.EndInit();
            _eventsProvider.Subscribe<RegistrationStateChanged>(e => OnRegistrationState(e));
        }

        #endregion

        public DefaultAccountManager(IAccountApiProvider accountApi, IEventsProvider eventsProvider, 
            ILocalRegistry localRegistry)
        {
            Helper.GuardNotNull(accountApi);
            Helper.GuardNotNull(eventsProvider);
            Helper.GuardNotNull(localRegistry);
            _provider = accountApi;
            _eventsProvider = eventsProvider;
            _localRegistry = localRegistry;
            _accounts = new SortedDictionary<int, IAccountInternal>();
            //_syncContext = SynchronizationContext.Current;
            _deleting = new Queue<Account>();
        }
    }
}