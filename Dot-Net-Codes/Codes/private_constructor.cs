using System;

namespace PrivateConstructor
{
    public class Animal
    {
        public string name;
        public string sound;
        // Writing this much only is enough to only allow this class to create object
        // Not even the child class can use this class to create objects
        private Animal() { }
        public Animal(string name, string sound)
        {
            this.name = name;
            this.sound = sound;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            //Animal dog = new Animal();			// This is not allowed due to private constructor

            Animal dog = new Animal("tommy", "Bhow bhow");
            Console.WriteLine(dog.name);
            Console.WriteLine(dog.sound);

            Console.WriteLine("\n lab no : 1.e");
            Console.WriteLine("prameshwor chaudhary");
            Console.WriteLine("roll no : 17");
        }
    }
}