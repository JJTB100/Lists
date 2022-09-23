using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throwaway1
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowOff();
            Console.ReadLine();
        }

        private static void ShowOff()
        {
            List<string> languages = new List<string> { "English", "German", "French", "Yorkshire"};

            foreach (string language in languages)
            {
                SayHello(language);
            }
        }
        private static void SayHello(string language)
        {

            Console.Write($"You can say hello in {language} by saying: ");

            switch (language)
            {
                case "English":
                    Console.WriteLine("\"Hello\"");
                    break;
                case "German":
                    Console.WriteLine("\"Guten \"");
                    break;
                case "French":
                    Console.WriteLine("\"Bonjour\"");
                    break;
                default:
                    Console.WriteLine("\"'Ay'up\"");
                    break;

            }
        }
    }
}
