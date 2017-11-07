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
            int hour = int.Parse(input[0]);
            int min = int.Parse(input[1]);

            min -= 45;

            if(min < 0)
            {
                min += 60;
                hour--;
            }

            if (hour < 0)
                hour = 23;

            Console.WriteLine(hour + " " + min);
            Console.ReadLine();

        }
    }
}
