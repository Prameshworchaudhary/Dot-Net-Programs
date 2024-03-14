using System;

namespace abstract_class
{
    abstract class animal
    {
        public abstract void animal_sound();

        public void display()
        {
            Console.WriteLine("sound of the animal ");
        }
    }

    class dog : animal
    {
        public override void animal_sound()
        {
            Console.WriteLine("the dog barks");
        }

    }

    internal class program
    {
        static void Main(string[] args)
        {
            dog d1 = new dog();
            d1.animal_sound();
            d1.display();

            Console.WriteLine("\n lab no : 7.a");
            Console.WriteLine("prameshwor chaudhary");
            Console.WriteLine("roll n: 17");

        }
    }
}