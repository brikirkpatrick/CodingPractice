using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Practice.CodeWarsProblems._6kyuProblems
{
    //https://www.codewars.com/kata/514b92a657cdc65150000006
    class MultiplesOf3Or5
    {
        public static int IsMultipleOf3Or5(int value)
        {
            var sum = 0;
            List<int> list = new List<int>();

            list.AddRange(Enumerable.Range(1, value));

            list.ForEach(r =>
            {
                sum += IsMultiple(r);
            }
            );

            return sum;
        }

        public static int IsMultiple(int number)
        {
            return ((number % 3 == 0) || (number % 5 == 0)) ? number : 0;
        }
    }
}
