using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PiratesGyak
{
    class Ship
    {
        List<Pirate> pirates = new List<Pirate>();
        string filename = "pirates.txt";

        internal List<Pirate> Pirates { get => pirates; set => pirates = value; }

        public void FillShip()
        {
            Random pirand = new Random();
            int numberOfPirates = pirand.Next(1, 20);
            int ageOfBastards = pirand.Next(30, 41);

            string[] names = File.ReadAllLines(filename);

            Pirates.Add(new Pirate("Jack Sparrow", 40, true));

            for (int i = 0; i < numberOfPirates; i++)
            {
                Pirates.Add(new Pirate(names[i], ageOfBastards, false));
            }
        }

        public void ShipStatus()
        {
            int aliveBastards = 0;
            foreach (Pirate pirate in Pirates)
            {
                if (pirate.Captain)
                {
                    Console.WriteLine("{0}", pirate.Rumlvl); 
                }
                if (pirate.Alive)
                {
                    aliveBastards++;
                }
                Console.WriteLine("{0} {1}",pirate.Name, pirate.Alive);
            }
            Console.WriteLine("Alive Bastards: {0}",aliveBastards);
        }

        public int CalculateScore()
        {
            int calc = 0;
            foreach (Pirate pirate in Pirates)
            {
                if (pirate.Alive)
                {
                    calc++;
                }
            }

            Pirate cap = Pirates[0];
            foreach (Pirate pirate in Pirates)
            {
                if (pirate.Captain)
                {
                    cap = pirate;
                }
            }
            calc = calc - cap.Rumlvl;

            return calc;
        }

        public bool Battle(Ship battleWith)
        {
            bool thisWins = CalculateScore() > battleWith.CalculateScore();

            if (thisWins)
            {
                Random pirand = new Random();
                
                for (int i = 1; i < pirand.Next(0, battleWith.Pirates.Count-1); i++)
                {
                    pirates[i].Die();
                }
            }

            return thisWins;
        }

    }
}
