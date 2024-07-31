// See https://aka.ms/new-console-template for more information
ExecutePatternMatchingSwitchWithWhen();

static void PlayingWithLoops() {
    for (int i = 0; i < 15; i++)
    {
        Console.WriteLine($"i = {i}");
    }

    bool stop = false;
    while (!stop)
    {
        stop = true;
        Console.WriteLine("while looping");
    }
    //stop is false after previous loop
    do
    {
        stop = !stop;
        Console.WriteLine("while looping");
    } while (!stop);

    int[] numbers = { 1, 2, 3 };
    foreach (int num in numbers)
    {
        Console.WriteLine($"num = {num}");
    }
}

static void PlayingWithConditions(object myInt) {
    int[] numbers = { 1, 2, 3 };
    // if only accepts booleans, hence: if(numbers.Length) generates an error
    // proper usage:
    if (numbers.Length > 0)
    {
        Console.WriteLine("Proper usage");
    }

    if (myInt is string myString)
    {
        Console.WriteLine(myString);
    }
    else if (myInt is int num)
    {
        Console.WriteLine(myInt);
    }
    else
    {
        Console.WriteLine("myInt is neither string nor int");
    }
}

static void PlayingWithEnhancedConditions() {
    object testItem = 123;
    Type t = typeof(string);
    char c = 'f';

    if (t is Type) {
        Console.WriteLine($"{t} is a Type");
    }
    if (c is >= 'a' and <= 'z' or >= 'A' and <= 'Z') {
        Console.WriteLine($"{c} is a character");
    }
    if (c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or ',' or '.') {
        Console.WriteLine($"{c} is  a character or separator");
    }
    if (testItem is not string) {
        Console.WriteLine($"{testItem} is not a string");
    }
    if (testItem is not null) { 
        Console.WriteLine($"{testItem} is not null");
    }
    Console.WriteLine();
}

static void ConditionalRefExample()
{
    var smallArray = new int[] { 1, 2, 3, 4, 5 };
    var largeArray = new int[] { 10, 20, 30, 40, 50 };
    //Глава 3.Главные конструкции программирования на С #: часть 1 141
    int index = 7;
    ref int refValue = ref ((index < 5)
    ? ref smallArray[index]
    : ref largeArray[index - 5]);
    refValue = 0;
    index = 2;
    ((index < 5)
    ? ref smallArray[index]
    : ref largeArray[index - 5]) = 100;
    Console.WriteLine(string.Join(" ", smallArray));
    Console.WriteLine(string.Join(" ", largeArray));
}

// Переключение на основе числового значения,
static void SwitchExample()
{
    Console.WriteLine("1 [C#], 2 [VB]");
    Console.Write("Please pick your language preference: ");
    // Выберите предпочитаемый язык:
    string langChoice = Console.ReadLine() ?? "2";
    int n = int.Parse(langChoice);
    // Works on int, string, char, bool, enum, long, short.
    switch (n)
    {
        case 1:
            Console.WriteLine("Good choice, C# is a fine language.");
            // Хороший выбор. C# - замечательный язык.
            break;
        case 2:
            Console.WriteLine("VB: OOP, multithreading, and more!");
            // VB: ООП, многопоточность и многое другое!
            break;
        default:
            Console.WriteLine("Well...good luck with that!");
            // Что ж... удачи с этим!
            break;
    }
}

static void SwitchOnEnumExample()
{
    Console.Write("Enter your favorite day of the week: ");
    // Введите любимый день недели:
    DayOfWeek favDay;
    try
    {
        favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Bad input!");
        // Недопустимое входное значение!
        return;
    }
    switch (favDay)
    {
        case DayOfWeek.Monday:
            Console.WriteLine("Another day, another dollar.");
            // Еще один день, еще один доллар.
            break;
        case DayOfWeek.Tuesday:
            Console.WriteLine("At least it is not Monday.");
            // В о всяком случае, не понедельник.
            break;
        case DayOfWeek.Wednesday:
            Console.WriteLine("A fine day.");
            // Хороший денек.
            break;
        case DayOfWeek.Thursday:
            Console.WriteLine("Almost F r i d a y... ");
            // Почти пятница...
            break;
        case DayOfWeek.Friday:
            Console.WriteLine("Yes, Friday rules!");
            // Да, пятница рулит!
            break;
        case DayOfWeek.Saturday:
        case DayOfWeek.Sunday:
            Console.WriteLine("It's the weekend ! ");
            // Выходные!
            break;
    }
    Console.WriteLine();
}

static void ExecutePatternMatchingSwitch()
{
    Console.WriteLine("1 [Integer (5)], 2 [String (\"Hi\")], 3 [Decimal (2.5)]");
    Console.Write("Please choose an option: ");
    string userChoice = Console.ReadLine();
    object choice;
    // Стандартный оператор switch, в котором применяется
    // сопоставление с образцом с константами
    switch (userChoice)
    {
        case "1":
            choice = 5;
            break;
        case "2":
            choice = "Hi";
            break;
        case "3":
            choice = 2.5;
            break;
        default:
            choice = 5;
            break;
    }
    // Новый оператор switch, в котором применяется
    // сопоставление с образцом с типами
    switch (choice)
    {
        case int i:
            Console.WriteLine("Your choice is an integer {0}.", i);
            break;
        case string s:
            Console.WriteLine("Your choice is a string {0}.", s);
            break;
        case decimal d:
            Console.WriteLine("Your choice is a decimal {0}.", d);
            break;
        default:
            Console.WriteLine("Your choice is something else.");
            break;
    }
    Console.WriteLine();
}

static void ExecutePatternMatchingSwitchWithWhen()
{
    Console.WriteLine("1 [C#], 2 [VB]");
    Console.Write("Please pick your language preference: ");
    object langChoice = Console.ReadLine();
    //Doesn't work as in the book
    object? c = null;
    var choice = int.TryParse(langChoice.ToString(), out int с) ? c : langChoice;
    switch (choice)
    {
        case int i when i == 2: // can be written as (> 1 and <3), i.e. all enhanced conditions work on switch
        case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("VB: OOP, multithreading, and more!");
            // VB: ООП, многопоточность и многое другое!
            break;
        case int i when i == 1:
        case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("Good choice, C# is a fine language.");
            // Хороший выбор. C# - замечательный язык.
            break;
        default:
            Console.WriteLine("Well...good luck with that!");
            // Хорошо, удачи с этим!
            break;
    }
    Console.WriteLine();
}

static string FromRainbow(string colorBand)
{
    return colorBand switch
    {
        "Red" => "#FF0000",
        "Orange" => "#FF7F00",
        "Yellow" => "#FFFF00",
        "Green" => "#00FF00",
        "Blue" => "#OOOOFF",
        "Indigo" => "#4B0082",
        "Violet" => "#9400D3",
        _ => "#FFFFFF",
    };  
}
// Выражения switch с кортежами.
static string RockPaperScissors(string first, string second)
{
    return (first, second) switch
    {
        ("rock", "paper") => "Paper wins.",
        ("rock", "scissors") => "Rock wins.",
        ("paper", "rock") => "Paper wins.",
        ("paper", "scissors") => "Scissors wins.",
        ("scissors", "rock") => "Rock wins.",
        ("scissors", "paper") => "Scissors wins.",
        ( _, _)    => "Tie.",
    };
}
