using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session__03_OOP.Interfaces
{
    internal interface ISeries
    {
        public int Current {  get; set; }
        void GetNext();
        void Reest()
        {
            Current = 0;
        }
    }
    class SeriesByTwo : ISeries
    {
        public int Current { get ; set; }

        public void GetNext()
        {
            Current += 2;
        }
    }
    class SeriesByThree : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 3;
        }
    }
    class SeriesByFour : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 4;
        }
    }
}
