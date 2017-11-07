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

            string input = Console.ReadLine();
            int days = 0;
            char[] cmp = { 'P', 'E', 'R' };
            
            for(int i=0; i<input.Length; i++) {
                if (cmp[i % 3] != input[i])
                    days++;
            }

            Console.WriteLine(days);
        }  
    }
}