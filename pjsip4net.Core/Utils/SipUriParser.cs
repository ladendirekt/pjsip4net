using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pjsip4net.Core.Utils
{
    public enum SipLexem
    {
        Scheme,
        Domain,
        Port,
        Extension,
        Password,
        Parameter,
        Header,
        Semicolumn,
        Column,
        DomainPortDelimiter,
        ExtensionPasswordDelimiter,
        At,
        Question
    }

    public class SipUriParser
    {
        private readonly HashSet<char> _alfabet;
        private readonly HashSet<char> _numbers;
        private readonly NfaWithBackTracking<SipLexem, char> _stateMachine = new NfaWithBackTracking<SipLexem, char>();
        //private StringBuilder _builder = new StringBuilder();

        protected SipUriParser()
        {
            //_stateMachine.Alphabets.AddRange(Enumerable.Range(0, 9).Select(i => i.ToString()));
            //_stateMachine.Alphabets.AddRange(Enumerable.Range((int)((char)'a'), 20).Select(i => i.ToString()));
            _alfabet = new HashSet<char>(Enumerable.Range('a', 26).Select(i => ((char) i)));
            foreach (char alfa in Enumerable.Range('A', 26).Select(i => ((char) i)))
                _alfabet.Add(alfa);
            _numbers = new HashSet<char>(Enumerable.Range('0', 10).Select(i => (char) i));

            Parameters = new Dictionary<string, string>();
            Headers = new Dictionary<string, string>();

            _stateMachine.Alphabets.Add(':');
            _stateMachine.Alphabets.Add(';');
            _stateMachine.Alphabets.Add('@');
            _stateMachine.Alphabets.Add('?');
            foreach (char alfa in _alfabet)
                _stateMachine.Alphabets.Add(alfa);
            foreach (char number in _numbers)
                _stateMachine.Alphabets.Add(number);
            var schemeState = new SipUriParseState(_stateMachine)
                                  {
                                      Id = SipLexem.Scheme,
                                  };
            schemeState.Act = () => { };
            _stateMachine.AddState(schemeState);
            var domainState = new SipUriParseState(_stateMachine)
                                  {
                                      Id = SipLexem.Domain,
                                  };
            domainState.Act = () => Domain = domainState.GetState();
            _stateMachine.AddState(domainState);
            var portState = new SipUriParseState(_stateMachine)
                                {
                                    Id = SipLexem.Port,
                                };
            portState.Act = () => Port = string.IsNullOrEmpty(portState.GetState()) ? "5060" : portState.GetState();
            _stateMachine.AddState(portState);
            var extState = new SipUriParseState(_stateMachine)
                               {
                                   Id = SipLexem.Extension,
                               };
            extState.Act = () => Extension = extState.GetState();
            _stateMachine.AddState(extState);
            var pwdState = new SipUriParseState(_stateMachine)
                               {
                                   Id = SipLexem.Password,
                               };
            pwdState.Act = () => Password = pwdState.GetState();
            _stateMachine.AddState(pwdState);
            var paramState = new SipUriParseState(_stateMachine)
                                 {
                                     Id = SipLexem.Parameter,
                                 };
            paramState.Act = () =>
                                 {
                                     string[] splits = paramState.GetState().Split('=');
                                     Parameters.Add(splits[0], splits.Length > 1 ? splits[1] : splits[0]);
                                 };
            _stateMachine.AddState(paramState);
            var headerState = new SipUriParseState(_stateMachine) //todo: dump state before entering this state again
                                  {
                                      Id = SipLexem.Header,
                                  };
            headerState.Act = () =>
                                  {
                                      string[] splits = headerState.GetState().Split('=');
                                      Headers.Add(splits[0], splits.Length > 1 ? splits[1] : splits[0]);
                                  };
            _stateMachine.AddState(headerState);
            var columnState = new SipUriParseState(_stateMachine)
                                  {
                                      Id = SipLexem.Column
                                  };
            _stateMachine.AddState(columnState);
            var domainDelim = new SipUriParseState(_stateMachine)
                                  {
                                      Id = SipLexem.DomainPortDelimiter
                                  };
            _stateMachine.AddState(domainDelim);
            var extDelim = new SipUriParseState(_stateMachine)
                               {
                                   Id = SipLexem.ExtensionPasswordDelimiter
                               };
            _stateMachine.AddState(extDelim);
            var semicolState = new SipUriParseState(_stateMachine)
                                   {
                                       Id = SipLexem.Semicolumn
                                   };
            _stateMachine.AddState(semicolState);
            var atState = new SipUriParseState(_stateMachine)
                              {
                                  Id = SipLexem.At
                              };
            _stateMachine.AddState(atState);
            var qState = new SipUriParseState(_stateMachine)
                             {
                                 Id = SipLexem.Question
                             };
            _stateMachine.AddState(qState);
            _stateMachine.SetStateType(SipLexem.Scheme, StateType.StartState);
            _stateMachine.SetStateType(SipLexem.Domain, StateType.FinalState);
            _stateMachine.SetStateType(SipLexem.Extension, StateType.FinalState);
            _stateMachine.SetStateType(SipLexem.Port, StateType.FinalState);
            _stateMachine.SetStateType(SipLexem.Password, StateType.FinalState);
            _stateMachine.SetStateType(SipLexem.Parameter, StateType.FinalState);
            _stateMachine.SetStateType(SipLexem.Header, StateType.FinalState);
            _stateMachine.SetStateType(SipLexem.Semicolumn, StateType.SinkState);
            _stateMachine.SetStateType(SipLexem.Column, StateType.SinkState);
            _stateMachine.SetStateType(SipLexem.DomainPortDelimiter, StateType.SinkState);
            _stateMachine.SetStateType(SipLexem.ExtensionPasswordDelimiter, StateType.SinkState);
            _stateMachine.SetStateType(SipLexem.At, StateType.SinkState);
            _stateMachine.SetStateType(SipLexem.Question, StateType.SinkState);
            //scheme to scheme
            _stateMachine.TransitionTable.Add(
                new PredicateTransitionFunction<NfaState<SipLexem>, char, NfaState<SipLexem>>(
                    s => SipUriBuilder.SIPScheme.TrimEnd(':').Contains(s))
                    {From = schemeState, To = schemeState, TransitionSymbols = new List<char> {'~'}});
            //domain to domain
            _stateMachine.TransitionTable.Add(
                new PredicateTransitionFunction<NfaState<SipLexem>, char, NfaState<SipLexem>>(
                    s =>
                    _alfabet.Contains(s) || _numbers.Contains(s) || s.Equals('.'))
                    {From = domainState, To = domainState, TransitionSymbols = new List<char> {'~'}});
            //extension to extension
            _stateMachine.TransitionTable.Add(
                new PredicateTransitionFunction<NfaState<SipLexem>, char, NfaState<SipLexem>>(
                    s => _numbers.Contains(s) || _alfabet.Contains(s) || s.Equals('.'))
                    {From = extState, To = extState, TransitionSymbols = new List<char> {'~'}});
            //password to password
            _stateMachine.TransitionTable.Add(
                new PredicateTransitionFunction<NfaState<SipLexem>, char, NfaState<SipLexem>>(
                    s => _numbers.Contains(s) || _alfabet.Contains(s))
                    {From = pwdState, To = pwdState, TransitionSymbols = new List<char> {'~'}});
            //port to port
            _stateMachine.TransitionTable.Add(
                new PredicateTransitionFunction<NfaState<SipLexem>, char, NfaState<SipLexem>>(
                    s => _numbers.Contains(s))
                    {From = portState, To = portState, TransitionSymbols = new List<char> {'~'}});
            //header to header
            _stateMachine.TransitionTable.Add(
                new PredicateTransitionFunction<NfaState<SipLexem>, char, NfaState<SipLexem>>(
                    s => _numbers.Contains(s) || _alfabet.Contains(s) || s.Equals('='))
                    {From = headerState, To = headerState, TransitionSymbols = new List<char> {'~'}});
            //param to param
            _stateMachine.TransitionTable.Add(
                new PredicateTransitionFunction<NfaState<SipLexem>, char, NfaState<SipLexem>>(
                    s => _numbers.Contains(s) || _alfabet.Contains(s) || s.Equals('='))
                    {From = paramState, To = paramState, TransitionSymbols = new List<char> {'~'}});
            //scheme to column
            _stateMachine.TransitionTable.Add(new TransitionFunction<NfaState<SipLexem>, char, NfaState<SipLexem>>
                                                  {
                                                      From = schemeState,
                                                      To = columnState,
                                                      TransitionSymbols = new List<char> {':'}
                                                  });
            //column to domain
            _stateMachine.TransitionTable.Add(new TransitionFunction<NfaState<SipLexem>, char, NfaState<SipLexem>>
                                                  {
                                                      From = columnState,
                                                      To = domainState,
                                                      TransitionSymbols = _alfabet.Union(_numbers).ToList()
                                                  });
            //column to extension
            _stateMachine.TransitionTable.Add(new TransitionFunction<NfaState<SipLexem>, char, NfaState<SipLexem>>
                                                  {
                                                      From = columnState,
                                                      To = extState,
                                                      TransitionSymbols = _alfabet.Union(_numbers).ToList()
                                                  });
            //domain to domain delimiter
            _stateMachine.TransitionTable.Add(new TransitionFunction<NfaState<SipLexem>, char, NfaState<SipLexem>>
                                                  {
                                                      From = domainState,
                                                      To = domainDelim,
                                                      TransitionSymbols = new List<char> {':'}
                                                  });
            //domain delimiter to port
            _stateMachine.TransitionTable.Add(new TransitionFunction<NfaState<SipLexem>, char, NfaState<SipLexem>>
                                                  {
                                                      From = domainDelim,
                                                      To = portState,
                                                      TransitionSymbols = _numbers.ToList()
                                                  });
            //domain to semicolumn
            _stateMachine.TransitionTable.Add(new TransitionFunction<NfaState<SipLexem>, char, NfaState<SipLexem>>
                                                  {
                                                      From = domainState,
                                                      To = semicolState,
                                                      TransitionSymbols = new List<char> {';'}
                                                  });
            //port to semicol
            _stateMachine.TransitionTable.Add(new TransitionFunction<NfaState<SipLexem>, char, NfaState<SipLexem>>
                                                  {
                                                      From = portState,
                                                      To = semicolState,
                                                      TransitionSymbols = new List<char> {';'}
                                                  });
            //semicol to header
            _stateMachine.TransitionTable.Add(new TransitionFunction<NfaState<SipLexem>, char, NfaState<SipLexem>>
                                                  {
                                                      From = semicolState,
                                                      To = headerState,
                                                      TransitionSymbols =
                                                          _alfabet.Union(_numbers).Union(Enumerable.Repeat('=', 1)).ToList()
                                                  });
            //header to semicol
            _stateMachine.TransitionTable.Add(new TransitionFunction<NfaState<SipLexem>, char, NfaState<SipLexem>>
                                                  {
                                                      From = headerState,
                                                      To = semicolState,
                                                      TransitionSymbols = new List<char> {';'}
                                                  });
            //extension to extension delimiter
            _stateMachine.TransitionTable.Add(new TransitionFunction<NfaState<SipLexem>, char, NfaState<SipLexem>>
                                                  {
                                                      From = extState,
                                                      To = extDelim,
                                                      TransitionSymbols = new List<char> {':'}
                                                  });
            //extension delimiter to password
            _stateMachine.TransitionTable.Add(new TransitionFunction<NfaState<SipLexem>, char, NfaState<SipLexem>>
                                                  {
                                                      From = extDelim,
                                                      To = pwdState,
                                                      TransitionSymbols = _alfabet.Union(_numbers).ToList()
                                                  });
            //extension to at
            _stateMachine.TransitionTable.Add(new TransitionFunction<NfaState<SipLexem>, char, NfaState<SipLexem>>
                                                  {
                                                      From = extState,
                                                      To = atState,
                                                      TransitionSymbols = new List<char> {'@'}
                                                  });
            //password to at
            _stateMachine.TransitionTable.Add(new TransitionFunction<NfaState<SipLexem>, char, NfaState<SipLexem>>
                                                  {
                                                      From = pwdState,
                                                      To = atState,
                                                      TransitionSymbols = new List<char> {'@'}
                                                  });
            //at to domain
            _stateMachine.TransitionTable.Add(new TransitionFunction<NfaState<SipLexem>, char, NfaState<SipLexem>>
                                                  {
                                                      From = atState,
                                                      To = domainState,
                                                      TransitionSymbols = _alfabet.Union(_numbers).ToList()
                                                  });
        }

        public SipUriParser(string sipUri)
            : this()
        {
            string str = sipUri.TrimStart('<').TrimEnd('>');
            Helper.GuardIsTrue(str.StartsWith(SipUriBuilder.SIPScheme));
            //Helper.GuardError(SipUserAgent.Instance.ApiFactory.GetBasicApi().pjsua_verify_sip_url(str));
            ParseString(str);
            //while (_statesStack.Count > 0)
            //{
            //    var mem = _statesStack.Pop();
            //    if (mem.State.Act != null)
            //        mem.State.Act();
            ////}
        }

        public string Extension { get; private set; }
        public string Password { get; private set; }
        public string Domain { get; private set; }
        public string Port { get; set; }

        public TransportType Transport
        {
            get
            {
                if (Headers.ContainsKey("transport"))
                {
                    string tport = Headers["transport"].ToLower();
                    tport = string.Concat(tport.Substring(0, 1).ToUpper(), tport.Substring(1, tport.Length - 1));
                    return (TransportType) Enum.Parse(typeof (TransportType), tport);
                }
                return TransportType.Udp;
            }
        }

        public Dictionary<string, string> Parameters { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public bool IsValid
        {
            get { return _stateMachine.IsAcceptedString(); }
        }

        /// <summary>
        /// NFA with backtracking algorithm
        /// </summary>
        /// <param name="sipUri"></param>
        private void ParseString(string sipUri)
        {
            _stateMachine.ComsumeAllInputSymbols(sipUri.Select(c => c).ToList());
            if (_stateMachine.IsAcceptedString())
            {
                foreach (var state in _stateMachine.FinalStates)
                {
                    if (state.Act != null)
                        state.Act();
                }
            }
            //int inx = 0;
            //int move = 0;

            //while (inx < sipUri.Length)
            //{
            //    var token = sipUri[inx];
            //    if (_stateMachine.Alphabets.Contains(token))
            //    {
            //        _stateMachine.ConsumeInputSymbol(token);
            //    }
            //    else
            //    {
            //        _stateMachine.CurrentStates[0].NextToken(token);
            //    }


            //    if (_stateMachine.Alphabets.Contains(sipUri[inx]))
            //        if (_stateMachine.CurrentStates.Count > 0)
            //        {
            //            _statesStack.Push(new SipParseStateMemento()
            //                                  {
            //                                      Move = move,
            //                                      State = (SipUriParseState) _stateMachine.CurrentStates[0],
            //                                      TokenIndex = inx
            //                                  });
            //        }

            //    try
            //    {
            //        var nextStates = _stateMachine.ConsumeInputSymbol(sipUri[inx]);
            //        if (_stateMachine.Alphabets.Contains(sipUri[inx]))
            //            _stateMachine.CurrentStates = nextStates.Skip(move).Take(1).ToList();
            //    }
            //    catch (SystemException)
            //    {
            //        _stateMachine.CurrentStates = new List<State<SipLexem>>();
            //    }

            //    if (_stateMachine.Alphabets.Contains(sipUri[inx]))
            //    {
            //        if (_stateMachine.CurrentStates.Count == 0)
            //        {
            //            if (_statesStack.Count == 0)
            //                break;
            //            var mem = _statesStack.Pop();
            //            inx = mem.TokenIndex;
            //            move = ++mem.Move;
            //            _stateMachine.CurrentStates.Clear();
            //            _stateMachine.CurrentStates.Add(mem.State);
            //        }
            //    }
            //    else
            //        //if (_stateMachine.CurrentStates.Count > move)
            //            _stateMachine.CurrentStates[0].NextToken(sipUri[inx]);

            //    inx++;
            //}
            ////foreach (var s in sipUri)
            ////{
            ////    if (!_stateMachine.Alphabets.Contains(s.ToString()))
            ////        _builder.Append(s);
            ////    _stateMachine.ConsumeInputSymbol(s.ToString());
            ////}
            //if (!_stateMachine.IsAcceptedString())
            //    throw new ArgumentException("Unable to parse SIP Uri");

            //var finalStates = _stateMachine.CurrentStates.Where(s => s.StateType == StateType.FinalState).ToList();
            //if (finalStates.Count > 0)
            //    _statesStack.Push(new SipParseStateMemento(){State = (SipUriParseState) finalStates[0]});
        }

        #region Nested type: SipHeaderState

        private class SipHeaderState : SipUriParseState
        {
            public SipHeaderState(StateMachine owner) : base(owner)
            {
            }

            public override void ClearState()
            {
                base.ClearState();
                if (Act != null)
                    Act();
            }
        }

        #endregion

        #region Nested type: SipUriParseState

        private class SipUriParseState : NfaState<SipLexem>
        {
            private readonly StringBuilder _builder = new StringBuilder();

            public SipUriParseState(StateMachine owner) : base(owner)
            {
            }

            public override void NextToken<S>(S token)
            {
                _builder.Append(Convert.ToChar(token));
            }

            public string GetState()
            {
                return _builder.ToString();
            }

            public override void ClearState()
            {
                _builder.Clear();
            }
        }

        #endregion
    }
}