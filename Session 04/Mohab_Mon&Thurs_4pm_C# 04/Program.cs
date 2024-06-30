using System;
using System.Drawing;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mohab_Mon_Thurs_4pm_C__04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("Enter Matrix Number : ");
            //int num;
            //int.TryParse(Console.ReadLine(), out num);
            //int[,] matrix = new int[num, num];
            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j < num; j++)
            //    {
            //        if(i == j)
            //            Console.Write(" 1");
            //        else Console.Write(" 0");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q2
            //int sum = 0;
            //int[] arr = { 10, 515, 15, 87, 65, 61, 1, 98 };
            //for (int i = 0; i < arr.Length; i++) { 
            //    sum += arr[i];
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Q3
            //Console.WriteLine("Enter the size of array : ");
            //int num, i = 0, j = 0, k = 0;

            //int.TryParse(Console.ReadLine(), out num);
            //int[] arr1 = new int[num];
            //int[] arr2 = new int[num];
            //int[] arr3 = new int[num * 2];
            //Console.WriteLine("First Array : ");
            //for (i = 0; i < num; i++)
            //{
            //    Console.WriteLine($"Enter item #{i + 1}");
            //    int.TryParse(Console.ReadLine(), out arr1[i]);
            //}
            //Console.WriteLine("Second Array : ");
            //for (i = 0; i < num; i++)
            //{
            //    Console.WriteLine($"Enter item #{i + 1}");
            //    int.TryParse(Console.ReadLine(), out arr2[i]);
            //}
            ////Console.WriteLine("---------");
            ////for (i = 0; i < num; i++)
            ////{
            ////    Console.Write(arr1[i] + " ");
            ////}
            ////for (i = 0; i < num; i++)
            ////{
            ////    Console.Write(arr2[i] + " ");
            ////}
            //i = 0;
            //while (k < arr3.Length)
            //{
            //    if (i < arr1.Length)
            //        arr3[k++] = arr1[i++];
            //    else if (j < arr2.Length)
            //        arr3[k++] = arr2[j++];
            //}
            //Array.Sort(arr3);
            //for (i = 0; i < arr3.Length; ++i) { 
            //    Console.Write(arr3[i] + " ");
            //}
            #endregion

            #region Q4
            //int num;
            //Console.WriteLine("Enter the size of array : ");
            //int.TryParse(Console.ReadLine(), out num);
            //int[] arr1 = new int[num];
            //int[] freqArr = new int[num];
            //bool[] Visted = new bool[num];

            //Console.WriteLine("First Array : ");
            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine($"Enter item #{i + 1}");
            //    int.TryParse(Console.ReadLine(), out arr1[i]);
            //}
            //for (int i = 0;i < num; i++)
            //{
            //    if (Visted[i])
            //        continue;
            //    int cnt = 1;
            //    for (int j = i + 1; j < num; j++)
            //    {
            //        if (arr1[i] == arr1[j])
            //        {
            //            Visted[j] = true;
            //            cnt++;
            //        }
            //    }
            //    freqArr[i] = cnt;
            //}

            //for (int i = 0; i < num; i++)
            //{
            //    if (!Visted[i])
            //    {
            //        Console.WriteLine($"{arr1[i]} : {freqArr[i]} times");
            //    }
            //}

            #endregion

            #region Q5
            //int num, max = 0, min = 0;
            //Console.WriteLine("Enter the size of array : ");
            //int.TryParse(Console.ReadLine(), out num);
            //int[] arr = new int[num];
            //Console.WriteLine("First Array : ");
            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine($"Enter item #{i + 1}");
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //max = min = arr[0];
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    if (arr[i] < min)
            //        min = arr[i];
            //}
            //Console.WriteLine($"Max : {max} min : {min}");

            #endregion

            #region Q7
            //int num, max01 = 0, max02 = 0;
            //Console.WriteLine("Enter the size of array : ");
            //int.TryParse(Console.ReadLine(), out num);
            //int[] arr = new int[num];
            //Console.WriteLine("First Array : ");
            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine($"Enter item #{i + 1}");
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max01)
            //    {
            //        max02 = max01;
            //        max01 = arr[i];
            //    }
            //    else if (arr[i] > max02 && arr[i] < max01)
            //    {
            //        max02 = arr[i];
            //    }
            //}
            //Console.WriteLine($"Max : {max01}, Sec Max : {max02}");
            #endregion

            #region Q8
            //int num, max =0;
            //Console.WriteLine("Enter the size of array : ");
            //int.TryParse(Console.ReadLine(), out num);
            //int[] arr = new int[num];
            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine($"Enter item #{i + 1}");
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int cnt = 0;
            //    for (int j = 0; j < num; j++)
            //    {
            //        if (arr[i] == arr[j])
            //            cnt = j - i -1;
            //    }
            //    if (cnt > max)
            //        max = cnt;
            //}
            //Console.WriteLine(max);
            #endregion

            #region Q9
            //String str = Console.ReadLine();
            //String[] words = str.Split(' ');

            // #1
            //StringBuilder text = new StringBuilder();
            //for (int i = words.Length - 1; i >= 0; i--)
            //{
            //    text.Append(words[i] + " ");
            //}
            //Console.WriteLine(text);

            // Another Solution #2
            //Array.Reverse(words);
            //Console.WriteLine(string.Join(" ", words));

            #endregion

            #region Q10
            //int num;
            //Console.WriteLine("Enter the size of array : ");
            //int.TryParse(Console.ReadLine(), out num);
            //int[,] arr1 = new int[num, num];
            //int[,] arr2 = new int[num, num];
            //for (int i = 0; i < num; i++) 
            //{
            //    Console.WriteLine($"Enter #{i+1} row : ");
            //    for (int j = 0; j < num; j++)
            //    {
            //        Console.WriteLine($"Enter #{j + 1} : ");
            //        int.TryParse(Console.ReadLine(), out arr1[i, j]);
            //    }
            //}
            //arr2 = (int[,]) arr1.Clone();
            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j < num; j++)
            //    {
            //        Console.Write(arr2[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q11
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for (int i = nums.Length - 1; i>=0 ; i--) { 
            //    Console.Write(nums[i] + " ");
            //}
            ////Array.Reverse(nums); => Can use this
            #endregion

            #region General

            #region Q1
            //int principal;
            //float rate, time;
            //int.TryParse(Console.ReadLine(), out principal);
            //float.TryParse(Console.ReadLine(), out rate);
            //float.TryParse(Console.ReadLine(), out rate);
            //float Interest = (principal * rate * rate) / 100;
            //Console.WriteLine(Interest);
            #endregion

            #region Q2
            //float Weight, Height;
            //Console.WriteLine("Enter Your Height : ");
            //float.TryParse(Console.ReadLine(), out Height);
            //Console.WriteLine("Enter Your Weight : ");
            //float.TryParse(Console.ReadLine(), out Weight);
            //float BMI = (Weight) / (Height * Height);
            #endregion

            #region Q3
            //int temperature = int.Parse(Console.ReadLine());
            //string result = temperature <= 10 ? "Just Cold" : temperature >= 30 ? "Just Hot" : "Just Good";
            //Console.WriteLine(result);
            #endregion

            #region Q4
            //DateTime date;
            //Console.WriteLine("Enter the date : {mm, dd, yyyy} ");
            //DateTime.TryParse(Console.ReadLine(), out date);
            //Console.WriteLine($"Today's date is : {date:dd, mm, yyyy}");
            //Console.WriteLine($"Today's date is : {date:dd / mm / yyyy}");
            //Console.WriteLine($"Today's date is : {date:dd - dd - yyyy}");
            #endregion

            #region Q5
            //c
            #endregion

            #endregion
        }
    }
}
