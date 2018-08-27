using System;
using System.Collections.Generic;
using System.Text;

namespace HighSchoolMuzikel
{
    class Person
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"Hi, I'm {Name}, I'm {Age} years old";
        }
    }
}
