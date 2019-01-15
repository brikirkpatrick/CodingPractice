using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.CodeWarsProblems._6kyuProblems
{
    [TestClass]
    public class _6kyuTests
    {
        [TestMethod]
        [TestCategory("6kyu")]
        public void FindTheOddIntTest()
        {
            Assert.AreEqual(5, FindTheOddInt.find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }

        [TestMethod]
        [TestCategory("6kyu")]
        public void MultipleOf3Or5Test()
        {
            Assert.AreEqual(23, MultiplesOf3Or5.IsMultipleOf3Or5(10));
        }

        [TestMethod]
        [TestCategory("6kyu")]
        public void ReplaceWithAlphabetPositionTest()
        {
            //TODO: Create test...
        }
    }
}
