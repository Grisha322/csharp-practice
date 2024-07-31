Console.WriteLine("Working with Timers");

Timer timer = new Timer(
    (_) => Console.WriteLine($"Time is {DateTime.Now}"),
    null,  // This argument is passed to the callback
    0, // time before first callback
    1000 // callback period
);
Console.WriteLine("Hit Enter to terminate...");
Console.ReadLine();
