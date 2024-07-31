using System.Linq;
using System.Threading.Tasks;
using System.Threading;

CancellationTokenSource _cancellationToken = new();

Console.WriteLine("Processing...");
Task.Factory.StartNew(ProcessIntData);
Console.WriteLine("Enter Q to quit: ");
string answer = Console.ReadLine();

if (answer!.Equals("Q", StringComparison.OrdinalIgnoreCase)) { 
    _cancellationToken.Cancel();
}
Console.ReadLine();

void ProcessIntData()
{
    int[] source = Enumerable.Range(1, 10_000_000).ToArray();
    int[] modThreeIsZero = null;
    try
    {
        modThreeIsZero = 
            (
                from i in source.AsParallel().WithCancellation(_cancellationToken.Token)
                where i % 3 == 0
                orderby i descending
                select i
            ).ToArray();
        Console.WriteLine($"Found {modThreeIsZero.Length} numbers that match querry!");
    }
    catch (OperationCanceledException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
