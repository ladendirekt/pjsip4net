using System;
using System.Runtime.ConstrainedExecution;
using pjsip4net.Core.Interfaces;

namespace pjsip4net.Core
{
    public class Resource : CriticalFinalizerObject, IResource
    {
        protected bool _isDisposed;

        internal bool IsDisposed
        {
            get { return _isDisposed; }
        }

        protected void GuardDisposed()
        {
            if (_isDisposed)
                throw new ObjectDisposedException("Initializable");
        }

        #region Implementation of IDisposable

        public void InternalDispose()
        {
            Dispose(true);
        }

        protected void Dispose(bool disposing)
        {
            if (_isDisposed) return;

            if (disposing)
            {
                _isDisposed = true;
                GC.SuppressFinalize(this);
            }

            CleanUp();
        }

        ~Resource()
        {
            Dispose(false);
        }

        protected virtual void CleanUp()
        {
        }

        #endregion
    }
}