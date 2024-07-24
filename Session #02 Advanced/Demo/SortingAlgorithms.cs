using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Demo
{
    public delegate bool CompareDelegate (int x, int y);
    public delegate TResult CompareGenericDelegate<in T1 ,in T2, out TResult>(T1 x, T2 y);

    public class SortingAlgorithms<T>
    {
        public static void BubbleSort(int[] nums, CompareDelegate compareDelegate)
        {
            if (nums is null) return;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - i - 1; j++)
                {
                    if (compareDelegate.Invoke(nums[j], nums[j + 1]))
                        Swap(ref nums[j], ref nums[j + 1]);
                }

            }
        }
        public static void Swap (ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
    public class CompareMethod
    {
        public static bool SortDescending(int x, int y)
        {
            return x < y;
        }
        public static bool SortAscending(int x, int y)
        {
            return x > y;
        }
    }
}
