using System;
using System.ComponentModel;

namespace pjsip4net.Core.Interfaces
{
    /// <summary>
    /// Marks object as the one that demand initialization prior its' use.
    /// </summary>
    public interface IInitializable : ISupportInitialize
    {
        bool IsInitialized { get; }
        /// <summary>
        /// A smart-pointer-like idiom to wrap initialization session.
        /// </summary>
        /// <remarks>May very well be replaced with more usual BeginInit() EndInit() imperative method calls.</remarks>
        IDisposable InitializationScope();
    }
}