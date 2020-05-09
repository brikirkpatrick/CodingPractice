using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Algorithms.Sorting
{
    //https://www.geeksforgeeks.org/insertion-sort/
    [TestClass]
    public class InsertionSort
    {
        //TODO: Reattempt this until I can recreate this without help.
        public int[] Sort(int[] arr)
        {
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

            return null;
        }

        public int[] SortOfficial(int[] arr)
        {
            string start = string.Join("", arr);
            Console.WriteLine(start);

            for (int i = 0; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                Console.WriteLine($"Next Index. j: {j}, key: {key}");

                while(j >= 0 && arr[j] > key)
                {
                    Console.WriteLine($"Hit. j: {j}, arr[j]: {arr[j]}, key: {key}");
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                Console.WriteLine($"End Index.  arr[j + 1] = key: {arr[j + 1]} = {key} \n");
                arr[j + 1] = key;
            }
            return arr;
        }

        [TestMethod]
        [TestCategory("Sorting")]
        public void InsertionSortTest()
        {
            int[] unsortedArr = SortOfficial(new[] { 5, 6, 3, 6, 1, 8, 9, 0 });
            int[] sortedArr = new int[] { 0, 1, 3, 5, 6, 6, 8, 9 };

            string result = string.Join("", unsortedArr);
            Console.WriteLine(result);

            CollectionAssert.AreEqual(sortedArr, unsortedArr);
        }
    }
}
