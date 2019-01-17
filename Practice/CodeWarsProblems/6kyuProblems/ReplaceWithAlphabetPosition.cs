using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

//TODO: Incomplete
namespace Practice.CodeWarsProblems._6kyuProblems
{
    //https://www.codewars.com/kata/546f922b54af40e1e90001da
    [TestClass]
    public class ReplaceWithAlphabetPosition
    {
        public static string AlphabetPosition(string text)
        {
            Dictionary<String, int> alphabet = InitStringDictionary();
            string formattedText = text.ToUpper().Replace(" ", "");
            string updatedText = String.Empty;

            for (int i = 0; i < formattedText.Length; i++)
            {
                Console.WriteLine("Assessing value: " + formattedText[i]);
                if (alphabet.ContainsKey(formattedText[i].ToString()))
                {
                    Console.WriteLine("Hit Value: " + formattedText[i]);
                    int value = alphabet[formattedText[i].ToString()];
                    String updatedChar = value.ToString();
                    updatedText += updatedChar + " "; //TODO: Do this better.

                    Console.WriteLine("Updated to: " + updatedChar);
                    Console.WriteLine("New String in loop: " + updatedText);
                }
            }

            Console.WriteLine($"Final Answer: {updatedText}");
            return updatedText.Trim();
        }

        public static Dictionary<String, int> InitStringDictionary()
        {
            Dictionary<String, int> map = new Dictionary<String, int>();

            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < 26; i++)
            {
                map.Add(alpha[i].ToString(), i + 1);
            }

            return map;
        }

        [Ignore]
        [TestMethod]
        [TestCategory("6kyu")]
        public void ReplaceWithAlphabetPositionTest()
        {
            //TODO: Create test...
        }
    }
}
