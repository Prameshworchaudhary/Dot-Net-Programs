using System;
namespace methods
{
    public class method1
    {
        static int square(int i)
        {
            int number = i;
            return number * number;
        }
        static void Main(string[] args)
        {
            int num = 4;
            int productA = square(num);
            int productB = square(12);
            int productC = square(productA * 3);
            Console.WriteLine("productA = " + productA);
            Console.WriteLine("productB = " + productB);
            Console.WriteLine("productC = " + productC);
        }
    }
}