using System.Collections;

namespace Session__01_Advanced
{
    internal class Program
    {
        public static void ReverseArrayList(ArrayList arrayList)
        {
            ArrayList temp = new ArrayList();
            for (int i = arrayList.Count - 1; i >= 0; i--)
            {
                temp.Add(arrayList[i]);
            }
            arrayList.Clear();
            for (int i = 0; i < temp.Count; i++)
            {
                arrayList.Add(temp[i]);
            }

        }
        static void Main(string[] args)
        {
            #region Q1
            //Range<int> range = new Range<int>(5,10);
            //Console.WriteLine(range.IsInRange(11));
            //Console.WriteLine(range.IsInRange(6));
            //Console.WriteLine(range.Length());
            #endregion

            #region Q2
            ArrayList arrayList = new ArrayList();
            arrayList.Add(2);
            arrayList.Add("mohab");
            arrayList.Add('x');
            arrayList.Add('y');
            arrayList.Add("AAA");
            arrayList.Add(85);
            arrayList.Add(987);
            Console.WriteLine("Before Reverse :");
            foreach (var i in arrayList)
            {
                Console.Write(i + " ");
            }

            ReverseArrayList(arrayList);

            Console.WriteLine("\nAfter Reverse :");
            foreach (var i in arrayList)
            {
                Console.Write(i + " ");
            }
            #endregion

            #region Q3
            //List<int> list = new List<int>();
            //for (int i = 0; i < 100; i++)
            //{
            //    list.Add(i);

            //}
            //List<int> newList = new List<int>();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] % 2 == 0)
            //        newList.Add(list[i]);
            //}
            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

        }

    }
}
