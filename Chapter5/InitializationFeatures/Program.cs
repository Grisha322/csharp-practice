using InitializationFeatures;

// Fields can be initialized with values, even if there is no dedicated constructor.
// Note! this trick doesn't work if there is no setter or if it is private
Point point = new Point { X = 5, Y = 10};
point.Y = 5; // property has a setter

PointWithInitProperties point2 = new PointWithInitProperties { X = 5, Y = 10 };
//point2.X = 10; this will give an error, since x and y are defined as init - can be set only once 