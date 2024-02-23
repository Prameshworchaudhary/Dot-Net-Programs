using System;
using static multi_delegate.delegate_multiple;

namespace multi_delegate
{
    class delegate_multiple
    {
        public delegate void Add_sub(int a, int b);

        public void show_sum(int a, int b)
        {
            Console.WriteLine("Addition of two number is {0}", a + b);
        }
        public void show_sub(int a, int b)
        {
            Console.WriteLine("subtraction of two number is {0}", a - b);
        }
    }
    internal class testdelegate
    {
        static void Main(string[] args)
        {
            delegate_multiple d1 = new delegate_multiple();
            //new Add_sub(d1.show_sum); or d1.show_sub; is same
            Add_sub a1 = new Add_sub(d1.show_sum);
            Add_sub s1 = d1.show_sub;
            Add_sub s = a1 + s1;

            s(20, 5); // or  s.Invoke(20, 5); same 
        }
    }
}