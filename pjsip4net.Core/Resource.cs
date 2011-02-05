using System;
using pjsip4net.Core.Interfaces;

namespace pjsip4net.Core
{
    public class Resource : IResource
    {
        protected bool _isDisposed;

        protected void GuardDisposed()
        {
            if (_isDisposed)
                throw new ObjectDisposedException("Initializable");
        }

        #region Implementation of IDisposable

        void IResource.InternalDispose()
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