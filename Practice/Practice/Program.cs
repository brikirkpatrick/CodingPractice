using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AlphabetPosition("The sunset se.......ts at twelve o' clock.");
            //find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 });

        }

        public static string AlphabetPosition(string text) //text
        {
            
            Dictionary<String, int> alphabet = new Dictionary<String, int>();
            string uppercaseText = text.ToUpper();
            var noSpaces = uppercaseText.Replace(" ", "");
            Console.WriteLine("Empty Spaces: " + uppercaseText);
            string updatedString = String.Empty;
            alphabet = InitStringDictionary();
            //noSpace
            string rgx = @"^[a-zA-Z]+$";
            Regex r = new Regex(rgx);

            for (int i = 0; i < noSpaces.Length; i++)
            {
                Console.WriteLine("ArrayValue: " + noSpaces[i]);
                if (alphabet.ContainsKey(noSpaces[i].ToString())) //i = 1, arrayOfText[i] = t
                {
                    int value = alphabet[noSpaces[i].ToString()];
                    String updatedChar = value.ToString(); //BAD
                    updatedString = noSpaces.Replace(noSpaces[i].ToString(), updatedChar);

                    //updatedString += updatedChar + " ";
                    Console.WriteLine("ValueAfter " + updatedChar);
                }
            }
            Console.WriteLine("New String in loop " + updatedString);


            Console.WriteLine("New String " + updatedString);
            return text;
        }

        //For AlphabetPosition
        public static Dictionary<String, int> InitStringDictionary()
        {
            Dictionary<String, int> map = new Dictionary<String, int>();

            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < 26; i++)
            {
                map.Add(alpha[i].ToString(), i+1);
            }

            return map;
        }

        public static int find_it(int[] seq)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int count = 1; 

            for(int i = 0; i < seq.Length; i++)
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

            foreach(int key in map.Keys)
            {
                if(map[key] % 2 != 0)
                {
                    oddKey = key;
                }
            }

            return oddKey;
        }



    }
}
