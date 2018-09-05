using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Animal
    {
        private int hunger;
        private int thirst;

        public Animal()
        {
            this.hunger = 50;
            this.thirst = 50;
        }

        public void Eat()
        {
            hunger--;
        }
        public void Drink()
        {
            thirst--;
        }
        public void Play()
        {
            hunger++;
            thirst++;
        }
    }
}
