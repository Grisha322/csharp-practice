var (first, _, last) = SplitNames();
Console.WriteLine($"{first} {last}");

static void FunWithTuples() {
    (string, int, int) myTuple = ("apple", 5, 10);

    Console.WriteLine($"myTuple Values: {myTuple.Item1}, {myTuple.Item2}, {myTuple.Item3}");

    (string stringValue, int intValue) tupleWithCustomNames1 = ("apple", 5);
    Console.WriteLine($"tupleWithCustomNames1 Values: {tupleWithCustomNames1.Item1}, {tupleWithCustomNames1.Item2}");
    Console.WriteLine($"tupleWithCustomNames1 Values: {tupleWithCustomNames1.stringValue}, {tupleWithCustomNames1.intValue}");

    var tupleWithCustomNames2 = (customName: "apple", customName2: 5);
    Console.WriteLine($"tupleWithCustomNames2 Values: {tupleWithCustomNames2.customName}, {tupleWithCustomNames2.customName2}");

    var tupleWithConstructor = new { Prop1 = "apple", Prop2 = 5 };
    Console.WriteLine($"tupleWithConstructor Values: {tupleWithConstructor.Prop1} {tupleWithConstructor.Prop2}");
}

static void EqualityOfTuples() {
    var myTuple = (a: 5, b: 10);
    (int? a, long b) tupleWithWrongTypes = (5, 10);
    (int, int) namelessTuple = (5, 10);
    Console.WriteLine(myTuple == tupleWithWrongTypes);
    Console.WriteLine(myTuple == namelessTuple);
}

static (string first, string middle, string last) SplitNames() {
    return ("Philip", "F", "Robert");
}

static string GetQuadrant(Point p)
{
    return p.Deconstruct() switch
    {
        (0, 0) => "Origin",
        var (x, y) when x > 0 && y > 0 => "One",
        var (x, y) when x < 0 && y > 0 => "Two",
        var (x, y) when x < 0 && y < 0 => "Three",
        var (x, y) when x > 0 && y < 0 => "Four",
        var ( _, _) => "Border",
    };
}

static string GetQuadrant2(Point p)
{
    return p switch
    {
        (0, 0) => "Origin",
        var (x, y) when x > 0 && y > 0 => "One",
        var (x, y) when x < 0 && y > 0 => "Two",
        var (x, y) when x < 0 && y < 0 => "Three",
        var (x, y) when x > 0 && y < 0 => "Four",
        var (_, _) => "Border",
    };
}

struct Point
{
    public int X;
    public int Y;
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public (int xPos, int yPos) Deconstruct() => (X, Y);
    public void Deconstruct(out int XPos, out int YPos) => (XPos,YPos) = (X, Y);
}
    