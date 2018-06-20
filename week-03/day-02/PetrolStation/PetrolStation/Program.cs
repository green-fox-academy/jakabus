using System;

namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Station station = new Station(car);

            Console.ReadKey();
        }
    }
}
