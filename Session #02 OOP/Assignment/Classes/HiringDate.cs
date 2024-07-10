using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Classes
{
    public class HiringDate
    {
        public DateTime HireDate { get; set; }
        int day { get; set; }
        int month { get; set; }
        int year { get; set; }
        public HiringDate() { }
        public HiringDate(DateTime _HireDate)
        {
            HireDate = _HireDate;
            day = _HireDate.Day;
            month = _HireDate.Month;
            year = _HireDate.Year;
        }
        
        public void DisplayDate()
        {
            Console.WriteLine($"Hiring Date : Month : {month}, Day : {day}, Year : {year}");
        }
    }
}
