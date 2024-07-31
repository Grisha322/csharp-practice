// See https://aka.ms/new-console-template for more information
using System.Numerics;
Console.WriteLine("****** Fun with basic types ******\n");
DataTypeFunctionality();
Console.ReadLine();

static void LocalVarDeclarations() {
    int myInt = 0;
    String myString;
    myString = "Hello my friend";

    bool b1 = false, b2 = true;

    int mySecondInt = default;

    int myThirdInt = new int();

    int myFourthInt = new();
}

static void ObjectFunctionality() {
    Console.WriteLine("-> System.Object Functionality:");

    Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
    Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
    Console.WriteLine("12.ToString = {0}", 12.ToString());
    Console.WriteLine("12.GetType = {0}", 12.GetType());
    Console.WriteLine();
}

static void DataTypeFunctionality() {
    Console.WriteLine("Max of int: {0}", int.MaxValue);
    Console.WriteLine("Min of int: {0}", int.MinValue);
    Console.WriteLine("Max of double: {0}", double.MaxValue);
    Console.WriteLine("Min of double: {0}", double.MinValue);
    Console.WriteLine("Epsilon: {0}", double.Epsilon);
    Console.WriteLine("Positive Infinity: {0}", double.PositiveInfinity);
    Console.WriteLine("Negative Infinity: {0}", double.NegativeInfinity);

    Console.WriteLine();
}

static void CharFunctionality() {
    Console.WriteLine("-> Char Type Functionality:");
    Char myChar = 'a';

    Console.WriteLine("Char.IsDigit(a) = {0}", Char.IsDigit(myChar));
    Console.WriteLine("Char.IsLetter(a) = {0}", Char.IsLetter(myChar));
    Console.WriteLine("Char.IsWhiteSpace('Hello there', 5) = {0}", Char.IsWhiteSpace("Hello there", 5));
    Console.WriteLine("Char.IsWhiteSpace('Hello there', 6) = {0}", Char.IsWhiteSpace("Hello there", 6));
    Console.WriteLine("Char.IsPunctuation('?') = {0}", Char.IsPunctuation('?'));
    Console.WriteLine();
}

static void ParseFromStringsWithTryParse()
{
    Console.WriteLine("=> Data type parsing with TryParse:");
    if (bool.TryParse("True", out bool b))
    {
        // Вывод значения bConsole.WriteLine("Value of b: {0}", b);
    }
    else
    {
        Console.WriteLine("Default value of b: {0}", b);
        // Вывод стандартного значения b
    }
    string value = "Hello";
    if (double.TryParse(value, out double d))
    {
        Console.WriteLine("Value of d: {0}", d);
    }
    else
    {
        // Преобразование входного значения в double потерпело неудачу
        // и переменной было присвоено стандартное значение.
        Console.WriteLine("Failed to convert the input ({0}) to a double and the variable was assigned the default {1}", value,d);
    }
    Console.WriteLine();
}

static void UseDatesAndTimes()
{
    Console.WriteLine("=> Dates and Times:");
    // Этот конструктор принимает год, месяц и день.
    DateTime dt = new DateTime(2015, 10, 17);
    // Какой это день месяца?
    Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
    // Сейчас месяц декабрь.
    dt = dt.AddMonths(2);
    Console.WriteLine("Daylight savings: {0}",
    dt.IsDaylightSavingTime());
    // Этот конструктор принимает часы, минуты и секунды.
    TimeSpan ts = new TimeSpan(4, 30, 0);
    Console.WriteLine(ts);
    // Вычесть 15 минут из текущего значения TimeSpan и вывести результат.
    Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
}

static void UseBigInteger()
{
    Console.WriteLine("=> Use Biglnteger:");
    BigInteger biggy = BigInteger.Parse("9999999999999999999999999999999999999999999999");
    Console.WriteLine("Value of biggy is {0}", biggy);
    // значение biggy
    Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
    // biggy - четное?
    Console.WriteLine("Is biggy a power of two?: {0}", biggy.
    IsPowerOfTwo);
    BigInteger reallyBig = BigInteger.Multiply(biggy,
    BigInteger.Parse("8888888888888888888888888888888888888888888"));
    Console.WriteLine("Value of reallyBig is {0}", reallyBig);
    // значение reallyBig
    // biggy - степень 2?
}