using System;
using System.Collections.Generic;
using System.Linq;

namespace pjsip4net.Core.Utils
{
    /// <summary>
    /// This class represents a Nondeterministic finite state machine
    /// </summary>
    /// <typeparam name="Q">The state type</typeparam>
    /// <typeparam name="S">The symbol type</typeparam>
    public class Nfa<Q, S> : StateMachine
    {
        public Nfa()
        {
            CurrentStates = new List<NfaState<Q>>();
            TransitionTable = new List<TransitionFunction<NfaState<Q>, S, NfaState<Q>>>();
            States = new List<NfaState<Q>>();
            Alphabets = new List<S>();
        }

        #region Properties

        public S CurrentSymbol { get; set; }

        /// <summary>
        /// Get or set the states
        /// </summary>
        public List<NfaState<Q>> States { get; set; }

        /// <summary>
        /// Get or set the TransitionTable
        /// </summary>
        public List<TransitionFunction<NfaState<Q>, S, NfaState<Q>>> TransitionTable { get; set; }

        /// <summary>
        /// Get all the start states
        /// </summary>
        public List<NfaState<Q>> StartStates
        {
            get { return States.FindAll(st => st.StateType == StateType.StartState); }
            internal set { }
        }

        /// <summary>
        /// Get all the final states
        /// </summary>
        public List<NfaState<Q>> FinalStates
        {
            get { return States.FindAll(st => st.StateType == StateType.FinalState); }
            internal set { }
        }

        /// <summary>
        /// Get all the Sink states
        /// </summary>
        public List<NfaState<Q>> SinkStates
        {
            get { return States.FindAll(st => st.StateType == StateType.SinkState); }
            internal set { }
        }

        /// <summary>
        /// Maintain a list of the current states
        /// </summary>
        public List<NfaState<Q>> CurrentStates { get; set; }

        /// <summary>
        /// Set of alphabets
        /// </summary>
        public List<S> Alphabets { get; set; }

        #endregion

        #region NFA Class Methods

        /// <summary>
        /// Add new state, this method check if the 
        /// state <see cref="T"/> exists, if not
        /// add the state.
        /// </summary>
        /// <param name="state"></param>
        public void AddState(NfaState<Q> state)
        {
            if (!IsExists(state.Id))
            {
                if (state.StateType == StateType.StartState)
                {
                    CurrentStates.Add(state);
                }
                States.Add(state);
            }
        }


        /// <summary>
        /// Get all the next states of the specified state
        /// </summary>
        /// <param name="state">The state for which to get the next states</param>
        /// <returns>List of all next states if any, empty list otherwise</returns>
        public List<NfaState<Q>> GetNextStates(NfaState<Q> state)
        {
            var list = new List<NfaState<Q>>();

            if (state != null && IsExists(state.Id))
            {
                list.AddRange(from s in
                                  TransitionTable.FindAll(tf => tf.From.Id.Equals(state.Id))
                              select s.To);
            }
            else return null;

            return list;
        }

        /// <summary>
        /// Get all the next states of the specified state
        /// and that's reachable through the symbol <see cref="S"/>
        /// </summary>
        /// <param name="state">The state for which to get the next states</param>
        /// <param name="symbol">The connector symbol</param>
        /// <returns>List of all next states if any, empty list otherwise</returns>
        public virtual List<NfaState<Q>> GetNextStates(NfaState<Q> state, S symbol)
        {
            var list = new List<NfaState<Q>>();

            if (state != null && IsExists(state.Id))
            {
                list.AddRange((from s in
                                   TransitionTable.FindAll(tf => tf.From.Id.Equals(state.Id) &&
                                                                 tf.TransitionSymbols.Contains(symbol))
                               select s.To).Union(
                                  from t in TransitionTable.OfType<PredicateTransitionFunction<NfaState<Q>, S, NfaState<Q>>>()
                                  where
                                      t.From.Id.Equals(state.Id) && t.PredicateLambda != null &&
                                      t.PredicateLambda(symbol)
                                  select t.To
                                  ).Distinct());
            }
            else return null;

            return list;
        }

        /// <summary>
        /// Get s state by key
        /// </summary>
        /// <param name="key">The key to search for</param>
        /// <returns>The state if found</returns>
        public NfaState<Q> GetState(Q key)
        {
            return States.Find(st => st.Id.Equals(key));
        }

        /// <summary>
        /// This method checks if the key already
        /// exists
        /// </summary>
        /// <param name="key">the key to examn</param>
        /// <returns>true if the key exists, false otherwise</returns>
        public bool IsExists(Q key)
        {
            return States.Exists(st => st.Id.Equals(key));
        }

        /// <summary>
        /// Set state type
        /// </summary>
        /// <param name="key">The state key</param>
        /// <param name="type">The type to  be set</param>
        public void SetStateType(Q key, StateType type)
        {
            NfaState<Q> state = null;
            if ((state = GetState(key)) != null)
            {
                state.StateType = type;
                if (state.StateType == StateType.StartState)
                {
                    CurrentStates.Add(state);
                }
                else CurrentStates.RemoveState(key);
            }
            else throw new Exception("State doesn't exists");
        }


        /// <summary>
        /// Reset the the start states to its origin
        /// </summary>
        public void ResetStartStates()
        {
            CurrentStates.Clear();
            CurrentStates.AddRange(
                States.FindAll(st => st.StateType == StateType.StartState));
        }

        /// <summary>
        /// Consume Symbol and return the current states
        /// </summary>
        /// <param name="symbol">the symbol to be consumed</param>
        /// <returns>The current states if applicable, or null otherwise</returns>
        protected virtual List<NfaState<Q>> ConsumeInputSymbol(S symbol)
        {
            var nextStates = new List<NfaState<Q>>();
            List<NfaState<Q>> currentNextStates = null;

            if (CurrentStates == null)
                throw new Exception("No current states available, input rejected");

            foreach (var state in CurrentStates)
            {
                currentNextStates = GetNextStates(state, symbol);
                if (currentNextStates != null)
                    nextStates.AddRange(currentNextStates);
            }

            //var diff = CurrentStates.Except(nextStates);
            //foreach (var state in diff)
            //    state.StateChanged();

            CurrentStates = nextStates;

            //foreach (var state in CurrentStates)
            //{
            //    state.NextToken(symbol);
            //    ChangeState(state);
            //}

            return nextStates.Count != 0 ? nextStates : null;
        }

        /// <summary>
        /// Consume all given symbols and return true 
        /// if accepted a
        /// </summary>
        /// <param name="symbols">a list of all symbols to be consumed</param>
        /// <returns>true if inputs are accepted, false otherwise</returns>
        public virtual bool ComsumeAllInputSymbols(List<S> symbols)
        {
            // Consume each symbol
            foreach (S symbol in symbols)
                ConsumeInputSymbol(symbol);

            return IsAcceptedString();
        }

        public bool IsAcceptedString()
        {
            // Iterate over all current states 
            // and check if anyone of them is
            // final state (accepted state) 
            foreach (var state in CurrentStates)
            {
                if (state.StateType == StateType.FinalState)
                {
                    state.StateChanged();
                    return true;
                }
            }
            return false;
        }

        #endregion
    }

    public static class StateExtensions
    {
        /// <summary>
        /// Remove a state from the list
        /// </summary>
        /// <typeparam name="Q"></typeparam>
        /// <param name="states"></param>
        /// <param name="key"></param>
        public static void RemoveState<Q>(this List<NfaState<Q>> states, Q key)
        {
            states.Remove(states.Find(st => st.Id.Equals(key)));
        }

        /// <summary>
        /// This method checks if the key already
        /// exists in the given list of states
        /// </summary>
        /// <param name="key">the key to examn</param>
        /// <returns>true if the key exists, false otherwise</returns>
        public static bool IsExists<Q>(this List<NfaState<Q>> states, Q key)
        {
            return states.Exists(st => st.Id.Equals(key));
        }


        /// <summary>
        /// Remove a state from the list
        /// </summary>
        /// <typeparam name="Q"></typeparam>
        /// <param name="states"></param>
        /// <param name="key"></param>
        public static void RemoveTranistionFunction<Q, S>(this List<TransitionFunction<NfaState<Q>, S, NfaState<Q>>> tf,
                                                          NfaState<Q> state, S symbol)
        {
            tf.Remove(
                tf.Find(
                    t =>
                    t.From.Id.Equals(state.Id) &&
                    ((symbol == null && t.TransitionSymbols == null) || t.TransitionSymbols.Equals(symbol))));
        }
    }
}