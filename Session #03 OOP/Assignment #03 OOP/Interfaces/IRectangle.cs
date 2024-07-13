using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__03_OOP.Interfaces
{
    public interface IRectangle : IShape
    {
        int perimeter { get; }
        int Width { get; set; }
        int Length { get; set; }
    }
}
