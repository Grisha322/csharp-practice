// See https://aka.ms/new-console-template for more information
using CustomGenericMethodsd;

Console.WriteLine("Hello, World!");

void Swap<T>(ref T a, ref T b) {
    (b, a) = (a, b);
}