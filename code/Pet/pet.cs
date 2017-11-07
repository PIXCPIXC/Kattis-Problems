using System;
using System.Collections.Generic;
using System.Linq;


namespace Kattis
{
    class Program
    {

        static void Main(string[] args)
        {
            int row = 0, best = 0;

            for (int i=0; i<5; i++)
            {
                int sum = 0;
                string[] input = Console.ReadLine().Split(' ');
                for (int j=0; j<4; j++)
                {
                    sum += int.Parse(input[j]);
                }
                if (best < sum)
                {
                    best = sum;
                    row = i+1;
                }
            }

            Console.WriteLine(row + " " + best);
            Console.ReadLine();
        }
    }
}
