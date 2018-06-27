using Test;
using NUnit.Framework;
using NthElementWTest;
using System.Collections.Generic;

namespace Test
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestMethod1()
        {
            double result;
            int[] numbers = { 2, 4, 10, 34, 3, 16, 3, 21 };

            result = Program.NthElement(numbers, 2);
            Assert.AreEqual(18.75, result);
        }
    }
}
