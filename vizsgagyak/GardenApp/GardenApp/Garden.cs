using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
    class Garden
    {
        List<Plants> myGarden = new List<Plants>();

        public void AddToMyGarden(Plants plant)
        {
            myGarden.Add(plant);
        }

        public void MyGarden()
        {
            foreach (Plants theplant in myGarden)
            {
                string eztaddodaneki;
                if (theplant.IsThirsty())
                {
                    eztaddodaneki = "needs water";
                }
                else
                {
                    eztaddodaneki = "doesn't need water";
                }
                Console.WriteLine("The {0} colored {1} {2}",theplant.Color, theplant.ToString(),eztaddodaneki);
            }
        }

        public void Watering(double wateringAmmount)
        {
            int howManyIsThirsty = 0;
            foreach (Plants plant in myGarden)
            {
                if (plant.IsThirsty())
                {
                    howManyIsThirsty++;
                }                
            }
            double wateringAmmountperHowManyIsThirsty = wateringAmmount / howManyIsThirsty;

            foreach (Plants plant in myGarden)
            {
                if (plant.IsThirsty())
                {
                    plant.Watering(wateringAmmountperHowManyIsThirsty);
                }
            }
            Console.WriteLine("{0} plants are thirsty!", howManyIsThirsty);
        }
    }
}
