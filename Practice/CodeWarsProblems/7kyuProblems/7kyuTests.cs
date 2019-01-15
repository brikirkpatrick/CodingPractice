using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.CodeWarsProblems._7kyuProblems
{
    [TestClass]
    public class _7kyuTests
    {
        //public _7kyuProblems problem;
        public _7kyuTests()
        {

        }

        [TestMethod]
        [TestCategory("7kyu")]
        public void PrintErrorsTest()
        {
            string s = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            Assert.AreEqual("3/56", PrinterErrors.PrinterError(s));
        }

    }
}
