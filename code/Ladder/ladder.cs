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

            string[] input = Console.ReadLine().Split();

            double radian = (Math.PI * int.Parse(input[1])) / 180;

            int length = (int)Math.Ceiling(int.Parse(input[0]) / Math.Sin(radian));

            Console.WriteLine(length);
        }
    }
}
