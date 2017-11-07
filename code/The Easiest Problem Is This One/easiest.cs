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
            while(true) {
                int p = int.Parse(Console.ReadLine());

                if (p == 0)
                    break;

                int end = SumOfDigits(p);
                int begin = 11;

                while(true) {
                    if(SumOfDigits(p*begin) == end) {
                        Console.WriteLine(begin);
                        break;
                    }
                    begin++;
                }
            }
        }

        private static int SumOfDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
    }
}
