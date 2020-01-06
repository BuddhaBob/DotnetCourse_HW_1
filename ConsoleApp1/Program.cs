using System;
using Library;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            do
            {
                Console.Write("Write your name: ");
                name = Console.ReadLine();
            }
            while (name.Length < 1);

            Console.WriteLine(Format.Output(name));
            Console.ReadKey();
        }
    }
}
