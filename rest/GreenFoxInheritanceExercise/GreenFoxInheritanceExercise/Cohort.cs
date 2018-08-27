using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxInheritanceExercise
{
    class Cohort
    {
        protected string name;
        protected List<Student> students = new List<Student>();
        protected List<Student> mentors = new List<Student>();
        protected Student student;
        protected Student mentor;

        public Cohort(string name, Student student, Student mentor)
        {
            this.name = name;
            this.student = student;
            this.mentor = mentor;
        }

        public void addStudents(Student student)
        {
            students.Add(student);
        }
        public void addMentor(Student mentor)
        {
            mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine("The {0} cohort has {2} students and {3} mentors.", name, students.Count, mentors.Count);
        }

    }
}
