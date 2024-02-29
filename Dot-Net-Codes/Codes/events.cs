using System;

namespace generic_method
{
    public class operation
    {
        public void addition<T,Z>(T a,Z b)
        {
            dynamic x = a;
            dynamic y = b;
            Console.WriteLine("sum is ", x + y);

        }
    }
    internal class test_generic
    {
        static void Main(string[] args)
        {

        }
    }
}
