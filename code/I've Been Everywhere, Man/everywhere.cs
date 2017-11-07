using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> answers = new List<string>();
            IEnumerable<string> unique;
            List<int> print = new List<int>();

            for(int i=0; i<n; i++) {
                int m = int.Parse(Console.ReadLine());

                for (int j = 0; j < m; j++)
                    answers.Add(Console.ReadLine());

                unique = answers.Distinct();
                print.Add(unique.Count());
                answers.Clear();
            }


            foreach (int val in print)
                Console.WriteLine(val);
        }
    }
}
