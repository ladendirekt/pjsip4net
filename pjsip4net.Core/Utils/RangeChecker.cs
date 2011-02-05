using System;

namespace pjsip4net.Core.Utils
{
    public class RangeChecker<T> where T : IComparable
    {
        // Methods
        public RangeChecker(T lowerBound, RangeBoundaryType lowerBoundType, T upperBound,
                            RangeBoundaryType upperBoundType)
        {
            if ((Equals(upperBound, default(T))) && (upperBoundType != RangeBoundaryType.Ignore))
            {
                throw new ArgumentNullException("Upper bound is null");
            }
            if ((Equals(lowerBound, default(T))) && (lowerBoundType != RangeBoundaryType.Ignore))
            {
                throw new ArgumentNullException("Lower bound is null");
            }
            if (((lowerBoundType != RangeBoundaryType.Ignore) && (upperBoundType != RangeBoundaryType.Ignore)) &&
                (upperBound.CompareTo(lowerBound) < 0))
            {
                throw new ArgumentException("Upper bound is lower than lower bound");
            }
            LowerBound = lowerBound;
            LowerBoundType = lowerBoundType;
            UpperBound = upperBound;
            UpperBoundType = upperBoundType;
        }

        // Properties
        public T LowerBound { get; private set; }

        public RangeBoundaryType LowerBoundType { get; private set; }

        public T UpperBound { get; set; }

        public RangeBoundaryType UpperBoundType { get; private set; }

        public bool IsInRange(T target)
        {
            if (LowerBoundType > RangeBoundaryType.Ignore)
            {
                int lowerBoundComparison = LowerBound.CompareTo(target);
                if (lowerBoundComparison > 0)
                {
                    return false;
                }
                if ((LowerBoundType == RangeBoundaryType.Exclusive) && (lowerBoundComparison == 0))
                {
                    return false;
                }
            }
            if (UpperBoundType > RangeBoundaryType.Ignore)
            {
                int upperBoundComparison = UpperBound.CompareTo(target);
                if (upperBoundComparison < 0)
                {
                    return false;
                }
                if ((UpperBoundType == RangeBoundaryType.Exclusive) && (upperBoundComparison == 0))
                {
                    return false;
                }
            }
            return true;
        }
    }

    public enum RangeBoundaryType
    {
        Exclusive,
        Ignore,
        Inclusive
    }
}