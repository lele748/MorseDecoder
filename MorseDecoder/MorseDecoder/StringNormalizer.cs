using System;
using System.Collections.Generic;

namespace MorseDecoder
{
    public static class StringNormalizer
    {
        public static List<string> Normalize(string[] args)
        {
            List<string> results = new List<string>();

            foreach(string arg in args)
            {
                string morseWord = arg.Replace("   ", "§");

                string[] wordss = morseWord.Split('§');

                foreach (string word in wordss)
                {
                    string[] words = word.Split(' ');

                    results.AddRange(words);
                    results.Add("#");
                }
            }

            return results;
        }
    }
}
