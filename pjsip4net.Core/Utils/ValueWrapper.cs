namespace pjsip4net.Core.Utils
{
    internal class ValueWrapper<T>
        where T : struct
    {
        public ValueWrapper(T value)
        {
            Value = value;
        }

        public T Value { get; private set; }

        public override bool Equals(object obj)
        {
            if (!(obj is ValueWrapper<T>)) return false;
            return Value.Equals(((ValueWrapper<T>) obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}