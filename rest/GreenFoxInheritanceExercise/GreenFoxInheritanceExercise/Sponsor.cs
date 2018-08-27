using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxInheritanceExercise
{
    class Sponsor : Person
    {
        protected string company;
        protected int hiredStudents = 0;

        public Sponsor(string name, int age, string gender, string company, int hiredStudents) :base(name, age, gender)                          
        {
            this.company = company;
            this.hiredStudents = hiredStudents;
        }

        public void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} who represents {3} and hired {4} students so far.",name, age, gender, company, hiredStudents);
        }

        public void Hire()
        {
            hiredStudents++;
        }

        public void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }

    }
}
