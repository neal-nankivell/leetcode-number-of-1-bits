using System;
using Answer;
using NUnit.Framework;

namespace Tests
{
    public class SolutionTests
    {
        [TestCase((uint)0, ExpectedResult = 0)]
        [TestCase((uint)1, ExpectedResult = 1)]
        [TestCase((uint)2, ExpectedResult = 1)]
        [TestCase((uint)3, ExpectedResult = 2)]
        [TestCase((uint)4, ExpectedResult = 1)]
        [TestCase((uint)5, ExpectedResult = 2)]
        public int HammingWeight(uint n)
        {
            Console.WriteLine(Convert.ToString(n, 2));
            var sut = new Solution();

            return sut.HammingWeight(n);
        }
    }
}