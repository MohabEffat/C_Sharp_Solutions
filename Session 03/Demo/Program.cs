namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Fractions & Discard
            //// default double 
            //float percentage = 2.5f;
            //double percentage2 = 2.5;
            //decimal percentage3 = 2.5m;

            //long Num = 6_595_648_465_486_548;
            #endregion

            #region Value type Casting 
            //// 1. Implicit Casting (Safe Casting) => Auto Conversion 
            //int x = 100;
            //long y = x;

            //// 2. Explicit Casting (Unsafe Casting) => Manually, May Occur Data loose
            //long a = 5164698561684984654;
            //checked
            //{
            //    x = (int)a; // Overflowing
            //}
            //Console.WriteLine(x); // => Overflow happened


            #endregion

            #region Parse Method
            //// Parse
            //
            //Console.WriteLine("Enter Your Name : ");
            //String name = Console.ReadLine();
            //Console.WriteLine("Enter Your Age : ");
            //int age = int.Parse(Console.ReadLine()); // => Convert from String
            //Console.WriteLine("Hello " + name + ", Your Age is : " + age);
            //// Parse Method Will Throw An Exception if the Entered value is in a wrong format

            //// TryParse
            //// More Safe Than parse
            //
            //Console.WriteLine("Enter Your Name : ");
            //String name = Console.ReadLine();
            //Console.WriteLine("Enter Your Age : ");
            //int age;
            //bool result = int.TryParse(Console.ReadLine(), out age); // => Convert from String
            //Console.WriteLine(result);
            //Console.WriteLine("Hello " + name + ", Your Age is : " + age);
            ////TryParse => Do not Throw An Exception instead it returns the default value of the Entered value

            // Convert 
            // Throw An Exception

            //Console.WriteLine("Enter Your Name : ");
            //String name = Console.ReadLine();
            //Console.WriteLine("Enter Your Age : ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Hello " + name + ", Your Age is : " + age);
            #endregion

            #region String Formating 
            //// Equation : 4 + 2 = 6
            //int x = 4, y = 2;
            //int z = x + y;
            //// 1. String Concatenation            
            //String result = "Equation : " + x + " + " + y + " = " + z;
            //Console.WriteLine(result);

            //// 2. Composite Formatting
            //Console.WriteLine("Equation : {0} + {1} = {2} ", x, y, z);

            //// 3. String Interpolation
            //String equation = $"Equation : {x} + {y} = {z}";
            //Console.WriteLine(equation);

            //DateTime now = DateTime.Now;
            //String formattedDate = String.Format("{0:MMMM dd, yyyy}", now);
            //Console.WriteLine(formattedDate);

            #endregion

            #region Conditional Statements
            //// if = switch
            //Console.WriteLine("Enter a Month Number : ");
            //int monthNum = int.Parse(Console.ReadLine());
            //if (monthNum == 1)
            //{
            //    Console.WriteLine("Jan");
            //}
            //else if (monthNum == 2)
            //{
            //    Console.WriteLine("Feb");
            //}
            //else if (monthNum == 3)
            //{
            //    Console.WriteLine("Mar");
            //}
            //else
            //{
            //    Console.WriteLine("N/A");
            //}
            //switch(monthNum)
            //{
            //    case 1:
            //        Console.WriteLine("Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mar");
            //        break;
            //    default:
            //        Console.WriteLine("N/A");
            //        break;
            //} // => jumpTable
            //int value = 3000;
            //switch (value)
            //{
            //    case 3000:
            //        Console.WriteLine("Option 03");
            //        //Console.WriteLine("Option 02");
            //        //Console.WriteLine("Option 01");
            //        goto case 2000;
            //    //break;
            //    case 2000:
            //        Console.WriteLine("Option 02");
            //        //Console.WriteLine("Option 01");
            //        //break;goto case 2000;
            //        goto case 1000;
            //    case 1000:
            //        Console.WriteLine("Option 01");
            //        break;
            //    default :
            //        Console.WriteLine("No Options");
            //        break;
            //}
            #endregion

            #region Loops Statements
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            //// for loop
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
           
            //// do .. while loop (At Least will be performed one time)
            //int num;
            //bool flag = true;
            //do
            //{
            //    Console.WriteLine("Enter a Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out num);

            //}
            //while (num % 2 == 1 || !flag); // odd num

            //// while loop
            //int x = 1;
            //while (x <= 10)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}

            // foreach
            #endregion
        }
    }
}
