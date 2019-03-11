using System.Text.RegularExpressions;

namespace MorseDecoder
{
    public static class CodeDecorer
    {
        public static string DecodeWord(string morseWord)
        {
            string result = string.Empty;

            if (Regex.IsMatch(morseWord, @"^[a-zA-Z0-9_$%&()£?]+$"))
                result = $"'{ morseWord }' is not a valid Morse Code";
            else
            {
                MorseCollection mc = new MorseCollection();

                string[] letters = morseWord.Split(' ');

                foreach (string letter in letters)
                    if (letter.Equals("#"))
                        result += " ";
                    else
                        result += mc.GetChar(letter).ToString();
            }

            return result;
        }

        public static string EncodeWord(string realWord)
        {
            string result = string.Empty;

            if (Regex.IsMatch(realWord, @"^[a-zA-Z0-9]+$"))
            {
                string[] letters = realWord.Split(' ');

                MorseCollection mc = new MorseCollection();

                foreach (string letter in letters)
                {
                    result += mc.GetMorse(letter);
                    result += " ";
                }
            }

            return result;
        }
    }
}
