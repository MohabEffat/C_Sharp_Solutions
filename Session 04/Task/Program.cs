namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////
            int[] arr = { 16, 265, 31, 54, 25, 66, 87, 800, 19, 11 };
            int[,] matrix =
            {
                {10,20,30 },
                {40,50,60 },
                {70,80,90 },
            };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) {
                sum += arr[i];
            }
            Console.WriteLine(sum);
            ////////////////////////////
            ///
            int max = 0, min = 0;
            max = min = arr[0];
            for (int i = 1; i < arr.Length; i++) {
                if (arr[i] > max) {
                    max = arr[i];
                }
                if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            ////////////////////////////
            ///
            int SumArr = 0;
            for (int i = 0; i < matrix.GetLength(0); i++) {
                for (int j = 0; j < matrix.GetLength(1); j++) {
                    if (i == j || i +j == matrix.GetLength(0) -1 )
                        SumArr += matrix[i, j];
                }
            }
            Console.WriteLine(SumArr);
        }

    }
}
