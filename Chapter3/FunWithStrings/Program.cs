using System.Text;

Console.WriteLine("Hello, World!");
FunWithStringBuilder();
Console.ReadLine();

static void BasicStringFunctionality() {
    Console.WriteLine("-> Fun With Strings");
    string firstName = "Freddy";
    Console.WriteLine($"Value of firstName: {firstName}");
    Console.WriteLine($"firstName has {firstName.Length} characters");
    Console.WriteLine($"firstName is Upper case: {firstName.ToUpper()}");
    Console.WriteLine($"firstName is Lower case: {firstName.ToLower()}");
    Console.WriteLine($"Does firstName contain the letter y?: {firstName.Contains('y')}");
    Console.WriteLine($"New First Name: {firstName.Replace("dy", "")}");
    Console.WriteLine();
}

static void FunWithStringBuilder()
{
    Console.WriteLine("=> Using the StringBuilder:");
    StringBuilder sb = new StringBuilder("****** Fantastic Games ******");
    sb.Append('\n');
    sb.AppendLine("Half Life");
    sb.AppendLine("Morrowind");
    sb.AppendLine("Deus Ex" + "2");
    sb.AppendLine("System Shock");
    Console.WriteLine(sb.ToString());
    sb.Replace("2", " Invisible War");
    Console.WriteLine(sb.ToString());
    Console.WriteLine("sb has {0} chars.", sb.Length);
    Console.WriteLine();
}