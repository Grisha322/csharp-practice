using LinqWithCollections;
using System.Collections;

List<Car> cars = new List<Car>{
    new Car{ PetName = "Felix", CurrentSpeed = 20},
    new Car{ PetName = "Felix 2", CurrentSpeed = 30},
    new Car{ PetName = "Alex", CurrentSpeed = 20},
    new Car{ PetName = "Alex the greatest", CurrentSpeed = 22},
    new Car{ PetName = "Some car", CurrentSpeed = 40},
    new Car{ PetName = "Felix 3", CurrentSpeed = 90},
};

ArrayList cars2 = new ArrayList{
    new Car{ PetName = "Felix", CurrentSpeed = 20},
    new Car{ PetName = "Felix 2", CurrentSpeed = 30},
    new Car{ PetName = "Alex", CurrentSpeed = 20},
    new Car{ PetName = "Alex the greatest", CurrentSpeed = 22},
    new Car{ PetName = "Some car", CurrentSpeed = 40},
    new Car{ PetName = "Felix 3", CurrentSpeed = 90},
};

QueryList(cars);

static void QueryList(List<Car> cars) { 
    var subset = from car in cars where car.CurrentSpeed > 55 orderby car.PetName select car;

    foreach (var car in subset) {
        Console.WriteLine(car.ToString());
    }
}

static void QueryArrayList(ArrayList cars)
{
    //OfType filters the non generic collections, so that if there will be an inapropriate item it wont be included in the result.
    var subset = from car in cars.OfType<Car>() where car.CurrentSpeed > 55 orderby car.PetName select car;

    foreach (var car in subset)
    {
        Console.WriteLine(car.ToString());
    }
}
