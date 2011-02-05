using System;

namespace pjsip4net.Core.Data
{
    [Flags]
    public enum TransportFlags
    {
        Reliable = 1,
        Secure = 2,
        Datagram = 4,
    }
}