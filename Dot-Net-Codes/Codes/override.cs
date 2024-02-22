using System;

namespace method_override
{
    public class father
    {
        public virtual void marriage()
        {
            Console.WriteLine("arrange marriage");
        }
    }
    public class son : father
    {
        public override void marriage()
        {
            Console.WriteLine("love marriage");
        }
    }
    public class daughter : father
    {
        public override void marriage()
        {
            Console.WriteLine("court marriage");
        }
    }
    public class testoverride
    {
        static void Main(string[] args)
        {
            son s = new son();
            s.marriage();
            daughter d = new daughter();
            d.marriage();
        }
    }
}