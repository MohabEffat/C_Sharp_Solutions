using System.Security.Cryptography.X509Certificates;

namespace Demo
{
    public delegate int StringFuncstionDelegate(string word);


    // Built In Delegates (Generic Delegate)
    // Predicates => Reference To Any Method That Takes one Parameter And Returns Bool
    // Func => (0-16) returns a value 
    // Action => (0-16) returns a void 
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ex1
            //StringFuncstionDelegate stringFuncstion;

            //stringFuncstion = new StringFuncstionDelegate(StringFunctions.GetCountOfLower);
            //stringFuncstion = StringFunctions.GetCountOfLower;
            //stringFuncstion += StringFunctions.GetCountOfUpper; // Two Methods And Return The Last Call 

            //int result = stringFuncstion.Invoke("MOhab EffAt");
            //Console.WriteLine(result);
            #endregion

            #region Ex2
            //CompareDelegate compareDelegate = CompareMethod.SortAscending;
            //int[] nums = [5, 1, 15, 56, 16, 32, 95, 64];
            //SortingAlgorithms<int>.BubbleSort(nums, compareDelegate);
            //Console.WriteLine(String.Join(",", nums));
            #endregion

            #region Ex3
            Predicate<int> predicate = (X) =>  X > 0; 
            predicate(10);

            Func<int, string> func = delegate (int x) {return x.ToString(); };
            func(10);

            Action<string> action = delegate (string name)
            {
                Console.WriteLine(name);
            };
            #endregion
        }
    }
    class StringFunctions
    {
        public static int GetCountOfUpper(String word)
        {
            Console.WriteLine("GetCountOfUpper");
            int cnt = 0;
            if (!string.IsNullOrEmpty(word))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                        cnt++;
                }

            }
            return cnt;
        }
        public static int GetCountOfLower(String word)
        {
            Console.WriteLine("GetCountOfLower");
            int cnt = 0;
            if (!string.IsNullOrEmpty(word))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                        cnt++;
                }

            }
            return cnt;
        }
    }
}
