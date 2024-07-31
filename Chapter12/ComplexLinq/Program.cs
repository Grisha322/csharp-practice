using ComplexLinq;

ProductInfo[] products = {
    new ProductInfo{Name = "Ball", Description = "Some Description", Stock = 100 },
    new ProductInfo{Name = "Football", Description = "Some Description2", Stock = 10 },
    new ProductInfo{Name = "Coke", Description = "Some Description  3", Stock = 200 },
    new ProductInfo{Name = "Something", Description = "Some Descripti 2on", Stock = 50 },
    new ProductInfo{Name = "Useless", Description = "Some Descript123 ion", Stock = 60 },
};

var subset =
    from product
    in products
     where product.Stock < 100
     orderby product.Stock descending
     select product;

static void VennDiagramWithLinq() {
    List<string> myCars = new List<String> { "Yugo", "Aztec", "BMW" };
    List<string> yourCars = new List<String> { "BMW", "Saab", "Aztec" };

    var carDif = (from car in myCars select car).Except(from car in yourCars select car);
    var carIntersect = (from car in myCars select car).Intersect(from car in yourCars select car);
    var carUnion = (from car in myCars select car).Union(from car in yourCars select car);
    var carConCat = (from car in myCars select car).Concat(from car in yourCars select car);

    Console.WriteLine("Car difference");
    foreach (var c in carDif) {
        Console.WriteLine(c);
    }
    Console.WriteLine("Car Intersect");
    foreach (var c in carIntersect)
    {
        Console.WriteLine(c);
    }
    Console.WriteLine("Car Union");
    foreach (var c in carUnion)
    {
        Console.WriteLine(c);
    }
    Console.WriteLine("Car Concatenation");
    foreach (var c in carConCat)
    {
        Console.WriteLine(c);
    }
}

static void AggreagtingWithLinq()
{
    int[] numbers = {1, 12, -23, 5, 100, -8 };

    Console.WriteLine($"Min Value: {numbers.Min()}");
    Console.WriteLine($"Count: {numbers.Count()}");
    Console.WriteLine($"Max Value: {numbers.Max()}");
    Console.WriteLine($"Average Value: {numbers.Average()}");
    Console.WriteLine($"Sum Value: {numbers.Sum()}");
}
