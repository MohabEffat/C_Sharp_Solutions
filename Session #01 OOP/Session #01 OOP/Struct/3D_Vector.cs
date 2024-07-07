 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session__01_OOP.Struct
{
    internal struct _3D_Vector
    {
        public _3D_Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public double CalcMagnitude()
        {
            return Math.Sqrt((x * x) + (y * y) + (z * z));
        }
        public _3D_Vector GetNormalize()
        {
            double magnitude = CalcMagnitude();
            _3D_Vector newVector = new _3D_Vector(x / magnitude, y / magnitude, z / magnitude);
            return newVector;
        }
        public double CalcDotProduct(_3D_Vector newVector)
        {
            newVector = GetNormalize();
            double dotProduct = (x * newVector.x) + (y * newVector.y) + (z * newVector.z);
            return dotProduct;
        }
        public override string ToString()
        {
            return $"{x},{y},{z}";
        }
    }
}
