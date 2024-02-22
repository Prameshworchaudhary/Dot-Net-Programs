using System;
namespace class_abstract
{
    abstract class shape
    {
        public abstract void draw();
    }
    class rectangle : shape
    {
        public override void draw()
        {
            Console.WriteLine("draw rectangle");
        }
    }
    class circle : shape
    {
        public override void draw()
        {
            Console.WriteLine("draw circle");
        }
    }
    class testabstract
    {
        static void Main(string[] args)
        {
            shape s;
            s = new rectangle();
            s.draw();
            s = new circle();
            s.draw();
        }
    }
}