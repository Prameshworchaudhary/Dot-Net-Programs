using System;
namespace default_constructor
{
    class def_const
    {
        int roll_num;
        string name;

        def_const()
        {
            Console.WriteLine("default constructor called ");
            Console.WriteLine("Lab no : 1.a");
            name = "prameshwor chaudhary";
            roll_num = 17;
        }

        public static void Main()
        {
            def_const obj = new def_const();
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.roll_num);
        }
    }

}