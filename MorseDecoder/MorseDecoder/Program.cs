using System;

namespace MorseDecoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string result = string.Empty;

            if (args != null && args.Length > 0)
            {
                if (args[0].StartsWith("\'"))
                    result = "## ATTENTION ##\r\nInvalid input. Please use the \" character to concatenate more words.";
                if (args[0].Equals("-e", StringComparison.InvariantCultureIgnoreCase) && args.Length > 1)
                {
                    for(int i = 1; i < args.Length; i++)
                    {
                        foreach (string word in StringNormalizer.Normalize(args[i]))
                            result += CodeDecorer.EncodeWord(word);

                        result += "  ";
                    }
                }
                else
                {
                    foreach (string word in StringNormalizer.Normalize(args))
                        result += CodeDecorer.DecodeWord(word);
                }
            }
            else
            {
                result = "## ATTENTION ##\r\nNo input received";
            }

            Console.WriteLine(result);
            Console.ReadLine();
            return;
        }
    }
}
