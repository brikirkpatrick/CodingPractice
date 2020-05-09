using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Practice.CodeWarsProblems._7kyuProblems
{
    //https://www.codewars.com/kata/57cebe1dc6fdc20c57000ac9/train/csharp
    [TestClass]
    public class ShortestWord
    {
        public static int FindShortWithLinq(string s)
        {
            return s.Split().OrderBy(w => w.Length).First().Length;
        }

        public static int FindShort(string s)
        {
            string[] sArray = s.Split(' ');
            int max = int.MaxValue;

            foreach(string word in sArray)
            {
                if(word.Length < max)
                {
                    max = word.Length;
                }
            }
            return max;
        }

        [TestMethod]
        [TestCategory("7kyu")]
        public void ShortestWordTest()
        {
            Assert.AreEqual(3, FindShortWithLinq("bitcoin take over the world maybe who knows perhaps"));
            Assert.AreEqual(3, FindShort("bitcoin take over the world maybe who knows perhaps"));
        }
    }
}
