using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Algorithms.Sorting
{
    [TestClass]
    public class InsertionSort
    {
        //TODO: Complete and understand.
        //https://www.geeksforgeeks.org/insertion-sort/
        public int[] Sort(int[] arr)
        {
            /**
            * 1. if i > 1 to n then stay.
            * 2. if i < 1 to n then move to proper position
            */
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{i} - {arr[i]}. ");
                for(int j = 0; j < arr.Length; j++)
                {
                    if(arr[j] < arr[i])
                    {
                        //arr.SetValue(arr[i])
                    }

                    Console.Write($"{arr[j]} ");
                }
                Console.WriteLine();
            }

            /**
                0 - 5. 5 6 3 6 
                1 - 6. 5 6 3 6 
                2 - 3. 5 6 3 6 
                3 - 6. 5 6 3 6
             */

            return null;
        }

        [TestMethod]
        [TestCategory("Sorting")]
        public void InsertionSortTest()
        {
            Console.WriteLine(Sort(new[] {5, 6, 3, 6}));
        }
    }
}
