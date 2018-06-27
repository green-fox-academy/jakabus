using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    abstract class Animal
    {
        private string name;
        private int age;
        private string gender;
        private int fedTimes;

        public Animal(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.fedTimes = 0;
        }
        public Animal(string name)
        {
            this.name = name;
            this.age = 0;
            this.gender = "unknown";
            this.fedTimes = 0;
        }

        public void Eat()
        {
            fedTimes++;
        }

        public void IsHungry()
        {

        }

        public override string ToString()
        {
            return $"{name} is a {age} year old {gender} animal and was fed {fedTimes} times";
        }
    }
}
