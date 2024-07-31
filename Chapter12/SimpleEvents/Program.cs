using SimpleEvents;

Car car = new("some name", 50);
car.AboutToExplode += delegate
{
    //do something
};

car.AboutToExplode += delegate (object? e, CarEventArgs args) { 
    // do something
};
