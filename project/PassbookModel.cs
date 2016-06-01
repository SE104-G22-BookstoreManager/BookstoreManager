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
		public static readonly string tbl_incomes	= "Incomes";
        public static readonly string tbl_outcomes = "Outcomes";
		public static readonly string tbl_types		= "Types";
        public static readonly string tbl_reportdate = "Report_Date";
        public static readonly string tbl_reportmonth = "Report_Month";
        public static readonly string tbl_parameter = "parameter";

		public static DataTable SelectCustomerByIdentityNumber(string identity_number)
		{
			string _query = "SELECT * FROM " + tbl_customers + " WHERE identity_number=\"" + identity_number + "\"";
			return Database.SQLiteDatabase.GetDataTable(_query);
		}
        public static DataTable SelectPassbooksbyIdcustomer(string id_customer)
        {
            string _query = "SELECT * FROM " + tbl_passbooks + " WHERE customer_id=\"" + id_customer + "\"";
            return Database.SQLiteDatabase.GetDataTable(_query);
        }
        public static DataTable SelectallPassbooks()
        {
            string _query = "SELECT * FROM " + tbl_passbooks;
            return Database.SQLiteDatabase.GetDataTable(_query);
        }
        public static DataTable SelectMinMoney()
        {
            string _query = "SELECT * FROM " + tbl_parameter;
            return Database.SQLiteDatabase.GetDataTable(_query);
        }
        public static DataTable SelectpassbookbyIDpassbook(string id_passbook)
        {
            string _query = "SELECT * FROM " + tbl_passbooks + " WHERE id=\"" + id_passbook+ "\"";
            return Database.SQLiteDatabase.GetDataTable(_query);
        }
      
        public static DataTable SelectIdTypePassbook(string nameTypePassbook)
        {
            	string _query = "SELECT type FROM " + tbl_types + " WHERE name =\"" +nameTypePassbook + "\"";
			return Database.SQLiteDatabase.GetDataTable(_query);
        }
        public static DataTable SelectTypePassbook()
        {
            string _query = "SELECT * FROM " + tbl_types;
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
        public static bool InsertIncomes(string passbook_id, string customer_id, string cash , string date_time)
        {
            Dictionary<string, string> _data = new Dictionary<string, string>();

            _data.Add("passbook_id", passbook_id);
            _data.Add("customer_id", customer_id);
            _data.Add("cash", cash);
            _data.Add("date_time", date_time);
            return Database.SQLiteDatabase.Insert(tbl_incomes, _data);
        }
        public static bool  updatemoneyPassbook(string id_passbook, string money)
        {
            string where = "id=\"" + id_passbook + "\" ";
            Dictionary<string, string> _data = new Dictionary<string, string>();

            _data.Add("cash", money);

            return Database.SQLiteDatabase.Update(tbl_passbooks, _data, where);

        }
	}
}
