using System;


namespace ncc_lab_prameshwor
{
    internal class for_loops
    {
        static void Main(string[] args)
        {
            //sum of natural number
            int n;
            int sum = 0;
            Console.Write("Enter the positive interger: ");
            n=int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                sum =sum + i;
            }
            Console.WriteLine("sum = " +sum);

        }
    }
}
