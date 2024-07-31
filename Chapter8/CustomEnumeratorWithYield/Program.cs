using CustomEnumeratorWithYield
;

Console.WriteLine("****** Fun with Enumerable/Enumerator ******");
Garage carLot = new Garage();
foreach (Car car in carLot) {
    Console.WriteLine($"{car.PetName} goes at {1} MPH");
}
Console.ReadLine();
