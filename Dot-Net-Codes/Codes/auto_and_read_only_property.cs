using System;
namespace demo_property
{
    class Program
    {
        class Rectangle
        {
            // Auto-implemented property
            public double Length { get; set; }

            // Auto-implemented read-only property
            public double Width { get; }

            // Constructor to initialize read-only property
            public Rectangle(double length, double width)
            {
                Length = length;
                Width = width;
            }

            // Method to calculate area
            public double CalculateArea()
            {
                return Length * Width;
            }
        }

        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5.5, 3.0);

            Console.WriteLine("Length: " + rectangle.Length);
            Console.WriteLine("Width: " + rectangle.Width);
            Console.WriteLine("Area: " + rectangle.CalculateArea());
            Console.WriteLine("\nlab no 2");
            Console.WriteLine("prameshwor chaudhary");
            Console.WriteLine("Roll no : 17");

            Console.ReadLine();
        }
    }
}
