using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__03_OOP.Classes
{
    public class Point_3D : IComparable, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point_3D() { }
        public Point_3D(Point_3D point_3D)
        {
            X = point_3D.X;
            Y = point_3D.Y;
            Z = point_3D.Z;
        }
        public Point_3D(int _X, int _Y, int _Z)
        {
            X = _X;
            Y = _Y;
            Z = _Z;
        }
        public Point_3D(int _X, int _Y) : this(_X, _Y, 0)
        {
        }
        public Point_3D(int _X) : this(_X , 0) 
        {
        }
        public override string ToString()
        {
            return $"Point Coordinates ({X}, {Y}, {Z})";
        }

        public int CompareTo(object? obj)
        {
            Point_3D? point_3D = obj as Point_3D;
            if(X + Y > point_3D?.X + point_3D?.Y)
                return 1 ;
            else if (X + Y < point_3D?.X + point_3D?.Y)
                return -1 ;
            return 0 ;

        }

        public object Clone()
        {
            return new Point_3D(this);
        }

        public static bool operator == (Point_3D one, Point_3D two)
        {
            if(one.X == two.X && one.Y == two.Y && one.Z == two.Z)
                return true ;
            return false ;
        }
        public static bool operator !=(Point_3D one, Point_3D two)
        {
            if (one.X != two.X || one.Y != two.Y || one.Z != two.Z)
                return true;
            return false;
        }

    }
}
