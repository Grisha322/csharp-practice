// See https://aka.ms/new-console-template for more information
Console.WriteLine("****** Fun with Arrays ******");
IndexesAndRanges();
Console.ReadLine();

static void SimpleArrays()
{
    Console.WriteLine(" => Simple Arrays Creation.");
    int[] intArray = new int[3];
    intArray[0] = 100;
    intArray[1] = 200;
    intArray[2] = 300;

    foreach (int i in intArray) {
        Console.WriteLine(i);
    }

    Console.WriteLine();
}

static void Arraylnitialization()
{
    Console.WriteLine("=> Array Initialization.");
    // Синтаксис инициализации массивов с использованием ключевого слова new.
    string[] stringArray = new string[]
    { "one", "two", "three" };
    Console.WriteLine("stringArray has {0} elements", stringArray.Length);
    // Синтаксис инициализации массивов без использования
    // ключевого слова new.
    bool[] boolArray = { false, false, true };
    Console.WriteLine("boolArray has {0} elements", boolArray.Length);
    // Инициализация массива с применением ключевого слова new
    // и указанием размера.
    int[] intArray = new int[4] { 20, 22, 23, 0 };
    Console.WriteLine("intArray has {0} elements", intArray.Length);
    Console.WriteLine();
}

static void DeclareImplicitArrays() {
    Console.WriteLine("=> Implicit Array Initialization");

    var a = new[] { 1, 2, 3 };

    var b = new[]  { "hi", "hello", null};

    Console.WriteLine($"a is a {a}");
    Console.WriteLine($"b is b {b}");
}

static void ArrayOfObjects()
{
    Console.WriteLine("=> Array of Objects.");
    // Массив объектов может содержать все что угодно,
    object[] myObjects = new object[4];
    myObjects[0] = 10;
    myObjects[1] = false;
    myObjects[2] = new DateTime(1969, 3, 24);
    myObjects[3] = "Form & Void";
    foreach (object obj in myObjects)
    {
        // Вывести тип и значение каждого элемента в массиве.
        Console.WriteLine("Type ; {0}, Value: {1}", obj.GetType(), obj);
    }
    Console.WriteLine();
}

static void RectMultidimensionalArray() {
    Console.WriteLine("=> Rectangular Multidimential Array");

    int[,] myArray = new int[3, 4];

    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 4; j++) {
            myArray[i, j] = i * j;
            Console.Write(myArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

static void JaggedMultidimensionalArray()
{
    Console.WriteLine("=> Jugged Multidimential Array");

    int[][] myArray = new int[5][];

    // Создать зубчатый массив.
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new int[i + 7];
    }

    for (int i = 0; i < 5; i++) {
        for (int j = 0; j < myArray[i].Length; j++) {
            Console.Write(myArray[i][j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

static void IndexesAndRanges() {
    Console.WriteLine("=> Messing with indexes and ranges");

    int[] myArray = {1, 2, 3, 4, 5, 6};

    foreach(int i in myArray[0..3]) {
        Console.Write(i + " ");
    }
    Console.WriteLine();

    Range range = 2..^0;
    // last element is ^1, however when working with ranges (..), second bound is exclusive
    foreach (int i in myArray[range]) {
        Console.Write(i + " ");
    }
    Console.WriteLine();

    Index start = 1;
    Index end = ^1;
    Console.WriteLine(myArray[start]);
    Console.WriteLine(myArray[end]);
}