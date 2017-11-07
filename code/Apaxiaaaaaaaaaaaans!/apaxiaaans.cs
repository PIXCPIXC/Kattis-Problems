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
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++) {
                if (i == input.Length - 1) {
                        sb.Append(input[i]);
                    break;
                }
                    
                if (input[i] != input[i + 1])
                    sb.Append(input[i]);
            }

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
