using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsInTheZoo
{
    class AirCraft : IFlyable
    {
        private string Type;
        private string Brand;

        public AirCraft(string type, string brand)
        {
            Type = type;
            Brand = brand;
        }

        public void Fly()
        {
            Console.WriteLine("i can fly cuz thats why i was made");
        }

        public void Land()
        {
            Console.WriteLine("flopflop over hahahahahs");
        }
    }
}
