using System;

namespace struct_method
{
    public struct bike
    {
        public int price;
        public string model;
        public string bike_name;

        public bike(int p, string m, string b_name)
        {
            price = p;
            model = m;
            bike_name = b_name;
        }
        public void show_display()
        {
            Console.WriteLine("price of bike : " + price);
            Console.WriteLine("model of bike : " + model);
            Console.WriteLine("bike name of bike : " + bike_name);
        }

    }
    internal class teststruct
    {
        static void Main(string[] args)
        {
            bike s = new bike(150000, "bmw", "fz");
            s.show_display();
            bike b1;
            b1.price = 15000;
            b1.model = "bajaj";
            b1.bike_name = "hero ";
            b1.show_display();




        }
    }
}