using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexLinq
{
    public class ProductInfo
    {
        public string Name { get; set; }
        public string Description { get; init; }
        public int Stock { get; init; }

        public override string ToString() => $"[{Name}, {Description}, {Stock}]";
    }
}
