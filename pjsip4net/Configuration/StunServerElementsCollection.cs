using System.Configuration;

namespace pjsip4net.Configuration
{
    [ConfigurationCollection(typeof (StunElement), CollectionType = ConfigurationElementCollectionType.BasicMap,
        AddItemName = "add")]
    public class StunServerElementsCollection : ConfigurationElementCollection
    {
        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.BasicMap; }
        }

        public StunElement this[int index]
        {
            get { return (StunElement) BaseGet(index); }
            set
            {
                if (BaseGet(index) != null)
                    BaseRemoveAt(index);
                BaseAdd(index, value);
            }
        }

        public StunElement this[string name]
        {
            get { return (StunElement) BaseGet(name); }
        }

        protected override string ElementName
        {
            get { return "add"; }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new StunElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((StunElement) element).Address;
        }

        public void Add(StunElement element)
        {
            BaseAdd(element);
        }

        public void Clear()
        {
            BaseClear();
        }
    }
}