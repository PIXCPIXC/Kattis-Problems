using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis
{
    class Program
    {

        static void Main(string[] args)
        {
            int n, nr, sum = 0;

            n = int.Parse(Console.ReadLine());

            for(int i = 0; i<n; i++) {
                nr = int.Parse(Console.ReadLine());
                sum += (int)Math.Pow(nr / 10, nr % 10);
            }

            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
