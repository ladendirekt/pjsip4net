using System;

namespace pjsip4net.Core.Utils
{
    public class StateMachine
    {
        protected AbstractState _state;

        public event EventHandler StateChanged = delegate { };

        protected virtual void OnStateChanged()
        {
            StateChanged(this, EventArgs.Empty);
        }

        public void HandleStateChanged()
        {
            if (_state != null)
                _state.StateChanged();
        }

        public void ChangeState(AbstractState newState)
        {
            Helper.GuardNotNull(newState);
            _state = newState;
            OnStateChanged();
        }
    }
}