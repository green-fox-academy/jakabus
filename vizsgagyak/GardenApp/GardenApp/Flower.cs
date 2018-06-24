using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
    class Flower : Plants 
    {
        public Flower(string color) : base(color) { }

        public override bool IsThirsty()
        {
            return Waterlevel < 5;
        }
        
        public override void Watering(double wateringAmmount)
        {
            Waterlevel += (wateringAmmount * 0.75);
        }

        public override string ToString()
        {
            return "Flower";
        }

    }
}
