using System;
using System.Collections.Generic;
using System.Text;

namespace HighSchoolMuzikel
{
    class Student : Person
    {
        private string className;
        private int knowledge;

        public string ClassName { get => className; set => className = value; }
        public int Knowledge { get => knowledge; set => knowledge = value; }

        public Student(string name, int age, string className) : base(name, age)
        {
            this.className = className;
            this.knowledge = 0;
        }
        public void Learn()
        {
            knowledge++;
        }
        public void Learn(int ammount)
        {
            knowledge += ammount;
        }
        public override string ToString()
        {
            return base.ToString() + $"I go to {className}, and I am {knowledge} smart.";
        }
        public void MessingAround()
        {

        }

    }
}
