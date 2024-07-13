using Session__03_OOP.Interfaces;
using Session__03_OOP.Operator_Overloading;

namespace Session__03_OOP
{
    internal class Program
    {
        public static void ProcessSeries(ISeries input)
        {
            if (input != null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"{input.Current} ");
                    input.GetNext();
                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            //ISeries seriesByTwo = new SeriesByTwo();
            //ProcessSeries(seriesByTwo);
            //ISeries seriesByThree = new SeriesByThree();
            //ProcessSeries(seriesByThree);
            //ISeries seriesByFour = new SeriesByFour();
            //ProcessSeries(seriesByFour);
            //Employee employee01 = new Employee()
            //{
            //    Id = 1,
            //    Name = "Mohab",
            //    Salary = 5000
            //};
            //Employee employee02 = new Employee()
            //{
            //    Id= 2,
            //    Name = "Ahmed",
            //    Salary = 3000
            //};
            //Console.WriteLine(employee01.GetHashCode());
            //Console.WriteLine(employee02.GetHashCode());

            //employee02 = new Employee(employee01);

            //Console.WriteLine(employee01.GetHashCode());
            //Console.WriteLine(employee02.GetHashCode());

            //employee02 = (Employee)employee01.Clone();

            //Employee[] employee =
            //{
            //    new Employee(){Id = 1, Name = "Mohab", Salary = 5000},
            //    new Employee(){Id = 2, Name = "Ahmed", Salary = 1000},
            //    new Employee(){Id = 3, Name = "Mahmoud", Salary = 2000},
            //    new Employee(){Id = 4, Name = "Mohamed", Salary = 7000}
            //}; 

            //Array.Sort(employee);
            //foreach (var emp in employee)
            //{
            //    Console.WriteLine(emp);
            //}
            //IShapeOne square01 = new Square();
            //IShapeTwo square02 = new Square();
            //square01.GetArea();
            //square02.GetArea();
            Complex C1 = new Complex() { Real = 1 , Imag = 2};
            Complex C2 = new Complex() { Real = 3 , Imag = 4};
            Complex C3 = C1 + C2;
            Console.WriteLine(C3);


        }
    }
}
