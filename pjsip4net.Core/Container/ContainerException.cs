using System;

namespace pjsip4net.Core.Container
{
    public class ContainerException : Exception
    {
        public ContainerException()
        { }
        
        public ContainerException(string message) : base(message)
        { }
        
        public ContainerException(string message, Exception inner) : base(message, inner)
        { }
    }
}