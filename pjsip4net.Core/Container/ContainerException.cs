using System;

namespace pjsip4net.Core.Container
{
    /// <summary>
    /// Exception that is thrown by dependency injection container.
    /// </summary>
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