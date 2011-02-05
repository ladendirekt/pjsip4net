using System.Configuration;

namespace pjsip4net.Configuration
{
    [ConfigurationCollection(typeof (DnsServerElement), CollectionType = ConfigurationElementCollectionType.BasicMap,
        AddItemName = "add")]
    public class DnsServerElementsCollection : ConfigurationElementCollection
    {
        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.BasicMap; }
        }

        public DnsServerElement this[int index]
        {
            get { return (DnsServerElement) BaseGet(index); }
            set
            {
                if (BaseGet(index) != null)
                    BaseRemoveAt(index);
                BaseAdd(index, value);
            }
        }

        public DnsServerElement this[string name]
        {
            get { return (DnsServerElement) BaseGet(name); }
        }

        protected override string ElementName
        {
            get { return "add"; }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new DnsServerElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((DnsServerElement) element).Address;
        }

        public void Add(DnsServerElement element)
        {
            BaseAdd(element);
        }

        public void Clear()
        {
            BaseClear();
        }
    }
}