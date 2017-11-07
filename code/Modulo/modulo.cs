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
            List<int> nrs = new List<int>();
            IEnumerable<int> dist;

            for(int i=0; i<10; i++) {
                nrs.Add(int.Parse(Console.ReadLine())%42);
            }

            dist = nrs.Distinct();

            Console.WriteLine(dist.Count());
        }
    }
}