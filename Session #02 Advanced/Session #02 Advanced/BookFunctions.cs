using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session__02_Advanced
{
    public class BookFunctions
    {
        public static string GetTitle(Book book)
        {
            return book.Title;
        }
        public static string GetAuthors(Book book)
        {
            return String.Join(", ",book.Authors);
        }
        public static string GetPrice (Book book)
        {
            return book.price.ToString();
        }
    }
}
