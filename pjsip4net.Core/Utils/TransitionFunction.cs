using System;
using System.Collections.Generic;

namespace pjsip4net.Core.Utils
{
    public class TransitionFunction<Q1, S, Q2>
    {
        public Q1 From { get; set; }

        public List<S> TransitionSymbols { get; set; }

        public Q2 To { get; set; }
    }

    public class PredicateTransitionFunction<Q1, S, Q2> : TransitionFunction<Q1, S, Q2>
    {
        public PredicateTransitionFunction(Func<S, bool> predicate)
        {
            Helper.GuardNotNull(predicate);
            PredicateLambda = predicate;
        }

        public Func<S, bool> PredicateLambda { get; set; }
    }
}