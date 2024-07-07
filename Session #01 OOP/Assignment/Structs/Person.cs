using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Structs
{
    internal struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(int _Age, string _Name)
        {
            Name = _Name;
            Age = _Age;
        }
    }
}
