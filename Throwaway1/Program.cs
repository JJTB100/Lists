﻿using System;
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
            SayHello("English");
            SayHello("German");
            SayHello("French");

            
            
        }
        private static void SayHello(string language)
        {
            

            switch (language)
            {
                case "English":
                    Console.WriteLine("Hello");
                    break;
                case "German":
                    Console.WriteLine("Guten Tag");
                    break;
                case "French":
                    Console.WriteLine("Bonjour");
                    break;
                default:
                    Console.WriteLine("Ay Up");
                    break;

            }
        }
    }
}
