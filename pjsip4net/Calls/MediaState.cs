using System.Diagnostics;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.Calls
{
    internal class NoneMediaState : AbstractState<MediaSession>
    {
        public NoneMediaState(MediaSession owner)
            : base(owner)
        {
            Debug.WriteLine("Call " + _owner.Call.Id + " NoneMediaState");
            _owner.IsActive = false;
            _owner.IsHeld = false;
            _owner.MediaState = CallMediaState.None;
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
            var info = _owner.Call.GetCallInfo();
            if (info.MediaStatus == CallMediaState.Active)
            {
                if (_owner.Registry.Config.AutoConference)
                    _owner.ChangeState(new ConferenceMediaStateDecorator(_owner, new ActiveMediaState(_owner)));
                else _owner.ChangeState(new ActiveMediaState(_owner));
            }
            else if (info.MediaStatus == CallMediaState.Error)
                _owner.ChangeState(new ErrorMediaState(_owner));
        }

        #endregion
    }

    internal class ActiveMediaState : AbstractState<MediaSession>
    {
        public ActiveMediaState(MediaSession owner)
            : base(owner)
        {
            _owner.IsHeld = false;
            Debug.WriteLine("Call " + _owner.Call.Id + " ActiveMediaState");
            //connect call's media to sound device
            if (!_owner.IsActive)
            {
                _owner.ConferenceBridge.ConnectToSoundDevice(
                    _owner.Call.ConferenceSlotId);
                _owner.IsActive = true;
                _owner.MediaState = CallMediaState.Active;
            }
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
            var info = _owner.Call.GetCallInfo();
            if (info.State == InviteState.Disconnected)
            {
                _owner.ChangeState(new DisconnectedMediaState(_owner));
                return;
            }

            if (info.MediaStatus == CallMediaState.Error)
                _owner.ChangeState(new ErrorMediaState(_owner));
            else if (info.MediaStatus == CallMediaState.LocalHold)
                _owner.ChangeState(new LocalHoldMediaState(_owner));
            else if (info.MediaStatus == CallMediaState.RemoteHold)
                _owner.ChangeState(new RemoteHoldMediaState(_owner));
            else if (info.MediaStatus == CallMediaState.Active)
                _owner.ChangeState(new ActiveMediaState(_owner)); //to remove decorator
        }

        #endregion
    }

    internal class DisconnectedMediaState : AbstractState<MediaSession>
    {
        public DisconnectedMediaState(MediaSession owner)
            : base(owner)
        {
            Debug.WriteLine("Call " + _owner.Call.Id + " DisconnectedMediaState");
            _owner.IsActive = false;
            _owner.IsHeld = false;
            _owner.MediaState = CallMediaState.Disconnected;
            _owner.CallManager.TerminateCall(_owner.Call);
        }

        public override void StateChanged()
        {
        }
    }

    internal class RemoteHoldMediaState : AbstractState<MediaSession>
    {
        public RemoteHoldMediaState(MediaSession owner)
            : base(owner)
        {
            _owner.IsHeld = true;
            Debug.WriteLine("Call " + _owner.Call.Id + " RemoteHoldMediaState");
            _owner.MediaState = CallMediaState.RemoteHold;
            //connect media if not connected
            if (!_owner.IsActive)
            {
                _owner.IsActive = true;
                _owner.ConferenceBridge.ConnectToSoundDevice(
                    _owner.Call.ConferenceSlotId);
            }
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
            var info = _owner.Call.GetCallInfo();
            if (info.MediaStatus == CallMediaState.Active)
            {
                if (_owner.Registry.Config.AutoConference)
                    _owner.ChangeState(new ConferenceMediaStateDecorator(_owner, new ActiveMediaState(_owner)));
                else _owner.ChangeState(new ActiveMediaState(_owner));
            }
            else if (info.MediaStatus == CallMediaState.Error)
                _owner.ChangeState(new ErrorMediaState(_owner));
            else if (info.MediaStatus == CallMediaState.None)
                _owner.ChangeState(new DisconnectedMediaState(_owner));
        }

        #endregion
    }

    internal class LocalHoldMediaState : AbstractState<MediaSession>
    {
        public LocalHoldMediaState(MediaSession owner)
            : base(owner)
        {
            _owner.IsHeld = true;
            Debug.WriteLine("Call " + _owner.Call.Id + " LocalHoldMediaState");
            _owner.MediaState = CallMediaState.LocalHold;
            //disconnect call's media from sound device if connected
            if (_owner.IsActive)
            {
                _owner.IsActive = false;
                _owner.ConferenceBridge.DisconnectFromSoundDevice(
                    _owner.Call.ConferenceSlotId);
            }
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
            var info = _owner.Call.GetCallInfo();
            if (info.MediaStatus == CallMediaState.Active)
            {
                if (_owner.Registry.Config.AutoConference)
                    _owner.ChangeState(new ConferenceMediaStateDecorator(_owner, new ActiveMediaState(_owner)));
                else _owner.ChangeState(new ActiveMediaState(_owner));
            }
            else if (info.MediaStatus == CallMediaState.Error)
                _owner.ChangeState(new ErrorMediaState(_owner));
            else if (info.MediaStatus == CallMediaState.None)
                _owner.ChangeState(new DisconnectedMediaState(_owner));
        }

        #endregion
    }

    internal class ErrorMediaState : AbstractState<MediaSession>
    {
        public ErrorMediaState(MediaSession owner)
            : base(owner)
        {
            _owner.IsHeld = false;
            Debug.WriteLine("Call " + _owner.Call.Id + " ErrorMediaState");
            _owner.MediaState = CallMediaState.Error;
            //disconnect call's media from sound device if connected
            if (_owner.IsActive)
            {
                _owner.IsActive = false;
                _owner.ConferenceBridge.DisconnectFromSoundDevice(
                    _owner.Call.ConferenceSlotId);
            }
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
        }

        #endregion
    }

    internal class ConferenceMediaStateDecorator : AbstractState<MediaSession>
    {
        private readonly ActiveMediaState _inner;

        public ConferenceMediaStateDecorator(MediaSession owner, ActiveMediaState inner)
            : base(owner)
        {
            Helper.GuardNotNull(inner);
            _inner = inner;
            Debug.WriteLine("Call " + _owner.Call.Id + " ConferenceMediaStateDecorator");
            _owner.ConferenceBridge.ConnectCall(_owner.Call);
            _owner.IsInConference = true;
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
            if (_owner.IsInConference)
            {
                _owner.ConferenceBridge.DisconnectCall(_owner.Call);
                _owner.IsInConference = false;
            }
            _inner.StateChanged(); //let pj take care about disconnection
        }

        #endregion
    }
}