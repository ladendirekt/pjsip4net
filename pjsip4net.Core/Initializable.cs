using System;
using System.ComponentModel;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Utils;

namespace pjsip4net.Core
{
    public class Initializable : Resource, IInitializable
    {
        protected bool _isInitialized;
        protected bool _isInitializing;

        #region Implementation of ISupportInitialize

        public virtual void BeginInit()
        {
            GuardDisposed();
            //GuardInitialized();
            _isInitializing = true;
        }

        public virtual void EndInit()
        {
            GuardDisposed();
            //GuardNotInitializing();
            _isInitializing = false;
            _isInitialized = true;
        }

        #endregion

        public bool IsInitialized
        {
            get { return _isInitialized; }
        }

        protected void GuardNotInitializing()
        {
            if (!_isInitializing)
                throw new InvalidOperationException(
                    "All adjustments should be made in ISupportInitialize initialization session");
        }

        protected void GuardNotInitialized()
        {
            if (!_isInitialized)
                throw new InvalidOperationException("Should be initialized first");
        }

        protected void GuardInitialized()
        {
            if (_isInitialized)
                throw new InvalidOperationException("Initializable doesn't support reconfiguration");
        }

        public virtual IDisposable InitializationScope()
        {
            return new Initializer(this);
        }

        #region Nested type: Initializer

        private sealed class Initializer : IDisposable
        {
            private readonly IInitializable _toInit;

            public Initializer(IInitializable toInit)
            {
                Helper.GuardNotNull(toInit);
                _toInit = toInit;
                _toInit.BeginInit();
            }

            #region Implementation of IDisposable

            public void Dispose()
            {
                OnInitializationFinished();
            }

            private void OnInitializationFinished()
            {
                _toInit.EndInit();
            }

            #endregion
        }

        #endregion
    }
}