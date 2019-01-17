using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.CodeWarsProblems._6kyuProblems
{
    //https://www.codewars.com/kata/514b92a657cdc65150000006
    [TestClass]
    public class MultiplesOf3Or5
    {
        public static int IsMultipleOf3Or5(int value)
        {
            if (value == 0) return 0;

            var sum = 0;
            List<int> list = new List<int>();

            list.AddRange(Enumerable.Range(1, value - 1));
            list.ForEach(r =>
            {
                sum += IsMultiple(r);
            });

            return sum;
        }

        public static int IsMultiple3Or5Linq(int value)
        {
            //TODO: 1 Line LINQ solution.
            return 0;
        }

        public static int IsMultiple(int number)
        {
            return ((number % 3 == 0) || (number % 5 == 0)) ? number : 0;
        }

        [TestMethod]
        [TestCategory("6kyu")]
        public void MultipleOf3Or5Test()
        {
            Assert.AreEqual(23, IsMultipleOf3Or5(10));
        }
    }
}
