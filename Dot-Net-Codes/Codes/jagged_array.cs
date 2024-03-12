using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaration of a jagged array
        int[][] jaggedArray = new int[3][];

        // Initialize the elements of the jagged array
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        // Accessing and displaying elements of the jagged array
        Console.WriteLine("Elements of the jagged array:");

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.Write("Row {0}: ", i);
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nLab no 3");
        Console.WriteLine("prameshwor chaudhary");
        Console.WriteLine("roll no : 17");

        Console.ReadLine();
    }
}
