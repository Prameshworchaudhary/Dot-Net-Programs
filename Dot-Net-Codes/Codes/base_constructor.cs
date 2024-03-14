using System;

namespace base_keyword
{
    public class Animal
    {
        public string color = "white";
        public Animal()
        {
            Console.WriteLine("color of parent class= " + color);

        }
        public Animal(string name)
        {
            string name2 = name;
            Console.WriteLine("name of dog : " + name);
        }

    }
    public class dog1 : Animal
    {
        public dog1() : base()
        {

        }
        public dog1(string name) : base(name)
        {

        }
    }
    internal class testbase
    {
        static void Main(string[] args)
        {
            dog1 d = new dog1();
            dog1 d1 = new dog1("tommy");

            Console.WriteLine("\nlab no: 5.c");
            Console.WriteLine("prameshwor chaudhary");
            Console.WriteLine("roll no : 17");

        }
    }
}