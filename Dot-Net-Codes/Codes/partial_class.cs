using System;

namespace partial_class
{
    public partial class user
    {
        private string name;
        private string location;
        public user(string a, string b)
        {
            this.name = a;
            this.location = b;
        }
    }
    public partial class user
    {
        public void userdetails()
        {
            Console.WriteLine("name = " + name);
            Console.WriteLine("location = " + location);
        }
    }
    internal class test_partial
    {
        static void Main(string[] args)
        {
            user u1 = new user("hari", "kathmandu");
            u1.userdetails();

        }
    }
}