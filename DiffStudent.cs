using System;
using System.Collections.Generic;
using System.Text;

namespace L3
{
    class DiffStudent : Student
    {
        public string Faculty { get; set; }
        public string Speciality { get; set; }
        public int Ticket { get; set; }
        public DiffStudent(string lastn, string firstn, string secondn, string university, string faculty,
            string speciality, int course) : 
            base(lastn, firstn, secondn, university, course)
        {
            Faculty = faculty;
            Speciality = speciality;
            Ticket = GenerateID.Generate();
        }
        public override string ToString()
        {
            return base.ToString() + "\nTicket: " + Ticket + "\nFaculty: " +
                Faculty + "\nSpeciality: " + Speciality + "\nRanking place: " + Course;
        }        
    }
}
