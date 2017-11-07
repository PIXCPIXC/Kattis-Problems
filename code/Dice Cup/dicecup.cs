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
            string[] input = Console.ReadLine().Split(' ');
            List<int> sums = new List<int>();

            for(int i=0; i<int.Parse(input[0]); i++)
                for (int j = 0; j < int.Parse(input[1]); j++) {
                    sums.Add(i+1 + j+1);
                }

            var l = sums.GroupBy(x => x).Select(c => new { Value = c.Key, Count = c.Count() }).OrderByDescending(x => x.Count);

            foreach(var v in l) {
                if (v.Count == l.First().Count)
                    Console.WriteLine(v.Value);
            }
        }
    }
}
