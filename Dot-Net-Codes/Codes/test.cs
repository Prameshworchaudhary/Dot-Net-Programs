using System;

namespace ncc_lab_prameshwor
{
    class box
    {
        public static int count;
        double length,breadth,height;
        //constructor
        public box()
        {
            length = 5.5;
            breadth = 4.6;
            height = 3.6;
            count++;
        }
        public box(double length, double breadth, double height)
        {
            this.length = length;
            this.breadth = breadth;
            this.height = height;
            count++;
        }
        public void setdimension(double l, double b, double h)
        {
            length = l;
            breadth = b;
            height = h;
        }
        public void display()
        {
            Console.WriteLine("length= " + length + " breadth = " + breadth + " height = " + height);
        }
        public static void showcount()
        {
            Console.WriteLine("no . of object created= " + box.count);
        }

    }
     class test
    {
        static void Main(string[] args)
        {
            box.showcount();
            box box1 = new box();
            box box2 = new box(34.5, 35.5, 36.5);
            box1.display();
            box1.setdimension(11.5, 12.5, 13.5);
            box1.display();
            box2.display();
            box.showcount();
           
        }
    }
}
