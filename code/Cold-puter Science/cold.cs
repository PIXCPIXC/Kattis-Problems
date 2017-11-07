using System;


namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int count = 0;

            string[] split = Console.ReadLine().Split(' ');

            for (int i = 0; i < input; i++)
            {
                int temp = int.Parse(split[i]);
                if (temp < 0)
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
