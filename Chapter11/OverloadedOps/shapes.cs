using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOps
{
    internal struct Square
    {
        public int Length { get; set; }

        public Square(int l)
        {
            Length = l;
        }

        public static explicit operator Square(Rectangle r) => new Square(r.Width);
    }

    internal struct Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int w, int h)
        {
            Width = w;
            Height = h;
        }

        public static implicit operator Rectangle(Square s) => new Rectangle(s.Length * 2, s.Length);
    }
}
