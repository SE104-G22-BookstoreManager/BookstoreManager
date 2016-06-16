using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PassbookManagement.src
{
	public partial class Passbook : MaterialForm
	{
		public Passbook()
		{
			InitializeComponent();

			Database.SQLiteDatabase = new SQLiteDatabase("passbook.s3db");

			var materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan500, Primary.Cyan600, Primary.Cyan300, Accent.LightBlue200, TextShade.WHITE);

			Processor.ReadParams("params.pro");

			GetPassbookPeriod();
		}


		////////////////////////////////////////////////////////////////////
		// Control for option
		/// <summary>
		///     
		/// </summary>
		private void btn_option_Click(object sender, EventArgs e)
		{
			context_option.Show(btn_option, new Point(0, btn_option.Height));
		}

		private void item_edit_condition_Click(object sender, EventArgs e)
		{
			var _editForm = new EditCondition();
			_editForm.Show();
		}

		private void item_setting_Click(object sender, EventArgs e)
		{

		}

		private void item_help_Click(object sender, EventArgs e)
		{

		}

		private void item_about_Click(object sender, EventArgs e)
		{

		}
		////////////////////////////////////////////////////////////////////


		////////////////////////////////////////////////////////////////////
		// Control for create passbook
		/// <summary>
		///     
		/// </summary>
		///
		private void btn_check_open_Click(object sender, EventArgs e)
		{
			if (txt_identity_number_open.Text == "")
			{
				MessageBox.Show("Please type identity number!!!");
				return;
			}

			DataTable _data = PassbookModel.SelectCustomerByIdentityNumber(txt_identity_number_open.Text);

			if (_data.Rows.Count == 0)
			{
				MessageBox.Show("Account not found. Please type all information to add new account!!!");
				return;
			}

			object[] _customer = _data.Rows[0].ItemArray;

			lbl_customer_id_open.Text		= _customer[TblColumn.A_ID].ToString();
			txt_name_open.Text				= _customer[TblColumn.A_NAME].ToString();
			txt_identity_number_open.Text	= _customer[TblColumn.A_IDENTITY_NUMBER].ToString();
			txt_address_open.Text			= _customer[TblColumn.A_ADDRESS].ToString();
			txt_phone_number_open.Text		= _customer[TblColumn.A_PHONE_NUMBER].ToString();

			txt_name_open.Enabled = false;
			txt_identity_number_open.Enabled = false;
			txt_address_open.Enabled = false;
			txt_phone_number_open.Enabled = false;
		}

		private void btn_submit_open_Click(object sender, EventArgs e)
		{
			if (txt_name_open.Text == "" ||
				txt_identity_number_open.Text == "" ||
				txt_address_open.Text == "" ||
				txt_phone_number_open.Text == "")
			{
				MessageBox.Show("All informations are required!!!");
				return;
			}

			DataTable _data = PassbookModel.SelectCustomerByIdentityNumber(txt_identity_number_open.Text);

			if (_data.Rows.Count != 0)
			{
				MessageBox.Show("Account is already exist!!!");
				return;
			}

			if (PassbookModel.InsertCustomer(txt_name_open.Text, txt_identity_number_open.Text, txt_address_open.Text, txt_phone_number_open.Text) == false)
			{
				MessageBox.Show("Something went wrong!!!");
				return;
			}

			DataTable _data1 = PassbookModel.SelectCustomerByIdentityNumber(txt_identity_number_open.Text);
			object[] _customer = _data1.Rows[0].ItemArray;

			lbl_customer_id_open.Text = _customer[TblColumn.A_ID].ToString();
			MessageBox.Show("Success.");

			txt_name_open.Enabled = false;
			txt_identity_number_open.Enabled = false;
			txt_address_open.Enabled = false;
			txt_phone_number_open.Enabled = false;
		}

		private void btn_create_open_Click(object sender, EventArgs e)
		{
			if (txt_name_open.Text == "" ||
				txt_identity_number_open.Text == "" ||
				txt_address_open.Text == "" ||
				txt_phone_number_open.Text == "" ||
				txt_cash_open.Text == "" ||
				cbb_period_open.Text == "")
			{
				MessageBox.Show("All informations are required!!!");
				return;
			}

			if (Convert.ToDouble(txt_cash_open.Text) < Convert.ToDouble(Params.PARAMS[Params.MIN_CASH].ToString()))
			{
				MessageBox.Show("Số tiền gửi quá ít, vui lòng kiểm tra lại");
				return;
			}

			DataTable _data = PassbookModel.SelectPeriodByName(cbb_period_open.Text);

			if(_data.Rows.Count == 0)
			{
				MessageBox.Show("Something went wrong!!!");
				return;
			}

			object[] _period = _data.Rows[0].ItemArray;

			string _periodId = _period[TblColumn.T_ID].ToString();
			DateTime _dateTime = calendar_open.SelectionEnd.Date;

			if (PassbookModel.InsertPassbook(_periodId, lbl_customer_id_open.Text, txt_cash_open.Text, _dateTime.ToString(), "true") == false)
			{
				MessageBox.Show("Something went wrong!!!");
				return;
			}

			MessageBox.Show("Success");
		}

		private void btn_refresh_open_Click(object sender, EventArgs e)
		{
			txt_name_open.Enabled = true;
			txt_identity_number_open.Enabled = true;
			txt_address_open.Enabled = true;
			txt_phone_number_open.Enabled = true;

			txt_name_open.Text = "";
			txt_identity_number_open.Text = "";
			txt_address_open.Text = "";
			txt_phone_number_open.Text = "";
			lbl_customer_id_open.Text = "ID";

			txt_cash_open.Text = "";
		}

		public void GetPassbookPeriod()
		{
			DataTable _result2 = PassbookModel.SelectAllPeriod();
			if (_result2.Rows.Count != 0)
			{
				for (int i = 0; i < _result2.Rows.Count; i++)
				{
					object[] _itemArray2 = _result2.Rows[i].ItemArray;
					cbb_period_open.Items.Add(_itemArray2[TblColumn.T_NAME].ToString());
					cbb_type_monthly.Items.Add(_itemArray2[TblColumn.T_NAME].ToString());
				}
			}
		}
		////////////////////////////////////////////////////////////////////


		////////////////////////////////////////////////////////////////////
		// Control for create lookup
		private void btn_refresh_lookup_Click(object sender, EventArgs e)
		{
			list_lookup.Items.Clear();

			DataTable _data = PassbookModel.SelectAllPassbooks();

			for (int i = 0; i < _data.Rows.Count; i++)
			{
				object[] _passbook = _data.Rows[i].ItemArray;

				ListViewItem _item = new ListViewItem((i + 1).ToString());


				// Set Passbook ID
				_item.SubItems.Add(_passbook[TblColumn.P_ID].ToString());


				// Set Period
				DataTable _data1 = PassbookModel.SelectPeriodById(_passbook[TblColumn.P_PERIOD_ID].ToString());
				if(_data1.Rows.Count == 0)
				{
					MessageBox.Show("Something went wrong!!!");
					return;
				}

				object[] _period = _data1.Rows[0].ItemArray;
				_item.SubItems.Add(_period[TblColumn.T_NAME].ToString());


				// Set Customer
				DataTable _data2 = PassbookModel.SelectCustomerById(_passbook[TblColumn.P_CUSTOMER_ID].ToString());
				if (_data2.Rows.Count == 0)
				{
					MessageBox.Show("Something went wrong!!!");
					return;
				}

				object[] _customer = _data2.Rows[0].ItemArray;
				_item.SubItems.Add(_customer[TblColumn.A_NAME].ToString());


				// Set balance
				_item.SubItems.Add(_passbook[TblColumn.P_CASH].ToString());

				list_lookup.Items.Add(_item);
			}
		}
		////////////////////////////////////////////////////////////////////

		
		////////////////////////////////////////////////////////////////////
		// Control for create deposit
		private void btn_check_deposit_Click(object sender, EventArgs e)
		{
			if (txt_identity_number_deposit.Text == "")
			{
				MessageBox.Show("Please type identity number!!!");
				return;
			}

			DataTable _data = PassbookModel.SelectCustomerByIdentityNumber(txt_identity_number_deposit.Text);

			if (_data.Rows.Count == 0)
			{
				MessageBox.Show("Account not found. Please go to passbook tab to add new account!!!");
				return;
			}

			object[] _customer = _data.Rows[0].ItemArray;

			lbl_customer_id_deposit.Text		= _customer[TblColumn.A_ID].ToString();
			txt_name_deposit.Text				= _customer[TblColumn.A_NAME].ToString();
			txt_identity_number_deposit.Text	= _customer[TblColumn.A_IDENTITY_NUMBER].ToString();
			txt_address_deposit.Text			= _customer[TblColumn.A_ADDRESS].ToString();
			txt_phone_number_deposit.Text		= _customer[TblColumn.A_PHONE_NUMBER].ToString();

			txt_name_deposit.Enabled = false;
			txt_identity_number_deposit.Enabled = false;
			txt_address_deposit.Enabled = false;
			txt_phone_number_deposit.Enabled = false;

			DataTable _data1 = PassbookModel.SelectPassbooksByCustomerId(lbl_customer_id_deposit.Text);

			for (int i = 0; i < _data1.Rows.Count; i++)
			{
				object[] _passbook = _data1.Rows[i].ItemArray;
				cbb_passbook_deposit.Items.Add(_passbook[TblColumn.P_ID].ToString() + ": " + _passbook[TblColumn.P_CASH].ToString());
			}
		}

		private void btn_create_deposit_Click(object sender, EventArgs e)
		{
			if (txt_name_deposit.Text == "" ||
				txt_identity_number_deposit.Text == "" ||
				txt_address_deposit.Text == "" ||
				txt_phone_number_deposit.Text == "" ||
				txt_cash_deposit.Text == "" ||
				cbb_passbook_deposit.Text == "")
			{
				MessageBox.Show("All informations are required!!!");
				return;
			}

			if (Processor.Compare(txt_cash_deposit.Text, Params.PARAMS[Params.MIN_INCOME].ToString()) < 0)
			{
				MessageBox.Show("Số tiền gửi thêm quá ít, vui lòng kiểm tra lại");
				return;
			}

			DateTime _dateTime = calendar_open.SelectionEnd.Date;
			string _passbookId = cbb_passbook_deposit.Text.Split(':')[0];

			if (PassbookModel.InsertIncome(_passbookId, txt_cash_deposit.Text, _dateTime.ToString()) == false)
			{
				MessageBox.Show("Something went wrong!!!");
				return;
			}

			DataTable _data = PassbookModel.SelectPassbookById(_passbookId);
			object[] _passbook = _data.Rows[0].ItemArray;

			double _cash = Processor.Add(txt_cash_deposit.Text, _passbook[TblColumn.P_CASH].ToString());
			PassbookModel.UpdateCashByPassbookId(_passbookId, _cash.ToString());

			PassbookModel.UpdateClosePassbookByPassbookId(cbb_passbook_deposit.Text, "true");

			MessageBox.Show("Success");
		}

		private void btn_refresh_deposit_Click(object sender, EventArgs e)
		{
			txt_name_deposit.Enabled = true;
			txt_identity_number_deposit.Enabled = true;
			txt_address_deposit.Enabled = true;
			txt_phone_number_deposit.Enabled = true;

			txt_name_deposit.Text = "";
			txt_identity_number_deposit.Text = "";
			txt_address_deposit.Text = "";
			txt_phone_number_deposit.Text = "";
			lbl_customer_id_deposit.Text = " ";

			txt_cash_deposit.Text = "";
		}
		////////////////////////////////////////////////////////////////////


		////////////////////////////////////////////////////////////////////
		// Control for create withdrawal
		private void btn_check_withdrawal_Click(object sender, EventArgs e)
		{
			if (txt_identity_number_withdrawal.Text == "")
			{
				MessageBox.Show("Please type identity number!!!");
				return;
			}

			DataTable _data = PassbookModel.SelectCustomerByIdentityNumber(txt_identity_number_withdrawal.Text);

			if (_data.Rows.Count == 0)
			{
				MessageBox.Show("Account not found. Please go to passbook tab to add new account!!!");
				return;
			}

			object[] _customer = _data.Rows[0].ItemArray;

			lbl_customer_id_withdrawal.Text		= _customer[TblColumn.A_ID].ToString();
			txt_name_withdrawal.Text			= _customer[TblColumn.A_NAME].ToString();
			txt_identity_number_withdrawal.Text = _customer[TblColumn.A_IDENTITY_NUMBER].ToString();
			txt_address_withdrawal.Text			= _customer[TblColumn.A_ADDRESS].ToString();
			txt_phone_number_withdrawal.Text	= _customer[TblColumn.A_PHONE_NUMBER].ToString();

			txt_name_withdrawal.Enabled = false;
			txt_identity_number_withdrawal.Enabled = false;
			txt_address_withdrawal.Enabled = false;
			txt_phone_number_withdrawal.Enabled = false;

			DataTable _data1 = PassbookModel.SelectPassbooksByCustomerId(lbl_customer_id_withdrawal.Text);

			for (int i = 0; i < _data1.Rows.Count; i++)
			{
				object[] _passbook = _data1.Rows[i].ItemArray;
				cbb_passbook_withdrawal.Items.Add(_passbook[TblColumn.P_ID].ToString() + ": " + _passbook[TblColumn.P_CASH].ToString());
			}
		}

		private void btn_create_withdrawal_Click(object sender, EventArgs e)
		{
			if (txt_name_withdrawal.Text == "" ||
				txt_identity_number_withdrawal.Text == "" ||
				txt_address_withdrawal.Text == "" ||
				txt_phone_number_withdrawal.Text == "" ||
				cbb_passbook_withdrawal.Text == "")
			{
				MessageBox.Show("All informations are required!!!");
				return;
			}

			string _passbookId = cbb_passbook_withdrawal.Text.Split(':')[0];
			DataTable _data = PassbookModel.SelectPassbookById(_passbookId);

			if(_data.Rows.Count == 0)
			{
				MessageBox.Show("Something went wrong!!!");
				return;
			}

			object[] _passbook = _data.Rows[0].ItemArray;

			DateTime _current = DateTime.Now;
			DateTime _opened = DateTime.Parse(_passbook[TblColumn.P_DATE_TIME].ToString());

			string _periodId = _passbook[TblColumn.P_PERIOD_ID].ToString();
			DataTable _data1 = PassbookModel.SelectPeriodById(_periodId);

			if(_data1.Rows.Count == 0)
			{
				MessageBox.Show("Something went wrong!!!");
				return;
			}

			object[] _period = _data1.Rows[0].ItemArray;

			if (Processor.Compare((_current - _opened).Days.ToString(), _period[TblColumn.T_PERIOD].ToString()) < 0)
			{
				MessageBox.Show("Chưa đến thời hạn rút tiền!!!");
				return;
			}

			string _rate = _period[TblColumn.T_RATE].ToString();
			string _cash = _passbook[TblColumn.P_CASH].ToString();

			string _withdrawal = "0";
			string _profit = (Processor.Multi(_cash, _rate) * (((_current - _opened).Days) / 30.0)).ToString();

			if (_periodId == "1")
			{
				if(txt_cash_withdrawal.Text == "")
				{
					MessageBox.Show("All informations are required!!!");
					return;
				}

				if(Processor.Compare(_cash, txt_cash_withdrawal.Text) < 0)
				{
					MessageBox.Show("Không đủ số tiền rút. Vui lòng kiểm tra lại!!!");
					return;
				}

				_withdrawal = txt_cash_withdrawal.Text;
				_cash = Processor.Sub(_cash, txt_cash_withdrawal.Text).ToString();
			}
			else
			{
				MessageBox.Show("Bạn rút hết tiền trong tài khoản");
				_withdrawal = _cash;
				_cash = "0";
			}

			string id_customer = _passbook[2].ToString();

			if (PassbookModel.InsertOutcome(_passbookId, txt_cash_withdrawal.Text, _current.ToString()) == false)
			{
				MessageBox.Show("Something went wrong!!!");
				return;
			}

			if (Processor.Compare(_cash, "0") == 0)
			{
				PassbookModel.UpdateClosePassbookByPassbookId(cbb_passbook_withdrawal.Text, "False");
			}

			PassbookModel.UpdateCashByPassbookId(_passbookId, _cash);
			PassbookModel.UpdateLastUpdateTimeByPassbookId(_passbookId, _current.ToString());
			MessageBox.Show("Success. Cash: " + _withdrawal + ", Profit: " + _profit);
		}

		private void btn_refresh_withdrawal_Click(object sender, EventArgs e)
		{
			txt_name_withdrawal.Enabled = true;
			txt_identity_number_withdrawal.Enabled = true;
			txt_address_withdrawal.Enabled = true;
			txt_phone_number_withdrawal.Enabled = true;

			txt_name_withdrawal.Text = "";
			txt_identity_number_withdrawal.Text = "";
			txt_address_withdrawal.Text = "";
			txt_phone_number_withdrawal.Text = "";
			lbl_customer_id_withdrawal.Text = " ";

			txt_cash_withdrawal.Text = "";
		}

		private void cbb_passbook_withdrawal_SelectedIndexChanged(object sender, EventArgs e)
		{
			string _passbookId = cbb_passbook_withdrawal.Text.Split(':')[0];

			DataTable _data = PassbookModel.SelectPassbookById(_passbookId);

			if(_data.Rows.Count == 0)
			{
				MessageBox.Show("Something went wrong!!!");
				return;
			}

			object[] _passbook = _data.Rows[0].ItemArray;

			if (_passbook[TblColumn.P_PERIOD_ID].ToString() == "1")
				txt_cash_withdrawal.Enabled = true;
			else
				txt_cash_withdrawal.Enabled = false;
		}
		////////////////////////////////////////////////////////////////////


		////////////////////////////////////////////////////////////////////
		// Control for create daily report
		private void btn_refresh_daily_Click(object sender, EventArgs e)
		{
			DateTime _dateTime = date_daily.Value;
			list_daily.Items.Clear();

			DataTable _data = PassbookModel.SelectAllPeriod();

			for(int i = 0; i < _data.Rows.Count; i++)
			{
				ListViewItem _item = new ListViewItem((i + 1).ToString());

				// Set period name
				object[] _period = _data.Rows[i].ItemArray;
				_item.SubItems.Add(_period[TblColumn.T_NAME].ToString());


				// Set income value
				string _income = "0";
				DataTable _data1 = PassbookModel.SelectAllIncomesByPeriodId(_period[TblColumn.T_ID].ToString());
				for(int j = 0; j < _data1.Rows.Count; j++)
				{
					object[] _row = _data1.Rows[j].ItemArray;
					DateTime _current = DateTime.Parse(_row[TblColumn.D_DATE_TIME].ToString());

					if (_dateTime.DayOfYear == _current.DayOfYear)
						_income = Processor.Add(_income, _row[TblColumn.D_CASH].ToString()).ToString();
				}
				_item.SubItems.Add(_income);


				// Set outcome value
				string _outcome = "0";
				DataTable _data2 = PassbookModel.SelectAllOutcomesByPeriodId(_period[TblColumn.T_ID].ToString());
				for (int j = 0; j < _data2.Rows.Count; j++)
				{
					object[] _row = _data2.Rows[j].ItemArray;
					DateTime _current = DateTime.Parse(_row[TblColumn.W_DATE_TIME].ToString());

					if (_dateTime.DayOfYear == _current.DayOfYear)
						_outcome = Processor.Add(_outcome, _row[TblColumn.W_CASH].ToString()).ToString();
				}
				_item.SubItems.Add(_outcome);


				// Set total value
				_item.SubItems.Add(Processor.Sub(_income, _outcome).ToString());


				list_daily.Items.Add(_item);
			}
		}
		////////////////////////////////////////////////////////////////////


		////////////////////////////////////////////////////////////////////
		// Control for create monthly report
		private void btn_refresh_monthly_Click(object sender, EventArgs e)
		{
			list_monthly.Items.Clear();

			DataTable query = PassbookModel.SelectPeriodByName(cbb_type_monthly.Text);
			object[] _itemArray1 = query.Rows[0].ItemArray;
			string type = _itemArray1[1].ToString();
			string date = date_monthly.Value.ToString();

			List<string> id_passbook = new List<string>();
			List<string> id_will = new List<string>();
			// Select passbook 
			DataTable query1 = PassbookModel.SelectAllOutcomes();
			DataTable query2 = PassbookModel.SelectAllPassbooks();
			for (int i = 0; i < query2.Rows.Count; i++)
			{
				Object[] array2 = query2.Rows[i].ItemArray;
				string type_passbook = array2[1].ToString();
				string id = array2[0].ToString();
				string date_passbook = array2[4].ToString();
				if (type == type_passbook && Processor.cut_month(date_passbook) == Processor.cut_month(date))
				{
					id_passbook.Add(date_passbook);
				}

			}
			for (int i = 0; i < query1.Rows.Count; i++)
			{
				Object[] array2 = query1.Rows[i].ItemArray;
				string type_passbook = array2[2].ToString();
				string id = array2[0].ToString();
				string date_passbook = array2[5].ToString();
				string return1 = array2[6].ToString();
				if (type == type_passbook && Processor.cut_month(date_passbook) == Processor.cut_month(date) && return1 == "0")
				{
					id_will.Add(date_passbook);

				}
			}
			int l = 0;
			for (int i = 0; i < id_passbook.Count; i++)
			{
				int cout_in = 1;
				int cout_out = 0;
				List<int> key = new List<int>();
				for (int j = i + 1; j < id_passbook.Count; j++)
				{
					if (Processor.cut_date(id_passbook[i]) == Processor.cut_date(id_passbook[j]))
					{
						cout_in = cout_in + 1;
						key.Add(j);

					}
				}


				List<int> key1 = new List<int>();
				for (int j = 0; j < id_will.Count; j++)
				{
					if (Processor.cut_date(id_passbook[i]) == Processor.cut_date(id_will[j]))
					{
						cout_out = cout_out + 1;
						key1.Add(j);
					}
				}
				int p_out = 0;

				for (int o = 0; o < key1.Count; o++)
				{
					if (p_out == 0)
					{
						id_will.Remove(id_will[key1[o]]);
						p_out++;
					}
					else
					{
						id_will.Remove(id_will[key1[o] - p_out]);
						p_out++;
					}

				}
				int p_in = 0;
				for (int o = 0; o < key.Count; o++)
				{

					if (p_in == 0)
					{
						id_passbook.Remove(id_passbook[key[o]]);
						p_in++;
					}
					else
					{
						id_passbook.Remove(id_passbook[key[o] - p_in]);
						p_in++;
					}
				}
				if (cout_in != 0 && cout_out != 0)
				{
					ListViewItem lvi = new ListViewItem(l.ToString());
					lvi.SubItems.Add(id_passbook[i].ToString());
					lvi.SubItems.Add(cout_in.ToString());
					lvi.SubItems.Add(cout_out.ToString());
					lvi.SubItems.Add((cout_in - cout_out).ToString());

					list_monthly.Items.Add(lvi);
					l++;
				}
				if (cout_in != 0 && cout_out == 0)
				{
					ListViewItem lvi = new ListViewItem(l.ToString());
					lvi.SubItems.Add(id_passbook[i].ToString());
					lvi.SubItems.Add(cout_in.ToString());
					lvi.SubItems.Add("0");
					lvi.SubItems.Add(cout_in.ToString());

					list_monthly.Items.Add(lvi);
					l++;
				}

			}

			for (int i = 0; i < id_will.Count; i++)
			{
				int cout = 0;
				for (int j = 0; j < id_will.Count; i++)
				{
					if (Processor.cut_date(id_will[i]) == Processor.cut_date(id_will[j]))
					{
						cout = cout + 1;
						ListViewItem lvi = new ListViewItem(l.ToString());
						lvi.SubItems.Add(id_passbook[i].ToString());
						lvi.SubItems.Add("0");
						lvi.SubItems.Add(cout.ToString());
						lvi.SubItems.Add((-cout).ToString());

						list_monthly.Items.Add(lvi);
						l++;
					}
				}
			}
		}
	}
}

