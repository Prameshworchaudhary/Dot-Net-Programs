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
                if (number == 0)
                {
                    return _s_id;
                }
                else if (number == 1)
                {
                    return _name;
                }
                else if (number == 2)
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
                if (number == 0)
                {
                    _s_id = (int)value;
                }
                else if (number == 1)
                {
                    _name = (string)value;
                }
                else if (number == 2)
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
            Student s1 = new Student(100, "Gopal", 85.6);
            Console.WriteLine("Id of student: {0}\n Name: {1}\n Obtain Mark: {2}", s1[0], s1[1], s1[2]);
            s1[2] = 95.75;
            Console.WriteLine("update obtain mark : " + s1[2]);
            Console.WriteLine("\nlab no : 4.a");
            Console.WriteLine("prameshwor chaudhary");
            Console.WriteLine("roll no : 17");
        }
    }
}
