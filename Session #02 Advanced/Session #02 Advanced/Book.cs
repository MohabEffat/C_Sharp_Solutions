using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session__02_Advanced
{
    public class Book
    {

        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime publicationDate { get; set; }
        public decimal price { get; set; }

        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _publicationDate, decimal _price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            publicationDate = _publicationDate;
            price = _price;
        }
        public override string ToString()
        {
            return $"Book's ISBN :{ISBN}, Title : {Title}, Authors :{String.Join(",", Authors)} publicationDate : {publicationDate}, Price : {price}";
        }
    }
}
