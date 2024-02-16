using System;

namespace Indexer
{
    class employee
    {
        int eid;
        string name;
        double salary;
        string department;

        public employee(int eid, string name, double salary, string department)
        {
            this.eid = eid;
            this.name = name;
            this.salary = salary;
            this.department = department;
        }
        public object this[int op]
        {
            get
            {
                if (op == 0)
                    return this.eid;
                else if (op == 1)
                    return this.name;
                else if (op == 2)
                    return this.salary;
                else if (op == 3)
                    return this.department;
                else
                    return "invalide";
            }
            set
            {
                if (op == 0)
                    this.eid = (int)value;
                else if (op == 1)
                    this.name = (string)value;
                else if (op == 2)
                    this.salary = (double)value;
                else if (op == 3)
                    this.department = (string)value;
                else
                    Console.WriteLine("invalide");

            }
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            employee emp1;
            emp1 = new employee(101, "hari parsad", 12000.22, "IT");
            Console.WriteLine("name = " + emp1[1]);
        }
    }
}
