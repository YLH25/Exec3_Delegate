using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Delegate
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List <int> list = new List<int>{1,2,3,4,5,6,7};
			
			List<int> source1= new List<int>();

			Func<int, bool> func = list1 => list1 % 2 == 0;

			source1 = GetEvenItems(list, func);
			foreach (var item in source1)
			{
				Console.WriteLine(item);
			}
		}
		public static List<int> GetEvenItems(List<int> source, Func<int, bool>func)
		{ 
			List<int> result = new List<int>();

			foreach (var i in source)
			{
				if (i % 2 == 0)
				{
					result.Add(i);	
				}
			}
			return result;
		}
	}
}
