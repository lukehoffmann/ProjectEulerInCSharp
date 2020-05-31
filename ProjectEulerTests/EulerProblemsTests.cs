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
            // In the 20×20 grid below, four numbers along a diagonal line have been marked in red.
            // The product of these numbers is 26 × 63 × 78 × 14 = 1788696.

            // Use 1-based index
            Assert.AreEqual(1788696, Problem11.RightDownProduct(9, 7));
        }

        [TestMethod]
        public void Problem11_Solution()
        {
            // What is the greatest product of four adjacent numbers in the same direction (up,
            // down, left, right, or diagonally) in the 20×20 grid ?
            Assert.AreEqual(70600674, Problem11.HighestProduct());
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

        [TestMethod]
        public void Problem15_ExampleRecursive()
        {
            // Starting in the top left corner of a 2×2 grid, and only being able to move
            // to the right and down, there are exactly 6 routes to the bottom right corner.
            //Assert.AreEqual(6, new BoxTraverser(2).CountRoutesRecursive());
            //Assert.AreEqual(20, new BoxTraverser(3).CountRoutesRecursive());
            //Assert.AreEqual(70, new BoxTraverser(4).CountRoutesRecursive());
            //Assert.AreEqual(252, new BoxTraverser(5).CountRoutesRecursive());
            //Assert.AreEqual(924, new BoxTraverser(6).CountRoutesRecursive());
            //Assert.AreEqual(3432, new BoxTraverser(7).CountRoutesRecursive());
            //Assert.AreEqual(12870, new BoxTraverser(8).CountRoutesRecursive());
            //Assert.AreEqual(48620, new BoxTraverser(9).CountRoutesRecursive());
            //Assert.AreEqual(184756, new BoxTraverser(10).CountRoutesRecursive());
            //Assert.AreEqual(705432, new BoxTraverser(11).CountRoutesRecursive());
            //Assert.AreEqual(2704156, new BoxTraverser(12).CountRoutesRecursive());
            //Assert.AreEqual(10400600, new BoxTraverser(13).CountRoutesRecursive());
            //Assert.AreEqual(40116600, new BoxTraverser(14).CountRoutesRecursive());
            //Assert.AreEqual(155117520, new BoxTraverser(15).CountRoutesRecursive());
            //Assert.AreEqual(601080390, new BoxTraverser(16).CountRoutesRecursive());
            //Assert.AreEqual(2333606220, new BoxTraverser(17).CountRoutesRecursive());
            Assert.AreEqual(9075135300, new BoxTraverser(18).CountRoutesRecursive());
        }

        [TestMethod]
        public void Problem15_ExampleDepthFirst()
         {
            // Starting in the top left corner of a 2×2 grid, and only being able to move
            // to the right and down, there are exactly 6 routes to the bottom right corner.
            //Assert.AreEqual(6, new BoxTraverser(2).CountRoutesDepthFirst());
            //Assert.AreEqual(20, new BoxTraverser(3).CountRoutesDepthFirst());
            //Assert.AreEqual(70, new BoxTraverser(4).CountRoutesDepthFirst());
            //Assert.AreEqual(252, new BoxTraverser(5).CountRoutesDepthFirst());
            //Assert.AreEqual(924, new BoxTraverser(6).CountRoutesDepthFirst());
            //Assert.AreEqual(3432, new BoxTraverser(7).CountRoutesDepthFirst());
            //Assert.AreEqual(12870, new BoxTraverser(8).CountRoutesDepthFirst());
            //Assert.AreEqual(48620, new BoxTraverser(9).CountRoutesDepthFirst());
            //Assert.AreEqual(184756, new BoxTraverser(10).CountRoutesDepthFirst());
            //Assert.AreEqual(705432, new BoxTraverser(11).CountRoutesDepthFirst());
            //Assert.AreEqual(2704156, new BoxTraverser(12).CountRoutesDepthFirst());
            //Assert.AreEqual(10400600, new BoxTraverser(13).CountRoutesDepthFirst());
            //Assert.AreEqual(40116600, new BoxTraverser(14).CountRoutesDepthFirst());
            //Assert.AreEqual(155117520, new BoxTraverser(15).CountRoutesDepthFirst());
            Assert.AreEqual(601080390, new BoxTraverser(16).CountRoutesDepthFirst());
            //Assert.AreEqual(2333606220, new BoxTraverser(17).CountRoutesDepthFirst());
        }

        [TestMethod, Ignore] // too slow
        public void Problem15_Solution()
        {
            // How many such routes are there through a 20×20 grid ?
            Assert.AreEqual(137846528820L, new BoxTraverser(20).CountRoutesRecursive());
        }
    }
}
