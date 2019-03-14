using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.CodeWarsProblems._7kyuProblems
{
    //https://www.codewars.com/kata/fibonacci
    [TestClass]
    public class Fibonacci
    {
        public static int fib(int n)
        {
            // your code here!
            return 0;
        }

        [TestMethod]
        public void FibonacciTests()
        {
            Assert.AreEqual(5, fib(5));
            Assert.AreEqual(55, fib(10));
        }
    }
}
