// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");


int[] prices = { 68, 735, 101, 770, 525, 279, 559, 563, 465,
                106, 146, 82, 28, 362, 492, 596, 743, 28, 637,
                392, 205, 703, 154, 293, 383, 622, 317, 519,
                696, 648, 127, 372, 339, 270, 713, 68, 700, 236, 295, 704, 612, 123 };

int[] arr = new int[100000];
for (int i = 0; i < 100000; i++)
{
    arr[i] = i + 1; 
}
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
Console.WriteLine(AdvancedDS.Stack.StockSpairProblem.calculateSpan(arr, 100000));
stopwatch.Stop();
Console.WriteLine("StockSpairProblem.calculateSpan :: ElapsedMilliseconds :: {0}", stopwatch.ElapsedMilliseconds);
