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

            int[] position = { 1, 0, 0 };

            for (int i=0; i<input.Length; i++) {
                int temp = 0;
                if (input[i] == 'A') {
                    temp = position[0];
                    position[0] = position[1];
                    position[1] = temp;
                }
                else if (input[i] == 'B') {
                    temp = position[1];
                    position[1] = position[2];
                    position[2] = temp;
                }
                else {
                    temp = position[0];
                    position[0] = position[2];
                    position[2] = temp;
                }
            }

            for (int j = 0; j < position.Length; j++)
                if (position[j] == 1)
                    Console.WriteLine(j+1);

            Console.ReadLine();
        }  
    }
}
