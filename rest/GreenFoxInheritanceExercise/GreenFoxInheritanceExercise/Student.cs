using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxInheritanceExercise
{
    class Student : Person
    {
        private string previousOrganization;
        private int skippedDays = 0;

        public Student(string name, int age, string gender, string previousOrganization, int skippedDays) :base (name, age, gender)
        {
            this.previousOrganization = previousOrganization;
            this.skippedDays = skippedDays;
        }

        public void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }
        public void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} from {3} who skipped {4} days from the course already.",name, age, gender, previousOrganization, skippedDays);
        }
        public void SkipDays(int numberOfDays)
        {
            skippedDays = skippedDays + numberOfDays;
        }
    }
}
