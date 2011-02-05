using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace pjsip4net.Core.Utils
{
    public static class Extensions
    {
        public static IEnumerable<T> Each<T>(this IEnumerable<T> collection, Action<T> act)
        {
            foreach (var item in collection)
                act(item);
            return collection;
        }

        public static IEnumerable<T> GrowWithDefaultToTheSizeOf<T>(this IEnumerable<T> collection, int count) where T : new()
        {
            Helper.GuardInRange(-1, int.MaxValue, count - collection.Count());

            var addition = Enumerable.Repeat(new T(), (count - collection.Count()).Times());
            var result = collection.Union(addition, new AllDifferentComparer<T>());
            return result;
        }

        public static ConstructorInfo SelectEligibleConstructor(this Type type)
        {
            return (from c in type.GetConstructors()
                    orderby c.GetParameters().Length descending
                    select c).FirstOrDefault();
        }

        public static int Times(this int times)
        {
            return times;
        }

        public static T As<T>(this object @object) where T : class
        {
            return @object as T;
        }
    }

    public class AllDifferentComparer<T> : IEqualityComparer<T>
    {
        #region Implementation of IEqualityComparer<T>

        public bool Equals(T x, T y)
        {
            return false;
        }

        public int GetHashCode(T obj)
        {
            return obj.GetHashCode();
        }

        #endregion
    }
}