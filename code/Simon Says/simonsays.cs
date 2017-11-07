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
            for(int i=0; i<n; i++)
            {
                string input = Console.ReadLine();
                string[] check = input.Split(' ');

                if(check[0] == "Simon" &&  check[1] == "says")
                {
                    answers.Add((string.Join(" ", check.Skip(2))));
                }
            }

            foreach(string ans in answers)
            {
                Console.WriteLine(ans);
            }
        }
    }
}
