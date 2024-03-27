 using System;

namespace IndexerIntValue
{
    class Student
    {
        private int _s_id;
        private string _name;
        private double _obtain_mark;

        public Student(int s_id, string name, double obtain_mark)
        {
            _s_id = s_id;
            _name = name;
            _obtain_mark = obtain_mark;
        }

        public object this[object number]
        {
            get
            {
                if (number == "id")
                {
                    return _s_id;
                }
                else if (number == "name")
                {
                    return _name;
                }
                else if (number == "mark")
                {
                    return _obtain_mark;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
            }
            set
            {
                if (number == "id")
                {
                    _s_id = (int)value;
                }
                else if (number == "name")
                {
                    _name = (string)value;
                }
                else if (number == "mark")
                {
                    _obtain_mark = (double)value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
            }
        }
    }

    class TestIndexer
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(500, "hari", 89.6);
            Console.WriteLine("Id of student: {0}\n Name: {1}\n Obtain Mark: {2}", s1["id"], s1["name"], s1["mark"]);
            s1["mark"] = 98.03;
            Console.WriteLine("update obtain mark : " + s1["mark"]);
            Console.WriteLine("\nlab no : 4.b");
            Console.WriteLine("prameshwor chaudhary");
            Console.WriteLine("roll no : 17");
        }
    }
}
