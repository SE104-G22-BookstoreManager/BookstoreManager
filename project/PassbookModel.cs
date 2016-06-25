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
		public static readonly string tbl_periods = "Periods";
		public static readonly string tbl_parameter = "parameter";


		////////////////////////////////////////////////////////////////////
		// CustomerModel
		/// <summary>
		///     
		/// </summary>
		public static DataTable SelectCustomerByIdentityNumber(string identity_number)
		{
			string _query = "SELECT * FROM " + tbl_customers;
			_query += " WHERE " + TblColumn.A_IDENTITY_NUMBER_S + "=\"" + identity_number + "\"";

			return Database.SQLiteDatabase.GetDataTable(_query);
		}

		public static DataTable SelectCustomerById(string id)
		{
			string _query = "SELECT * FROM " + tbl_customers;
			_query += " WHERE " + TblColumn.A_ID_S + "=\"" + id + "\"";

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
			string _query = "SELECT * FROM " + tbl_passbooks;
			_query += " WHERE " + TblColumn.P_CUSTOMER_ID_S + "=\"" + customer_id + "\"";

			return Database.SQLiteDatabase.GetDataTable(_query);
		}

		public static DataTable SelectAllPassbooks()
		{
			string _query = "SELECT * FROM " + tbl_passbooks;
			return Database.SQLiteDatabase.GetDataTable(_query);
		}

		public static DataTable SelectPassbookById(string id)
		{
			string _query = "SELECT * FROM " + tbl_passbooks;
			_query += " WHERE " + TblColumn.P_ID_S + "=\"" + id + "\"";

			return Database.SQLiteDatabase.GetDataTable(_query);
		}

		public static bool InsertPassbook(string name, string period_id, string customer_id, string cash, string date_time, string status)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();

			_data.Add("name", name);
			_data.Add("period_id", period_id);
			_data.Add("customer_id", customer_id);
			_data.Add("cash", cash);
			_data.Add("date_time", date_time);
			_data.Add("status", status);

			return Database.SQLiteDatabase.Insert(tbl_passbooks, _data);
		}

		public static bool UpdateCashByPassbookId(string id, string cash)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();
			_data.Add("cash", cash);

			string where = TblColumn.P_ID_S + "=\"" + id + "\"";

			return Database.SQLiteDatabase.Update(tbl_passbooks, _data, where);
		}

		public static bool UpdateStatusByPassbookId(string id, string status)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();
			_data.Add("status", status);

			string where = TblColumn.P_ID_S + "=\"" + id + "\"";

			return Database.SQLiteDatabase.Update(tbl_passbooks, _data, where);
		}

		public static bool UpdateLastUpdateTimeByPassbookId(string id, string date_time)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();
			_data.Add("date_time", date_time);

			string where = TblColumn.P_ID_S + "=\"" + id + "\"";

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

		public static DataTable SelectAllIncomesByPeriodId(string period_id)
		{
			string _query = "SELECT * FROM " + tbl_incomes + " AS a JOIN " + tbl_passbooks + " AS b";
			_query += " ON " + "a." + TblColumn.D_PASSBOOK_ID_S + " = b." + TblColumn.P_ID_S;
			_query += " WHERE b." + TblColumn.P_PERIOD_ID_S + "=\"" + period_id + "\"";

			return Database.SQLiteDatabase.GetDataTable(_query);
		}

		public static bool InsertIncome(string passbook_id, string cash, string date_time)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();

			_data.Add("passbook_id", passbook_id);
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

		public static DataTable SelectAllOutcomesByPeriodId(string period_id)
		{
			string _query = "SELECT * FROM " + tbl_outcomes + " AS a JOIN " + tbl_passbooks + " AS b";
			_query += " ON " + "a." + TblColumn.D_PASSBOOK_ID_S + " = b." + TblColumn.P_ID_S;
			_query += " WHERE b." + TblColumn.P_PERIOD_ID_S + "=\"" + period_id + "\"";

			return Database.SQLiteDatabase.GetDataTable(_query);
		}

		public static bool InsertOutcome(string passbook_id, string cash, string date_time)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();

			_data.Add("passbook_id", passbook_id);

			_data.Add("cash", cash);
			_data.Add("date_time", date_time);

			return Database.SQLiteDatabase.Insert(tbl_outcomes, _data);
		}


		////////////////////////////////////////////////////////////////////
		// PeriodModel
		/// <summary>
		///     
		/// </summary>
		public static DataTable SelectPeriodByName(string name)
		{
			string _query = "SELECT * FROM " + tbl_periods;
			_query += " WHERE " + TblColumn.T_NAME_S + " =\"" + name + "\"";

			return Database.SQLiteDatabase.GetDataTable(_query);
		}

		public static DataTable SelectAllPeriod()
		{
			string _query = "SELECT * FROM " + tbl_periods;
			return Database.SQLiteDatabase.GetDataTable(_query);
		}

		public static DataTable SelectPeriodById(string id)
		{
			string _query = "SELECT * FROM " + tbl_periods;
			_query += " WHERE " + TblColumn.T_ID_S + " =\"" + id + "\"";

			return Database.SQLiteDatabase.GetDataTable(_query);
		}

		public static bool InsertPeriod(string name, string rate, string period)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();

			_data.Add("name", name);
			_data.Add("rate", rate);
			_data.Add("period", period);

			return Database.SQLiteDatabase.Insert(tbl_periods, _data);
		}

		public static bool UpdatePeriod(string id, string name, string rate, string period)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();

			_data.Add("name", name);
			_data.Add("rate", rate);
			_data.Add("period", period);

			string where = TblColumn.T_ID_S + "=\"" + id + "\"";

			return Database.SQLiteDatabase.Update(tbl_periods, _data, where);
		}

		public static bool DeletePeriodById(string id)
		{
			string where = TblColumn.T_ID_S + "=\"" + id + "\" ";
			return Database.SQLiteDatabase.Delete(tbl_periods, where);
		}


		////////////////////////////////////////////////////////////////////
		// XModel
		/// <summary>
		///     
		/// </summary>
		
		public static bool UpdateMinCash(string cash)
		{
			Params.PARAMS[Params.MIN_CASH] = cash;
			Processor.WriteParams("params.pro");

			return true;
		}

		public static bool UpdateMinIncome(string cash)
		{
			Params.PARAMS[Params.MIN_INCOME] = cash;
			Processor.WriteParams("params.pro");

			return true;
		}
	}
}
