using System;

namespace generic_method
{
    public class add
    {
        public void addition<T, Z>(T x, Z y)
        {
            dynamic a = x;
            dynamic b = y;
            Console.WriteLine("sum is {0}", a + b);
        }
    }
    internal class test_generic
    {
        static void Main(string[] args)
        {
            add a1 = new add();
            a1.addition<int, int>(5, 5);
            a1.addition<double, double>(2.5, 2.512);
            a1.addition<float, float>(5.5f, 5.5f);
            a1.addition<int, double>(5, 2.5);
            a1.addition<float, double>(5.2f, 2.5);
            a1.addition<string, double>("hello", 2.5);
            Console.ReadLine();
        }
    }
}