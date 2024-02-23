using System;
using static delegate_method.addition;

namespace delegate_method
{
	class addition
	{
		public delegate void addnum(int a, int b);
		public delegate void subnum(int a, int b);

		public void add(int a, int b)
		{
			Console.WriteLine("addition of two number is : {0}", a + b);
		}
		public void sub(int a, int b)
		{
			Console.WriteLine("subtraction of two number is : {0}", a - b);
		}
	}
	public class testdelegate
	{
		static void Main(string[] args)
		{
			addition a1 = new addition();
			addnum obj1 = new addnum(a1.add);
			subnum obj2 = new subnum(a1.sub);
			obj1(100, 20);
			obj2(150, 90);

		}
	}
}