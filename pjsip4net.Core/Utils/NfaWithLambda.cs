using System.Collections.Generic;
using System.Linq;

namespace pjsip4net.Core.Utils
{
    public class NfaWithLambda<Q, S> : Nfa<Q, S> where S : class
    {
        /// <summary>
        /// Override the GetNextStates methdo in the base 
        /// class to add the lambda feature
        /// It gets all the next states of the specified state
        /// and that's reachable through the symbol <see cref="S"/>
        /// or the lambda, lambda is represented as null.
        /// </summary>
        /// <param name="state">The state for which to get the next states</param>
        /// <param name="symbol">The connector symbol</param>
        /// <returns>List of all next states if any, empty list otherwise</returns>
        public override List<NfaState<Q>> GetNextStates(NfaState<Q> state, S symbol)
        {
            var list = new List<NfaState<Q>>();

            if (state != null && IsExists(state.Id))
            {
                IEnumerable<TransitionFunction<NfaState<Q>, S, NfaState<Q>>> transitions = (from t in TransitionTable
                                                                                            where
                                                                                                t.From.Id.Equals(state.Id) &&
                                                                                                t.TransitionSymbols != null &&
                                                                                                t.TransitionSymbols.Contains(
                                                                                                    symbol)
                                                                                            select t).Union(
                    from t in TransitionTable.OfType<PredicateTransitionFunction<NfaState<Q>, S, NfaState<Q>>>()
                    where t.From.Id.Equals(state.Id) && t.PredicateLambda != null && t.PredicateLambda(symbol)
                    select (TransitionFunction<NfaState<Q>, S, NfaState<Q>>) t
                    ).Distinct();

                foreach (var tf in transitions)
                {
                    list.Add(tf.To);
                    // For each one check to see of there are some states
                    // reachable via lambda
                    List<NfaState<Q>> nextLambdaStates = GetNextLambdaStates(tf.To);
                    // add the states reachable via lambda 
                    if (nextLambdaStates != null)
                    {
                        list.AddRange(nextLambdaStates);
                    }
                }

                // Search for lambda transtion from the state and other states
                List<NfaState<Q>> nextStateLambdaStates = GetNextLambdaStates(state);

                if (nextStateLambdaStates != null)
                {
                    // if found, iterate over them and check if 
                    // they have a transition with the same symbol
                    foreach (var st in nextStateLambdaStates)
                    {
                        list.AddRange(from t in TransitionTable
                                      where t.From.Id.Equals(st.Id) &&
                                            t.TransitionSymbols != null &&
                                            t.TransitionSymbols.Contains(symbol)
                                      select t.To);
                    }
                }
            }
            else return null;

            return list;
        }

        /// <summary>
        /// This method gets all the states reachable via lambda
        /// transition
        /// </summary>
        /// <param name="state">The start to start from</param>
        /// <returns>List of all states reachable via lambda, null otherwise</returns>
        private List<NfaState<Q>> GetNextLambdaStates(NfaState<Q> state)
        {
            var list = new List<NfaState<Q>>();

            if (state != null && IsExists(state.Id))
            {
                IEnumerable<NfaState<Q>> states = from t in TransitionTable
                                                  where t.From.Id.Equals(state.Id) &&
                                                        t.TransitionSymbols == null
                                                  select t.To;

                foreach (var st in states)
                {
                    list.Add(st);
                    List<NfaState<Q>> nextLambdaStates = GetNextLambdaStates(st);

                    if (nextLambdaStates != null)
                    {
                        list.AddRange(nextLambdaStates);
                    }
                }
            }
            else return null;

            return list;
        }
    }
}