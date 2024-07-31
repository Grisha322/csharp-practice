int? myInt = null;

Console.WriteLine(myInt.HasValue ? $"myInt = {myInt.Value}" : "myInt contains null");

string? myString = null;
myString ??= "Some String";

string anotherString = myString ?? "Actual String";
