using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.CodeWarsProblems._6kyuProblems
{
    [TestClass]
    public class FindTheOddInt
    {
        //https://www.codewars.com/kata/54da5a58ea159efa38000836
        public static int find_it(int[] seq)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int count = 1;

            for (int i = 0; i < seq.Length; i++)
            {
                if (map.ContainsKey(seq[i]))
                {
                    //var debug = map.TryGetValue(i, out var value);
                    map[seq[i]] = map[seq[i]] + 1;
                }
                else
                {
                    map.Add(seq[i], count);
                }
            }

            var oddKey = 0;

            foreach (int key in map.Keys)
            {
                if (map[key] % 2 != 0)
                {
                    oddKey = key;
                }
            }

            return oddKey;
        }

        [TestMethod]
        [TestCategory("6kyu")]
        public void FindTheOddIntTest()
        {
            Assert.AreEqual(5, find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }
    }
}
