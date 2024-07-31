using System;
using System.Threading;

namespace WorkingWithThreadPool
{
    public class Printer
    {
        private object threadLock = new();
        public void PrintNumbers() {
            lock (threadLock) {
                Console.WriteLine($"-> {Thread.CurrentThread.Name} is executing print numbers");

                Console.Write("Your numbers: ");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("{0} ", i);
                    Thread.Sleep(500);
                }
                Console.WriteLine();
            }
        }   
    }
}
