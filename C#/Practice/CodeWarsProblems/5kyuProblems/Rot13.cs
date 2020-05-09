using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Practice.CodeWarsProblems._5kyuProblems
{
    //https://www.codewars.com/kata/rot13-1/train/csharp
    [TestClass]
    public class Rot13Problem
    {
        public static string Rot13(string message)
        {
            char[] newMessage = message.ToCharArray();
            return new string(newMessage.ToList().Select(x => Convert(x)).ToArray());
        }

        public static char Convert(char c)
        {
            if (Math.Abs(c - 'z') <= 13 || Char.IsUpper(c))
                return (char)(c - 13);
            else
                return (char)(c + 13);
        }

        [TestMethod]
        [TestCategory("5kyu")]
        public void Rot13Test()
        {
            Assert.AreEqual("grfg", Rot13("test"), String.Format("Input: test, Expected Output: Grfg, Actual Output: {0}", Rot13("test")));
            Assert.AreEqual("Grfg", Rot13("Test"), String.Format("Input: Test, Expected Output: grfg, Actual Output: {0}", Rot13("Test")));
        }
    }
}
