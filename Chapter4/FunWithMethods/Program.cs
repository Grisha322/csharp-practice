// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int x = 5, y = 10;
int ans;
AddUsingOutParam(x, y, out ans);
AddUsingOutParam(x, y, out int answer);
FillTheseValues(out int a, out _, out _);
Console.WriteLine(ans + answer);
string strl = "Flip";
string str2 = "Flop";
Console.WriteLine("Before: {0}, {1} ", strl, str2); // До
SwapStrings(ref strl, ref str2);
Console.WriteLine("After: {0}, {1} ", strl, str2); // После
Console.ReadLine();
double[] values = {1.0, 2.0, 3.0};
Console.WriteLine($"{CalculateAverage(1.0, 2.0, 3.0)} {CalculateAverage()} {CalculateAverage(values)}");
LogErrorData("some error without owner");
LogErrorData("some error with owner", "CEO");

static void AddUsingOutParam(int x, int y, out int ans)
{
    ans = x + y;
}

// Возвращение множества выходных параметров.
static void FillTheseValues(out int a, out string b, out bool c)
{
    a = 9;
    b = "Enjoy your string.";
    c = true;
}

static void SwapStrings(ref string si, ref string s2)
{
    string tempStr = si;
    si = s2;
    s2 = tempStr;
}

static int ReadOnlyAdd(in int x, in int y) {

    // Can not reassign values, since x and y are given by read only refference
    //x = 500;
    //y = 600;

    return x + y;
}

static double CalculateAverage(params double[] values) {
    Console.WriteLine("You sent me {0} doubles.", values.Length);
    double sum = 0;
    if (values.Length == 0) return sum;

    for (int i = 0; i < values.Length; i++)
    {
        sum += values[i];
    }
    return (sum / values.Length);
}

static void LogErrorData(string message, string owner = "Programmer") {
    Console.Beep();
    Console.WriteLine("Error: {0}", message);
    Console.WriteLine("Owner of Error: {0}", owner);
}