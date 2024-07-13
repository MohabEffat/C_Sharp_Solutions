using Assignment__03_OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__03_OOP.Classes
{
    public class Circle : ICircle
    {
        public double Area => Radius * Radius * Math.PI;
        public double Radius { get; set; }
        public Circle()
        {
            
        }
        public Circle(double _Radius)
        {
            Radius = _Radius;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Area Of The Circle Is : {Area}, Radius is : {Radius}");
        }
    }
}
