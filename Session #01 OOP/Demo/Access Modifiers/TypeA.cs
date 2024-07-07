using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Access_Modifiers
{
    // What can we write inseide namespace
    // Class
    // Enum
    // Struct 
    // Interface 
    // Delegate 

    // Alowed  Access Modifiers Inside Namespace 
    // Internal
    // Public 
    // File
    internal class TypeA
    {
        // Alowed  Access Modifiers Inside Class 
        // 1. Private (Default) -> Can be accessed only inside the class
        // 2. Private Protected -> InCase of Inheratance and  Inside The Same Project 
        // 3. Protected -> InCase of Inheratance
        // 4. Internal -> Can Not be Used Outside the project 
        // 5. Protected Internal -> Can be accessed Outside the Project InCase of Inheratance
        // 6. public
        private int x; 
        protected int y;
        private protected int z;
        internal int h;
        protected internal int w;
        public void Print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
    file class TypeF 
    {

    }

}
