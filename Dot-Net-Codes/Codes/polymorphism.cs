using System;

namespace polymorphism
{
    class animal
    {
        public virtual void animal_sound()
        {
            Console.WriteLine("sound of animal.");
        }
    }
    class pig : animal
    {
        public override void animal_sound()
        {
            Console.WriteLine("the pig says: wee wee");
        }
    }
    class dog : animal
    {
        public override void animal_sound()
        {
            Console.WriteLine("the dog say: baw wow ");
        }
    }

    internal class class_polymmorphism
    {
        static void Main(string[] args)
        {

            animal my_pig = new pig();
            dog my_dog = new dog();

            my_pig.animal_sound();
            my_dog.animal_sound();
            Console.WriteLine("\nlab no 6.b");
            Console.WriteLine("prameshwor chaudhary");
            Console.WriteLine("roll no : 17");


        }
    }
}