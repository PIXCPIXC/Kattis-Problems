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
            for (int i = 0; i < n; i++)
                Encrypt(Console.ReadLine());
        }

        public static void Encrypt(string message)
        {
            int m = (int)Math.Ceiling((Math.Sqrt(message.Length))),
                    c = 0;
                    

            string output = null;
            char[,] encrypted = new char[m, m], temp = new char[m,m];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < m; j++)
                {
                    if (c < message.Length)
                    {
                        temp[i, j] = message[c];
                        c++;
                    }
                    else
                        temp[i, j] = ' ';
                }

            for (int i = 0; i < m; i++) {
                int t = m-1;
                for (int j = 0; j < m; j++) {
                    encrypted[i, j] = temp[t, i];
                    if(temp[t,i] != ' ')
                    output += temp[t, i];
                    t--;
                }
            }
                

            Console.WriteLine(output);
        }
    }
}
