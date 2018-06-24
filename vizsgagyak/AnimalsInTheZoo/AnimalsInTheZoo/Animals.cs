using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsInTheZoo
{
    abstract class Animals
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public void Greet()
        {

        }

        public void WantChlid()
        {

        }


    }
}
