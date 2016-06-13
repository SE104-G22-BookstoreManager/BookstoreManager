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

namespace PassbookManagement.src
{
	public partial class Passbook : MaterialForm
	{
		public Passbook()
		{
			InitializeComponent();

			Database.SQLiteDatabase = new SQLiteDatabase("../../project/data/passbook.s3db");

			var materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan500, Primary.Cyan600, Primary.Cyan300, Accent.LightBlue200, TextShade.WHITE);
			GetPassbookPeriodType();
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
			lbl_customer_id_open.Text = _customer[0].ToString();

			txt_name_open.Text = _customer[1].ToString();
			txt_identity_number_open.Text = _customer[2].ToString();
			txt_address_open.Text = _customer[3].ToString();
			txt_phone_number_open.Text = _customer[4].ToString();

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

			_data = PassbookModel.SelectCustomerByIdentityNumber(txt_identity_number_open.Text);
			object[] _items_1 = _data.Rows[0].ItemArray;
			lbl_customer_id_open.Text = _items_1[0].ToString();
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

			DataTable _data = PassbookModel.SelectAllConfig();
			object[] _params = _data.Rows[0].ItemArray;

			if (Convert.ToDouble(txt_cash_open.Text) < Convert.ToDouble(_params[0].ToString()))
			{
				MessageBox.Show("Số tiền gửi quá ít, vui lòng kiểm tra lại");
				return;
			}

			DataTable _data2 = PassbookModel.SelectPeriodByName(cbb_period_open.Text);
			if(_data2.Rows.Count == 0)
			{
				MessageBox.Show("Something went wrong!!!");
				return;
			}

			object[] _period = _data2.Rows[0].ItemArray;
			string _periodId = _period[1].ToString();
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

		public void GetPassbookPeriodType()
		{
			DataTable _result2 = PassbookModel.SelectAllPeriod();
			if (_result2.Rows.Count != 0)
			{
				for (int i = 0; i < _result2.Rows.Count; i++)
				{
					object[] _itemArray2 = _result2.Rows[i].ItemArray;
					cbb_period_open.Items.Add(_itemArray2[2].ToString());
					cbb_type_monthly.Items.Add(_itemArray2[2].ToString());
				}
			}
		}
		////////////////////////////////////////////////////////////////////


		////////////////////////////////////////////////////////////////////
		// Control for create lookup
		private void btn_refresh_lookup_Click(object sender, EventArgs e)
		{
			list_lookup.Items.Clear();
			DataTable _result2 = PassbookModel.SelectAllPassbooks();
			int count = _result2.Rows.Count;
			for (int i = 0; i < count; i++)
			{
				object[] _itemArray2 = _result2.Rows[i].ItemArray;
				ListViewItem lvi = new ListViewItem(i.ToString());
				lvi.SubItems.Add(_itemArray2[0].ToString());
				lvi.SubItems.Add(_itemArray2[1].ToString());
				lvi.SubItems.Add(_itemArray2[2].ToString());
				lvi.SubItems.Add(_itemArray2[3].ToString());
				list_lookup.Items.Add(lvi);
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

			lbl_customer_id_deposit.Text = _customer[0].ToString();

			txt_name_deposit.Text = _customer[1].ToString();
			txt_identity_number_deposit.Text = _customer[2].ToString();

			txt_address_deposit.Text = _customer[3].ToString();
			txt_phone_number_deposit.Text = _customer[4].ToString();

			txt_name_deposit.Enabled = false;
			txt_identity_number_deposit.Enabled = false;
			txt_address_deposit.Enabled = false;
			txt_phone_number_deposit.Enabled = false;

			DataTable _data2 = PassbookModel.SelectPassbooksByCustomerId(lbl_customer_id_deposit.Text);
			for (int i = 0; i < _data2.Rows.Count; i++)
			{
				object[] _passbook = _data2.Rows[i].ItemArray;
				cbb_passbook_deposit.Items.Add(_passbook[0].ToString());
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

			DataTable _data = PassbookModel.SelectAllConfig();
			object[] _params = _data.Rows[0].ItemArray;

			if (Processor.Compare(txt_cash_deposit.Text, _params[TblColumn.MIN_DEPOSIT_MORE].ToString()) < 0)
			{
				MessageBox.Show("Số tiền gửi thêm quá ít, vui lòng kiểm tra lại");
				return;
			}

			DateTime _dateTime = calendar_open.SelectionEnd.Date;
			if (PassbookModel.InsertIncome(cbb_passbook_deposit.Text, lbl_customer_id_deposit.Text, txt_cash_deposit.Text, _dateTime.ToString()) == false)
			{
				MessageBox.Show("Something went wrong!!!");
				return;
			}

			DataTable _data2 = PassbookModel.SelectPassbookById(cbb_passbook_deposit.Text);
			object[] _passbook = _data2.Rows[0].ItemArray;

			double _cash = Processor.Add(txt_cash_deposit.Text, _passbook[3].ToString());
			PassbookModel.UpdateCashByPassbookId(cbb_passbook_deposit.Text, _cash.ToString());
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

			lbl_customer_id_withdrawal.Text = _customer[0].ToString();

			txt_name_withdrawal.Text = _customer[1].ToString();
			txt_identity_number_withdrawal.Text = _customer[2].ToString();

			txt_address_withdrawal.Text = _customer[3].ToString();
			txt_phone_number_withdrawal.Text = _customer[4].ToString();

			txt_name_withdrawal.Enabled = false;
			txt_identity_number_withdrawal.Enabled = false;
			txt_address_withdrawal.Enabled = false;
			txt_phone_number_withdrawal.Enabled = false;

			DataTable _data2 = PassbookModel.SelectPassbooksByCustomerId(lbl_customer_id_withdrawal.Text);
			for (int i = 0; i < _data2.Rows.Count; i++)
			{
				object[] _passbook = _data2.Rows[i].ItemArray;
				cbb_passbook_withdrawal.Items.Add(_passbook[0].ToString());
			}
		}

		private void btn_create_withdrawal_Click(object sender, EventArgs e)
		{
			if (txt_name_deposit.Text == "" ||
				txt_identity_number_withdrawal.Text == "" ||
				txt_address_withdrawal.Text == "" ||
				txt_phone_number_withdrawal.Text == "" ||
				txt_cash_withdrawal.Text == "" ||
				cbb_passbook_withdrawal.Text == "")
			{
				MessageBox.Show("All informations are required!!!");
				return;
			}

			DataTable _data = PassbookModel.SelectPassbookById(cbb_passbook_withdrawal.Text);
			object[] _passbook = _data.Rows[0].ItemArray;

			DateTime _current = DateTime.Now;
			DateTime _opened = DateTime.Parse(_passbook[4].ToString());

			string _periodId = _passbook[1].ToString();
			DataTable _data2 = PassbookModel.SelectPeriodById(_periodId);
			object[] _period = _data2.Rows[0].ItemArray;

			if (Processor.Compare((_current - _opened).Days.ToString(), _period[4].ToString()) < 0)
			{
				MessageBox.Show("Chưa đến thời hạn rút tiền!!!");
				return;
			}




			string date_now = DateTime.Now.ToString().Trim();


			string id_customer = _passbook[2].ToString();


			string money_goc = _passbook[3].ToString();

			string ngay_open = _passbook[4].ToString();
			int count_ngay = Processor.count_datetime(ngay_open, date_now);
			string rate = _period[3].ToString();


			double rate_1 = Convert.ToDouble(rate);
			double money1_goc = Convert.ToDouble(money_goc);
			Double money_sum = money1_goc + money1_goc * rate_1 * (count_ngay / 30);
			double cash_rut = Convert.ToDouble(txt_cash_withdrawal.Text);

			if (cash_rut < money_sum)
			{
				if (_periodId == "3")
				{
					txt_cash_withdrawal.Text = money_sum.ToString();
					MessageBox.Show("bạn  rút hết tiền trong tài khoản : " + txt_cash_withdrawal.Text);
					money_sum = 0;
					PassbookModel.UpdateClosePassbookByPassbookId(cbb_passbook_withdrawal.Text, "False");

				}
				if (_periodId == "6")
				{
					txt_cash_withdrawal.Text = money_sum.ToString();
					MessageBox.Show("bạn rút hết tiền trong tài khoảng : " + txt_cash_withdrawal.Text);
					money_sum = 0;
					PassbookModel.UpdateClosePassbookByPassbookId(cbb_passbook_withdrawal.Text, "False");

				}
				if (_periodId == "0")
				{
					money_sum = money_sum - cash_rut;
					if (money_sum == 0)
					{
						PassbookModel.UpdateClosePassbookByPassbookId(cbb_passbook_withdrawal.Text, "False");
					}
					MessageBox.Show(" success");
				}
				PassbookModel.UpdateCashByPassbookId(cbb_passbook_withdrawal.Text, money_sum.ToString());

				DateTime _dateTime = calendar_withdrawal.SelectionEnd.Date;
				if (PassbookModel.InsertOutcome(cbb_passbook_withdrawal.Text, _periodId, txt_cash_withdrawal.Text, id_customer, _dateTime.ToString(), money_sum.ToString()) == false)
				{
					MessageBox.Show(" error");
				}
			}
			else
			{
				MessageBox.Show("không đủ tiền để rút, nhập lại số tiền rút  ");
			}
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

		}
		////////////////////////////////////////////////////////////////////


		////////////////////////////////////////////////////////////////////
		// Control for create daily report
		private void btn_refresh_daily_Click(object sender, EventArgs e)
		{
			list_daily.Items.Clear();

			string date = datetime1.Value.ToString();

			DataTable result2 = PassbookModel.SelectAllPeriod();
			int count = result2.Rows.Count;
			string[] loai = new string[count];
			double[] tongthu = new double[count];
			double[] tongchi = new double[count];
			for (int i = 0; i < count; i++)
			{
				object[] _itemArray2 = result2.Rows[i].ItemArray;
				loai[i] = _itemArray2[1].ToString();
				tongthu[i] = 0;
				tongchi[i] = 0;
			}
			DataTable result1 = PassbookModel.SelectAllPassbooks();
			DataTable result02 = PassbookModel.SelectAllIncomes();
			DataTable result03 = PassbookModel.SelectAllOutcomes();
			int count_2 = result1.Rows.Count;
			int count_3 = result02.Rows.Count;
			int count_4 = result03.Rows.Count;
			for (int i = 0; i < count_2; i++)
			{
				object[] _itemArray1 = result1.Rows[i].ItemArray;
				string ngay = _itemArray1[4].ToString();
				string type = _itemArray1[1].ToString();
				string cash = _itemArray1[3].ToString();
				if (Processor.cut_date(ngay) == Processor.cut_date(date))
				{
					for (int j = 0; j < count; j++)
					{
						if (loai[j] == type)
						{
							tongthu[j] = tongthu[j] + Convert.ToDouble(cash);
						}
					}
				}
			}

			for (int i = 0; i < count_3; i++)
			{
				object[] _itemArray2 = result02.Rows[i].ItemArray;
				string ngay = _itemArray2[4].ToString();
				string money = _itemArray2[2].ToString();
				string pass_id = _itemArray2[1].ToString();
				DataTable query = PassbookModel.SelectPassbookById(pass_id);
				object[] _itemaray3 = query.Rows[0].ItemArray;
				string type = _itemaray3[1].ToString();

				if (Processor.cut_date(ngay) == Processor.cut_date(date))
				{
					for (int j = 0; j < count; j++)
					{
						if (loai[j] == type)
						{
							tongthu[j] = tongthu[j] + Convert.ToDouble(money);
						}
					}
				}
			}
			for (int i = 0; i < count_4; i++)
			{
				object[] _itemArray3 = result03.Rows[i].ItemArray;

				string ngay = _itemArray3[5].ToString();
				string money = _itemArray3[3].ToString();
				string pass_id = _itemArray3[1].ToString();
				string type = _itemArray3[2].ToString();

				if (Processor.cut_date(ngay) == Processor.cut_date(date))
				{
					for (int j = 0; j < count; j++)
					{
						if (loai[j] == type)
						{
							tongchi[j] = tongchi[j] + Convert.ToDouble(money);
						}
					}
				}

			}
			for (int i = 0; i < count; i++)
			{

				ListViewItem lvi = new ListViewItem(i.ToString());
				lvi.SubItems.Add(loai[i].ToString());
				lvi.SubItems.Add(tongthu[i].ToString());
				lvi.SubItems.Add(tongchi[i].ToString());
				lvi.SubItems.Add((tongthu[i] - tongchi[i]).ToString());
				list_daily.Items.Add(lvi);

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

