using Session__04_OOP.Abstract;
using Session__04_OOP.Class;
using Session__04_OOP.Static;

namespace Session__04_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape rectanlge = new Rectanlge(10, 20);
            Console.WriteLine(rectanlge.GetArea());

            Shape circle = new Circle(10);
            Console.WriteLine(circle.GetArea());
            Console.WriteLine("--------------------");
            TempConverter.CelsiusToFahrenheit(30);
            TempConverter.FahrenheitToCelsius(80);
            TempConverter.CelsiusToKelvin(30);
            TempConverter.KelvinToCelsius(500);
            TempConverter.FahrenheitToKelvin(500);
            TempConverter.KelvinToFahrenheit(300);
        }
    }
}
