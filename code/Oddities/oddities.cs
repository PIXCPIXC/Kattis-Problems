using System;
using System.Collections.Generic;


namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());
            List<int> nrs = new List<int>();

            for(int i=0; i<c; i++) 
                nrs.Add(int.Parse(Console.ReadLine()));
            

            foreach(int var in nrs) {
                if (var % 2 == 0)
                    Console.WriteLine(var + " is even");
                else
                    Console.WriteLine(var + " is odd");
            }
        }
    }
}
