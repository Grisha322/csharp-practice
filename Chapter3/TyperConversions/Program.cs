// See https://aka.ms/new-console-template for more information
Console.WriteLine("****** Fun with Type Conversions ******");
byte num1 = 200, num2 = 200;
try {
    short num3 = checked((byte)Add(num1, num2));
    Console.WriteLine($"{num1} + {num2} = {num3}");
}
catch (OverflowException ex) {
    Console.WriteLine(ex.Message);
}

unchecked { 
    short num4 = (byte)Add((byte)100, (byte)100);
    Console.WriteLine(num4);
}
Console.Read();

static int Add(int x, int y) {
    return x + y;
}
