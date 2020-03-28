using System.Collections.Generic;

namespace ProjectEulerInCSharp
{
    public class Collatz
    {
        // The following iterative sequence is defined for the set of positive integers:
        //
        //      n → n/2 (n is even)
        //      n → 3n + 1 (n is odd)
        //
        // Although it has not been proved yet (Collatz Problem), it is thought that all starting
        // numbers finish at 1.

        /// <summary>
        /// Get the Collatz sequence for a given starting point
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static IEnumerable<long> Sequence(long n)
        {
            yield return n;
            while (n > 1)
                yield return n = Iterate(n);
        }

        private readonly Dictionary<long, long> knownLengths = new Dictionary<long, long>();

        /// <summary>
        /// An optimized function for finding only the length of a given Collatz sequence.
        /// </summary>
        public long SequenceLength(long n)
        {
            long count = 1;
            var item = n;
            while (item > 1)
            {
                if (knownLengths.ContainsKey(item))
                {
                    count += knownLengths[item];
                    break;
                }

                item = Iterate(item);
                count++;
            }

            knownLengths[n] = count;
            return count;
        }

        /// <summary>
        /// Get the next term in a Collatz sequence.
        /// </summary>
        private static long Iterate(long n)
        {
            return n.IsEven()
                ? n / 2
                : 3 * n + 1;
        }

    }
}
