using System;

namespace generic_method
{
    public class add<T, Z>
    {
        public T data1;
        public Z data2;
        public void addition()
        {
            //dynamic a = x;
            //dynamic b = y;
            Console.WriteLine("sum is " + data1 + data2);
        }
    }
    internal class test_generic
    {
        static void Main(string[] args)
        {
            add<int, int> obj = new add<int, int>();
            obj.data1 = 5;
            obj.data2 = 4;
            obj.addition();
            //add<int,int> a1 = new add<int,int>();
            //a1.addition(5, 5);
            //add<double, double> a2 = new add<double, double>();
            //a2.addition(2.5, 2.512);

            Console.ReadLine();
        }
    }
}