using System;


namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
                Console.WriteLine(i+1 + " Abracadabra");

            Console.ReadLine();
        }
    }
}
