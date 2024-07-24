using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session__02_Advanced
{
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> books, BookFuncstionsDelegate BookDelegate)
        {
            foreach(var book in books)
            {
                Console.WriteLine(BookDelegate(book));
            }
        }
    }
}
