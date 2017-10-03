using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWork2
{
    class Student
    {
        public string Name { get; set; }
        public string Grade { get; set; }
        public string Course { get; set; }


        public Student(string newName, string newCourse, string newGrade)
        {
            Name = newName;
            Grade = newGrade;
            Course = newCourse;
        }

        public string Display()
        {
            return "Name: " + Name + " Grade: " + Grade;
        }
    }
}
