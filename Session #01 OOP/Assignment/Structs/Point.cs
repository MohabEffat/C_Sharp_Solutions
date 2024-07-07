using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Structs
{
    internal struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }
        public double CalcDistance(Point point)
        {
            return Math.Sqrt(Math.Pow((point.X - X), 2) + Math.Pow((point.Y - Y), 2)); 
        }
    }
}
