﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
                       
            Console.WriteLine("Привет, как тебя зовут?");
            string s = Console.ReadLine();
            Console.WriteLine("Привет, " + s);

            Console.WriteLine("Рад тебя видеть, " + s);
            Console.ReadKey();
        }
    }
}
