using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
    abstract class Plants
    {
        private string color;
        private double waterlevel;

        public double Waterlevel { get => waterlevel; set => waterlevel = value; }
        public string Color { get => color; set => color = value; }

        public Plants(string color)
        {
            this.color = color;
            this.waterlevel = 0;
        }

        public abstract void Watering(double wateringAmmount);

        public abstract bool IsThirsty();
 
    }
}
