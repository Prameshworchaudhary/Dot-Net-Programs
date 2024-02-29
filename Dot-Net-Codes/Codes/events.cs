using System;

namespace events_handel
{
    public delegate void test_point();
    public class process
    {
        public event test_point mouse;

        public void show_display()
        {
            Console.WriteLine("start button");
            onmouse();
        }
        protected virtual void onmouse()
        {
            mouse?.Invoke();
        }

    }
    internal class testevents
    {
        static void Main(string[] args)
        {
            process p1 = new process();
            p1.mouse += p_process1;
            p1.show_display();
        }
        static void p_process1()
        {
            Console.WriteLine("events handel");
        }
    }
}