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
            string answer = null;

            for (int i=0; i<input.Length; i++) {
                string cur = input[i];
                string temp = null;
                for(int j=0; j<cur.Length; j++) {
                    if (cur[j] == 'a' || cur[j] == 'o' || cur[j] == 'i' || cur[j] == 'e' || cur[j] == 'u')
                    {
                        temp += cur[j];
                        j += 2;
                    }
                    else
                        temp += cur[j];
                }
                if (i == input.Length - 1)
                    answer += temp;
                else
                    answer += temp + " ";
            }
            Console.WriteLine(answer);
        }
    }
}
