using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsInTheZoo
{
    class Mammals : Animals
    {
        public Mammals(string name)
        {
            this.Name = name;
        }

        public override string WantChlid()
        {
            return "NEMTOJASD";
        }
    }
}
