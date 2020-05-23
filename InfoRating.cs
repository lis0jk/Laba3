using System;
using System.Collections.Generic;
using System.Text;

namespace L3
{
    class InfoRating : IRating
    {
        public void PrintBasicInfo(Student student)
        {
            Console.WriteLine(student.ToString());
        }
        public void Rating()
        {
            Console.WriteLine("Ranking place: 65");
            Console.WriteLine("Average mark: 7.34");
        }
    }
}
