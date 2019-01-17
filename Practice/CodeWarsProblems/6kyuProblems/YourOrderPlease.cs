using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Practice.CodeWarsProblems._6kyuProblems
{
    [TestClass]
    public class YourOrderPlease
    {
        //Sorting... Insertion Sort?
        //https://www.codewars.com/kata/55c45be3b2079eccff00010f/train/csharp

        public static string InsertionSort(string words)
        {
            string[] wordsArray = words.Split(" ");

            for (int i = 0; i < wordsArray.Length; i++)
            {
                int keyInt = GetIntInWord(wordsArray[i]);
                string keyWord = wordsArray[i];
                int j = i - 1;

                while(j >= 0 && GetIntInWord(wordsArray[j]) > keyInt)
                {
                    wordsArray[j + 1] = wordsArray[j];
                    j = j - 1;
                }
                wordsArray[j + 1] = keyWord;
            }

            string sortedWords = string.Join(" ", wordsArray);
            return sortedWords;
        }

        public static string LinqSort(string words)
        {
            //Note: I didn't create this solution.
            return string.Join(" ", words.Split().OrderBy(w => w.SingleOrDefault(char.IsDigit)));
        }

        public static int GetIntInWord(string word)
        {
            for(int i = 0; i < word.Length; i++)
            {
                if (Char.IsDigit(word[i]))
                {
                    return Int32.Parse(word[i].ToString());
                }
            }
            return -1; //What Exception should I return in the rare case a number isn't found?
        }

        [TestMethod]
        [TestCategory("6kyu")]
        public void YourOrderPleaseTest()
        {
            Assert.AreEqual("Thi1s is2 3a T4est", InsertionSort("is2 Thi1s T4est 3a"));
            Assert.AreEqual("Fo1r the2 g3ood 4of th5e pe6ople", LinqSort("4of Fo1r pe6ople g3ood th5e the2"));
            Assert.AreEqual("", InsertionSort(""));
        }
    }
}
