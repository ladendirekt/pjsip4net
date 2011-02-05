namespace pjsip4net.Core.Utils
{
    public class Tuple<T1, T2>
    {
        public Tuple(T1 part1, T2 part2)
        {
            Part1 = part1;
            Part2 = part2;
        }

        public T1 Part1 { get; private set; }
        public T2 Part2 { get; private set; }
    }
}