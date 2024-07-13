using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session__03_OOP.Interfaces
{
    public class Square : IShapeOne, IShapeTwo
    {
        void IShapeOne.GetArea()
        {
            Console.WriteLine("IShapeOne");
        }

        void IShapeTwo.GetArea()
        {
            Console.WriteLine("IShapeTwo");
        }
    }
}
