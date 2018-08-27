using System;
using System.Collections.Generic;
using NUnit.Framework;
using testGyak;

namespace test1
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestMethod1()
        {

            List<int> result = new List<int>();

            result = Program.Method2(new int[] { 1, 7, 2, 3, 9, 4, 5, 6, 7, 8, 9, 10 });
            Assert.AreEqual(new int[] { 7, 3, 4, 6, 8, 10 }, result);
        }
    }
}
