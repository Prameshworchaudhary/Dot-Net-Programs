using System;

namespace AnonymousFunction
{
    public class Program
    {
        public delegate double MyDelegate(double p1, double p2);
        public static void Main(string[] args)
        {
            MyDelegate md1 = delegate (double a, double b)
            {
                return a + b;
            };
            Console.WriteLine(md1(5.5, 10.5));
            Console.WriteLine("\n lab no: 9.d");
            Console.WriteLine("prameshwor chaudhary");
            Console.WriteLine("roll no : 17");
        }
    }
}