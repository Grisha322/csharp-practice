using System.Linq;

QueryOverInts();
QueryStrings();
NonLazyExecution();
QueryOverStringsWithExtentionMethods();

static void QueryOverInts()
{
    int[] ints = {10, 20, 30, 40, 6, 5, 8, 9 };

    // Linq uses lazy execution
    var subset = from i in ints where i < 10 select i;

    foreach (var i in subset) {
        Console.WriteLine($"{i} < 10");
    }

    ints[0] = 4;

    foreach (var i in subset)
    {
        Console.WriteLine($"{i} < 10");
    }
}

static void NonLazyExecution() { 
    int[] ints = {10, 20, 30, 40, 6, 5, 8, 9 };

    // This will execute linq immediately, providing only current snapshot of data
    int number = (from i in ints where i < 10 select i).First();
    int number2 = (from i in ints where i < 10 select i).Single();
    int[] subset = (from i in ints where i < 10 select i).ToArray<int>();

}

static void QueryStrings() {
    string[] games = {"fallout 2", "some game", "justGame", "skyrim 2" };

    IEnumerable<string> subset = 
        from g in games 
        where g.Contains(' ') 
        orderby g 
        select g;

    ReflectOverQueryResults(subset);

    foreach (string s in subset) {
        Console.WriteLine($"Item: {s}");
    }
}

static void QueryOverStringsWithExtentionMethods() { 
    string[] games = {"fallout 2", "some game", "justGame", "skyrim 2" };

    // best to use var for type in case of Linq
    IEnumerable<string> subset = 
        games.Where(g => g.Contains(' ')).
        OrderBy(g => g).
        Select(g => g);

    ReflectOverQueryResults(subset);

    foreach (string s in subset) {
        Console.WriteLine($"Item: {s}");
    }
}

static void ReflectOverQueryResults(object resultSet, string queryType = "Query Expressions") {
    Console.WriteLine($"Info about your query using {queryType}");
    Console.WriteLine($"resultSet is of type: {resultSet.GetType().Name}");
    Console.WriteLine($"resultSet location: {resultSet.GetType().Assembly.GetName().Name}");
}
