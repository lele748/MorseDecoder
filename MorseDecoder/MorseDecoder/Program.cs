using System;

namespace MorseDecoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args != null && args.Length > 0)
            {
                if (args[0].StartsWith("\'"))
                    Console.WriteLine("## ATTENTION ##\r\nInvalid input. Please use the \" character to concatenate more words.");
                else
                {
                    string result = string.Empty;

                    foreach (string word in StringNormalizer.Normalize(args))
                        result += CodeDecorer.DecodeWord(word);

                    Console.WriteLine(result);
                }
            }
            else
            {
                Console.WriteLine("## ATTENTION ##\r\nNo input received");
            }

            Console.ReadLine();
            return;
        }
    }
}
