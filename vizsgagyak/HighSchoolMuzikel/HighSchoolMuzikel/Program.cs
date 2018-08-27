using System;

namespace HighSchoolMuzikel
{
    class Program
    {
        static void Main(string[] args)
        {
            Student pisti = new Student("Pisti", 15, "11b");
            Student moni = new Student("Móni", 16, "11c");
            Student istvan = new Student("István", 17, "12a");

            Teacher karcsiba = new Teacher("KarcsiBácsi", 44);



            Console.ReadLine();
        }
    }
}
