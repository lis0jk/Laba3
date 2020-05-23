using System;
using System.Collections.Generic;
using System.Text;

namespace L3
{
    class Human
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public Human(string lastn, string firstn, string secondn)
        {
            LastName = lastn;
            FirstName = firstn;
            SecondName = secondn;
        }
    }
}
