using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session__04_OOP.Static
{
    public static class TempConverter
    {
        public static void CelsiusToFahrenheit(double c)
        {
            Console.WriteLine($"Celsius : {c} To Fahrenheit :{((c * 9) / 5) + 32}");
        }
        public static void FahrenheitToCelsius(double f)
        {
            Console.WriteLine($"Fahrenheit : {f} To Celsius : {(f - 32) * 5 / 9}");
        }
        public static void CelsiusToKelvin(double c)
        {
            Console.WriteLine($"Celsius : {c} To Kelvin : {c + 273.15} ");
        }
        public static void KelvinToCelsius(double k)
        {
            Console.WriteLine($"Kelvin : {k} To Celsius : {k - 273.15} ");
        }
        public static void FahrenheitToKelvin(double f)
        {
            Console.WriteLine($"Fahrenheit : {f} To Kelvin : {(f - 32) * 5 / 9 + 273.15} ");
        }
        public static void KelvinToFahrenheit(double k)
        {
            Console.WriteLine($"Kelvin : {k} To Fahrenheit {(k - 273.15) * 9 / 5 + 32}");
        }
    }
}
