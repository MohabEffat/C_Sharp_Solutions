using Session__04_OOP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session__04_OOP.Class
{
    public class Rectanlge : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectanlge() { }
        public Rectanlge(double _Width, double _Height)
        {
            Width = _Width;
            Height = _Height;
        }
        public override double GetArea()
        {
            return Width * Height;
        }
    }
}
