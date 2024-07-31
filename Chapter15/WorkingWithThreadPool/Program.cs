using WorkingWithThreadPool;

Console.WriteLine($"Main Thread started. ThreadId = {Thread.CurrentThread.ManagedThreadId}");
Printer p = new();
for (int i = 0; i < 10; i++) {
   ThreadPool.QueueUserWorkItem(new WaitCallback((state) => ((Printer?)state)?.PrintNumbers()), p);
}

Console.WriteLine("All tasks queued");
Console.ReadLine();