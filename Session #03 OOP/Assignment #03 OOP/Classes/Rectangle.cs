using Assignment__03_OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__03_OOP.Classes
{
    public class Rectangle : IRectangle
    {
        public double Area => Width * Length;
        public int Width { get; set; }
        public int Length { get; set; }

        public int perimeter => (Width + Length) * 2;
        public Rectangle()
        {
            
        }
        public Rectangle(int _Width, int _Length)
        {
            Width = _Width;
            Length = _Length;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Area Of The Rectangle is : {Area}, perimeter is : {perimeter}");
        }
    }
}
