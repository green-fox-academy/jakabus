using System;

namespace Box
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a class that represents a cuboid:
            // It should take its three dimensions as constructor parameters (numbers)
            // It should have a method called `GetSurface` that returns the cuboid's surface
            // It should have a method called `GetVolume` that returns the cuboid's volume
            Cuboid cub = new Cuboid();
            cub.GetVolume();
            cub.GetSurface();
            

        }
    }
}
