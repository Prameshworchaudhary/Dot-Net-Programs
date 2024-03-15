
using System;
using System.IO;
namespace file_handle
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text to write to the file:");

            string input = Console.ReadLine(); // Read input from the keyboard
            string fileName = "output.txt"; // File name

            try
            {
                File.WriteAllText(fileName, input); // Write input to file
                Console.WriteLine($"Text successfully written to {fileName}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.WriteLine("\nLab No.: 12");
            Console.WriteLine("Name: prameshwor chaudhary");
            Console.WriteLine("Roll No.: 17");
            Console.ReadLine();
        }
    }
}















