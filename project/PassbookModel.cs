using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassbookManagement
{
	public static class PassbookModel
	{
		public static readonly string tbl_customers = "tbl_customers";
		public static readonly string tbl_passbooks = "tbl_passbooks";
		public static readonly string tbl_incomes	= "tbl_incomes";
		public static readonly string tbl_outcomes	= "tbl_outcomes";
		public static readonly string tbl_types		= "tbl_types";

		public static DataTable SelectCustomerByIdentityNumber(string identity_number)
		{
			string _query = "SELECT * FROM " + tbl_customers + " WHERE identity_number=\"" + identity_number + "\"";
			return Database.SQLiteDatabase.GetDataTable(_query);
		}

		public static bool InsertCustomer(string name, string identity_number, string address, string phone_number)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();

			_data.Add("name", name);
			_data.Add("identity_number", identity_number);
			_data.Add("address", address);
			_data.Add("phone_number", phone_number);

			return Database.SQLiteDatabase.Insert(tbl_customers, _data);
		}

		public static bool InsertPassbook(string type_id, string customer_id, string cash, string date_time)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();

			_data.Add("type_id", type_id);
			_data.Add("customer_id", customer_id);
			_data.Add("cash", cash);
			_data.Add("date_time", date_time);

			return Database.SQLiteDatabase.Insert(tbl_passbooks, _data);
		}
	}
}
