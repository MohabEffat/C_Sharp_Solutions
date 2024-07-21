using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session__01_Advanced
{
    public class Range<T> where T : struct, IComparable<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }
        public Range(T min, T max)
        { 
            Min = min; Max = max;
        }

        public bool IsInRange(T _data)
        {
            return _data.CompareTo(Min) > 0 && _data.CompareTo(Max) < 0;
        }
        public int Length()
        {
            int min = Convert.ToInt32(Min);
            int max = Convert.ToInt32(Max);
            return max - min + 1;
        }

    }
}
