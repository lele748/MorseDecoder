using System.Collections.Generic;

namespace MorseDecoder
{
    public class MorseCollection
    {
        public Dictionary<string, char> Morse { get; set; }

        public MorseCollection()
        {
            this.Morse = new Dictionary<string, char>();

            MorsePopulation();
        }

        private void MorsePopulation()
        {
            this.Morse.Add(".-", 'A');
            this.Morse.Add("-...", 'B');
            this.Morse.Add("-.-.", 'C');
            this.Morse.Add("-..", 'D');
            this.Morse.Add(".", 'E');
            this.Morse.Add("..-.", 'F');
            this.Morse.Add("--.", 'G');
            this.Morse.Add("....", 'H');
            this.Morse.Add("..", 'I');
            this.Morse.Add(".---", 'J');
            this.Morse.Add("-.-", 'K');
            this.Morse.Add(".-..", 'L');
            this.Morse.Add("--", 'M');
            this.Morse.Add("-.", 'N');
            this.Morse.Add("---", 'O');
            this.Morse.Add(".--.", 'P');
            this.Morse.Add("--.-", 'Q');
            this.Morse.Add(".-.", 'R');
            this.Morse.Add("...", 'S');
            this.Morse.Add("-", 'T');
            this.Morse.Add("..-", 'U');
            this.Morse.Add("...-", 'V');
            this.Morse.Add(".--", 'W');
            this.Morse.Add("-..-", 'X');
            this.Morse.Add("-.--", 'Y');
            this.Morse.Add("--..", 'Z');

            this.Morse.Add("-----", '0');
            this.Morse.Add(".----", '1');
            this.Morse.Add("..---", '2');
            this.Morse.Add("...--", '3');
            this.Morse.Add("....-", '4');
            this.Morse.Add(".....", '5');
            this.Morse.Add("-....", '6');
            this.Morse.Add("--...", '7');
            this.Morse.Add("---..", '8');
            this.Morse.Add("----.", '9');

        }

        public string GetChar(string morseCode)
        {
            string result = string.Empty;

            if (!string.IsNullOrEmpty(morseCode))
            {
                if (this.Morse.ContainsKey(morseCode))
                    result = this.Morse[morseCode].ToString();
                else
                   result = "~";
            }

            return result;
        }

        public string GetMorse(string morseCode)
        {
            string result = string.Empty;

            if (!morseCode.Equals(' '))
            {
                result = "~";

                foreach (KeyValuePair<string, char> m in this.Morse)
                {
                    if (m.Value.Equals(morseCode.ToUpper().ToCharArray()[0]))
                    {
                        result = m.Key;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
