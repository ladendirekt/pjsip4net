using System.Diagnostics;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.Calls
{
    /// <summary>
    /// Before INVITE is sent or received
    /// </summary>
    internal class NullInviteState : AbstractState<InviteSession>
    {
        public NullInviteState(InviteSession owner)
            : base(owner)
        {
            Debug.WriteLine("Call " + _owner.Call.Id + " NullInviteState");
            _owner.InviteState = InviteState.None;
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
            CallInfo info = _owner.Call.GetCallInfo();
            if (info.State == InviteState.Disconnected)
                _owner.ChangeState(new DisconnectedInviteState(_owner));
            else
                _owner.ChangeState(new CallingInviteState(_owner)); //after INVITE is sent
        }

        #endregion
    }

    /// <summary>
    /// After INVITE is sent
    /// </summary>
    internal class CallingInviteState : AbstractState<InviteSession>
    {
        public CallingInviteState(InviteSession owner)
            : base(owner)
        {
            Debug.WriteLine("Call " + _owner.Call.Id + " CallingInviteState");
            if (!_owner.Call.IsIncoming)
                _owner.CallManager.RaiseRingEvent(_owner.Call, true);
            _owner.IsRinging = true;
            _owner.InviteState = InviteState.Calling;
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
            CallInfo info = _owner.Call.GetCallInfo();
            if (info.State == InviteState.Confirmed)
                _owner.ChangeState(new ConfirmedInviteState(_owner));
            else if (info.State == InviteState.Connecting)
                _owner.ChangeState(new ConnectingInviteState(_owner));
            else if (info.State == InviteState.Disconnected)
                _owner.ChangeState(new DisconnectedInviteState(_owner));
        }

        #endregion
    }

    /// <summary>
    /// After INVITE is received
    /// </summary>
    internal class IncomingInviteState : AbstractState<InviteSession>
    {
        public IncomingInviteState(InviteSession owner)
            : base(owner)
        {
            Debug.WriteLine("Call " + _owner.Call.Id + " IncomingInviteState");
            //SingletonHolder<ICallManagerImpl>.Instance.RaiseRingEvent(_owner.Call, true);
            _owner.IsRinging = true;
            _owner.InviteState = InviteState.Incoming;
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
            CallInfo info = _owner.Call.GetCallInfo();
            if (info.State == InviteState.Confirmed)
                _owner.ChangeState(new ConfirmedInviteState(_owner));
            else if (info.State == InviteState.Connecting)
                _owner.ChangeState(new ConnectingInviteState(_owner));
            else if (info.State == InviteState.Early)
                _owner.ChangeState(new EarlyInviteState(_owner));
            else if (info.State == InviteState.Disconnected)
                _owner.ChangeState(new DisconnectedInviteState(_owner));
        }

        #endregion
    }

    /// <summary>
    /// After response with To tag
    /// </summary>
    internal class EarlyInviteState : AbstractState<InviteSession>
    {
        public EarlyInviteState(InviteSession owner)
            : base(owner)
        {
            Debug.WriteLine("Call " + _owner.Call.Id + " EarlyInviteState");
            _owner.InviteState = InviteState.Early;
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
            CallInfo info = _owner.Call.GetCallInfo();
            if (info.State == InviteState.Confirmed)
                _owner.ChangeState(new ConfirmedInviteState(_owner));
            else if (info.State == InviteState.Connecting)
                _owner.ChangeState(new ConnectingInviteState(_owner));
            else if (info.State == InviteState.Disconnected)
                _owner.ChangeState(new DisconnectedInviteState(_owner));
        }

        #endregion
    }

    /// <summary>
    /// After 2xx is sent/received
    /// </summary>
    internal class ConnectingInviteState : AbstractState<InviteSession>
    {
        public ConnectingInviteState(InviteSession owner)
            : base(owner)
        {
            Debug.WriteLine("Call " + _owner.Call.Id + " ConnectingInviteState");
            //if (_owner.IsRinging)
            //{
            //    SingletonHolder<ICallManagerImpl>.Instance.RaiseRingEvent(_owner.Call, false);
            //    _owner.IsRinging = false;
            //}
            _owner.InviteState = InviteState.Connecting;
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
            CallInfo info = _owner.Call.GetCallInfo();
            if (info.State == InviteState.Confirmed)
                _owner.ChangeState(new ConfirmedInviteState(_owner));
            else if (info.State == InviteState.Disconnected)
                _owner.ChangeState(new DisconnectedInviteState(_owner));
        }

        #endregion
    }

    /// <summary>
    /// After ACK is sent/received
    /// </summary>
    internal class ConfirmedInviteState : AbstractState<InviteSession>
    {
        public ConfirmedInviteState(InviteSession owner)
            : base(owner)
        {
            Debug.WriteLine("Call " + _owner.Call.Id + " ConfirmedInviteState");
            if (_owner.IsRinging)
            {
                _owner.CallManager.RaiseRingEvent(_owner.Call, false);
                _owner.IsRinging = false;
            }
            _owner.IsConfirmed = true;
            _owner.InviteState = InviteState.Confirmed;
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
            CallInfo info = _owner.Call.GetCallInfo();
            if (info.State == InviteState.Disconnected)
                _owner.ChangeState(new DisconnectedInviteState(_owner));
        }

        #endregion
    }

    /// <summary>
    /// Session is terminated
    /// </summary>
    internal class DisconnectedInviteState : AbstractState<InviteSession>
    {
        public DisconnectedInviteState(InviteSession owner)
            : base(owner)
        {
            Debug.WriteLine("Call " + _owner.Call.Id + " DisconnectedInviteState");
            _owner.IsConfirmed = false;
            _owner.IsDisconnected = true;
            _owner.InviteState = InviteState.Disconnected;
            if (_owner.IsRinging)
            {
                _owner.CallManager.RaiseRingEvent(_owner.Call, false);
                _owner.IsRinging = false;
            }
            if (!_owner.Call.HasMedia)
                _owner.CallManager.TerminateCall(_owner.Call);
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
        }

        #endregion
    }
}