using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassbookManagement
{
	public static class SDictionary
	{
		public static Dictionary<string, string> CreateCustomer(string name, string identity_number, string address, string phone_number)
		{
			Dictionary<string, string> _dict = new Dictionary<string, string>();

			_dict.Add("name", name);
			_dict.Add("identity_number", identity_number);
			_dict.Add("address", address);
			_dict.Add("phone_number", phone_number);

			return _dict;
		}

		public static Dictionary<string, string> CreatePassbook(string type_id, string customer_id, string cash, string date_time)
		{
			Dictionary<string, string> _dict = new Dictionary<string, string>();

			_dict.Add("type_id", type_id);
			_dict.Add("customer_id", customer_id);
			_dict.Add("cash", cash);
			_dict.Add("date_time", date_time);

			return _dict;
		}
	}
}
