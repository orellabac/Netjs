using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	public class Program
	{
		static void Main(string[] args)
		{
		}

		[WebMap.ClientSide]
		public void goo()
		{
			Console.WriteLine("aa");
		}

		
		public void foo() { 
		}
	}
}
