using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerInCSharp
{
    public class EulerProblems
    {
        /// <summary>
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
        /// The sum of these multiples is 23.
        /// </summary>
        public static int Problem1Example()
        {
            //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
            //The sum of these multiples is 23.
            return Enumerable.Range(0, 10)
                .Where(i => i.IsMultipleOf(3) || i.IsMultipleOf(5))
                .Sum();
        }

        /// <summary>
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        public static int Problem1Solution()
        {
            //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
            //The sum of these multiples is 23.
            return Enumerable.Range(0, 1000)
                .Where(i => i.IsMultipleOf(3) || i.IsMultipleOf(5))
                .Sum();
        }

        /// <summary>
        /// By considering the terms in the Fibonacci sequence whose values do not exceed four
        /// million, find the sum of the even-valued terms.
        /// </summary>
        public static int Problem2Solution()
        {
            return MathHelpers.FibonacciNumbersUpTo(4000000)
                .Where(f => f.IsMultipleOf(2))
                .Sum();
        }

        /// <summary>
        /// The prime factors of 13195 are 5, 7, 13 and 29.
        /// </summary>
        public static List<long> Problem3Example()
        {
            return MathHelpers.PrimeFactorsOf(13195).ToList();
        }

        /// <summary>
        /// What is the largest prime factor of the number 600851475143 ?
        /// </summary>
        public static long Problem3Solution()
        {
            return MathHelpers.PrimeFactorsOf(600851475143).Max();
        }

        /// <summary>
        /// A palindromic number reads the same both ways. The largest palindrome made from the
        /// product of two 2-digit numbers is 9009 = 91 × 99.
        /// </summary>
        public static int Problem4Example()
        {
            return MathHelpers.AllProductsOfXDigitNumbers(2)
                .Where(p => p.IsPalindromic())
                .Max();
        }

        /// <summary>
        /// Find the largest palindrome made from the product of two 3-digit numbers.
        /// </summary>
        public static int Problem4Solution()
        {
            return MathHelpers.AllProductsOfXDigitNumbers(3)
                .Where(p => p.IsPalindromic())
                .Max();
        }

        /// <summary>
        /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10
        /// without any remainder.
        /// </summary>
        public static int Problem5Example()
        {
            var factors = Enumerable.Range(1, 10).ToList();
            return MathHelpers.SmallestMultipleOfAllFactors(factors);
        }

        /// <summary>
        /// What is the smallest positive number that is evenly divisible by all of the numbers
        /// from 1 to 20?
        /// </summary>
        public static int Problem5Solution()
        {
            var factors = Enumerable.Range(1, 20).ToList();
            return MathHelpers.SmallestMultipleOfAllFactors(factors);
        }

        /// <summary>
        /// The sum of the squares of the first ten natural numbers is 385
        /// The square of the sum of the first ten natural numbers is 3025
        /// Hence the difference between the sum of the squares of the first ten natural numbers
        /// and the square of the sum is 3025 − 385 = 2640.
        /// </summary>
        public static int Problem6Example()
        {
            var upTo = 10;

            var sum = Enumerable.Range(1, upTo).Sum();
            var squareOfSum = sum * sum;

            var sumOfSquares = Enumerable.Range(1, upTo)
                .Select(i => i * i)
                .Sum();

            return Math.Abs(sumOfSquares - squareOfSum);
        }

        /// <summary>
        /// Find the difference between the sum of the squares of the first one hundred natural
        /// numbers and the square of the sum.
        /// </summary>
        public static long Problem6Solution()
        {
            var upTo = 100;

            var sum = Enumerable.Range(1, upTo).Sum();
            var squareOfSum = sum * sum;

            var sumOfSquares = Enumerable.Range(1, upTo)
                .Select(i => i * i)
                .Sum();

            return Math.Abs(sumOfSquares - squareOfSum);
        }

        /// <summary>
        /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the
        /// 6th prime is 13.
        /// </summary>
        public static long Problem7Example()
        {
            return MathHelpers.NthPrime(6);
        }

        /// <summary>
        /// What is the 10001st prime number?
        /// </summary>
        public static long Problem7Solution()
        {
            return MathHelpers.NthPrime(10001);
        }

        public static string Problem8Data = "73167176531330624919225119674426574742355349194934" +
                                            "96983520312774506326239578318016984801869478851843" +
                                            "85861560789112949495459501737958331952853208805511" +
                                            "12540698747158523863050715693290963295227443043557" +
                                            "66896648950445244523161731856403098711121722383113" +
                                            "62229893423380308135336276614282806444486645238749" +
                                            "30358907296290491560440772390713810515859307960866" +
                                            "70172427121883998797908792274921901699720888093776" +
                                            "65727333001053367881220235421809751254540594752243" +
                                            "52584907711670556013604839586446706324415722155397" +
                                            "53697817977846174064955149290862569321978468622482" +
                                            "83972241375657056057490261407972968652414535100474" +
                                            "82166370484403199890008895243450658541227588666881" +
                                            "16427171479924442928230863465674813919123162824586" +
                                            "17866458359124566529476545682848912883142607690042" +
                                            "24219022671055626321111109370544217506941658960408" +
                                            "07198403850962455444362981230987879927244284909188" +
                                            "84580156166097919133875499200524063689912560717606" +
                                            "05886116467109405077541002256983155200055935729725" +
                                            "71636269561882670428252483600823257530420752963450";

        /// <summary>
        /// The four adjacent digits in the 1000-digit number that have the greatest product are
        /// 9 × 9 × 8 × 9 = 5832.
        /// </summary>
        public static int Problem8Example()
        {
            var data = Problem8Data;
            const int n = 4;
            var l = data.Length;
            var max = 0;

            for (var i = 0; i + n <= l; i++)
            {
                var product = Enumerable.Range(i, n).Aggregate(1, (j, k) => j * data.DigitAtPosition(k));
                max = Math.Max(max, product);
            }

            return max;
        }

        /// <summary>
        /// Find the thirteen adjacent digits in the 1000-digit number that have the greatest
        /// product. What is the value of this product?
        /// </summary>
        public static long Problem8Solution()
        {
            var data = Problem8Data;
            var l = data.Length;
            const int n = 13;

            long max = 0;
            for (var i = 0; i + n <= l; i++)
            {
                var product = Enumerable.Range(i, n)
                    .Aggregate(1L, (j, k) => j * data.DigitAtPosition(k));

                max = Math.Max(max, product);
            }

            return max;
        }

        /// <summary>
        /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        /// Find the product abc.
        /// </summary>
        public static long Problem9Solution()
        {
            for (var a = 1; a < 998; ++a)
            {
                for (var b = a; b < 998; ++b)
                {
                    for (var c = b; c < 998; ++c)
                    {
                        if (a + b + c == 1000
                            && MathHelpers.IsPythagoreanTriplet(a, b, c))
                        {
                            return a * b * c;
                        }
                    }
                }
            }

            return 0;
        }

        /// <summary>
        /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        /// Find the sum of all the primes below two million.
        /// </summary>
        public static long Problem10Solution()
        {
            return MathHelpers.SumOfPrimesBelow(2000000);
        }

        public static long Problem11Example()
        {
            // In the 20×20 grid below, four numbers along a diagonal line have been marked in red.
            // The product of these numbers is 26 × 63 × 78 × 14 = 1788696.

            // Use 1-based index
            const int x = 9;
            const int y = 7;

            return Problem11.RightDownProduct(x, y);
        }

        public static long Problem11Solution()
        {
            // What is the greatest product of four adjacent numbers in the same direction(up,
            // down, left, right, or diagonally) in the 20×20 grid ?

            return Problem11.HighestProduct();
        }

        public static long Problem12Example()
        {
            // Let us list the factors of the first seven triangle numbers:

            // 1: 1
            // 3: 1,3
            // 6: 1,2,3,6
            // 10: 1,2,5,10
            // 15: 1,3,5,15
            // 21: 1,3,7,21
            // 28: 1,2,4,7,14,28

            //We can see that 28 is the first triangle number to have over five divisors.

            return MathHelpers.FirstTriangleNumberWhere(
                n => MathHelpers.FactorsOf(n).Count > 5);
        }

        public static long Problem12Solution()
        {
            //What is the value of the first triangle number to have over five hundred divisors?
            return MathHelpers.FirstTriangleNumberWhere(
                n => MathHelpers.FactorsOf(n).Count > 500);
        }

        public static string Problem13Solution()
        {
            // Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.
            return Problem13.AddNumbersAsStrings(Problem13.Problem13Data)
                .Substring(0, 10);
        }

        public static long Problem14Solution()
        {
            // Which starting number, under one million, produces the longest chain?
            //
            // NOTE: Once the chain starts the terms are allowed to go above one million.
            long maxLength = 0;
            long maxI = 0;
            var collatz = new Collatz();
            for (long i = 1; i < 1.0e6; i++)
            {
                var length = collatz.SequenceLength(i);
                if (length > maxLength)
                {
                    maxLength = length;
                    maxI = i;
                }
            }
            return maxI;
        }
    }
}
