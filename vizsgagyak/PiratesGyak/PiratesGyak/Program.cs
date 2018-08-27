using System;

namespace PiratesGyak
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship shipOne = new Ship();
            shipOne.FillShip();
            shipOne.ShipStatus();

            Ship shipTwo = new Ship();
            shipTwo.FillShip();
            shipTwo.ShipStatus();

            Console.WriteLine("\n{0}",shipOne.Battle(shipTwo));

            Console.WriteLine( "\n{0}", shipOne.CalculateScore());

            shipOne.ShipStatus();
            Console.WriteLine("\n"); 
            shipTwo.ShipStatus();

            Console.ReadLine();
        }
    }
}
