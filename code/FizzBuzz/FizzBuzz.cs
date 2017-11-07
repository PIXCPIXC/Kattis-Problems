using System;
using System.Linq;

/// <summary>
/// Author: Pontus Ihlström
/// Date: 26/10/2017
/// Purpose: Uppgift åt Exertis Captech för att titta kunskap.
/// </summary>


namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            fizzbuzz.Start();
        }
    }

    public class FizzBuzz
    {
        /// <summary>
        /// Klass gjord för att avbelasta main och vars syfte är att ta in en sträng av 3 integers och skriva ut leken fizzbuzz med dessa.
        /// </summary>
        public void Start()
        {
            //Läser in input och splittar med mellanslag.
            string[] input = Console.ReadLine().Split(' ');
            //Konverterar string[] till int[].
            int[] inputInt = Array.ConvertAll(input, a => int.Parse(a));
            //Deklarerar x, y och n för att tydliggöra vad som händer nedan. Deklarationer av dessa hade ej behövts, hade funkat att namnge
            //inputInt[0], inputInt[1], inputInt[2] i for loop.
            int x = inputInt[0], y = inputInt[1], n = inputInt[2];

            //Skriv ut n gånger och börja på 1. Tar inte hänsyn till felhantering då jag antar att strängen jag får är enligt uppgift.
            //Om felhantering skulle använts hade jag tittat om 1=X<Y=N=100 uppfyllts. Hade tittat så jag fått 3 och inte mindre eller fler tal.
            //Hade tittat så de var mellanslag mellan varje siffra. Hade lagt allt inom en while loop som frågade efter ett nytt svar tills kravet var uppfyllt.
            //Med risk för att övergöra uppgiften låter jag bli.
            for (int i = 1; i < n + 1; i++)
            {
                //Om i är delbar med x och y, skriv ut fizzbuzz.
                if (i % x == 0 && i % y == 0)
                    Console.WriteLine("FizzBuzz");
                //Om i är delbar med x, skriv ut "Fizz".
                else if (i % x == 0)
                    Console.WriteLine("Fizz");
                //Om i är delbar med y, skriv ut "Buzz".
                else if (i % y == 0)
                    Console.WriteLine("Buzz");
                //Om det ej är delbart med något, skriv ut talet.
                else
                    Console.WriteLine(i);
            }
        }
    }
}
