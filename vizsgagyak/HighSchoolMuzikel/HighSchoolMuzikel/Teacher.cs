using System;
using System.Collections.Generic;
using System.Text;

namespace HighSchoolMuzikel
{
    class Teacher : Person
    {
        private int knowledgeToShare;

        public int KnowledgeToShare { get => knowledgeToShare; set => knowledgeToShare = value; }

        public Teacher(string name, int age, int knowledgeToShare) :base(name, age)
        {
            this.KnowledgeToShare = 1000;
        }

        public void Teach(List<Student> students)
        {
            knowledgeToShare--;
            foreach (Student student in students)
            {
                student.Learn();
            }
        }
        
    }
}
