using System.Configuration;

namespace pjsip4net.Configuration
{
    [ConfigurationCollection(typeof (AccountElement), CollectionType = ConfigurationElementCollectionType.BasicMap,
        AddItemName = "add")]
    public class ProxyElementsCollection : ConfigurationElementCollection
    {
        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.BasicMap; }
        }

        public ProxyElement this[int index]
        {
            get { return (ProxyElement) BaseGet(index); }
            set
            {
                if (BaseGet(index) != null)
                    BaseRemoveAt(index);
                BaseAdd(index, value);
            }
        }

        public ProxyElement this[string name]
        {
            get { return (ProxyElement) BaseGet(name); }
        }

        protected override string ElementName
        {
            get { return "add"; }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new ProxyElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ProxyElement) element).Address;
        }

        public void Add(ProxyElement element)
        {
            BaseAdd(element);
        }

        public void Clear()
        {
            BaseClear();
        }
    }
}