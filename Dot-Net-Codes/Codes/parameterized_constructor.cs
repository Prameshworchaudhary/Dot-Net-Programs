
using System;

namespace Parameterized_Constructor
{
    class Car
    {
        public string model;

        // Create a class constructor with a parameter
        public Car(string modelName)
        {
            model = modelName;
        }

        static void Main(string[] args)
        {
            Car Ford = new Car("tesla");
            Console.WriteLine(Ford.model);
            Console.WriteLine("lab no : 1.b");
            Console.WriteLine("name : prameshwor chaudhary");
            Console.WriteLine("roll no : 17");
        }
    }
}