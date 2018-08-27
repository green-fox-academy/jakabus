using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsInTheZoo
{
    class Birds : Animals, IFlyable
    {
        public Birds(string name)
        {
            this.Name = name;
        }

        public override string WantChlid()
        {
            return "TOJASD";
        }

        public void Fly()
        {
            Console.WriteLine("flapflap");
        }
        public void Land()
        {
            Console.WriteLine("okitsenaugh");
        }

    }
}
