using System;

namespace GardenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Flower firstFlower = new Flower("GREEN");
            Flower secondFlower = new Flower("RED");

            Tree firstTree = new Tree("PURPLE");
            Tree secondTree = new Tree("ORANGE");

            Garden kert = new Garden();
            kert.AddToMyGarden(firstFlower);
            kert.AddToMyGarden(secondFlower);
            kert.AddToMyGarden(firstTree);
            kert.AddToMyGarden(secondTree);


            kert.Watering(40);
            kert.MyGarden();
            kert.Watering(40);
            kert.MyGarden();

            Console.ReadLine();
        }
    }
}
