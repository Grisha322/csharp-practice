using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Drawing;
using System.IO;
using System.Threading;

namespace DataParallelismWithForEach
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CancellationTokenSource? _cancelToken = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object? Sender, EventArgs args) { 
            _cancelToken.Cancel();
        }
        private void cmdProcess_Click(object? Sender, EventArgs args) {
            Task.Factory.StartNew(ProcessFiles);
        }

        private async void cmdProcess_ClickWithAsyncAwait(object? Sender, EventArgs args) {
            _cancelToken = new();
            var basePath = Directory.GetCurrentDirectory();
            var pictureDirectory = Path.Combine(basePath, "test_pics");
            var outputDirectory = Path.Combine(basePath, "output");

            if (Directory.Exists(outputDirectory))
            {
                Directory.Delete(outputDirectory, true);
            }
            Directory.CreateDirectory(outputDirectory);

            string[] files = Directory.GetFiles(pictureDirectory, "*.JPG", SearchOption.AllDirectories);

            // try catch can be here
            try {
                foreach (string file in files) {
                    //try catach can be here
                    // this is async work, the main thread is not locked.
                    await ProcessFilesAsync(file, outputDirectory, _cancelToken.Token);
                }
            }
            catch (OperationCanceledException ex) {
                Console.WriteLine(ex);
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
            _cancelToken = null;
            this.Title = "Processing complete!";
        }

        private async Task ProcessFilesAsync(string currentFile, string outputDirectory, CancellationToken token) {
            string fileName = Path.GetFileName(currentFile);
            using (Bitmap bitmap = new Bitmap(fileName))
            {
                // try catch can be here
                await Task.Run(() => {
                    Dispatcher?.Invoke(() => {
                        this.Title = $"Processing {fileName}";
                    });
                    bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    bitmap.Save(Path.Combine(outputDirectory, fileName));
                }, token);
            };
        }

        private void ProcessFiles() {
            _cancelToken = new();
            ParallelOptions parallelOptions = new ParallelOptions();
            parallelOptions.CancellationToken = _cancelToken.Token;
            parallelOptions.MaxDegreeOfParallelism = Environment.ProcessorCount;
            var basePath = Directory.GetCurrentDirectory();
            var pictureDirectory = Path.Combine(basePath, "test_pics");
            var outputDirectory = Path.Combine(basePath, "output");

            if (Directory.Exists(outputDirectory)) { 
                Directory.Delete(outputDirectory, true);
            }
            Directory.CreateDirectory(outputDirectory);

            string[] files = Directory.GetFiles(pictureDirectory, "*.JPG", SearchOption.AllDirectories);

            try
            {
                Parallel.ForEach(files, parallelOptions, (currentFile) =>
                {
                    string fileName = Path.GetFileName(currentFile);

                    // this line here causes an error, when in the parallel for each
                    //this.Title = $"Processing {fileName} on thread {Thread.CurrentThread.ManagedThreadId}";

                    Dispatcher?.Invoke(() => this.Title = $"Processing {fileName}");

                    using (Bitmap bitmap = new Bitmap(currentFile))
                    {
                        bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        bitmap.Save(Path.Combine(outputDirectory, fileName));
                    };
                });
                Dispatcher?.Invoke(() => this.Title = "All done");
            }
            catch (OperationCanceledException ex) {
                Dispatcher?.Invoke(() => this.Title = ex.Message);
            }
            _cancelToken = null;
        }
    }
}
