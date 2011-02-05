using System.Configuration;
using System.Net;
using pjsip4net.Accounts;

namespace pjsip4net.Configuration
{
    public class AccountElement : ConfigurationElement
    {
        private readonly ConfigurationProperty _idProp = new ConfigurationProperty("accountId", typeof (string),
                                                                                   "sip:0@0.0.0.0", null,
                                                                                   new SipUriValidator(),
                                                                                   ConfigurationPropertyOptions.
                                                                                       IsRequired);

        private readonly ConfigurationProperty _isDefaultProp = new ConfigurationProperty("isDefault", typeof (bool),
                                                                                          false);

        private readonly ConfigurationProperty _passwordProp = new ConfigurationProperty("password", typeof (string), "",
                                                                                         ConfigurationPropertyOptions.
                                                                                             IsRequired);

        private readonly ConfigurationPropertyCollection _properties;

        private readonly ConfigurationProperty _publishPresProp = new ConfigurationProperty("publishPresence",
                                                                                            typeof (bool), false);

        private readonly ConfigurationProperty _realmProp = new ConfigurationProperty("realm", typeof (string), "",
                                                                                      ConfigurationPropertyOptions.
                                                                                          IsRequired);

        private readonly ConfigurationProperty _regUriProp = new ConfigurationProperty("registrarUri", typeof (string),
                                                                                       "sip:0.0.0.0", null,
                                                                                       new SipUriValidator(),
                                                                                       ConfigurationPropertyOptions.
                                                                                           IsRequired);

        private readonly ConfigurationProperty _usernameProp = new ConfigurationProperty("userName", typeof (string), "",
                                                                                         ConfigurationPropertyOptions.
                                                                                             IsRequired);

        public AccountElement()
        {
            _properties = new ConfigurationPropertyCollection
                              {
                                  _idProp,
                                  _regUriProp,
                                  _usernameProp,
                                  _passwordProp,
                                  _realmProp,
                                  _isDefaultProp,
                                  _publishPresProp
                              };
        }

        [ConfigurationProperty("accountId", DefaultValue = "sip:0@0.0.0.0", IsRequired = true)]
        [SipUriValidator]
        public string AccountId
        {
            get { return base[_idProp].ToString(); }
            set { base[_idProp] = value; }
        }

        [ConfigurationProperty("registrarUri", DefaultValue = "sip:0.0.0.0", IsRequired = true)]
        [SipUriValidator]
        public string RegistrarUri
        {
            get { return base[_regUriProp].ToString(); }
            set { base[_regUriProp] = value; }
        }

        [ConfigurationProperty("userName", IsRequired = true)]
        public string UserName
        {
            get { return base[_usernameProp].ToString(); }
            set { base[_usernameProp] = value; }
        }

        [ConfigurationProperty("password", IsRequired = true)]
        public string Password
        {
            get { return base[_passwordProp].ToString(); }
            set { base[_passwordProp] = value; }
        }

        [ConfigurationProperty("realm", IsRequired = true)]
        public string Realm
        {
            get { return base[_realmProp].ToString(); }
            set { base[_realmProp] = value; }
        }

        [ConfigurationProperty("isDefault", DefaultValue = false)]
        public bool IsDefault
        {
            get { return (bool) base[_isDefaultProp]; }
            set { base[_isDefaultProp] = value; }
        }

        [ConfigurationProperty("publishPresence", DefaultValue = false)]
        public bool PublishPresence
        {
            get { return (bool) base[_publishPresProp]; }
            set { base[_publishPresProp] = value; }
        }

        protected override ConfigurationPropertyCollection Properties
        {
            get { return _properties; }
        }

        //public Account CreateAccount()
        //{
        //    var account = new Account(false, IsDefault);
        //    using (account.InitializationScope())
        //    {
        //        account.AccountId = AccountId;
        //        account.RegistrarUri = RegistrarUri;
        //        account.Credential = new NetworkCredential(UserName, Password, Realm);
        //        account.PublishPresence = PublishPresence;
        //    }
        //    return account;
        //}
    }
}