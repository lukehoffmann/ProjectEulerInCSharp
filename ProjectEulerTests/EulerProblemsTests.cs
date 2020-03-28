using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerInCSharp;

namespace ProjectEulerTests
{
    [TestClass]
    public class EulerProblemsTests
    {

        [TestMethod]
        public void Problem1_ExampleTest()
        {
            Assert.AreEqual(23, EulerProblems.Problem1Example());
        }

        [TestMethod]
        public void Problem1_SolutionTest()
        {
            Assert.AreEqual(233168, EulerProblems.Problem1Solution());
        }

        [TestMethod]
        public void Problem2_Solution()
        {
            Assert.AreEqual(4613732, EulerProblems.Problem2Solution());
        }

        [TestMethod]
        public void Problem3_Example()
        {
            var result = EulerProblems.Problem3Example();

            Assert.AreEqual(4, result.Count);
            Assert.IsTrue(result.Contains(5));
            Assert.IsTrue(result.Contains(7));
            Assert.IsTrue(result.Contains(13));
            Assert.IsTrue(result.Contains(29));
        }

        [TestMethod]
        public void Problem3_Solution()
        {
            Assert.AreEqual(6857, EulerProblems.Problem3Solution());
        }

        [TestMethod]
        public void Problem4_Example()
        {
            Assert.AreEqual(9009, EulerProblems.Problem4Example());
        }

        [TestMethod]
        public void Problem4_Solution()
        {
            Assert.AreEqual(906609, EulerProblems.Problem4Solution());
        }

        [TestMethod]
        public void Problem5_Example()
        {
            Assert.AreEqual(2520, EulerProblems.Problem5Example());
        }

        [TestMethod]
        public void Problem5_Solution()
        {
            Assert.AreEqual(232792560, EulerProblems.Problem5Solution());
        }

        [TestMethod]
        public void Problem6_Example()
        {
            Assert.AreEqual(2640, EulerProblems.Problem6Example());
        }

        [TestMethod]
        public void Problem6_Solution()
        {
            Assert.AreEqual(25164150, EulerProblems.Problem6Solution());
        }

        [TestMethod]
        public void Problem7_Example()
        {
            Assert.AreEqual(13, EulerProblems.Problem7Example());
        }

        [TestMethod]
        public void Problem7_Solution()
        {
            Assert.AreEqual(104743, EulerProblems.Problem7Solution());
        }

        [TestMethod]
        public void Problem8_Example()
        {
            Assert.AreEqual(5832, EulerProblems.Problem8Example());
        }

        [TestMethod]
        public void Problem8_Solution()
        {
            Assert.AreEqual(23514624000, EulerProblems.Problem8Solution());
        }

        [TestMethod]
        public void Problem9_Solution()
        {
            Assert.AreEqual(31875000, EulerProblems.Problem9Solution());
        }

        [TestMethod]
        public void Problem10_Solution()
        {
            Assert.AreEqual(142913828922, EulerProblems.Problem10Solution());
        }

        [TestMethod]
        public void Problem11_Example()
        {
            Assert.AreEqual(1788696, EulerProblems.Problem11Example());
        }

        [TestMethod]
        public void Problem11_Solution()
        {
            Assert.AreEqual(70600674, EulerProblems.Problem11Solution());
        }

        [TestMethod]
        public void Problem12_Example()
        {
            Assert.AreEqual(28, EulerProblems.Problem12Example());
        }

        [TestMethod]
        public void Problem12_Solution()
        {
            Assert.AreEqual(76576500, EulerProblems.Problem12Solution());
        }

        [TestMethod]
        public void Problem13_Solution()
        {
            Assert.AreEqual("5537376230", EulerProblems.Problem13Solution());
        }

        [TestMethod]
        public void Problem14_Solution()
        {
            Assert.AreEqual(837799, EulerProblems.Problem14Solution());
        }
    }
}
