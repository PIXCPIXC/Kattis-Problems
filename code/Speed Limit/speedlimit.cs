using System;
using System.Collections.Generic;
using System.Linq;


namespace Kattis
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> answers = new List<string>();

            while (true) {

                int n = int.Parse(Console.ReadLine());
                int prev = 0, sum = 0;

                if (n == -1)
                    break;

                for(int i=0; i<n; i++) {
                    string[] input = Console.ReadLine().Split(' ');
                    sum += int.Parse(input[0]) * (int.Parse(input[1])-prev);
                    prev = int.Parse(input[1]);
                }

                answers.Add(sum + " miles");

            }

            foreach (string str in answers)
                Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
