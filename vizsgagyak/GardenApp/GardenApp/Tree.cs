using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
    class Tree : Plants
    {
        public Tree(string color) : base(color) { }

        public override void Watering(double wateringAmmount)
        {
            Waterlevel += (wateringAmmount * 0.4);
        }
        public override bool IsThirsty()
        {
            return Waterlevel < 10;
        }
        public override string ToString()
        {
            return "Tree";
        }
        
    }
}
