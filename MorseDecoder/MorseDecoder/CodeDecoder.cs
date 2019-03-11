using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MorseDecoder
{
    public static class CodeDecorer
    {
        public static string Decode(string MorseCode)
        {
            string result = string.Empty;

            if (Regex.IsMatch(MorseCode, @"^[a-zA-Z0-9_]+$"))
                result = $"'{ MorseCode }' is not a valid Morse Code";
            else
            {
                MorseCollection mc = new MorseCollection();

                result = mc.GetChar(MorseCode).ToString();
            }

            return result;
        }
    }
}
