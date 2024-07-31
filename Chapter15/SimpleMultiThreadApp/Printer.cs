using System;
using System.Threading;

namespace SimpleMultiThreadApp
{
    public class Printer
    {
        public void PrintNumbers() { // No synchronization provided. May cause problems! Refer to working with thread pool for a better solution
            Console.WriteLine($"-> {Thread.CurrentThread.Name} is executing print numbers");

            Console.Write("Your numbers: ");
            for (int i = 0; i < 10; i++) {
                Console.Write("{0} ", i);
                Thread.Sleep(500);
            }
            Console.WriteLine();
        }   
    }
}
