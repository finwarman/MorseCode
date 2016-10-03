using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MorseCodeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter string to convert to Morse:\n");
                string StringInput = Console.ReadLine();

                string InputMorse = MorseCode.StringToMorse(StringInput);

                MorseCode.BeepCode(InputMorse);

                Console.WriteLine("\nDone. Press any key to continue, or Ctrl + C to quit.\n");

                Console.ReadKey(true);
            }

        }
    }

    class MorseCode
    {
        public static string StringToMorse(string TextIn)
        {
            string MorseOut = "";
            TextIn = TextIn.ToLower();

            for(int i = 0; i < TextIn.Length; i++)
            {
                if(PlaintextToMorse.ContainsKey(TextIn[i].ToString()))
                {
                    MorseOut += PlaintextToMorse[TextIn[i].ToString()] + ' ';
                }
            }


            return MorseOut;
        }

        public static void BeepCode(string Morse)
        {
            Console.WriteLine("");
            foreach (char ch in Morse)
            {
                Console.Write(ch);

                if (ch == '-')
                {
                    Console.Beep(660, 500);
                }
                else if (ch == '.')
                {
                    Console.Beep(660, 150);
                }
                else 
                {
                    Thread.Sleep(500);
                }
            }
            Console.WriteLine("");

        }

        public static Dictionary<string, string> PlaintextToMorse = new Dictionary<string, string>()
        {
            { "a", ".-" },
            { "b", "-..." },
            { "c", "-.-." },
            { "d", "-.." },
            { "e", "." },
            { "f", "..-." },
            { "g", "--." },
            { "h", "...." },
            { "i", ".." },
            { "j", ".---" },
            { "k", "-.-" },
            { "l", ".-.." },
            { "m", "--" },
            { "n", "-." },
            { "o", "---" },
            { "p", ".--." },
            { "q", "--.-" },
            { "r", ".-." },
            { "s", "..." },
            { "t", "-" },
            { "u", "..-" },
            { "v", "...-" },
            { "w", ".--" },
            { "x", "-..-" },
            { "y", "-.--" },
            { "z", "--.." },
            { " ", " " },
            { "0", "-----" },
            { "1", ".----" },
            { "2", "..---" },
            { "3", "...--" },
            { "4", "....-" },
            { "5", "....." },
            { "6", "-...." },
            { "7", "--..." },
            { "8", "---.." },
            { "9", "----." }
        };

    }
}
