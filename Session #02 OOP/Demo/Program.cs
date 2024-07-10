namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TypeA typeA = new TypeA(10);
            //typeA.StaticPrintType();

            //TypeB typeB = new TypeB(10, 20);
            //typeB.StaticPrintType();

            TypeA baseA = new TypeB(10, 20);
            baseA.StaticPrintType();
            baseA.DynamicPrintType();
        }
    }
}
