using System;
using System.Diagnostics;

namespace pjsip4net.Core.Utils
{
    public static class Helper
    {
        private static readonly object _lock = new object();
        private static string _lastError;

        public static string LastError
        {
            get
            {
                lock (_lock)
                    return _lastError;
            }
            set
            {
                lock (_lock)
                    _lastError = value;
            }
        }

        public static void GuardInRange<T>(T lower, T upper, T target)
            where T : IComparable
        {
            var checker = new RangeChecker<T>(lower, RangeBoundaryType.Ignore, upper, RangeBoundaryType.Ignore);
            if (!checker.IsInRange(target))
                throw new ArgumentOutOfRangeException();
        }

        public static void GuardPositiveInt(int target)
        {
            GuardInRange(0, int.MaxValue, target);
        }

        public static void GuardError(int code)
        {
            if (code != 0)
            {
                var frame = new StackFrame(1);
                throw new PjsipErrorException(code,
                                              string.Format("PJSIP error code = {0} in {1}", LastError,
                                                            frame.GetMethod().Name));
            }
        }

        public static void GuardNotNull(object arg)
        {
            if (arg == null)
                throw new ArgumentNullException();
        }

        public static void GuardNotNullStr(string arg)
        {
            if (string.IsNullOrEmpty(arg))
                throw new ArgumentNullException();
        }

        public static void GuardIsTrue(bool invariant)
        {
            if (!invariant)
                throw new ArgumentException("Invariant is not TRUE");
        }
    }
}