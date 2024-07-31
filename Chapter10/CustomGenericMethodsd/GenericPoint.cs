using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethodsd
{
    public struct GenericPoint<T> where T : class, new()
    {
        public T X { get; set; } = default;
        public T Y { get; set; } = default;

        public GenericPoint(T xVal, T yVal)
        {
            X = xVal;
            Y = yVal;
        }

        public override string ToString() => $"[{X}, {Y}]";
    }
}
