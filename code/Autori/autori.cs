using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            string sum = null;

            string[] input = Console.ReadLine().Split('-');

            foreach (string str in input)
                sum += str[0];

            Console.WriteLine(sum);
        }
    }
}
