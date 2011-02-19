using System;
using System.ComponentModel;

namespace pjsip4net.Core.Interfaces
{
    /// <summary>
    /// Marks class' instance as the one that demand initialization prior its' use.
    /// </summary>
    public interface IInitializable : ISupportInitialize
    {
        /// <summary>
        /// Signals whether an object has been initialized.
        /// </summary>
        bool IsInitialized { get; }
        /// <summary>
        /// A smart-pointer-like idiom to wrap initialization session.
        /// </summary>
        /// <remarks>May very well be replaced with more usual BeginInit() EndInit() imperative method calls.</remarks>
        IDisposable InitializationScope();
    }
}