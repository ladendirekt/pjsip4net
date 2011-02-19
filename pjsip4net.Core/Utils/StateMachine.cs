using System;

namespace pjsip4net.Core.Utils
{
    public class StateMachine
    {
        protected AbstractState _state;

        public AbstractState CurrentState
        {
            get { return _state; }
        }
        
        public event EventHandler StateChanged = delegate { };

        protected virtual void OnStateChanged()
        {
            StateChanged(this, EventArgs.Empty);
        }

        public virtual void HandleStateChanged()
        {
            if (_state != null)
                _state.StateChanged();
        }

        public virtual void ChangeState(AbstractState newState)
        {
            Helper.GuardNotNull(newState);
            _state = newState;
            OnStateChanged();
        }
    }
}