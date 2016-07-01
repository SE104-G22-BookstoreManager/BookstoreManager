using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassbookManagement
{
	public static class IMessage
	{
		// MESSAGE
		public static readonly string MSG_SOMETHING_WENT_WRONG = "Something went wrong!!!";

		// CAPTION
		public static readonly string CPT_NOTICE = "Notice";
	}

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
		public static readonly string P_STATUS_S = "status";


		// Column index for table Periods
		public static readonly int T_ID = 0;
		public static readonly int T_NAME = 1;
		public static readonly int T_RATE = 2;
		public static readonly int T_PERIOD = 3;

		public static readonly string T_ID_S = "id";
		public static readonly string T_NAME_S = "name";
		public static readonly string T_RATE_S = "rate";
		public static readonly string T_PERIOD_S = "period";


		// Column index for table Staffs
		public static readonly int S_ID = 0;
		public static readonly int S_NAME = 1;
		public static readonly int S_EMAIL = 2;
		public static readonly int S_PASSWORD = 3;
		public static readonly int S_ROLES = 4;
		public static readonly int S_IDENTITY_NUMBER = 5;
		public static readonly int S_PHONE_NUMBER = 6;

		public static readonly string S_ID_S = "id";
		public static readonly string S_NAME_S = "name";
		public static readonly string S_EMAIL_S = "email";
		public static readonly string S_PASSWORD_S = "password";
		public static readonly string S_ROLES_S = "roles";
		public static readonly string S_IDENTITY_NUMBER_S = "identity_number";
		public static readonly string S_PHONE_NUMBER_S = "phone_number";
	}

	public static class Params
	{
		public static ArrayList PARAMS = new ArrayList();
		public static ArrayList CURRENT_SESSION = new ArrayList();

		public static readonly int MIN_CASH = 0;
		public static readonly int MIN_INCOME = 1;

		public static readonly int USERNAME = 2;
		public static readonly int PASSWORD = 3;

		public static readonly int CURRENT_EMAIL = 0;
		public static readonly int CURRENT_PASSWORD = 1;
		public static readonly int CURRENT_USERNAME = 2;
		public static readonly int CURRENT_ROLES = 3;


		public static void ReadFromObject(JsonObject o)
		{
			PARAMS.Add(o.MIN_CASH);
			PARAMS.Add(o.MIN_INCOME);
			PARAMS.Add(o.USERNAME);
			PARAMS.Add(o.PASSWORD);
		}

		public static JsonObject CreateObject()
		{
			JsonObject o = new JsonObject();

			if(PARAMS[MIN_CASH] != null)
				o.MIN_CASH = PARAMS[MIN_CASH].ToString();
			if (PARAMS[MIN_INCOME] != null)
				o.MIN_INCOME = PARAMS[MIN_INCOME].ToString();
			if (PARAMS[USERNAME] != null)
				o.USERNAME = PARAMS[USERNAME].ToString();
			if (PARAMS[PASSWORD] != null)
				o.PASSWORD = PARAMS[PASSWORD].ToString();

			return o;
		}
	}

	public class JsonObject
	{
		public string MIN_CASH;
		public string MIN_INCOME;
		
		public string USERNAME;
		public string PASSWORD;
	}

	public static class Roles
	{
		public static readonly int ROLE_MANAGER = 1;
		public static readonly int ROLE_STAFF = 2;
	}

	public static class Processor
	{
		public static readonly string PARAMS_FILE = "params.pro";
		public static readonly string HASH_KEY = "C0d3F0rF4n!";
		public static readonly double UNIDENTIFIED = double.Epsilon;

		public static void ReadParams(string path)
		{
			var _filestream = new System.IO.FileStream(path,
										  System.IO.FileMode.Open,
										  System.IO.FileAccess.Read,
										  System.IO.FileShare.ReadWrite);
			var _reader = new System.IO.StreamReader(_filestream, System.Text.Encoding.UTF8, true, 128);

			string _json = StringCipher.Decrypt(_reader.ReadToEnd(), HASH_KEY);
			JsonObject o = JsonConvert.DeserializeObject<JsonObject>(_json);

			Params.ReadFromObject(o);

			_reader.Dispose();
			_filestream.Dispose();
		}

		public static void WriteParams(string path)
		{
			var _fileStream = new System.IO.FileStream(path,
										  System.IO.FileMode.Create,
										  System.IO.FileAccess.Write,
										  System.IO.FileShare.ReadWrite);
			var _writer = new System.IO.StreamWriter(_fileStream, System.Text.Encoding.UTF8, 128);

			JsonObject o = Params.CreateObject();
			string _json = JsonConvert.SerializeObject(o);

			_writer.Write(StringCipher.Encrypt(_json, HASH_KEY));

			_writer.Dispose();
			_fileStream.Dispose();
		}

		public static void EncryptedDatabase(string source, string dest)
		{
			var _readStream = new System.IO.FileStream(source,
										  System.IO.FileMode.Open,
										  System.IO.FileAccess.Read,
										  System.IO.FileShare.ReadWrite);
			var _reader = new System.IO.StreamReader(_readStream, System.Text.Encoding.UTF8, true, 128);

			string _data = _reader.ReadToEnd();

			_reader.Dispose();
			_readStream.Dispose();


			var _writeStream = new System.IO.FileStream(dest,
										  System.IO.FileMode.Create,
										  System.IO.FileAccess.Write,
										  System.IO.FileShare.ReadWrite);
			var _writer = new System.IO.StreamWriter(_writeStream, System.Text.Encoding.UTF8, 128);

			_writer.Write(StringCipher.Encrypt(_data, HASH_KEY));

			_writer.Dispose();
			_writeStream.Dispose();
		}

		public static void DecryptedDatabase(string source, string dest)
		{
			var _readStream = new System.IO.FileStream(source,
										  System.IO.FileMode.Open,
										  System.IO.FileAccess.Read,
										  System.IO.FileShare.ReadWrite);
			var _reader = new System.IO.StreamReader(_readStream, System.Text.Encoding.UTF8, true, 128);

			string _data = StringCipher.Decrypt(_reader.ReadToEnd(), HASH_KEY);

			_reader.Dispose();
			_readStream.Dispose();


			var _writeStream = new System.IO.FileStream(dest,
										  System.IO.FileMode.Create,
										  System.IO.FileAccess.Write,
										  System.IO.FileShare.ReadWrite);
			var _writer = new System.IO.StreamWriter(_writeStream, System.Text.Encoding.UTF8, 128);

			_writer.Write(_data);

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
				return UNIDENTIFIED;
			}

			return result;
		}

		public static string GetMd5Hash(MD5 md5Hash, string input)
		{
			// Convert the input string to a byte array and compute the hash.
			byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

			// Create a new Stringbuilder to collect the bytes
			// and create a string.
			StringBuilder sBuilder = new StringBuilder();

			// Loop through each byte of the hashed data 
			// and format each one as a hexadecimal string.
			for (int i = 0; i < data.Length; i++)
			{
				sBuilder.Append(data[i].ToString("x2"));
			}

			// Return the hexadecimal string.
			return sBuilder.ToString();
		}

		// Verify a hash against a string.
		public static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
		{
			// Hash the input.
			string hashOfInput = GetMd5Hash(md5Hash, input);

			// Create a StringComparer an compare the hashes.
			StringComparer comparer = StringComparer.OrdinalIgnoreCase;

			if (0 == comparer.Compare(hashOfInput, hash))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
