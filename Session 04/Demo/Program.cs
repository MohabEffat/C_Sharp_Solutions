using System.Text;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String vs StringBuilder
            //String name01 = "Mohab"; // => Strings are immutable, Changing the value of the String making a new address
            //String name02 = "Effat";
            //Console.WriteLine(name01.GetHashCode());
            //Console.WriteLine(name02.GetHashCode());

            //name01 = name02;

            //Console.WriteLine(name01.GetHashCode());
            //Console.WriteLine(name02.GetHashCode());

            //StringBuilder Message = new StringBuilder();
            //Console.WriteLine(Message.GetHashCode());
            //Message.Append("Hello, ");
            //Console.WriteLine(Message.GetHashCode());
            //Message.AppendLine("Mohab");
            //Console.WriteLine(Message.GetHashCode()); // Mutable, Mutable = Same Address
            //Console.WriteLine(Message); 
            //Message.Clear();
            //Console.WriteLine("Message : " + Message);


            #endregion

            #region One D Array
            //int[] Numbers;
            //Numbers = new int[10];
            //int x = int.Parse(Console.ReadLine());
            //int[] arr = new int[x];
            //Numbers[0] = 1;
            //Numbers[1] = 2;
            //Numbers[2] = 3;
            //int[] nums = { 1,2,3 };
            //Console.WriteLine($"Size = {Numbers.Length}, Number of D = {arr.Rank}");
            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}
            //int[] Nums1 = { 1, 2, 3, 7, 8, 9 };
            //int[] Nums2 = { 4, 5, 6 };
            //Console.WriteLine(Nums1.GetHashCode());
            //Console.WriteLine(Nums2.GetHashCode());

            //Nums2 = Nums1; // => Deep Copy 

            //Console.WriteLine(Nums1.GetHashCode());
            //Console.WriteLine(Nums2.GetHashCode());
            //foreach(int i in Nums2)
            //    Console.WriteLine(i);
            //Nums2 = (int[])Nums1.Clone(); // => Shallow Copy 
            //Console.WriteLine(Nums1.GetHashCode());
            //Console.WriteLine(Nums2.GetHashCode());
            #endregion

            #region Two D Array
            //int[,] marks = new int[3, 4];
            //for (int i = 0; i < marks.GetLength(0); i++)
            //{

            //    Console.WriteLine($"PleaseEnter The Marks Of Student Number #{i + 1}");
            //    for (int j = 0; j < marks.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"PleaseEnter The Marks Of Subject Number #{j + 1}");
            //        int.TryParse(Console.ReadLine(), out marks[i, j]);
            //    }
            //    Console.WriteLine("-------------------------");
            //}
            #endregion

            #region Boxing And Unboxing
            // Casting Between Object(Ref Type) And Any Value Type
            //object obj = new object();
            //obj = 10;
            //obj = 'A';
            //obj = "Mohab";
            //// Cast From int(Value Type) to object (Ref Type) => Implicit Casting
            ////Safe Casting, Parent = Child, => Boxing
            //int y = (int)obj;
            // Cast From int(Ref Type) to object (Value Type) => Implicit Casting
            //UnSafe Casting, Child = Parent , => UnBoxing

            #endregion

            #region Nullable Types
            //int? x = null;
            //int y ; 
            //if(x == null)
            //    y =0 ;
            //y = (int) x;
            //if(!x.HasValue)
            //    x = 0 ;
            //y = x.HasValue ? x.Value : 0 ;
            //// Null Coalescing Operator 
            //y = x ?? 0; // => if null then = 0
            #endregion

            #region Implicitly Typed Local Variable [ var - dynamic ]
            var x = 5;
            // Strongly Typed : Cant Change its data typed 
            // Must be Initialized
            // Can not be null

            dynamic y = null;
            y = 10;
            y = 'M';
            #endregion
        }
    }
}
