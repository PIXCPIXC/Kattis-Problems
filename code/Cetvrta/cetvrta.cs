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
            List<int> x = new List<int>();
            List<int> y = new List<int>();
            string[] input = null;
            for (int i = 0; i < 3; i++) {
                input = Console.ReadLine().Split(' ');
                if (x.Contains(int.Parse(input[0])))
                    x.Remove(int.Parse(input[0]));
                else
                    x.Add(int.Parse(input[0]));
                if (y.Contains(int.Parse(input[1])))
                    y.Remove(int.Parse(input[1]));
                else
                    y.Add(int.Parse(input[1]));
            }

            Console.WriteLine(x.Last() + " " + y.Last());
            Console.ReadLine();
        }
    }
}
