using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.CodeWarsProblems._6kyuProblems
{
    //https://www.codewars.com/kata/54da5a58ea159efa38000836
    public class FindTheOddInt
    {
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
    }
}
