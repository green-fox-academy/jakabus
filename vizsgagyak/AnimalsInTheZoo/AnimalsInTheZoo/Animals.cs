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

        public void GetName()
        {
            Console.WriteLine(Name);
        }

        public abstract string WantChlid();

             


    }
}
