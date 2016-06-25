using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
		public static readonly int P_NAME = 1;
		public static readonly int P_PERIOD_ID = 2;
		public static readonly int P_CUSTOMER_ID = 3;
		public static readonly int P_CASH = 4;
		public static readonly int P_DATE_TIME = 5;
		public static readonly int P_STATUS = 6;

		public static readonly string P_ID_S = "id";
		public static readonly string P_NAME_S = "name";
		public static readonly string P_PERIOD_ID_S = "period_id";
		public static readonly string P_CUSTOMER_ID_S = "customer_id";
		public static readonly string P_CASH_S = "cash";
		public static readonly string P_DATE_TIME_S = "date_time";
		public static readonly string P_CLOSE_S = "status";


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

		public static void WriteParams(string path)
		{
			var _writeStream = new System.IO.FileStream(path,
										  System.IO.FileMode.Create,
										  System.IO.FileAccess.Write,
										  System.IO.FileShare.ReadWrite);
			var _writer = new System.IO.StreamWriter(_writeStream, System.Text.Encoding.UTF8, 128);

			foreach (string _param in Params.PARAMS)
			{
				_writer.WriteLine(_param);
			}

			_writer.Dispose();
			_writeStream.Dispose();
		}

		public static int Compare(string num1, string num2)
		{
			return (Convert.ToDouble(num1) > Convert.ToDouble(num2)) ? 1 : 
						((Convert.ToDouble(num1) == Convert.ToDouble(num2)) ? 0 : -1);
		}

		public static string Add(string num1, string num2)
		{
			return (Convert.ToDouble(num1) + Convert.ToDouble(num2)).ToString();
		}

		public static string Sub(string num1, string num2)
		{
			return (Convert.ToDouble(num1) - Convert.ToDouble(num2)).ToString();
		}

		public static string Multi(string num1, string num2)
		{
			return (Convert.ToDouble(num1) * Convert.ToDouble(num2)).ToString();
		}

		public static string Div(string num1, string num2)
		{
			return (Convert.ToDouble(num1) / Convert.ToDouble(num2)).ToString();
		}

		public static int CountDay(int month, int year)
		{
			int[] a = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

			if (LeapYear(year) == 1)
				a[1] = 29;

			return a[month - 1];
		}

		public static int LeapYear(int year)
		{
			if (year % 400 == 0)
				return 1;

			if (year % 100 != 0 && year % 4 == 0)
				return 1;

			return 0;
		}

		public static double ConvertToDouble(string s)
		{
			char systemSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
			double result = 0;
			try
			{
				if (s != null)
					if (!s.Contains(","))
						result = double.Parse(s, CultureInfo.InvariantCulture);
					else
						result = Convert.ToDouble(s.Replace(".", systemSeparator.ToString()).Replace(",", systemSeparator.ToString()));
			}
			catch (Exception e)
			{
				MessageBox.Show("Wrong string-to-double format", "Notice");
			}

			return result;
		}
	}
}
