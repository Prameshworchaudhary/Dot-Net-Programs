using System;


namespace ncc_lab_prameshwor
{
    class even
    {
        public even()
        {
            double[] array = new double[30];
        }
       public void display()
        {
            for (int i = 0; i < 20;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("a[" + i + "] =" + i);
                }
            }
        }


    }
    

    internal class array
    {
        static void Main(string[] args)
        {
            even e1 = new even();
            e1.display();
        }
    }
}
