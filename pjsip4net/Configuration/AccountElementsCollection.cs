using System.Configuration;

namespace pjsip4net.Configuration
{
    [ConfigurationCollection(typeof (AccountElement), CollectionType = ConfigurationElementCollectionType.BasicMap,
        AddItemName = "account")]
    public class AccountElementsCollection : ConfigurationElementCollection
    {
        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.BasicMap; }
        }

        public AccountElement this[int index]
        {
            get { return (AccountElement) BaseGet(index); }
            set
            {
                if (BaseGet(index) != null)
                    BaseRemoveAt(index);
                BaseAdd(index, value);
            }
        }

        public AccountElement this[string name]
        {
            get { return (AccountElement) BaseGet(name); }
        }

        protected override string ElementName
        {
            get { return "account"; }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new AccountElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return (element as AccountElement).AccountId;
        }

        public void Add(AccountElement element)
        {
            BaseAdd(element);
        }

        public void Clear()
        {
            BaseClear();
        }
    }
}