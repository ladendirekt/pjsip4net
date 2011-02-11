using System;
using pjsip4net.Core.Utils;

namespace pjsip4net.Core.Interfaces
{
    /// <summary>
    /// An interface that provides comparison template method for <see cref="EqualsTemplate"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IIdentifiable<T> : IEquatable<IIdentifiable<T>>
    {
        int Id { get; }
        bool DataEquals(T other);
    }
}