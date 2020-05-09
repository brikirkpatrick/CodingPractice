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
        //returns n'th element of Fibonacci sequence (classic programming task).
        //0, 1, 1, 2, 3, 5, 8, 13, 21, 34....
        public static int fib(int n) //n=3, return 2
        {
            int count = 0;
            int value = 0;

            if (n == count)
            {
                return value;
            }
            else
            {

                return value;
            }
        }

        [TestMethod]
        public void FibonacciTests()
        {
            Assert.AreEqual(5, fib(5));
            Assert.AreEqual(55, fib(10));
        }
    }
}
