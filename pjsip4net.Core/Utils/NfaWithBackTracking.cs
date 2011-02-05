using System;
using System.Collections.Generic;
using System.Linq;

namespace pjsip4net.Core.Utils
{
    public class NfaWithBackTracking<Q, S> : Nfa<Q, S>
    {
        private readonly Stack<StateMemento> _statesStack = new Stack<StateMemento>();
        private int _inx;
        private int _move;

        private StateMemento CreateMemento()
        {
            return new StateMemento {Move = _move, State = CurrentStates[0], TokenIndex = _inx};
        }

        protected override List<NfaState<Q>> ConsumeInputSymbol(S symbol)
        {
            var nextStates = new List<NfaState<Q>>();

            if (CurrentStates == null || CurrentStates.Count == 0)
                throw new Exception("No current states available, input rejected");

            if (CurrentStates.Count > 1)
                throw new Exception("NFA with backtracking can only have one active state");

            nextStates.AddRange(GetNextStates(CurrentStates[0], symbol) ?? Enumerable.Empty<NfaState<Q>>());

            if (nextStates == null || nextStates.Count == 0)
            {
                _move = -1;
                return nextStates;
            }
            if (nextStates.Count > 1)
            {
                if (_move > nextStates.Count)
                    throw new Exception("There are no choices for this move.");
                PushChoice();
            }

            if (CurrentStates[0] != nextStates[_move])
                nextStates[_move].ClearState();

            CurrentStates = new List<NfaState<Q>> {nextStates[_move]};
            CurrentStates[0].NextToken(symbol);
            _inx++;
            _move = 0;

            return nextStates.Count != 0 ? nextStates : null;
        }

        public override bool ComsumeAllInputSymbols(List<S> symbols)
        {
            while (_inx < symbols.Count)
            {
                ConsumeInputSymbol(symbols[_inx]);
                if (_move == -1)
                    PopChoice();
            }

            return IsAcceptedString();
        }

        private void PopChoice()
        {
            CurrentStates[0].ClearState();
            CurrentStates.Clear();
            if (_statesStack.Count == 0)
                throw new Exception("Choice stack is empty. Unable to fallback to another state.");

            StateMemento memento = _statesStack.Pop();
            _inx = memento.TokenIndex;
            _move = memento.Move + 1;
            CurrentStates.Add(memento.State);
        }

        private void PushChoice()
        {
            _statesStack.Push(CreateMemento());
            //_move = 0;
        }

        #region Nested type: StateMemento

        private class StateMemento
        {
            public int Move;
            public NfaState<Q> State;
            public int TokenIndex;
        }

        #endregion
    }
}