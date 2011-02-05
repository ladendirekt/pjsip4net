namespace pjsip4net.Core.Utils
{
    public abstract class AbstractState
    {
        public abstract void StateChanged();
    }

    public abstract class AbstractState<T> : AbstractState where T : StateMachine
    {
        protected T _owner;

        protected AbstractState(T owner)
        {
            Helper.GuardNotNull(owner);
            _owner = owner;
        }
    }
}