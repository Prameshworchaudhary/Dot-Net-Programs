using System;

namespace Enum
{
    enum level
    {
        low,
        medium,
        high
    }
    internal class program
    {
        static void Main(string[] args)
        {
            level var = level.medium;
            Console.WriteLine("level is " +(int)var);
            level l = level.high;
            Console.WriteLine("level is " + l);
        }
    }
}