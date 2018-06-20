using System;

namespace Sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            Sharpie Fart = new Sharpie("Fosszinu",15);
            Fart.use();
            Console.WriteLine("asd {0} megalol",Fart.Ink);
            Console.ReadKey();

        }
    }

}
