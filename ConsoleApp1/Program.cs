using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			A obj = new B();
			A obj2 = new C();
			Console.WriteLine(obj.Method());
			Console.WriteLine(obj2.Method());
			Console.ReadLine();
		}
    }


	class A
	{
		public virtual string Method()
		{
			return "A";
		}
	}

	class B : A
	{
		public override string Method()
		{
			return "B";
		}
	}

	class C : A
	{
		public new string Method()
		{
			return "C";
		}
	}
}
