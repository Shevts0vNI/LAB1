using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 15, c = 5;
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            string sharp = "Welcome to C# world, ";
            Console.WriteLine(sharp + name);
            Console.WriteLine((a + b) / c);
        }
    }
}
