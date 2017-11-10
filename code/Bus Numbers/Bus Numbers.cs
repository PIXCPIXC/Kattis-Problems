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
            int n = int.Parse(Console.ReadLine());
            List<int> nrs = new List<int>();
            string[] input = Console.ReadLine().Split(' ');



            for (int i=0; i<n; i++)
            {
                nrs.Add(int.Parse(input[i]));
            }

            nrs.Sort();

            int j = 0;

            while(j < n)
            {
                int start = nrs[j];
                while (j + 1 < n && nrs[j] == nrs[j + 1] - 1)
                    j++;
                int end = nrs[j];
                string str = j == n - 1 ? "\n" : " ";
                if (start == end)
                    Console.Write(start+str);
                else if (start == end - 1)
                    Console.Write($"{start} {end}{str}");
                else
                    Console.Write($"{start}-{end}{str}");
                j++;
            }

            Console.ReadLine();
        }
    }
}
