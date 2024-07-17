using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__04_OOP
{
    public static class Math
    {
        static Math()
        {

        }
        public static double Add(double num1, double num2) {return num1 + num2;}
        public static double Subtract(double num1, double num2) { return num1 - num2; }

        public static double Multiply(double num1, double num2) { return num1 * num2 ; }

        public static double Divide(double num1, double num2)
        {
            if(num2 != 0)
                return num1 / num2;
            throw new DivideByZeroException();
        }
    }
}
