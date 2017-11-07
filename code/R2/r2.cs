using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            Console.WriteLine((2 * int.Parse(input[1])) - int.Parse(input[0]));

        }
    }
}
