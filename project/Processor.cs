using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassbookManagement
{
	public static class TblColumn
	{
		// Column index for table Customers
		public static readonly int A_ID = 0;
		public static readonly int A_NAME = 1;
		public static readonly int A_IDENTITY_NUMBER = 2;
		public static readonly int A_ADDRESS = 3;
		public static readonly int A_PHONE_NUMBER = 4;

		public static readonly string A_ID_S = "id";
		public static readonly string A_NAME_S = "name";
		public static readonly string A_IDENTITY_NUMBER_S = "identity_number";
		public static readonly string A_ADDRESS_S = "address";
		public static readonly string A_PHONE_NUMBER_S = "phone_number";


		// Column index for table Incomes
		public static readonly int D_ID = 0;
		public static readonly int D_PASSBOOK_ID = 1;
		public static readonly int D_CASH = 2;
		public static readonly int D_DATE_TIME = 3;

		public static readonly string D_ID_S = "id";
		public static readonly string D_PASSBOOK_ID_S = "passbook_id";
		public static readonly string D_CASH_S = "cash";
		public static readonly string D_DATE_TIME_S = "date_time";


		// Column index for table Outcomes
		public static readonly int W_ID = 0;
		public static readonly int W_PASSBOOK_ID = 1;
		public static readonly int W_CASH = 2;
		public static readonly int W_DATE_TIME = 3;

		public static readonly string W_ID_S = "id";
		public static readonly string W_PASSBOOK_ID_S = "passbook_id";
		public static readonly string W_CASH_S = "cash";
		public static readonly string W_DATE_TIME_S = "date_time";


		// Column index for table Passbooks
		public static readonly int P_ID = 0;
		public static readonly int P_PERIOD_ID = 1;
		public static readonly int P_CUSTOMER_ID = 2;
		public static readonly int P_CASH = 3;
		public static readonly int P_DATE_TIME = 4;
		public static readonly int P_CLOSE = 5;

		public static readonly string P_ID_S = "id";
		public static readonly string P_PERIOD_ID_S = "period_id";
		public static readonly string P_CUSTOMER_ID_S = "customer_id";
		public static readonly string P_CASH_S = "cash";
		public static readonly string P_DATE_TIME_S = "date_time";
		public static readonly string P_CLOSE_S = "Close";


		// Column index for table Periods
		public static readonly int T_ID = 0;
		public static readonly int T_NAME = 1;
		public static readonly int T_RATE = 2;
		public static readonly int T_PERIOD = 3;

		public static readonly string T_ID_S = "id";
		public static readonly string T_NAME_S = "name";
		public static readonly string T_RATE_S = "rate";
		public static readonly string T_PERIOD_S = "period";
	}

	public static class Params
	{
		public static ArrayList PARAMS = new ArrayList();

		public static readonly int MIN_CASH = 0;
		public static readonly int MIN_INCOME = 1;
	}

	public static class Processor
	{
		public static void ReadParams(string path)
		{
			var _filestream = new System.IO.FileStream(path,
										  System.IO.FileMode.Open,
										  System.IO.FileAccess.Read,
										  System.IO.FileShare.ReadWrite);
			var _file = new System.IO.StreamReader(_filestream, System.Text.Encoding.UTF8, true, 128);

			string _word = null;
			while ((_word = _file.ReadLine()) != null)
			{
				Params.PARAMS.Add(_word);
			}

			_file.Dispose();
			_filestream.Dispose();
		}

		public static int Compare(string num1, string num2)
		{
			return (Convert.ToDouble(num1) > Convert.ToDouble(num2)) ? 1 : 
						((Convert.ToDouble(num1) == Convert.ToDouble(num2)) ? 0 : -1);
		}

		public static double Add(string num1, string num2)
		{
			return Convert.ToDouble(num1) + Convert.ToDouble(num2);
		}

		public static double Sub(string num1, string num2)
		{
			return Convert.ToDouble(num1) - Convert.ToDouble(num2);
		}

		public static double Multi(string num1, string num2)
		{
			return Convert.ToDouble(num1) * Convert.ToDouble(num2);
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
