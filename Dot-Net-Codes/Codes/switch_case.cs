using System;

namespace ncc_lab_prameshwor
{
    internal class switch_case
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("enter the two values: ");
            x = int.Parse(Console.ReadLine()); 
            y=int.Parse(Console.ReadLine());
            Console.WriteLine("operation\n");
            Console.WriteLine("1=addition\n2=subtraction\n3=multiplication\n4=division\n");
            Console.WriteLine("operation\n");
            Console.Write("enter the operation code: ");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("add = " + (x + y));
                    break;
                case 2:
                    Console.WriteLine("sub = " + (x - y));
                    break;
                case 3:
                    Console.WriteLine("mul = " + (x * y));
                    break;
                case 4:
                    Console.WriteLine("div = " + (x / y));
                    break;
                default:
                    Console.WriteLine("wrong choice");
                    break;

            }
        }

    }
}
