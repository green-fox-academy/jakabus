using System;

namespace AnimalsInTheZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Birds madi = new Birds("MADIIIIII");
            Console.WriteLine(madi.WantChlid());

            Mammals mami = new Mammals("asd");
            Console.WriteLine(mami.WantChlid());

            madi.GetName();
            mami.GetName();
            Console.WriteLine("\n");
            madi.Fly();

            AirCraft boeing = new AirCraft("747", "Boeing");
            AirCraft airbus = new AirCraft("A380", "Airbus");


            Console.ReadLine();
        }
    }
}
