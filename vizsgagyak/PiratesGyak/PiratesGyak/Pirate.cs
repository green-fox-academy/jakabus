using System;
using System.Collections.Generic;
using System.Text;

namespace PiratesGyak
{
    class Pirate
    {
        private string name;
        private int age;
        private int rumlvl;
        private bool captain;
        private bool alive;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Rumlvl { get => rumlvl; set => rumlvl = value; }
        public bool Captain { get => captain; set => captain = value; }
        public bool Alive { get => alive; set => alive = value; }

        public Pirate(string name, int age, bool captain)
        {
            this.Name = name;
            this.Age = age;
            this.Rumlvl = 0;
            this.Captain = captain;
            this.Alive = true;
        }

        public void DruinkSomeRum()
        {
            Rumlvl++;
        }

        public void HowsItGoinMate()
        {
            if (Rumlvl <= 4)
            {
                Console.WriteLine("Pour me anudder!");
            }
            else
            {
                Rumlvl = 0;
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
            }
        }

        public void Die()
        {
            Alive = false;
        }
    }
}
