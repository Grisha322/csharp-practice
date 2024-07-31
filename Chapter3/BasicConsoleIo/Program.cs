// See https://aka.ms/new-console-template for more information
using System.Xml;

Console.WriteLine("****** Basic Console I/O ******");
FormatNumericalValues();
Console.ReadLine();
GetUserData();

static void GetUserData() {
    Console.WriteLine("Please enter your name: ");
    string username = Console.ReadLine()!;

    Console.WriteLine("Please enter your age: ");
    string age = Console.ReadLine()!;

    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.WriteLine("Hello {0}! You are {1} years old.", username, age);

    Console.ForegroundColor = prevColor;
}

//https://docs.microsoft.com/ru-ru/dotnet/standard/base - types / formatting - types
static void FormatNumericalValues() {
    Console.WriteLine("The value 99999 in various formats.");
    Console.WriteLine("c format: {0:c}", 99999);
    Console.WriteLine("d9 format: {0:d9}", 99999);
    Console.WriteLine("f3 format: {0:f3}", 99999);
    Console.WriteLine("n format: {0:n}", 99999);
    Console.WriteLine("E format: {0:E}", 99999);
    Console.WriteLine("e format: {0:e}", 99999);
    Console.WriteLine("X format: {0:X}", 99999);
    Console.WriteLine("x format: {0:x}", 99999);
}
