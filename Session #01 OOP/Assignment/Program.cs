using Assignment.Structs;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Person[] person = new Person[3];
            //person[0].Name = "Mohab";
            //person[0].Age = 22;
            //person[1].Name = "Ahmed";
            //person[1].Age = 24;
            //person[2].Name = "Ali";
            //person[2].Age = 25;
            //for (int i = 0; i < person.Length; i++)
            //{
            //    Console.WriteLine($"Name : {person[i].Name}, Age : {person[i].Age}");
            //}
            #endregion

            #region Q2
            //int _X, _Y;
            //Console.WriteLine("Enter The Value of X1 :");
            //int.TryParse(Console.ReadLine(), out _X);
            //Console.WriteLine("Enter The Value of Y1 :");
            //int.TryParse(Console.ReadLine(), out _Y);
            //Point point1 = new Point(_X, _Y);

            //Console.WriteLine("Enter The Value of X2 :");
            //int.TryParse(Console.ReadLine(), out _X);
            //Console.WriteLine("Enter The Value of Y2 :");
            //int.TryParse(Console.ReadLine(), out _Y);
            //Point point2 = new Point(_X, _Y);

            //Console.WriteLine("The Distance Between The Two Points is : " + point1.CalcDistance(point2));

            #endregion
            #region Q3
            int max = 0;
            string name = "";
            Person[] person = new Person[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter The Age of Person # {i + 1} ");
                int.TryParse(Console.ReadLine(), out int age);
                person[i].Age = age;
                Console.WriteLine($"Enter The Name of Person # {i + 1} ");
                person[i].Name = Console.ReadLine();
                if(max < age)
                {
                    max = age;
                    name = person[i].Name;
                }
            }
            Console.WriteLine($"The Oldest Persone is : {name}, age : {max}");

            #endregion
        }
    }
}
