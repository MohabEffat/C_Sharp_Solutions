using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("Please Enter a Number : ");
            //int num;
            //int.TryParse(Console.ReadLine(), out num);
            //if (num % 3 == 0 && num % 4 == 0)
            //    Console.WriteLine("Yes");
            //else Console.WriteLine("No");
            #endregion

            #region Q2
            //Console.WriteLine("Please Enter a Number : ");
            //int num;
            //int.TryParse(Console.ReadLine(), out num);
            //if (num >= 0)
            //    Console.WriteLine("Positive");
            //else Console.WriteLine("Negative");
            #endregion

            #region Q3
            //Console.WriteLine("Enter 3 Numbers");
            //int x, y, z, max=0, min=0;
            //int.TryParse(Console.ReadLine(), out x);
            //int.TryParse(Console.ReadLine(), out y);
            //int.TryParse(Console.ReadLine(), out z);
            //if (x > y && x > z)
            //{
            //    max = x;
            //    if (y > z)
            //        min = z;
            //    else
            //        max = y;
            //}
            //else if (y > x && y > z) {
            //    max = y;
            //    if (z > x)
            //        min = x;
            //    else
            //        min = z;
            //}
            //else if(z > x && z > y)
            //{
            //    max = z;
            //    if (x > y)
            //        min = y;
            //    else
            //        min = x;
            //}
            //Console.WriteLine("Min Number is : " + min);
            //Console.WriteLine("Max Number is : " + max);
            #endregion

            #region Q4
            //Console.WriteLine("Please Enter a Number : ");
            //int num;
            //int.TryParse(Console.ReadLine(), out num);
            //if (num % 2 == 0)
            //    Console.WriteLine("Even Number");
            //else Console.WriteLine("Odd Number");
            #endregion

            #region Q5
            //Console.WriteLine("Enter a Character");
            //char c;
            //char.TryParse(Console.ReadLine(), out c);
            //if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            //    Console.WriteLine("vowel");
            //else Console.WriteLine("consonant");
            #endregion

            #region Q6
            //Console.WriteLine("Please Enter a Number : ");
            //int num;
            //int.TryParse(Console.ReadLine(), out num);
            //for (int i = 1; i <= num; i++)
            //{
            //    Console.Write(i + " ");
            //}

            #endregion

            #region Q7
            //Console.WriteLine("Please Enter a Number : ");
            //int num;
            //int.TryParse(Console.ReadLine(), out num);
            //for (int i = 1; i <= 12; i++)
            //{ 
            //    Console.Write(i * 5 + " ");
            //}
            #endregion

            #region Q8
            //Console.WriteLine("Please Enter a Number : ");
            //int num;
            //int.TryParse(Console.ReadLine(), out num);
            //for (int i = 1; i <= num; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.Write(i + " ");
            //}
            #endregion

            #region Q9
            //Console.WriteLine("Please Two Numbers  : ");
            //int x, y, sum = 1;
            //int.TryParse(Console.ReadLine(), out x);
            //int.TryParse(Console.ReadLine(), out y);
            //for (int i = 1; i <= y; i++)
            //{
            //    sum *= x;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Q10
            //Console.WriteLine("Enter Marks of five subjects: ");
            //String str =Console.ReadLine();
            //String[] arr = str.Split(' ');
            //int sun = 0, avg, percentage, b;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int.TryParse(arr[i], out b);
            //    sun += b;
            //}
            //Console.WriteLine("Total marks : " + sun);
            //Console.WriteLine("Average Marks :" + sun/arr.Length);
            //Console.WriteLine("Percentage " +(sun/(100.0 * arr.Length))*100);

            #endregion

            #region Q11
            //Console.WriteLine("Enter Month Number");
            //int Num;
            //int.TryParse(Console.ReadLine(), out Num);
            //switch (Num)
            //{
            //    case 1:
            //        Console.WriteLine(31);
            //        break;
            //    case 2:
            //        Console.WriteLine(28);
            //        break;
            //    case 3:
            //        Console.WriteLine(31);
            //        break;
            //    case 4:
            //        Console.WriteLine(30);
            //        break;
            //    case 5:
            //        Console.WriteLine(31);
            //        break;
            //    case 6:
            //        Console.WriteLine(30);
            //        break;
            //    case 7:
            //        Console.WriteLine(31);
            //        break;
            //    case 8:
            //        Console.WriteLine(31);
            //        break;
            //    case 9:
            //        Console.WriteLine(30);
            //        break;
            //    case 10:
            //        Console.WriteLine(31);
            //        break;
            //    case 11:
            //        Console.WriteLine(30);
            //        break;
            //    case 12:
            //        Console.WriteLine(31);
            //        break;
            //    default:
            //        Console.WriteLine("Enter A Number between 1 - 12");
            //        break;
            //}
            #endregion

            #region Q12
            //Console.WriteLine("Enter First Number");
            //float num1;
            //float.TryParse(Console.ReadLine(), out num1);
            //Console.WriteLine("Choose the Operation (+, -, *, /)");
            //char c;
            //char.TryParse(Console.ReadLine(), out c);
            //Console.WriteLine("Enter Second Number");
            //float num2;
            //float.TryParse(Console.ReadLine(), out num2);
            //if (c == '+')
            //    Console.WriteLine("The Result is : " + (num1 + num2));
            //else if (c == '-')
            //    Console.WriteLine("The Result is : " + (num1 - num2));
            //else if (c == '*')
            //    Console.WriteLine("The Result is : " + (num1 * num2));
            //else if (c == '/')
            //{
            //    if (num2 != 0)
            //        Console.WriteLine("The Result is : " + (num1 + num2));
            //    else Console.WriteLine("Cant Divid by 0 ");
            //}
            //else Console.WriteLine("Choose a Valid Operation");



            #endregion

            #region Q13
            //Console.WriteLine("Enter a text");
            //String Str = Console.ReadLine();
            //String Str2 ="";
            //for (int i = Str.Length - 1; i >= 0 ; i--)
            //{
            //    Str2 += Str[i];
            //}
            //Console.WriteLine(Str2);
            #endregion Q14


            #region Q14
            //int num, result=0, mod;
            //int.TryParse(Console.ReadLine(), out num);
            //while (num > 0)
            //{
            //    mod = num % 10;
            //    result = (result * 10) + mod;
            //    num /= 10;
            //}
            //Console.WriteLine(result);
            #endregion

            #region Q15
            //Console.WriteLine("Enter A Number");
            //int start, end;
            //int.TryParse(Console.ReadLine(), out start);
            //int.TryParse(Console.ReadLine(), out end);
            //for (int i = start; i <= end; i++)
            //{
            //    if (i < 2)
            //    {
            //        continue; 
            //    }
            //    bool isPrime = true;
            //    for (int j = 2; j <= Math.Sqrt(i); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}

            #endregion

            #region Q16
            //Console.WriteLine("Enter a Number");
            //int num;
            //int.TryParse(Console.ReadLine(), out num);
            //string binary = "";
            //if (num == 0)
            //    binary = "0";
            //while (num > 0)
            //{
            //    binary = (num % 2) + binary;
            //    num = num / 2;
            //}
            //Console.WriteLine(binary);
            #endregion

            #region Q17
            //Console.WriteLine("Enter the coordinates for point 1 (x1 y1):");
            //string[] point1 = Console.ReadLine().Split(' ');
            //double x1 = double.Parse(point1[0]);
            //double y1 = double.Parse(point1[1]);

            //Console.WriteLine("Enter the coordinates for point 2 (x2 y2):");
            //string[] point2 = Console.ReadLine().Split(' ');
            //double x2 = double.Parse(point2[0]);
            //double y2 = double.Parse(point2[1]);

            //Console.WriteLine("Enter the coordinates for point 3 (x3 y3):");
            //string[] point3 = Console.ReadLine().Split(' ');
            //double x3 = double.Parse(point3[0]);
            //double y3 = double.Parse(point3[1]);
            //if (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2) == 0)
            //    Console.WriteLine("The 3 points lies on the same line");
            //else Console.WriteLine("The 3 are not on the same line");
            #endregion

            #region Q18
            //Console.WriteLine("Please Enter the taken time in hours");
            //float hours;
            //float.TryParse(Console.ReadLine(), out hours);
            //if (hours >= 2 && hours <= 3)
            //    Console.WriteLine("highly efficient");
            //if (hours > 3 && hours <= 4)
            //    Console.WriteLine("increase  speed");
            //if (hours > 4 && hours <= 5)
            //    Console.WriteLine("enhance the speed");
            //if(hours > 5)
            //    Console.WriteLine("leave the company");
            #endregion




        }
    }
}
