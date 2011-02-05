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
            //GuardDisposed();
            if (!_isInitializing)
                throw new InvalidOperationException(
                    "All adjustments should be made in ISupportInitialize initialization session");
        }

        protected void GuardNotInitialized()
        {
            //GuardDisposed();
            if (!_isInitialized)
                throw new InvalidOperationException("Should be initialized first");
        }

        protected void GuardInitialized()
        {
            //GuardDisposed();
            if (_isInitialized)
                throw new InvalidOperationException("Initializable doesn't support reconfiguration");
        }

        public virtual IDisposable InitializationScope()
        {
            return new Initializer(this);
        }

        #region Nested type: Initializer

        private class Initializer : IDisposable
        {
            protected readonly ISupportInitialize _toInit;

            public Initializer(ISupportInitialize toInit)
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

            protected virtual void OnInitializationFinished()
            {
                _toInit.EndInit();
            }

            #endregion
        }

        #endregion
    }
}