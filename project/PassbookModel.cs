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
        public static DataTable SelectallDespoit()
        {
            string _query = "SELECT * FROM " + tbl_incomes;
            return Database.SQLiteDatabase.GetDataTable(_query);
        }
        public static DataTable SelectallWithdraw()
        {
            string _query = "SELECT * FROM " + tbl_outcomes;
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
            	string _query = "SELECT * FROM " + tbl_types + " WHERE name =\"" +nameTypePassbook + "\"";
			return Database.SQLiteDatabase.GetDataTable(_query);
        }
        public static DataTable SelectAllWill (string id_wall )
        {
            string _query = "SELECT * FROM " + tbl_outcomes + " WHERE id =\"" + id_wall + "\"";
            return Database.SQLiteDatabase.GetDataTable(_query);
        }
        public static DataTable SelectTypePassbook()
        {
            string _query = "SELECT * FROM " + tbl_types;
            return Database.SQLiteDatabase.GetDataTable(_query);
        }
        public static DataTable SelectTypebyIDtype(string idtype)
        {
            string _query = "SELECT * FROM " + tbl_types + " WHERE type =\"" + idtype + "\"";
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
        public static bool InsertWithDraw(string passbook_id, string type, string total, string customerid, string date,string money_return)
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
        public static bool updateclosePassbook(string id_passbook, string close)
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
        public static bool InsertTypePassbook(string type, string name, string rate, string date)
        {

            Dictionary<string, string> _data = new Dictionary<string, string>();

            _data.Add("type", type);
            _data.Add("name", name);
            _data.Add("rate", rate);
            _data.Add("dateWithdrawal", date);
            return Database.SQLiteDatabase.Insert(tbl_types, _data);
        }
        public static bool UpdateTypePassbook(string type, string name, string rate, string date,string id)
        {
            string where = "id=\"" + id + "\" ";
            Dictionary<string, string> _data = new Dictionary<string, string>();

            _data.Add("type", type);
            _data.Add("name", name);
            _data.Add("rate", rate);
            _data.Add("dateWithdrawal", date);

            return Database.SQLiteDatabase.Update(tbl_types, _data, where);
        }
        
        public static bool  delete_typepassbook(string type_name)
        {
            string where = "name=\"" + type_name + "\" ";
            return Database.SQLiteDatabase.Delete(tbl_types, where);
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

           return  timngay(ngay1,ngay2,thang1,thang2,nam1,nam2);
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

        public  static int  LeapYear(int year)
        {
            if (year % 400 == 0)
                return 1;
            else if (year % 100 != 0 && year % 4 == 0)
                return 1;
            return 0;
        }


 
      public static  int timngay(int date1, int date2, int month1,int month2,int year1, int year2)
        {
            int dateOfYear=0,dateOfMonth=0, date=0;
 
            /* Tinh khoang cach so ngay giua 2 nam */
            for (int i=year1;i<year2;i++)
                if( LeapYear(i)==1) 
                    dateOfYear+=366;  //////
                else dateOfYear+=365;
 
            /* Tinh khoang cach so ngay giua 2 thang */
            int [] a={31,28,31,30,31,30,31,31,30,31,30,31};
            if ( LeapYear(year2)==1) 
                a[1]=29;           /////
            if (month1>month2)
            {
                for (int i=month2;i<month1;i++)
                    dateOfMonth-=a[i-1];
            }
            else
            {
                for (int i=month1;i<month2;i++)
                    dateOfMonth+=a[i-1];
            }
 
            /* Tinh khoang cach giua 2 ngay */
            date=date2-date1+1;       //Ket qua tinh ca ngay cuoi cung
 
            return dateOfYear + dateOfMonth + date;
            
        }
 
       

	}
}
