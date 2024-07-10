using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Dog : Animal
    {
        string breed;

        public Dog(string name, string _breed) : base(name) 
        {
            breed = _breed;
        }
    }
}
