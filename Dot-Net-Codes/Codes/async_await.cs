using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Start");

        // Call the asynchronous method
        await DoSomeAsyncWork();

        Console.WriteLine("End");
    }

    static async Task DoSomeAsyncWork()
    {
        // Simulate an asynchronous operation that takes 2 seconds
        await Task.Delay(2000);

        // Print a message after the asynchronous operation completes
        Console.WriteLine("Async work completed!");

        Console.WriteLine("\n lab no 17");
        Console.WriteLine("prameshwor chaudhary");
        Console.WriteLine("roll no : 17");
    }
}










