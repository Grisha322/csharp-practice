using FunWithRecords;

Car car = new Car {Model = "SomeModel", Make = "SomeMake", Color = "SomeColor" };

CarRecord carRecord = new CarRecord ("SomeMake", "SomeModel", "SomeColor" );
CarRecord anotherCarRecord = new CarRecord("SomeMake", "SomeModel", "SomeColor"); //carRecord and anotherCarRecord will work with == and != operators, due to the nature of records
CarRecord pointerCopy = carRecord; // Both point to the same object
CarRecord deepCopy = carRecord with {Model = "SomeOtherModel" }; // Creates a deep copy,


