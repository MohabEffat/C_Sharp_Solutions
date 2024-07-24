using System.ComponentModel;

namespace Session__02_Advanced
{
    public delegate string BookFuncstionsDelegate(Book book);

    internal class Program
    {

        public static int RepeatedChar(string word) 
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            char x = (char)0;
            int index = -1;
            for (int i = 0; i < word.Length; i++)
            {
                if (dic.ContainsKey(word[i]))
                    dic[word[i]]++;
                else 
                    dic.Add(word[i], 1);
            }
            foreach (var c in dic)
            {
                if(c.Value == 1)
                {
                     x = c.Key;
                    break;
                }
            }
            for (int i = 0;i < word.Length; i++)
            {
                if(x == word[i])
                {
                    index = i;
                    break;
                }
            }
            return index;

        }
        static void Main(string[] args)
        {
            #region Q1
            //string str = "the first non repeated character";
            //Console.WriteLine(RepeatedChar(str));
            #endregion

            #region Q2
            Book book = new Book("Md163S", "The Cloud", ["Mohab", "Ahmed", "Mahmoud"], DateTime.Now, 3000);


            BookFuncstionsDelegate bookDelegate;
            bookDelegate = BookFunctions.GetTitle; // change the method as you want from the BookFunctions Class
            string title = bookDelegate(book);


            Console.WriteLine(title);

            List<Book> books = new List<Book>
            {
                new Book("Md163S", "The See", ["Mohab", "Ahmed", "Mahmoud"], DateTime.Now, 3000),
                new Book("Md163S", "The Sand", ["Mohab", "Ahmed", "Mahmoud"], DateTime.Now, 3000),
                new Book("Md163S", "The Fire", ["Mohab", "Ahmed", "Mahmoud"], DateTime.Now, 3000)

            };

            LibraryEngine.ProcessBooks(books, bookDelegate);

            Func<Book, string> func1 = delegate (Book book) { return book.ISBN; };
            Console.WriteLine(func1(book));

            Func<Book, DateTime> func2 = (book) => book.publicationDate;
            Console.WriteLine(func2(book));

            #endregion



        }
    }
}
