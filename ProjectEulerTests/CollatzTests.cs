using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerInCSharp;

namespace ProjectEulerTests
{
    [TestClass]
    public class CollatzTests
    {
        [TestMethod]
        public void CollatzExampleTest()
        {
            // The following iterative sequence is defined for the set of positive integers:
            //
            //      n → n/2 (n is even)
            //      n → 3n + 1 (n is odd)
            //
            // Using the rule above and starting with 13, we generate the following sequence:
            // 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
            //
            // It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms.

            var sequence = Collatz.Sequence(13).ToList();
            Assert.AreEqual(10, sequence.Count);
            Assert.AreEqual(13, sequence[0]);
            Assert.AreEqual(40, sequence[1]);
            Assert.AreEqual(20, sequence[2]);
            Assert.AreEqual(10, sequence[3]);
            Assert.AreEqual(5, sequence[4]);
            Assert.AreEqual(16, sequence[5]);
            Assert.AreEqual(8, sequence[6]);
            Assert.AreEqual(4, sequence[7]);
            Assert.AreEqual(2, sequence[8]);
            Assert.AreEqual(1, sequence[9]);
        }
    }
}
