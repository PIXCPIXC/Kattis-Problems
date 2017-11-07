using System;
using System.Collections.Generic;
using System.Linq;


namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(input, 2);
            binary = new string(Enumerable.Range(1, binary.Length).Select(i => binary[binary.Length - i]).ToArray());
            input = Convert.ToInt32(binary, 2);
            Console.WriteLine(input);
        }
    }
}
