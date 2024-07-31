using SimpleMultiThreadApp;
using System.Threading;

Console.Write("Do you want [1] or [2] threads? ");
string threadCount = Console.ReadLine() ?? "1";

Thread primary = Thread.CurrentThread;
primary.Name = "PrimaryThread";
Printer p = new();

switch (threadCount) {
    case "2":
        Thread backgroundThread = new Thread(new ThreadStart(p.PrintNumbers));
        backgroundThread.Name = "Secondary";
        backgroundThread.Start();
        break;
    case "1":
        p.PrintNumbers();
        break;
    default:
        Console.WriteLine("I don't know what you want... you get 1 thread.");
        goto case "1";
}

Console.WriteLine("I'm busy...");
Console.ReadLine();
