using System;
namespace default_constructor
{
    class def_const
    {
        int num;
        string name;

        def_const()
        {
            Console.WriteLine("constructor called ");
        }

        public static void Main()
        {
            def_const obj = new def_const();
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.num);
        }
    }

}