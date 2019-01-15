using System;
using System.Collections.Generic;
using System.Text;

//TODO: Incomplete
namespace Practice.CodeWarsProblems._6kyuProblems
{
    //https://www.codewars.com/kata/546f922b54af40e1e90001da
    class ReplaceWithAlphabetPosition
    {
        public static string AlphabetPosition(string text) //text
        {

            Dictionary<String, int> alphabet = new Dictionary<String, int>();
            string uppercaseText = text.ToUpper();
            var noSpaces = uppercaseText.Replace(" ", "");
            Console.WriteLine("Empty Spaces: " + uppercaseText);
            string updatedString = String.Empty;
            alphabet = InitStringDictionary();

            for (int i = 0; i < noSpaces.Length; i++)
            {
                Console.WriteLine("ArrayValue: " + noSpaces[i]);
                if (alphabet.ContainsKey(noSpaces[i].ToString())) //i = 1, arrayOfText[i] = t
                {
                    int value = alphabet[noSpaces[i].ToString()];
                    String updatedChar = value.ToString(); //BAD

                    //updatedString = uppercaseText.Replace(uppercaseText[i].ToString(), updatedChar);
                    //if(i != noSpaces.Length)
                    updatedString += updatedChar + " ";
                    //else 
                    //updatedString += updatedChar;
                    Console.WriteLine("ValueAfter " + updatedChar);
                    Console.WriteLine("New String in loop " + updatedString);
                }
            }

            Console.WriteLine("New String " + updatedString);
            return updatedString.Trim();
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
    }
}
