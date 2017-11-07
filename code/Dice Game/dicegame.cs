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

            int gunnar = GetSumOnDice(Console.ReadLine().Split(' '));
            int emma = GetSumOnDice(Console.ReadLine().Split(' '));

            if (emma > gunnar)
                Console.WriteLine("Emma");
            else if (gunnar > emma)
                Console.WriteLine("Gunnar");
            else
                Console.WriteLine("Tie");

            Console.ReadLine();

            
        }

        public static int GetSumOnDice(string[] input)
        {
            int sum=0;

            for (int i = 0; i < input.Length; i++)
                sum += int.Parse(input[i]);
            

            return sum;
        }
    }
}
