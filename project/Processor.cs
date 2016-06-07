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

		public static int count_datetime(string date1, string date2)
		{
			string[] arrListStr1 = date1.Split(new char[] { ' ' });
			string date_1 = arrListStr1[0];
			string[] month1 = arrListStr1[0].Split(new char[] { '/' });

			string[] arrListStr2 = date2.Split(new char[] { ' ' });
			string date_2 = arrListStr2[0];
			string[] month2 = arrListStr2[0].Split(new char[] { '/' });
			int thang1 = Convert.ToInt16(month1[0]);
			int thang2 = Convert.ToInt16(month2[0]);
			int ngay1 = Convert.ToInt16(month1[1]);
			int ngay2 = Convert.ToInt16(month2[1]);
			int nam1 = Convert.ToInt16(month1[2]);
			int nam2 = Convert.ToInt16(month2[2]);

			return timngay(ngay1, ngay2, thang1, thang2, nam1, nam2);
		}

		public static string cut_month(string ngay)
		{
			string[] arrListStr = ngay.Split(new char[] { ' ' });
			string date_1 = arrListStr[0];
			string[] month = arrListStr[0].Split(new char[] { '/' });

			return month[0];
		}

		public static string cut_date(string date)
		{
			string[] arrListStr = date.Split(new char[] { ' ' });
			string date_1 = arrListStr[0];
			return date_1;
		}

		public static int LeapYear(int year)
		{
			if (year % 400 == 0)
				return 1;
			else if (year % 100 != 0 && year % 4 == 0)
				return 1;
			return 0;
		}

		public static int timngay(int date1, int date2, int month1, int month2, int year1, int year2)
		{
			int dateOfYear = 0, dateOfMonth = 0, date = 0;

			/* Tinh khoang cach so ngay giua 2 nam */
			for (int i = year1; i < year2; i++)
				if (LeapYear(i) == 1)
					dateOfYear += 366;  //////
				else dateOfYear += 365;

			/* Tinh khoang cach so ngay giua 2 thang */
			int[] a = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
			if (LeapYear(year2) == 1)
				a[1] = 29;           /////
			if (month1 > month2)
			{
				for (int i = month2; i < month1; i++)
					dateOfMonth -= a[i - 1];
			}
			else
			{
				for (int i = month1; i < month2; i++)
					dateOfMonth += a[i - 1];
			}

			/* Tinh khoang cach giua 2 ngay */
			date = date2 - date1 + 1;       //Ket qua tinh ca ngay cuoi cung

			return dateOfYear + dateOfMonth + date;

		}
	}
}
