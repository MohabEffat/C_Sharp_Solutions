using Session__01_OOP.Struct;

namespace Session__01_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _3D_Vector vector = new _3D_Vector(1,2,3);
            _3D_Vector newVector = new _3D_Vector();
            Console.WriteLine(vector.CalcMagnitude());

            newVector = vector.GetNormalize();
            Console.WriteLine(newVector.ToString());

            Console.WriteLine(vector.CalcDotProduct(newVector));
            Console.WriteLine(vector.ToString());

        }
    }
}
