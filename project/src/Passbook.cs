using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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

			btn_check_open.Enabled = true;
			btn_submit_open.Enabled = true;
			btn_create_open.Enabled = false;

			btn_check_deposit.Enabled = true;
			btn_create_deposit.Enabled = false;
			btn_check_withdrawal.Enabled = true;
			btn_create_withdrawal.Enabled = false;

			LoginForm _loginForm = new LoginForm();

			Hide();
			_loginForm.ShowDialog();

			txt_welcome_main.Text = "Welcome back,\n" + Params.CURRENT_SESSION[Params.CURRENT_USERNAME];
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
			_editForm.ShowDialog();
		}
		////////////////////////////////////////////////////////////////////


		////////////////////////////////////////////////////////////////////
		// Control for create passbook
		/// <summary>
		///     
		/// </summary>
		///
		private void SelectCustomerOpen()
		{
			DataTable _data = null;
			if (txt_identity_number_open.Text != "")
			{
				_data = PassbookModel.SelectCustomerByIdentityNumber(txt_identity_number_open.Text);

				if (_data.Rows.Count == 0)
				{
					MessageBox.Show("Account not found. Please type all information to add new account!!!", "Notice");
					return;
				}
			}
			else if(txt_phone_number_open.Text != "")
			{
				_data = PassbookModel.SelectCustomerByPhoneNumber(txt_phone_number_open.Text);

				if (_data.Rows.Count == 0)
				{
					MessageBox.Show("Account not found. Please type all information to add new account!!!", "Notice");
					return;
				}
			}
			else
			{
				MessageBox.Show("Please type identity number!!!", "Notice");
				return;
			}

			object[] _customer = _data.Rows[0].ItemArray;

			lbl_customer_id_open.Text = _customer[TblColumn.A_ID].ToString();
			txt_name_open.Text = _customer[TblColumn.A_NAME].ToString();
			txt_identity_number_open.Text = _customer[TblColumn.A_IDENTITY_NUMBER].ToString();
			txt_address_open.Text = _customer[TblColumn.A_ADDRESS].ToString();
			txt_phone_number_open.Text = _customer[TblColumn.A_PHONE_NUMBER].ToString();

			DataTable _data2 = PassbookModel.SelectAllPeriod();

			if (_data2.Rows.Count == 0)
			{
				MessageBox.Show("Something went wrong!!!", "Notice");
				return;
			}

			for (int i = 0; i < _data2.Rows.Count; i++)
			{
				object[] _period = _data2.Rows[i].ItemArray;
				cbb_period_open.Items.Add(_period[TblColumn.T_NAME].ToString());
			}

			cbb_period_open.SelectedIndex = 0;

			txt_name_open.Enabled = false;
			txt_identity_number_open.Enabled = false;
			txt_address_open.Enabled = false;
			txt_phone_number_open.Enabled = false;

			btn_check_open.Enabled = false;
			btn_submit_open.Enabled = false;
			btn_create_open.Enabled = true;
		}

		private void btn_check_open_Click(object sender, EventArgs e)
		{
			SelectCustomerOpen();
		}

		private void txt_identity_number_open_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				SelectCustomerOpen();
			}
		}

		private void txt_phone_number_open_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				SelectCustomerOpen();
			}
		}

		private void btn_submit_open_Click(object sender, EventArgs e)
		{
			if (txt_name_open.Text == "" ||
				txt_identity_number_open.Text == "" ||
				txt_address_open.Text == "" ||
				txt_phone_number_open.Text == "")
			{
				MessageBox.Show("All informations are required!!!", "Notice");
				return;
			}

			DataTable _data = PassbookModel.SelectCustomerByIdentityNumber(txt_identity_number_open.Text);

			if (_data.Rows.Count != 0)
			{
				MessageBox.Show("Account is already exist!!!", "Notice");
				return;
			}

			if (PassbookModel.InsertCustomer(txt_name_open.Text, txt_identity_number_open.Text, txt_address_open.Text, txt_phone_number_open.Text) == false)
			{
				MessageBox.Show("Cannot create customer. Something went wrong!!!", "Notice");
				return;
			}

			DataTable _data1 = PassbookModel.SelectCustomerByIdentityNumber(txt_identity_number_open.Text);
			object[] _customer = _data1.Rows[0].ItemArray;

			lbl_customer_id_open.Text = _customer[TblColumn.A_ID].ToString();
			MessageBox.Show("Success create new account! Please go ahead to create new passbook for this account.", "Create Customer");

			txt_name_open.Enabled = false;
			txt_identity_number_open.Enabled = false;
			txt_address_open.Enabled = false;
			txt_phone_number_open.Enabled = false;

			btn_check_open.Enabled = false;
			btn_submit_open.Enabled = false;
			btn_create_open.Enabled = true;

			DataTable _data2 = PassbookModel.SelectAllPeriod();

			for (int i = 0; i < _data2.Rows.Count; i++)
			{
				object[] _period = _data2.Rows[i].ItemArray;
				cbb_period_open.Items.Add(_period[TblColumn.T_NAME].ToString());
			}

			cbb_period_open.SelectedIndex = 0;
		}

		private void btn_create_open_Click(object sender, EventArgs e)
		{
			if (txt_name_open.Text == "" ||
				txt_identity_number_open.Text == "" ||
				txt_address_open.Text == "" ||
				txt_phone_number_open.Text == "" ||
				txt_cash_open.Text == "" ||
				cbb_period_open.Text == "" ||
				txt_passbook_name_open.Text == "")
			{
				MessageBox.Show("All informations are required!!!", "Notice");
				return;
			}

			if (Convert.ToDouble(txt_cash_open.Text) < Convert.ToDouble(Params.PARAMS[Params.MIN_CASH].ToString()))
			{
				MessageBox.Show("Your cash is less than usual. Please check again...", "Notice");
				return;
			}

			DataTable _data = PassbookModel.SelectPeriodByName(cbb_period_open.Text);

			if(_data.Rows.Count == 0)
			{
				MessageBox.Show("Something went wrong!!!", "Notice");
				return;
			}

			object[] _period = _data.Rows[0].ItemArray;

			string _periodId = _period[TblColumn.T_ID].ToString();
			DateTime _dateTime = calendar_open.SelectionEnd.Date;

			string _status = "open-" + _dateTime.ToString();

			if (PassbookModel.InsertPassbook(txt_passbook_name_open.Text, _periodId, lbl_customer_id_open.Text, txt_cash_open.Text, _dateTime.ToString(), _status) == false)
			{
				MessageBox.Show("Cannot create passbook. Something went wrong!!!", "Notice");
				return;
			}

			MessageBox.Show("Congratulation! You have just successed create a passbook.", "Create Passbook");
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

			btn_check_open.Enabled = true;
			btn_submit_open.Enabled = true;
			btn_create_open.Enabled = false;

			cbb_period_open.Items.Clear();
			cbb_period_open.Text = "";
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
					MessageBox.Show("Something went wrong!!!", "Notice");
					return;
				}

				object[] _period = _data1.Rows[0].ItemArray;
				_item.SubItems.Add(_period[TblColumn.T_NAME].ToString());


				// Set Customer
				DataTable _data2 = PassbookModel.SelectCustomerById(_passbook[TblColumn.P_CUSTOMER_ID].ToString());
				if (_data2.Rows.Count == 0)
				{
					MessageBox.Show("Something went wrong!!!", "Notice");
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
		private void SelectCustomerDeposit()
		{
			if (txt_identity_number_deposit.Text == "")
			{
				MessageBox.Show("Please type identity number!!!", "Notice");
				return;
			}

			DataTable _data = PassbookModel.SelectCustomerByIdentityNumber(txt_identity_number_deposit.Text);

			if (_data.Rows.Count == 0)
			{
				MessageBox.Show("Account not found. Please go to passbook tab to add new account!!!", "Notice");
				return;
			}

			object[] _customer = _data.Rows[0].ItemArray;

			lbl_customer_id_deposit.Text = _customer[TblColumn.A_ID].ToString();
			txt_name_deposit.Text = _customer[TblColumn.A_NAME].ToString();
			txt_identity_number_deposit.Text = _customer[TblColumn.A_IDENTITY_NUMBER].ToString();
			txt_address_deposit.Text = _customer[TblColumn.A_ADDRESS].ToString();
			txt_phone_number_deposit.Text = _customer[TblColumn.A_PHONE_NUMBER].ToString();

			DataTable _data1 = PassbookModel.SelectPassbooksByCustomerId(lbl_customer_id_deposit.Text);

			if (_data1.Rows.Count == 0)
			{
				MessageBox.Show("There is no passbook of this customer. Please check again...", "Notice");
				return;
			}

			for (int i = 0; i < _data1.Rows.Count; i++)
			{
				object[] _passbook = _data1.Rows[i].ItemArray;
				string _cashFormatted = string.Format("{0:#,##0}", Processor.ConvertToDouble(_passbook[TblColumn.P_CASH].ToString()));
				cbb_passbook_deposit.Items.Add(_passbook[TblColumn.P_ID].ToString() + ": " + _passbook[TblColumn.P_NAME].ToString() + " - " + _cashFormatted);
			}

			cbb_passbook_deposit.SelectedIndex = 0;

			txt_name_deposit.Enabled = false;
			txt_identity_number_deposit.Enabled = false;
			txt_address_deposit.Enabled = false;
			txt_phone_number_deposit.Enabled = false;

			btn_check_deposit.Enabled = false;
			btn_create_deposit.Enabled = true;
		}

		private void btn_check_deposit_Click(object sender, EventArgs e)
		{
			SelectCustomerDeposit();
		}

		private void txt_identity_number_deposit_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				SelectCustomerDeposit();
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
				MessageBox.Show("All informations are required!!!", "Notice");
				return;
			}

			if (Processor.Compare(txt_cash_deposit.Text, Params.PARAMS[Params.MIN_INCOME].ToString()) < 0)
			{
				MessageBox.Show("Your income is less than usual. Pleas check again...", "Notice");
				return;
			}

			DateTime _dateTime = calendar_deposit.SelectionEnd.Date;
			string _passbookId = cbb_passbook_deposit.Text.Split(':')[0];

			if (PassbookModel.InsertIncome(_passbookId, txt_cash_deposit.Text, _dateTime.ToString()) == false)
			{
				MessageBox.Show("Something went wrong!!!", "Notice");
				return;
			}

			DataTable _data = PassbookModel.SelectPassbookById(_passbookId);
			object[] _passbook = _data.Rows[0].ItemArray;

			if(Processor.Compare(_passbook[TblColumn.P_CASH].ToString(), "0") == 0)
			{
				List<string> _status = _passbook[TblColumn.P_STATUS].ToString().Split('|').ToList();
				_status.Add("open-" + _dateTime.ToString());
				PassbookModel.UpdateStatusByPassbookId(_passbookId, string.Join("|", _status));
			}

			string _cash = Processor.Add(txt_cash_deposit.Text, _passbook[TblColumn.P_CASH].ToString());
			PassbookModel.UpdateCashByPassbookId(_passbookId, _cash);

			MessageBox.Show("Congratulation. You have created a new deposit!!!", "Create deposit");
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

			btn_check_deposit.Enabled = true;
			btn_create_deposit.Enabled = false;
		}
		////////////////////////////////////////////////////////////////////


		////////////////////////////////////////////////////////////////////
		// Control for create withdrawal
		private void SelectCustomerWithdrawal()
		{
			if (txt_identity_number_withdrawal.Text == "")
			{
				MessageBox.Show("Please type identity number!!!", "Notice");
				return;
			}

			DataTable _data = PassbookModel.SelectCustomerByIdentityNumber(txt_identity_number_withdrawal.Text);

			if (_data.Rows.Count == 0)
			{
				MessageBox.Show("Account not found. Please go to passbook tab to add new account!!!", "Notice");
				return;
			}

			object[] _customer = _data.Rows[0].ItemArray;

			lbl_customer_id_withdrawal.Text = _customer[TblColumn.A_ID].ToString();
			txt_name_withdrawal.Text = _customer[TblColumn.A_NAME].ToString();
			txt_identity_number_withdrawal.Text = _customer[TblColumn.A_IDENTITY_NUMBER].ToString();
			txt_address_withdrawal.Text = _customer[TblColumn.A_ADDRESS].ToString();
			txt_phone_number_withdrawal.Text = _customer[TblColumn.A_PHONE_NUMBER].ToString();

			DataTable _data1 = PassbookModel.SelectPassbooksByCustomerId(lbl_customer_id_withdrawal.Text);

			if (_data1.Rows.Count == 0)
			{
				MessageBox.Show("There is no passbook of this customer. Please check again...", "Notice");
				return;
			}

			for (int i = 0; i < _data1.Rows.Count; i++)
			{
				object[] _passbook = _data1.Rows[i].ItemArray;
				string _cashFormatted = string.Format("{0:#,##0}", Processor.ConvertToDouble(_passbook[TblColumn.P_CASH].ToString()));
				cbb_passbook_withdrawal.Items.Add(_passbook[TblColumn.P_ID].ToString() + ": " + _passbook[TblColumn.P_NAME].ToString() + " - " + _cashFormatted);
			}

			cbb_passbook_withdrawal.SelectedIndex = 0;

			txt_name_withdrawal.Enabled = false;
			txt_identity_number_withdrawal.Enabled = false;
			txt_address_withdrawal.Enabled = false;
			txt_phone_number_withdrawal.Enabled = false;

			btn_check_withdrawal.Enabled = false;
			btn_create_withdrawal.Enabled = true;
		}

		private void btn_check_withdrawal_Click(object sender, EventArgs e)
		{
			SelectCustomerWithdrawal();
		}

		private void txt_identity_number_withdrawal_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				SelectCustomerWithdrawal();
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
				MessageBox.Show("All informations are required!!!", "Notice");
				return;
			}

			string _passbookId = cbb_passbook_withdrawal.Text.Split(':')[0];
			DataTable _data = PassbookModel.SelectPassbookById(_passbookId);

			if(_data.Rows.Count == 0)
			{
				MessageBox.Show("Something went wrong!!!", "Notice");
				return;
			}

			object[] _passbook = _data.Rows[0].ItemArray;

			DateTime _current = calendar_withdrawal.SelectionEnd.Date;
			DateTime _opened = DateTime.Parse(_passbook[TblColumn.P_DATE_TIME].ToString());

			string _periodId = _passbook[TblColumn.P_PERIOD_ID].ToString();
			DataTable _data1 = PassbookModel.SelectPeriodById(_periodId);

			if(_data1.Rows.Count == 0)
			{
				MessageBox.Show("Something went wrong!!!", "Notice");
				return;
			}

			object[] _period = _data1.Rows[0].ItemArray;

			if (Processor.Compare((_current - _opened).Days.ToString(), _period[TblColumn.T_PERIOD].ToString()) < 0)
			{
				MessageBox.Show("Chưa đến thời hạn rút tiền!!!", "Notice");
				return;
			}

			string _rate = _period[TblColumn.T_RATE].ToString();
			string _cash = _passbook[TblColumn.P_CASH].ToString();

			string _withdrawal = "0";
			string _profit = "0";

			if (_periodId == "1")
			{
				if(txt_cash_withdrawal.Text == "")
				{
					MessageBox.Show("All informations are required!!!", "Notice");
					return;
				}

				if(Processor.Compare(_cash, txt_cash_withdrawal.Text) < 0)
				{
					MessageBox.Show("Không đủ số tiền rút. Vui lòng kiểm tra lại!!!", "Notice");
					return;
				}

				_withdrawal = txt_cash_withdrawal.Text;
				_profit = Processor.Multi(Processor.Multi(_cash, _rate), Processor.Div((_current - _opened).Days.ToString(), "30"));
				_cash = Processor.Sub(_cash, _withdrawal);
			}
			else
			{
				_withdrawal = _cash;
				_profit = Processor.Multi(Processor.Multi(_cash, _rate), Processor.Div(_period[TblColumn.T_PERIOD].ToString(), "30"));
				_cash = "0";
			}

			string id_customer = _passbook[2].ToString();

			if (PassbookModel.InsertOutcome(_passbookId, _withdrawal, _current.ToString()) == false)
			{
				MessageBox.Show("Something went wrong!!!", "Notice");
				return;
			}

			if (Processor.Compare(_cash, "0") == 0)
			{
				List<string> _status = _passbook[TblColumn.P_STATUS].ToString().Split('|').ToList();
				_status.Add("close-" + _current.ToString());
				PassbookModel.UpdateStatusByPassbookId(_passbookId, string.Join("|", _status));
			}

			PassbookModel.UpdateCashByPassbookId(_passbookId, _cash);
			PassbookModel.UpdateLastUpdateTimeByPassbookId(_passbookId, _current.ToString());
			MessageBox.Show("Success. Cash: " + _withdrawal + ", Profit: " + _profit, "Create Withdrawal");
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

			btn_check_withdrawal.Enabled = true;
			btn_create_withdrawal.Enabled = false;
		}

		private void cbb_passbook_withdrawal_SelectedIndexChanged(object sender, EventArgs e)
		{
			string _passbookId = cbb_passbook_withdrawal.Text.Split(':')[0];

			DataTable _data = PassbookModel.SelectPassbookById(_passbookId);

			if(_data.Rows.Count == 0)
			{
				MessageBox.Show("Something went wrong!!!", "Notice");
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
						_income = Processor.Add(_income, _row[TblColumn.D_CASH].ToString());
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
						_outcome = Processor.Add(_outcome, _row[TblColumn.W_CASH].ToString());
				}
				_item.SubItems.Add(_outcome);


				// Set total value
				_item.SubItems.Add(Processor.Sub(_income, _outcome));


				list_daily.Items.Add(_item);
			}
		}
		////////////////////////////////////////////////////////////////////


		////////////////////////////////////////////////////////////////////
		// Control for create monthly report
		private void btn_refresh_monthly_Click(object sender, EventArgs e)
		{
			DataTable _data = PassbookModel.SelectAllPeriod();

			cbb_period_monthly.Items.Clear();

			for (int i = 0; i < _data.Rows.Count; i++)
			{
				object[] _period1 = _data.Rows[i].ItemArray;
				cbb_period_monthly.Items.Add(_period1[TblColumn.T_NAME].ToString());
			}

			cbb_period_monthly.SelectedIndex = 0;

			DateTime _dateTime = date_monthly.Value;

			DataTable _data1 = PassbookModel.SelectPeriodByName(cbb_period_monthly.Text);

			if (_data1.Rows.Count == 0)
			{
				MessageBox.Show("Something went wrong!!!", "Notice");
				return;
			}

			object[] _period = _data1.Rows[0].ItemArray;

			list_monthly.Items.Clear();

			int _daysCount = Processor.CountDay(_dateTime.Month, _dateTime.Year);

			for(int i = 0; i < _daysCount; i++)
			{
				ListViewItem _item = new ListViewItem((i + 1).ToString());

				// Set date
				string _date = (i + 1) + "/" + _dateTime.Month + "/" + _dateTime.Year;
				_item.SubItems.Add(_date);
				DateTime _current = DateTime.Parse(_date);


				// Set income/outcome value
				int _income = 0;
				int _outcome = 0;

				DataTable _data2 = PassbookModel.SelectAllPassbooks();
				
				for(int j = 0; j < _data2.Rows.Count; j++)
				{
					object[] _passbook = _data2.Rows[j].ItemArray;

					if(_passbook[TblColumn.P_PERIOD_ID].ToString() == _period[TblColumn.T_ID].ToString())
					{
						List<string> _status = _passbook[TblColumn.P_STATUS].ToString().Split('|').ToList();
						foreach (string __status in _status)
						{
							string[] _temp = __status.Split('-');
							DateTime _statusDate = DateTime.Parse(_temp[1]);

							if (_current.Date.DayOfYear == _statusDate.Date.DayOfYear)
							{
								if (_temp[0] == "open")
									_income++;
								else
									_outcome++;
							}
						}
					}
				}

				_item.SubItems.Add(_income.ToString());
				_item.SubItems.Add(_outcome.ToString());


				// Set total value
				_item.SubItems.Add((_income - _outcome).ToString());

				list_monthly.Items.Add(_item);
			}
		}
	}
}

