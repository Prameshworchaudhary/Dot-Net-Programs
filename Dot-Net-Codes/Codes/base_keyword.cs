using System;

namespace base_keyword
{
    public class Animal
    {
        public string color = "white";

    }
    public class dog1 : Animal
    {
        public string color = "black";
        public void show_color()
        {
            Console.WriteLine("color of parent class= " + base.color);
            Console.WriteLine("COLOR OF child class = " + color);
        }

    }
    internal class testbase
    {
        static void Main(string[] args)
        {
            dog1 d = new dog1();
            d.show_color();
        }
    }
}