using System;

namespace pjsip4net.Core
{
    public class PjsipErrorException : Exception
    {
        public PjsipErrorException(int code)
            : this(code, "")
        {
        }

        public PjsipErrorException(int code, string message)
            : base(message)
        {
            ErrorCode = code;
        }

        public int ErrorCode { get; private set; }
    }
}