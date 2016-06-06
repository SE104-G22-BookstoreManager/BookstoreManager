using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassbookManagement
{
	public static class Processor
	{
		public static int Compare(string num1, string num2)
		{
			return (Convert.ToDouble(num1) > Convert.ToDouble(num2)) ? 1 : 
						((Convert.ToDouble(num1) == Convert.ToDouble(num2)) ? 0 : -1);
		}

		public static double Add(string num1, string num2)
		{
			return Convert.ToDouble(num1) + Convert.ToDouble(num2);
		}
	}
}
