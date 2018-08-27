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

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public int FedTimes { get => fedTimes; set => fedTimes = value; }

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.FedTimes = 0;
        }
        public Animal(string name)
        {
            this.Name = name;
            this.Age = 0;
            this.Gender = "unknown";
            this.FedTimes = 0;
        }

        public void Eat()
        {
            FedTimes++;
        }

        public abstract bool IsHungry();


        public override string ToString()
        {
            return $"{Name} is a {Age} year old {Gender} animal and was fed {FedTimes} times";
        }
    }
}
