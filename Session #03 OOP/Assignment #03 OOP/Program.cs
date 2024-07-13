using Assignment__03_OOP.Classes;

namespace Assignment__03_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Point_3D p02 = new Point_3D(10, 10, 10);
            //Console.WriteLine(p02.ToString());

            //Console.WriteLine("Enter Point #1");
            //int.TryParse(Console.ReadLine(), out int _X);
            //Console.WriteLine("Enter Point #2");
            //int.TryParse(Console.ReadLine(), out int _Y);
            //Point_3D p01 = new Point_3D(_X,_Y,10);
            //Console.WriteLine(p01.ToString());
            //if (p01 == p02) // => It Doesnt Work Properly
            //    Console.WriteLine("The Two Points Are Equale");
            //else Console.WriteLine("The Two Points Are Not Equale"); // It Will Work Properly After Operator Overloading
            //Point_3D[] points = 
            //{ 
            //    new Point_3D (10, 20, 30),
            //    new Point_3D (5, 10, 15),
            //    new Point_3D (12, 16, 20),
            //    new Point_3D (3, 6, 12),
            //};
            //Array.Sort(points);
            //foreach (Point_3D point in points)
            //    Console.WriteLine(point);

            //Point_3D Clowned = (Point_3D)points[0].Clone();
            //Console.WriteLine($"The Cloned Point : {Clowned}");
            #endregion

            #region Q2
            //Circle circle = new Circle(5);
            //circle.DisplayShapeInfo();

            //Rectangle rectangle = new Rectangle();
            //rectangle.Length = 5;
            //rectangle.Width = 6;
            //rectangle.DisplayShapeInfo();

            #endregion

            #region Q3
            Duration duration01 = new Duration(1, 10, 15);
            Console.WriteLine(duration01.ToString());

            Duration duration02 = new Duration(3600);
            Console.WriteLine(duration02.ToString());

            Duration duration03 = new Duration(7800);
            Console.WriteLine(duration03.ToString());

            Duration duration04 = new Duration(666);
            Console.WriteLine(duration04.ToString());

            Console.WriteLine("------------------------------");

            Duration duration05 = duration01 + duration02;
            Console.WriteLine(duration05.ToString());

            Duration duration06 = duration01 + 3600;
            Console.WriteLine(duration06.ToString());

            Duration duration07 = 666 + duration01;
            Console.WriteLine(duration07.ToString());

            Duration duration08 = ++ duration07;
            Console.WriteLine(duration08.ToString());

            Duration duration09 = -- duration08;
            Console.WriteLine(duration09.ToString());

            Duration duration10 = duration01 - duration07;
            Console.WriteLine(duration10.ToString());

            if (duration02 > duration03)
                Console.WriteLine("True");

            if(duration02)
                Console.WriteLine("True");

            DateTime dateTime = (DateTime)duration02;
            Console.WriteLine(dateTime.ToString());



            #endregion
        }
    }
}
