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
            while(true)
            {
                string input = Console.ReadLine();

                if (input == "0 0")
                    break;

                string[] split = input.Split(' ');

                int x = (int)Math.Floor(int.Parse(split[0]) / (double)int.Parse(split[1]));

                Console.WriteLine(x + " " + (int.Parse(split[0])%int.Parse(split[1]) + " / " + int.Parse(split[1])));
            }
        }
    }
}
