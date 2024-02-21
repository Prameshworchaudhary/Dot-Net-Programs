using System;
using static inheritence.program;

namespace inheritence
{
    class program
    {
        public class parent_class
        {
            public void display()
            {
                Console.WriteLine("i am from parent ");

            }
        }
        public class child_class : parent_class
        {

        }
    }
    internal class property
    {
        static void Main(string[] args)
        {
            child_class c1 = new child_class();
            c1.display();
        }
    }
}