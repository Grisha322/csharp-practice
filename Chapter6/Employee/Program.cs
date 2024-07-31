using Employees;

object[] objects = new object[2];
objects[0] = new Manager("Frank", 12, 5000, "somestring", 10);
objects[1] = 5;

if ((objects[0] as Employee) == null)
{
    Console.WriteLine("it is null");
}
else
{
    Console.WriteLine("it is not");
}

// a better version of the above achieved by using is keyword
// if(objects[0] is Employee) ...

if (objects[1] is >= 10) { 
    // can use s instead
}

