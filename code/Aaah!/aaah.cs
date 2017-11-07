using System;
using System.Collections.Generic;


namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            string jm = Console.ReadLine();
            string doc = Console.ReadLine();

            if (jm.Length >= doc.Length)
                Console.WriteLine("go");
            else
                Console.WriteLine("no");
        }
    }
}
