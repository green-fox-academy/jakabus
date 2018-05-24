using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {

            Counter counter = new Counter();
            counter.Counters();
            counter.Add();
            Console.ReadKey();
            counter.AddOne();
            counter.Get();
            counter.Reset();
            counter.Add();

                        

            Console.ReadKey();
        }
    }
}
