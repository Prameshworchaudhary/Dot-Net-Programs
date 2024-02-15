using System;


namespace ncc_lab_prameshwor
{
    internal class else_if
    {
        static void Main(string[] args)
        {
            int x = 10, y = 20, z = 30;
            if (x > y)
            {
                Console.WriteLine("x is highest");
            }
            else if (x > z)
            {
                Console.WriteLine("x is highest");
            }
            else if (y > z)
            {
                Console.WriteLine("y is highest");
            }
            else
            {
                Console.WriteLine("z is highest");
            }
        }
    }
}
