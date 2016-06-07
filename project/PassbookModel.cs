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
		public static readonly string tbl_customers = "Customers";
		public static readonly string tbl_passbooks = "Passbooks";
		public static readonly string tbl_incomes = "Incomes";
		public static readonly string tbl_outcomes = "Outcomes";
		public static readonly string tbl_types = "Types";
		public static readonly string tbl_reportdate = "Report_Date";
		public static readonly string tbl_reportmonth = "Report_Month";
		public static readonly string tbl_parameter = "parameter";


		////////////////////////////////////////////////////////////////////
		// CustomerModel
		/// <summary>
		///     
		/// </summary>
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


		////////////////////////////////////////////////////////////////////
		// PassbookModel
		/// <summary>
		///     
		/// </summary>
		public static DataTable SelectPassbooksByCustomerId(string customer_id)
		{
			string _query = "SELECT * FROM " + tbl_passbooks + " WHERE customer_id=\"" + customer_id + "\"";
			return Database.SQLiteDatabase.GetDataTable(_query);
		}

		public static DataTable SelectAllPassbooks()
		{
			string _query = "SELECT * FROM " + tbl_passbooks;
			return Database.SQLiteDatabase.GetDataTable(_query);
		}

		public static DataTable SelectPassbookById(string id)
		{
			string _query = "SELECT * FROM " + tbl_passbooks + " WHERE id=\"" + id + "\"";
			return Database.SQLiteDatabase.GetDataTable(_query);
		}

		public static bool InsertPassbook(string type_id, string customer_id, string cash, string date_time, string Open)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();

			_data.Add("type_id", type_id);
			_data.Add("customer_id", customer_id);
			_data.Add("cash", cash);
			_data.Add("date_time", date_time);
			_data.Add("Close", Open);
			return Database.SQLiteDatabase.Insert(tbl_passbooks, _data);
		}

		public static bool UpdateCashByPassbookId(string id, string cash)
		{
			string where = "id=\"" + id + "\" ";
			Dictionary<string, string> _data = new Dictionary<string, string>();

			_data.Add("cash", cash);

			return Database.SQLiteDatabase.Update(tbl_passbooks, _data, where);
		}


		////////////////////////////////////////////////////////////////////
		// IncomeModel
		/// <summary>
		///     
		/// </summary>
		public static DataTable SelectAllIncomes()
		{
			string _query = "SELECT * FROM " + tbl_incomes;
			return Database.SQLiteDatabase.GetDataTable(_query);
		}

		public static bool InsertIncome(string passbook_id, string customer_id, string cash, string date_time)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();

			_data.Add("passbook_id", passbook_id);
			_data.Add("customer_id", customer_id);
			_data.Add("cash", cash);
			_data.Add("date_time", date_time);

			return Database.SQLiteDatabase.Insert(tbl_incomes, _data);
		}


		////////////////////////////////////////////////////////////////////
		// OutcomeModel
		/// <summary>
		///     
		/// </summary>
		public static DataTable SelectAllOutcomes()
		{
			string _query = "SELECT * FROM " + tbl_outcomes;
			return Database.SQLiteDatabase.GetDataTable(_query);
		}

		public static bool InsertOutcome(string passbook_id, string type, string total, string customerid, string date, string money_return)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();

			_data.Add("passbook_id", passbook_id);
			_data.Add("type", type);
			_data.Add("total", total);
			_data.Add("customer_id", customerid);
			_data.Add("date_time", date);
			_data.Add("cash_return", money_return);

			return Database.SQLiteDatabase.Insert(tbl_outcomes, _data);
		}


		////////////////////////////////////////////////////////////////////
		// PeriodModel
		/// <summary>
		///     
		/// </summary>
		public static DataTable SelectPeriodByName(string name)
		{
			string _query = "SELECT * FROM " + tbl_types + " WHERE name =\"" + name + "\"";
			return Database.SQLiteDatabase.GetDataTable(_query);
		}

		public static DataTable SelectAllPeriod()
		{
			string _query = "SELECT * FROM " + tbl_types;
			return Database.SQLiteDatabase.GetDataTable(_query);
		}

		public static DataTable SelectPeriodById(string type)
		{
			string _query = "SELECT * FROM " + tbl_types + " WHERE type =\"" + type + "\"";
			return Database.SQLiteDatabase.GetDataTable(_query);
		}

		public static bool InsertPeriod(string type, string name, string rate, string date)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();

			_data.Add("type", type);
			_data.Add("name", name);
			_data.Add("rate", rate);
			_data.Add("dateWithdrawal", date);
			return Database.SQLiteDatabase.Insert(tbl_types, _data);
		}

		public static bool UpdatePeriod(string id, string type, string name, string rate, string date)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();

			_data.Add("type", type);
			_data.Add("name", name);
			_data.Add("rate", rate);
			_data.Add("dateWithdrawal", date);

			string _condition = "id=\"" + id + "\" ";
			return Database.SQLiteDatabase.Update(tbl_types, _data, _condition);
		}

		public static bool DeletePeriod(string name)
		{
			string _condition = "name=\"" + name + "\" ";
			return Database.SQLiteDatabase.Delete(tbl_types, _condition);
		}


		////////////////////////////////////////////////////////////////////
		// XModel
		/// <summary>
		///     
		/// </summary>
		public static DataTable SelectAllConfig()
		{
			string _query = "SELECT * FROM " + tbl_parameter;
			return Database.SQLiteDatabase.GetDataTable(_query);
		}



		

		

		

		

		

		public static bool UpdateClosePassbookByPassbookId(string id_passbook, string close)
		{
			string where = "id=\"" + id_passbook + "\" ";
			Dictionary<string, string> _data = new Dictionary<string, string>();

			_data.Add("Close", close);

			return Database.SQLiteDatabase.Update(tbl_passbooks, _data, where);
		}

		public static bool updatemoneymin(string money)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();

			_data.Add("Min_Deposit", money);
			//string where = "";
			return Database.SQLiteDatabase.Update1(tbl_parameter, _data);
		}

		public static bool updateMoneyMinMore(string money)
		{

			Dictionary<string, string> _data = new Dictionary<string, string>();
			_data.Add("Min_DepositMore", money);
			return Database.SQLiteDatabase.Update1(tbl_parameter, _data);
		}
	}
}
