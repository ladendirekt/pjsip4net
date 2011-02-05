using pjsip4net.Core.Interfaces;

namespace pjsip4net.Core.Utils
{
    public static class EqualsTemplate
    {
        internal static bool Equals<T>(IIdentifiable<T> left, IIdentifiable<T> right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) return false;
            if (typeof (T) != left.GetType() || typeof (T) != right.GetType()) return false;
            return left.Id == right.Id
                       ? left.DataEquals((T) right)
                       : left.Id.Equals(-1) && right.Id.Equals(-1) ? left.DataEquals((T) right) : false;
        }
    }
}