using System;
using System.Collections.Generic;


namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 1)
                Console.WriteLine("Alice");
            else
                Console.WriteLine("Bob");

            Console.ReadLine();
        }
    }
}
