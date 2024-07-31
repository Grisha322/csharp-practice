
var myCar = new {Make = "some make", Color = "SomeColor" };
var mySecondCar = new { Make = "some make", Color = "SomeColor", Speed = 55 };

Console.WriteLine(myCar.Equals(mySecondCar));
Console.WriteLine($"{myCar.GetType().Name} {mySecondCar.GetType().Name}");