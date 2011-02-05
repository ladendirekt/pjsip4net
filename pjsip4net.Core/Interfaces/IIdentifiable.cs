using System;

namespace pjsip4net.Core.Interfaces
{
    public interface IIdentifiable<T> : IEquatable<IIdentifiable<T>>
    {
        int Id { get; }
        bool DataEquals(T other);
    }
}