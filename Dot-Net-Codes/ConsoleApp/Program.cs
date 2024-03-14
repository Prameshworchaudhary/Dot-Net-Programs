using System;

namespace interface_class
{
    interface animal
    {
        void animal_sound();
        void run();


    }

    class dog : animal
    {
        public void animal_sound()
        {
            Console.WriteLine("the dog sound baw wow");
        }
        public void run()
        {
            Console.WriteLine("dog is a animal");
        }

    }
    class cat : animal
    {
        public void animal_sound()
        {
            Console.WriteLine("the cat sound ");
        }
        public void run()
        {
            Console.WriteLine("cat is  animal");
        }

    }

    internal class program
    {
        static void Main(string[] args)
        {
            dog d1 = new dog();
            cat c1 = new cat();
            d1.animal_sound();
            d1.run();
            c1.animal_sound();
            c1.run();

            Console.WriteLine("\n lab no : 7.b");
            Console.WriteLine("prameshwor chaudhary");
            Console.WriteLine("roll no : 17");

        }
    }
}