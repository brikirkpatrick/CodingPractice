using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.CodeWarsProblems._6kyuProblems
{
    //https://www.codewars.com/kata/split-strings/train/csharp
    [TestClass]
    public class SplitStrings
    {
        public static string[] SplitStringbuilder(string str)
        {
            List<string> tempList = new List<string>();

            for (int i = 0; i <= str.Length - 1; i += 2)
            {
                if (i == str.Length - 1 && (str.Length % 2 != 0))
                {
                    tempList.Add(str.Substring(i, 1) + "_");

                }
                else
                {
                    tempList.Add(str.Substring(i, 2));
                }
            }

            return tempList.ToArray();
        }

        [TestMethod]
        [TestCategory("6kyu")]
        public void SplitStringsTest()
        {

            var expected = new string[] { "ab", "cd", "ef", "g_" };
            var actual = SplitStringbuilder("abcdefg");

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
