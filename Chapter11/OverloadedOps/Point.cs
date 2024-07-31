using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOps
{
    public class Point: IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"[{X}, {Y}]";

        // Works with += automatically
        public static Point operator + (Point p1, Point p2) => new Point(p1.X + p2.X, p1.Y + p2.Y);
        public static Point operator + (Point p1, int v) => new Point(p1.X + v, p1.Y + v);
        public static Point operator + (int v, Point p1) => new Point(p1.X + v, p1.Y + v);

        //Works with both prefix and postfix increments automatically
        public static Point operator ++(Point p) => new Point(p.X + 1, p.Y + 1);

        public override bool Equals(object? p) => p?.ToString() == this.ToString();

        public override int GetHashCode() => this.ToString().GetHashCode();

        public int CompareTo(Point? other)
        {
            if (other is null) throw new Exception();
            if (X > other.X && Y > other.Y)
            {
                return 1;
            }
            else if (X < other.X && Y < other.Y) {
                return -1;
            }
            return 0;
        }

        public static bool operator > (Point p1, Point p2) => p1.CompareTo(p2) > 0;
        public static bool operator < (Point p1, Point p2) => p1.CompareTo(p2) < 0;

        public static bool operator ==(Point p1, Point p2) => p1.Equals(p2);

        public static bool operator !=(Point p1, Point p2) => !p1.Equals(p2);

    }
}
