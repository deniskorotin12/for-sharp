using System;
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

            var R = new Random();
           
                Console.WriteLine("Случайное число: {0}", R.Next(1, 100));
                Console.ReadKey();
           
        }
    }
}
