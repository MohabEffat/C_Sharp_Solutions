using Session__04_OOP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session__04_OOP.Class
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle() { }
        public Circle(double _Radius)
        {
            Radius = _Radius;
        }
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
