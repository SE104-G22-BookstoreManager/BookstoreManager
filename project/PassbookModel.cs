using System.Collections.Generic;
using System.Data;

namespace PassbookManagement
{
	public static class PassbookModel
	{
		public static readonly string tbl_customers = "Customers";
		public static readonly string tbl_passbooks = "Passbooks";
		public static readonly string tbl_incomes = "Incomes";
		public static readonly string tbl_outcomes = "Outcomes";
		public static readonly string tbl_periods = "Periods";
		public static readonly string tbl_staffs = "Staffs";


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

		public static DataTable SelectCustomerByPhoneNumber(string phone_number)
		{
			string _query = "SELECT * FROM " + tbl_customers;
			_query += " WHERE " + TblColumn.A_PHONE_NUMBER_S + "=\"" + phone_number + "\"";

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

            _data.Add(TblColumn.A_NAME_S, name);
            _data.Add(TblColumn.A_IDENTITY_NUMBER_S, identity_number);
            _data.Add(TblColumn.A_ADDRESS_S, address);
            _data.Add(TblColumn.A_PHONE_NUMBER_S, phone_number);

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

		public static bool InsertPassbook(string name, string period_id, string customer_id, string staff_id, string cash, string date_time, string status)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();

            _data.Add(TblColumn.P_NAME_S, name);
            _data.Add(TblColumn.P_PERIOD_ID_S, period_id);
            _data.Add(TblColumn.P_CUSTOMER_ID_S, customer_id);
			_data.Add(TblColumn.P_STAFF_ID_S, staff_id);
			_data.Add(TblColumn.P_CASH_S, cash);
            _data.Add(TblColumn.P_DATE_TIME_S, date_time);
            _data.Add(TblColumn.P_STATUS_S, status);

			return Database.SQLiteDatabase.Insert(tbl_passbooks, _data);
		}

		public static bool UpdateCashByPassbookId(string id, string cash)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();
            _data.Add(TblColumn.P_CASH_S, cash);

			string where = TblColumn.P_ID_S + "=\"" + id + "\"";

			return Database.SQLiteDatabase.Update(tbl_passbooks, _data, where);
		}

		public static bool UpdateStatusByPassbookId(string id, string status)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();
            _data.Add(TblColumn.P_STATUS_S, status);

			string where = TblColumn.P_ID_S + "=\"" + id + "\"";

			return Database.SQLiteDatabase.Update(tbl_passbooks, _data, where);
		}

		public static bool UpdateLastUpdateTimeByPassbookId(string id, string date_time)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();
            _data.Add(TblColumn.P_DATE_TIME_S, date_time);

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

		public static bool InsertIncome(string passbook_id, string staff_id, string cash, string date_time)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();

            _data.Add(TblColumn.D_PASSBOOK_ID_S, passbook_id);
			_data.Add(TblColumn.D_STAFF_ID_S, staff_id);
			_data.Add(TblColumn.D_CASH_S, cash);
            _data.Add(TblColumn.D_DATE_TIME_S, date_time);

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
			_query += " ON " + "a." + TblColumn.W_PASSBOOK_ID_S + " = b." + TblColumn.P_ID_S;
			_query += " WHERE b." + TblColumn.P_PERIOD_ID_S + "=\"" + period_id + "\"";

			return Database.SQLiteDatabase.GetDataTable(_query);
		}

		public static bool InsertOutcome(string passbook_id, string staff_id, string cash, string date_time)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();

            _data.Add(TblColumn.W_PASSBOOK_ID_S, passbook_id);
			_data.Add(TblColumn.W_STAFF_ID_S, passbook_id);
			_data.Add(TblColumn.W_CASH_S, cash);
            _data.Add(TblColumn.W_DATE_TIME_S, date_time);

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

            _data.Add(TblColumn.T_NAME_S, name);
            _data.Add(TblColumn.T_RATE_S, rate);
            _data.Add(TblColumn.T_PERIOD_S, period);

			return Database.SQLiteDatabase.Insert(tbl_periods, _data);
		}

		public static bool UpdatePeriod(string id, string name, string rate, string period)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();

            _data.Add(TblColumn.T_NAME_S, name);
            _data.Add(TblColumn.T_RATE_S, rate);
            _data.Add(TblColumn.T_PERIOD_S, period);

            string where = TblColumn.T_ID_S + "=\"" + id + "\"";

			return Database.SQLiteDatabase.Update(tbl_periods, _data, where);
		}

		public static bool DeletePeriodById(string id)
		{
			string where = TblColumn.T_ID_S + "=\"" + id + "\" ";
			return Database.SQLiteDatabase.Delete(tbl_periods, where);
		}


		////////////////////////////////////////////////////////////////////
		// StaffModel
		/// <summary>
		///     
		/// </summary>
		/// 
		public static DataTable SelectAllStaff()
		{
			string _query = "SELECT * FROM " + tbl_staffs;
			return Database.SQLiteDatabase.GetDataTable(_query);
		}

		public static DataTable SelectStaffByEmailAndPassword(string email, string password)
		{
			string _query = "SELECT * FROM " + tbl_staffs;
			_query += " WHERE " + TblColumn.S_EMAIL_S + "=\"" + email + "\" AND " + TblColumn.S_PASSWORD_S + "=\"" + password + "\"";

			return Database.SQLiteDatabase.GetDataTable(_query);
		}

		public static DataTable SelectStaffByEmail(string email)
		{
			string _query = "SELECT * FROM " + tbl_staffs;
			_query += " WHERE " + TblColumn.S_EMAIL_S + "=\"" + email + "\"";

			return Database.SQLiteDatabase.GetDataTable(_query);
		}

		public static bool UpdateStaff(string id, string name, string email, string identity_number, string phone_number)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();

			_data.Add(TblColumn.S_NAME_S, name);
			_data.Add(TblColumn.S_EMAIL_S, email);
			_data.Add(TblColumn.S_IDENTITY_NUMBER_S, identity_number);
			_data.Add(TblColumn.S_PHONE_NUMBER_S, phone_number);

			string where = TblColumn.S_ID_S + "=\"" + id + "\"";

			return Database.SQLiteDatabase.Update(tbl_staffs, _data, where);
		}

		public static bool UpdatePasswordByStaffId(string id, string password)
		{
			Dictionary<string, string> _data = new Dictionary<string, string>();
			_data.Add(TblColumn.S_PASSWORD_S, password);

			string where = TblColumn.S_ID_S + "=\"" + id + "\"";

			return Database.SQLiteDatabase.Update(tbl_staffs, _data, where);
		}

		////////////////////////////////////////////////////////////////////
		// XModel
		/// <summary>
		///     
		/// </summary>

		public static bool UpdateMinCash(string cash)
		{
			Params.PARAMS[Params.MIN_CASH] = cash;
			Processor.WriteParams(Processor.PARAMS_FILE);

			return true;
		}

		public static bool UpdateMinIncome(string cash)
		{
			Params.PARAMS[Params.MIN_INCOME] = cash;
			Processor.WriteParams(Processor.PARAMS_FILE);

			return true;
		}
	}
}
