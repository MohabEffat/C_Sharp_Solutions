using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class TypeA
    {
        public int A { get; set; }
        public TypeA(int _a)
        {
            A = _a;
        }
        public void StaticPrintType()
        {
            Console.WriteLine($"TypeA => = {A}");
        }
        public virtual void DynamicPrintType()
        {
            Console.WriteLine($"TypeA => = {A}");
        }
    }
    public class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int _a, int _b) : base(_a)
        {
            B = _b;
        }
        public new void StaticPrintType()
        {
            Console.WriteLine($"TypeB => = {A}, B = {B}");
        }
        public override void DynamicPrintType()
        {
            Console.WriteLine($"TypeB => = {A}, B = {B}");
        }
    }
}
