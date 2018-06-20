using System;

namespace GreenFoxInheritanceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Jane Doe", 30, "female");
            person.Introduce();

            Student student = new Student("Jane Doe", 30, "female", "The School Of Life",0);
            Student mentor = new Student("Elon Musk", 15, "male", "Tesla", 0);

            Sponsor sponsor = new Sponsor("Jane Doe", 30, "female", "Google",0);

            Cohort cohort = new Cohort("szarezafeladat",student,mentor);

            Console.ReadKey();
        }
    }
}
