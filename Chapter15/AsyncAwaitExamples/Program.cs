using System.Threading.Tasks;

DoWork();
Console.WriteLine("Doing Something else...");
Console.ReadLine();

static async void DoWork() {
    Console.WriteLine(await DoWorkAsync().ConfigureAwait(false));
}

static async Task<string> DoWorkAsync() {
    return await Task.Run(() => {
        Thread.Sleep(5000);
        return "Work is Done!";
    });
}

static async void MultipleJobsAsync() {
    var task1 = Task.Run(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("First task completed");
    });
    var task2 = Task.Run(() =>
    {
        Thread.Sleep(1000);
        Console.WriteLine("Second task completed");
    });
    var task3 = Task.Run(() =>
    {
        Thread.Sleep(1000);
        Console.WriteLine("Third task completed");
    });
    await Task.WhenAll(task1, task2, task3); // This awaits for all. WhenAny await for the first one to complete.
}