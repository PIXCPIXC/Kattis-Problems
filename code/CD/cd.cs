using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Author: Pontus Ihlström
/// Date: 02/11/2017
/// Problem: https://open.kattis.com/problems/cd
/// </summary>


namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Starts the program
            Market market = new Market();
            market.Start();
        }
    }

    /// <summary>
    /// Class representing a CD with a unique key value cataloge nr (catnr).
    /// </summary>
    public class CD
    {
        public int CatNr { get; private set; }

        public CD(int key)
        {
            CatNr = key;
        }
    }

    /// <summary>
    /// Class representing an owner of CDs with a unique name.
    /// </summary>
    public class Owner
    {
        public string Name { get; private set; }
        public List<CD> OwnedCDs { get; set; }

        public Owner(string name)
        {
            Name = name;
            OwnedCDs = new List<CD>();
        }
    }

    /// <summary>
    /// The class which handles the logic of selling CDs.
    /// </summary>
    public class Market
    {
        //Declare owners.
        Owner jill = new Owner("Jack");
        Owner jack = new Owner("Jill");

        private void ReadInfo()
        {
            int n, m;
            List<string> fullinput = new List<string>();
            List<int> IDs = new List<int>();

            //Read input untill 0 0 is hit.
            while (true)
            {
                string temp = Console.ReadLine();
                if (temp == "0 0")
                    break;
                fullinput.Add(temp);
            }

            //Split first line to get n and m.
            string[] nm = fullinput[0].Split(' ');

            n = int.Parse(nm[0]);
            m = int.Parse(nm[1]);

            //This could be done as a method to keep the code dry. I did not do it in this case.

            //Read Jacks input and add to a list
            for (int i = 0; i < n; i++)
            {
                IDs.Add(int.Parse(fullinput[i + 1]));
            }

            //Take unique cases.
            IDs = IDs.Distinct().ToList();

            //Add CDs to Jacks CD list.
            foreach (int val in IDs)
                jack.OwnedCDs.Add(new CD(val));

            //Clear IDs before using on jill.
            IDs.Clear();

            //Read Jills input and add to a list.
            for (int i = 0; i < m; i++)
            {
                IDs.Add(int.Parse(fullinput[i + n + 1]));
            }

            //Take unique cases.
            IDs = IDs.Distinct().ToList();

            //Add to Jills list.
            foreach (int val in IDs)
                jill.OwnedCDs.Add(new CD(val));
        }

        /// <summary>
        /// Method to sell CDs from an owner.
        /// </summary>
        private void SellCDs()
        {
            int count = 0;
            List<int> remove = new List<int>();
            //If they both own CD with the same catnr, sell it.
            foreach (CD jackcd in jack.OwnedCDs)
            {
                foreach (CD jillcd in jill.OwnedCDs)
                {
                    if (jackcd.CatNr == jillcd.CatNr)
                    {
                        count++;
                        remove.Add(jackcd.CatNr);
                    }
                }
            }
            //remove sold CDS
            foreach (int var in remove)
                RemoveCD(var);

            Console.WriteLine(count);
        }

        //Start method.
        public void Start()
        {
            ReadInfo();
            SellCDs();
        }

        private void RemoveCD(int nr)
        {
            jack.OwnedCDs.RemoveAll(x => x.CatNr == nr);
            jill.OwnedCDs.RemoveAll(x => x.CatNr == nr);
        }

    }
}