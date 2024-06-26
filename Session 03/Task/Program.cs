using System.Drawing;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 01
            //int num;
            //bool flag = int.TryParse(Console.ReadLine(),out num);
            //if (!flag)
            //    Console.WriteLine("Not a valid Number");
            //--------------------------------------


            //// 02
            //Console.WriteLine("Enter First Name");
            //String Fname = Console.ReadLine();
            //Console.WriteLine("Enter Last Name");
            //String Lname = Console.ReadLine();
            //Console.WriteLine(Lname + ", " + Fname);


            //--------------------------------------
            //// 03
            //int x = int.Parse(Console.ReadLine());
            //if (x == 0)
            //    Console.WriteLine("Zero");
            //else if (x > 0)
            //    Console.WriteLine("Positive");
            //else Console.WriteLine("Negative");


            //--------------------------------------
            //// 04
            //foreach(var c in "Mohab")
            //    Console.WriteLine(c);


            //--------------------------------------
            // 05
            //int sum = 0;
            //for (int i = 0; i < 100; i++)
            //    if (i % 2 == 0)
            //        sum += i;
            //Console.WriteLine(sum);


            //--------------------------------------
            //// 06
            //String s2 = Console.ReadLine();
            //String[] arr = s2.Split(' ');
            //int sun = 0, b;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int.TryParse(arr[i], out b);
            //    sun += b;
            //}
            //Console.WriteLine(sun);


            //--------------------------------------
            //// 07
            //String s1 = Console.ReadLine();
            //int j = s1.Length-1, cnt=0;
            //for (int i = 0;i < s1.Length / 2; i++)
            //{
            //    if (s1[i] == s1[j])
            //        cnt++;
            //    j--;
            //}
            //if (cnt == s1.Length / 2)
            //    Console.WriteLine("True");
            //else Console.WriteLine("False");


            //--------------------------------------
            // 08
            //for (int i = 1; i <= 50 ; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //        Console.WriteLine("Fizz & Buzz");
            //    else if (i % 3 == 1)
            //        Console.WriteLine("Fizz");
            //    else if(i % 5 == 1) Console.WriteLine("Buzz");
            //}


            //--------------------------------------
            // 09
            //Console.WriteLine("Please Enter The Date (MM/dd/yyyy)");
            //DateTime date;
            //DateTime.TryParse( Console.ReadLine(), out date);
            //Console.WriteLine(String.Format("{0:MMMM dd, yyyy}", date));


            //--------------------------------------
            //10
            //int num, sum = 0 ;
            //do
            //{
            //    Console.WriteLine("Please Enter the numbers, if you want to stop enter 0 : ");
            //    int.TryParse( Console.ReadLine(), out num);
            //    sum+=num;
            //}
            //while (num != 0);
            //Console.WriteLine(sum);

        }
    }
}
