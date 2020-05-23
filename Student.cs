using System;
using System.Collections.Generic;
using System.Text;

namespace L3
{
    class Student : Human
    {
        public string University { get; set; }
        public int Course { get; set; }

        public Student(string lastn, string firstn, string secondn, 
            string university, int course) : 
            base(lastn, firstn, secondn)
        {
            University = university;
            Course = course;
        }
        public override string ToString()
        {
            return "Last name: " + LastName +"First name: " + FirstName + 
                "Second name: " + SecondName + "\nUniversity: " + University;
        }
    }
}
