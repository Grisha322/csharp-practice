using System.Xml.Linq;

Console.WriteLine("****** Fun With Structures ******");

Point p1 = new();
Point p2 = new(10, 20, "Point2");

struct Point {
    public int X;
    public int Y;
    public readonly string Name;
    public Point(int x, int y, string name) {
        X = x;
        Y = y;
        this.Name = name;
    }

    public void Increment() {
        X++; Y++;
    }

    public void Decrement() {
        X--; Y--;   
    }

    public void Display() {
        Console.WriteLine($"X = {X}, Y = {Y}, Name = {Name}");
    }
}

readonly struct ReadOnlyPoint
{
    int X { get; }
    int Y { get; }

    public ReadOnlyPoint(int x, int y)
    {
        X = x;
        Y = y;
    }
    public void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}");
    }

}
