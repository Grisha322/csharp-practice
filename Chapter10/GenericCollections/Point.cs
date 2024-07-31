using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class PointWithInitProperties {
        public int X { get; init; }
        public int Y { get; init; }
    }
}
