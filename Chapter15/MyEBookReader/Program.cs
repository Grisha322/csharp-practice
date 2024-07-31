using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Net;
using System.Text;

string EBook = "";
GetBook();

Console.WriteLine("Downloading...");
Console.ReadLine();

void GetBook() {
    WebClient wc = new();

    wc.DownloadStringCompleted += (s, args) => { 
        EBook = args.Result;
        Console.WriteLine("Download completed.");
        GetStats();
    };

    // Загрузить электронную книгу Чарльза Диккенса "A Tale of Two Cities".
    // Может понадобиться двукратное выполнение этого кода, если ранее вы
    // н е посещали данный сайт, поскольку при первом его посещении появляется
    // окно с сообщением, предотвращающее нормальное выполнение кода.
    wc.DownloadStringAsync(new Uri("https://www.gutenberg.org/files/98/98-0.txt"));
}

void GetStats() {
    string[] words = EBook.Split(new char[] { ' ', '\u000A', ',', '.', ';', ':', '-', '?', '/'}, StringSplitOptions.RemoveEmptyEntries);
    string[] tenMostCommon = null;
    string longestWord = string.Empty;
    Parallel.Invoke(
        () => tenMostCommon = FindTenMostCommon(words),
        () => longestWord = FindLongestWord(words)
    );

    StringBuilder bookStats = new StringBuilder("Ten Most common words are: \n");
    foreach (string s in tenMostCommon!) { 
        bookStats.AppendLine(s);
    }
  
    bookStats.Append($"Longest word: {longestWord}");
    bookStats.AppendLine();
    Console.WriteLine(bookStats.ToString(), "Book info");
}

string[] FindTenMostCommon(string[] words) { 
    var frequencyOrder = from word in words
                         where word.Length > 6
                         group word by word into g
                         orderby g.Count() descending
                         select g.Key;

    return (frequencyOrder.Take(10).ToArray());
}

string FindLongestWord(string[] words) {
    return (from word in words orderby word.Length descending select word).FirstOrDefault() ?? "";
}