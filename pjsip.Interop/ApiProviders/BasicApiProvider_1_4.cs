using System;
using Magnum.Pipeline;
using pjsip.Interop.Interfaces;
using pjsip4net.Core.Data;
using pjsip4net.Core.Data.Events;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;

namespace pjsip.Interop.ApiProviders
{
    /// <summary>
    /// here should be implemented all of the callbacks converting data to messages and publishing to pipe
    /// </summary>
    public class BasicApiProvider_1_4 : IBasicApiProvider
    {
        private IMapper _mapper;
        private Pipe _eventAggregator;
        private pjsua_config _uaCfg;
        private pjsua_logging_config _lCfg;
        private pjsua_media_config _mCfg;

        public BasicApiProvider_1_4(IMapper mapper, Pipe eventAggregator)
        {
            Helper.GuardNotNull(mapper);
            Helper.GuardNotNull(eventAggregator);
            _mapper = mapper;
            _eventAggregator = eventAggregator;
        }

        #region Implementation of IBasicApiProvider

        public UaConfig GetDefaultUaConfig()
        {
            _uaCfg = new pjsua_config();
            PJSUA_DLL.Basic.pjsua_config_default(_uaCfg);
            return _mapper.Map(_uaCfg, new UaConfig());
        }

        public LoggingConfig GetDefaultLoggingConfig()
        {
            _lCfg = new pjsua_logging_config();
            PJSUA_DLL.Basic.pjsua_logging_config_default(_lCfg);
            return _mapper.Map(_lCfg, new LoggingConfig());
        }

        public void InitPjsua(UaConfig uaCfg, LoggingConfig logCfg, MediaConfig mediaCfg)
        {
            var ua_cfg = _mapper.Map(uaCfg, _uaCfg);
            var l_cfg = _mapper.Map(logCfg, _lCfg);
            
            ua_cfg.cb.on_reg_state = OnRegState;
            
            ua_cfg.cb.on_call_state = OnCallState;
            ua_cfg.cb.on_call_media_state = OnCallMediaState;
            ua_cfg.cb.on_incoming_call = OnIncomingCall;
            ua_cfg.cb.on_stream_destroyed = OnStreamDestroyed;
            ua_cfg.cb.on_dtmf_digit = OnDtmfDigit;
            ua_cfg.cb.on_call_transfer_request = OnCallTransfer;
            ua_cfg.cb.on_call_transfer_status = OnCallTransferStatus;
            ua_cfg.cb.on_call_redirected = OnCallRedirect;
            
            ua_cfg.cb.on_nat_detect = OnNatDetect;

            ua_cfg.cb.on_buddy_state = OnBuddyState;
            ua_cfg.cb.on_incoming_subscribe = OnIncomingSubscribe;
            ua_cfg.cb.on_pager = OnPager;
            ua_cfg.cb.on_pager_status = OnPagerStatus;
            ua_cfg.cb.on_typing = OnTyping;

            l_cfg.AnonymousMember1 = OnLog;

            //etc;
            _mCfg = new pjsua_media_config();
            PJSUA_DLL.Media.pjsua_media_config_default(_mCfg);
            Helper.GuardError(PJSUA_DLL.Basic.pjsua_init(ua_cfg, l_cfg, _mapper.Map(mediaCfg, _mCfg)));
        }

        
        public void CreatePjsua()
        {
            Helper.GuardError(PJSUA_DLL.Basic.pjsua_create());
        }

        public void Start()
        {
            Helper.GuardError(PJSUA_DLL.Basic.pjsua_start());
        }

        public void Destroy()
        {
            Helper.GuardError(PJSUA_DLL.Basic.pjsua_destroy());
        }

        public void Dump(bool detail)
        {
            PJSUA_DLL.Basic.pjsua_dump(detail);
        }

        #endregion

        #region Events
        
        private void OnLog(int level, string data, int len)
        {
            _eventAggregator.Send(new LogRequested() {Message = data, Level = level});
        }

        private void OnTyping(int callId, ref pj_str_t @from, ref pj_str_t to, ref pj_str_t contact, int isTyping)
        {
            _eventAggregator.Send(new IncomingTypingRecieved()
                                      {
                                          CallId = callId,
                                          From = from,
                                          Contact = contact,
                                          IsTyping = Convert.ToBoolean(isTyping),
                                          To = to
                                      });
        }

        private void OnPagerStatus(int callId, ref pj_str_t to, ref pj_str_t body, IntPtr user_data, pjsip_status_code status, ref pj_str_t reason)
        {
            _eventAggregator.Send(new ImStatusChanged()
                                      {
                                          Id = callId,
                                          To = to,
                                          Body = body,
                                          Reason = reason,
                                          Status = (SipStatusCode) status
                                      });
        }

        private void OnPager(int callId, ref pj_str_t @from, ref pj_str_t to, ref pj_str_t contact, ref pj_str_t mimeType, ref pj_str_t body)
        {
            _eventAggregator.Send(new IncomingImRecieved()
                                      {
                                          CallId = callId,
                                          From = from,
                                          Body = body,
                                          Contact = contact,
                                          MimeType = mimeType
                                      });
        }

        private void OnIncomingSubscribe(int accId, IntPtr srvPres, int buddyId, ref pj_str_t @from, IntPtr rdata, ref pjsip_status_code code, ref pj_str_t reason, pjsua_msg_data msgData)
        {
            _eventAggregator.Send(new IncomingSubscribeRecieved()
                                      {
                                          AccountId = accId,
                                          BuddyId = buddyId,
                                          From = @from,
                                          Reason = reason,
                                          Status = (SipStatusCode) code
                                      });
        }

        private void OnNatDetect(ref pj_stun_nat_detect_result res)
        {
            _eventAggregator.Send(new NatDetected()
                                      {
                                          NatType = (NatType) res.nat_type,
                                          NatName = res.nat_type_name,
                                          Status = res.status,
                                          StatusText = res.status_text
                                      });
        }

        private pjsip_redirect_op OnCallRedirect(int callId, ref pjsip_uri target, IntPtr e)
        {
            var @event = new CallRedirected() {Id = callId};
            _eventAggregator.Send(@event);
            return (pjsip_redirect_op) @event.Option;
        }

        private void OnCallTransferStatus(int callId, int stCode, ref pj_str_t stText, int final, ref int pCont)
        {
            var @event = new CallTransferStatusChanged()
                             {
                                 Id = callId,
                                 Status = stCode,
                                 StatusText = stText,
                                 Final = Convert.ToBoolean(final),
                                 Continue = Convert.ToBoolean(pCont)
                             };
            _eventAggregator.Send(@event);
            pCont = Convert.ToInt32(@event.Continue);
        }

        private void OnCallTransfer(int callId, ref pj_str_t dst, ref pjsip_status_code code)
        {
            _eventAggregator.Send(new CallTransferRequested()
                                      {Id = callId, Destination = dst, Status = (SipStatusCode) code});
        }

        private void OnDtmfDigit(int callId, int digit)
        {
            _eventAggregator.Send(new DtmfRecieved() {Id = callId, Digit = digit});
        }

        private void OnStreamDestroyed(int callId, IntPtr sess, uint streamIdx)
        {
            _eventAggregator.Send(new StreamDestroyed() {Id = callId});
        }

        private void OnIncomingCall(int accId, int callId, IntPtr rdata)
        {
            _eventAggregator.Send(new IncomingCallRecieved() {AccountId = callId, CallId = callId});
        }

        private void OnCallMediaState(int callId)
        {
            _eventAggregator.Send(new CallMediaStateChanged() {Id = callId});
        }

        private void OnCallState(int callId, ref IntPtr e)
        {
            _eventAggregator.Send(new CallStateChanged() {Id = callId});
        }

        private void OnRegState(int accId)
        {
            _eventAggregator.Send(new RegistrationStateChanged() { Id = accId });
        }

        private void OnBuddyState(int buddyId)
        {
            _eventAggregator.Send(new BuddyStateChanged {Id = buddyId});
        }

        #endregion
    }
}