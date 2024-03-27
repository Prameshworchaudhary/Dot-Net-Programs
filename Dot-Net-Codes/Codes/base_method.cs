using System;

namespace base_keyword
{
    public class Animal
    {
        public string color = "white";
        public void display()
        {
            Console.WriteLine("color of parent class= " + color);

        }

    }
    public class dog1 : Animal
    {
        public string color = "black";
        public void show_color()
        {
            base.display();
            Console.WriteLine("color of child class = " + color);
        }

    }
    internal class testbase
    {
        static void Main(string[] args)
        { 
            dog1 d = new dog1();
            d.show_color();
            Console.WriteLine("\nlab no: 5.b");
            Console.WriteLine("prameshwor chaudhary");
            Console.WriteLine("roll no : 17");

        }
    }
}