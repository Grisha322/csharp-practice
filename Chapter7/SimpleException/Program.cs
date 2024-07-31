using SimpleException;

Console.WriteLine("****** Simple Exception example ******");
Console.WriteLine("Creating a car and stepping on it");
Car myCar = new("Zippy", 20);
myCar.CrankTunes(true);

try
{
    for (int i = 0; i < 10; i++)
    {
        myCar.Accelerate(10);
    }
}
catch (Exception e) when (e.Message.IsNormalized())
{
    Console.WriteLine("\n*** Error! ***");
    Console.WriteLine("Method: {0}", e.TargetSite);
    Console.WriteLine("Message: {0}", e.Message);
    Console.WriteLine("Source: {0}", e.Source);
}
Console.ReadLine();
