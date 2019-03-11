using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseDecoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args != null && args.Length > 0)
            {
                foreach (string arg in args)
                    Console.WriteLine(CodeDecorer.Decode(arg));
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
