using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace PassbookManagement.src
{
	public partial class Passbook : MaterialForm
	{
		private LoginForm m_loginForm;

		public Passbook()
		{
			InitializeComponent();

			//Processor.DecryptedDatabase("passbook.pro", "passbook.s3db");
			Database.SQLiteDatabase = new SQLiteDatabase("passbook.s3db");


			/////////////////////////////////////////////////////////////////////////////
			// Set style
			var materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan500, Primary.Cyan600, Primary.Cyan300, Accent.LightBlue200, TextShade.WHITE);

			Processor.ReadParams(Processor.PARAMS_FILE);

			btn_check_open.Enabled = true;
			btn_submit_open.Enabled = true;
			btn_create_open.Enabled = false;

			btn_check_deposit.Enabled = true;
			btn_create_deposit.Enabled = false;
			btn_check_withdrawal.Enabled = true;
			btn_create_withdrawal.Enabled = false;

			m_loginForm = new LoginForm();
		}


		////////////////////////////////////////////////////////////////////
		// Load login form after create form
		private void Passbook_Load(object sender, EventArgs e)
		{
			Hide();
			OpenLoginForm();
			txt_welcome_main.Text = "Welcome back,\n" + Params.CURRENT_SESSION[Params.CURRENT_USERNAME];
			Show();

			LoadStaffList();
		}

		private void OpenLoginForm()
		{
			m_loginForm.ShowDialog();

			if (m_loginForm.DialogResult == DialogResult.Cancel)
			{
				Application.Exit();
				return;
			}
		}

		private void LoadStaffList()
		{
			DataTable _data = PassbookModel.SelectAllStaff();

			if(_data.Rows.Count == 0)
			{
				MessageBox.Show(IMessage.MSG_NO_STAFF, IMessage.CPT_NOTICE);
				return;
			}

			for(int i = 0; i < _data.Rows.Count; i++)
			{
				object[] _staff = _data.Rows[i].ItemArray;
				cbb_staff_open.Items.Add(_staff[TblColumn.S_ID].ToString() + ": " + _staff[TblColumn.S_NAME].ToString());
				cbb_staff_deposit.Items.Add(_staff[TblColumn.S_ID].ToString() + ": " + _staff[TblColumn.S_NAME].ToString());
				cbb_staff_withdrawal.Items.Add(_staff[TblColumn.S_ID].ToString() + ": " + _staff[TblColumn.S_NAME].ToString());
			}

			cbb_staff_open.SelectedIndex = 0;
			cbb_staff_deposit.SelectedIndex = 0;
			cbb_staff_withdrawal.SelectedIndex = 0;
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

		private void item_dashboard_Click(object sender, EventArgs e)
		{
			var _dashboard = new Dashboard();
			_dashboard.ShowDialog();
		}

		private void item_logout_Click(object sender, EventArgs e)
		{
			Params.CURRENT_SESSION.Clear();
			OpenLoginForm();
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

			// Select customer by identity number. This is priority order.
			if (txt_identity_number_open.Text != "")
			{
				_data = PassbookModel.SelectCustomerByIdentityNumber(txt_identity_number_open.Text);
			}
			// Select customer by phone number
			else if(txt_phone_number_open.Text != "")
			{
				_data = PassbookModel.SelectCustomerByPhoneNumber(txt_phone_number_open.Text);
			}
			else
			{
				MessageBox.Show(IMessage.MSG_TYPE_ID, IMessage.CPT_NOTICE);
				return;
			}

			if (_data.Rows.Count == 0)
			{
				MessageBox.Show(IMessage.MSG_NOT_ACC, IMessage.CPT_NOTICE);
				return;
			}

			// Extract info
			object[] _customer = _data.Rows[0].ItemArray;

			lbl_customer_id_open.Text = _customer[TblColumn.A_ID].ToString();
			txt_name_open.Text = _customer[TblColumn.A_NAME].ToString();
			txt_identity_number_open.Text = _customer[TblColumn.A_IDENTITY_NUMBER].ToString();
			txt_address_open.Text = _customer[TblColumn.A_ADDRESS].ToString();
			txt_phone_number_open.Text = _customer[TblColumn.A_PHONE_NUMBER].ToString();


			// Initialize cbb_period_open
			DataTable _data2 = PassbookModel.SelectAllPeriod();

			if (_data2.Rows.Count == 0)
			{
				MessageBox.Show(IMessage.MSG_SOMETHING_WENT_WRONG, IMessage.CPT_NOTICE);
				return;
			}

			for (int i = 0; i < _data2.Rows.Count; i++)
			{
				object[] _period = _data2.Rows[i].ItemArray;
				cbb_period_open.Items.Add(_period[TblColumn.T_NAME].ToString());
			}

			cbb_period_open.SelectedIndex = 0;


			// UX Enhancer
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


		// UX Enhancer: Press enter for select customer
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
				MessageBox.Show(IMessage.MSG_REQUIRED, IMessage.CPT_NOTICE);
				return;
			}

			DataTable _data = PassbookModel.SelectCustomerByIdentityNumber(txt_identity_number_open.Text);

			if (_data.Rows.Count != 0)
			{
				MessageBox.Show(IMessage.MSG_EXIST, IMessage.CPT_NOTICE);
				return;
			}

			if (PassbookModel.InsertCustomer(txt_name_open.Text, txt_identity_number_open.Text, txt_address_open.Text, txt_phone_number_open.Text) == false)
			{
				MessageBox.Show(IMessage.MSG_NOT_CREAT, IMessage.CPT_NOTICE);
				return;
			}

			MessageBox.Show(IMessage.MSG_S_CREAT, IMessage.CPT_CREAT_CUSTOMER);

			_data = PassbookModel.SelectCustomerByIdentityNumber(txt_identity_number_open.Text);
			object[] _customer = _data.Rows[0].ItemArray;
			lbl_customer_id_open.Text = _customer[TblColumn.A_ID].ToString();


			// Initialize cbb_period_open
			DataTable _data2 = PassbookModel.SelectAllPeriod();

			for (int i = 0; i < _data2.Rows.Count; i++)
			{
				object[] _period = _data2.Rows[i].ItemArray;
				cbb_period_open.Items.Add(_period[TblColumn.T_ID].ToString() + ": " +_period[TblColumn.T_NAME].ToString());
			}

			cbb_period_open.SelectedIndex = 0;


			// UX Enhancer.
			txt_name_open.Enabled = false;
			txt_identity_number_open.Enabled = false;
			txt_address_open.Enabled = false;
			txt_phone_number_open.Enabled = false;

			btn_check_open.Enabled = false;
			btn_submit_open.Enabled = false;
			btn_create_open.Enabled = true;
		}

		private void btn_create_open_Click(object sender, EventArgs e)
		{
			if (txt_name_open.Text == "" ||
				txt_identity_number_open.Text == "" ||
				txt_address_open.Text == "" ||
				txt_phone_number_open.Text == "" ||
				txt_cash_open.Text == "" ||
				cbb_period_open.Text == "" ||
				txt_passbook_name_open.Text == "" ||
				cbb_staff_open.Text == "")
			{
				MessageBox.Show(IMessage.MSG_REQUIRED,IMessage.CPT_NOTICE);
				return;
			}

			// Validate input
			double _cash = Processor.ConvertToDouble(txt_cash_open.Text);
			if(_cash == Processor.UNIDENTIFIED)
			{
				MessageBox.Show(IMessage.MSG_WRONG_INPUT,IMessage.CPT_NOTICE);
				return;
			}


			if (_cash < Processor.ConvertToDouble(Params.PARAMS[Params.MIN_CASH].ToString()))
			{
				MessageBox.Show(IMessage.MSG_LESS_CASH,IMessage.CPT_NOTICE);
				return;
			}

			string _periodId = cbb_period_open.Text.Split(':')[0];
			string _staffId = cbb_staff_open.Text.Split(':')[0];
			DateTime _dateTime = calendar_open.SelectionEnd.Date;
			string _status = "open-" + _dateTime.ToString();

			if (PassbookModel.InsertPassbook(txt_passbook_name_open.Text, _periodId, lbl_customer_id_open.Text, _staffId, txt_cash_open.Text, _dateTime.ToString(), _status) == false)
			{
                MessageBox.Show(IMessage.MSG_N_CREAT_PB, IMessage.CPT_NOTICE);
				return;
			}

            MessageBox.Show(IMessage.MSG_S_PB, IMessage.CPT_CREAT_PB);
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
                    MessageBox.Show(IMessage.MSG_SOMETHING_WENT_WRONG, IMessage.CPT_NOTICE);
					return;
				}

				object[] _period = _data1.Rows[0].ItemArray;
				_item.SubItems.Add(_period[TblColumn.T_NAME].ToString());


				// Set Customer
				DataTable _data2 = PassbookModel.SelectCustomerById(_passbook[TblColumn.P_CUSTOMER_ID].ToString());
				if (_data2.Rows.Count == 0)
				{
                    MessageBox.Show(IMessage.MSG_SOMETHING_WENT_WRONG, IMessage.CPT_NOTICE);
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
			DataTable _data = null;

			// Select customer by identity number. This is priority order.
			if (txt_identity_number_deposit.Text != "")
			{
				_data = PassbookModel.SelectCustomerByIdentityNumber(txt_identity_number_deposit.Text);
			}
			// Select customer by phone number
			else if (txt_phone_number_deposit.Text != "")
			{
				_data = PassbookModel.SelectCustomerByPhoneNumber(txt_phone_number_deposit.Text);
			}
			else
			{
                MessageBox.Show(IMessage.MSG_TYPE_ID, IMessage.CPT_NOTICE);
				return;
			}

			if (_data.Rows.Count == 0)
			{
                MessageBox.Show(IMessage.MSG_NOT_ACC, IMessage.CPT_NOTICE);
				return;
			}

			// Extract data
			object[] _customer = _data.Rows[0].ItemArray;

			lbl_customer_id_deposit.Text = _customer[TblColumn.A_ID].ToString();
			txt_name_deposit.Text = _customer[TblColumn.A_NAME].ToString();
			txt_identity_number_deposit.Text = _customer[TblColumn.A_IDENTITY_NUMBER].ToString();
			txt_address_deposit.Text = _customer[TblColumn.A_ADDRESS].ToString();
			txt_phone_number_deposit.Text = _customer[TblColumn.A_PHONE_NUMBER].ToString();

			DataTable _data1 = PassbookModel.SelectPassbooksByCustomerId(lbl_customer_id_deposit.Text);

			if (_data1.Rows.Count == 0)
			{
                MessageBox.Show(IMessage.MSG_NO_PB, IMessage.CPT_NOTICE);
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

		private void txt_phone_number_deposit_KeyDown(object sender, KeyEventArgs e)
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
				cbb_passbook_deposit.Text == "" ||
				cbb_staff_deposit.Text == "")
			{
                MessageBox.Show(IMessage.MSG_REQUIRED, IMessage.CPT_NOTICE);
				return;
			}

			// Validate input
			double _income = Processor.ConvertToDouble(txt_cash_deposit.Text);
			if(_income == Processor.UNIDENTIFIED)
			{
                MessageBox.Show(IMessage.MSG_WRONG_INPUT, IMessage.CPT_NOTICE);
				return;
			}

			if (_income < Processor.ConvertToDouble(Params.PARAMS[Params.MIN_INCOME].ToString()))
			{
                MessageBox.Show(IMessage.MSG_LESS_CASH, IMessage.CPT_NOTICE);
				return;
			}


			// Submit income
			DateTime _dateTime = calendar_deposit.SelectionEnd.Date;
			string _passbookId = cbb_passbook_deposit.Text.Split(':')[0];
			string _staffId = cbb_staff_deposit.Text.Split(':')[0];

			if (PassbookModel.InsertIncome(_passbookId, _staffId, txt_cash_deposit.Text, _dateTime.ToString()) == false)
			{
                MessageBox.Show(IMessage.MSG_SOMETHING_WENT_WRONG, IMessage.CPT_NOTICE);
				return;
			}


			///////////////////////////////////////////////////////////////////
			// Update passbook info
			DataTable _data = PassbookModel.SelectPassbookById(_passbookId);
			object[] _passbook = _data.Rows[0].ItemArray;

			// Reopen passbook
			if(Processor.Compare(_passbook[TblColumn.P_CASH].ToString(), "0") == 0)
			{
				List<string> _status = _passbook[TblColumn.P_STATUS].ToString().Split('|').ToList();
				_status.Add("open-" + _dateTime.ToString());
				PassbookModel.UpdateStatusByPassbookId(_passbookId, string.Join("|", _status));
			}

			// Update cash
			string _cash = Processor.Add(txt_cash_deposit.Text, _passbook[TblColumn.P_CASH].ToString());
			PassbookModel.UpdateCashByPassbookId(_passbookId, _cash);

            MessageBox.Show(IMessage.MSG_S_PS, IMessage.CPT_CREAT_PS);
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
			DataTable _data = null;

			// Select customer by identity number. This is priority order.
			if (txt_identity_number_withdrawal.Text != "")
			{
				_data = PassbookModel.SelectCustomerByIdentityNumber(txt_identity_number_withdrawal.Text);
			}
			// Select customer by phone number
			else if (txt_phone_number_withdrawal.Text != "")
			{
				_data = PassbookModel.SelectCustomerByPhoneNumber(txt_phone_number_withdrawal.Text);
			}
			else
			{
                MessageBox.Show(IMessage.MSG_TYPE_ID, IMessage.CPT_NOTICE);
				return;
			}

			if (_data.Rows.Count == 0)
			{
                MessageBox.Show(IMessage.MSG_NOT_ACC, IMessage.CPT_NOTICE);
				return;
			}

			// Extract data
			object[] _customer = _data.Rows[0].ItemArray;

			lbl_customer_id_withdrawal.Text = _customer[TblColumn.A_ID].ToString();
			txt_name_withdrawal.Text = _customer[TblColumn.A_NAME].ToString();
			txt_identity_number_withdrawal.Text = _customer[TblColumn.A_IDENTITY_NUMBER].ToString();
			txt_address_withdrawal.Text = _customer[TblColumn.A_ADDRESS].ToString();
			txt_phone_number_withdrawal.Text = _customer[TblColumn.A_PHONE_NUMBER].ToString();

			DataTable _data1 = PassbookModel.SelectPassbooksByCustomerId(lbl_customer_id_withdrawal.Text);

			if (_data1.Rows.Count == 0)
			{
                MessageBox.Show(IMessage.MSG_NO_PB, IMessage.CPT_NOTICE);
				return;
			}


			// Initialize cbb_passbook_withdrawal
			for (int i = 0; i < _data1.Rows.Count; i++)
			{
				object[] _passbook = _data1.Rows[i].ItemArray;
				string _cashFormatted = string.Format("{0:#,##0}", Processor.ConvertToDouble(_passbook[TblColumn.P_CASH].ToString()));
				cbb_passbook_withdrawal.Items.Add(_passbook[TblColumn.P_ID].ToString() + ": " + _passbook[TblColumn.P_NAME].ToString() + " - " + _cashFormatted);
			}

			cbb_passbook_withdrawal.SelectedIndex = 0;


			// UX Enhancer.
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

		private void txt_phone_number_withdrawal_KeyDown(object sender, KeyEventArgs e)
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
				cbb_passbook_withdrawal.Text == "" ||
				cbb_staff_withdrawal.Text == "")
			{
                MessageBox.Show(IMessage.MSG_REQUIRED, IMessage.CPT_NOTICE);
				return;
			}

			string _passbookId = cbb_passbook_withdrawal.Text.Split(':')[0];
			DataTable _data = PassbookModel.SelectPassbookById(_passbookId);

			if(_data.Rows.Count == 0)
			{
                MessageBox.Show(IMessage.MSG_SOMETHING_WENT_WRONG, IMessage.CPT_NOTICE);
				return;
			}

			object[] _passbook = _data.Rows[0].ItemArray;

			DateTime _current = calendar_withdrawal.SelectionEnd.Date;
			DateTime _opened = DateTime.Parse(_passbook[TblColumn.P_DATE_TIME].ToString());

			string _periodId = _passbook[TblColumn.P_PERIOD_ID].ToString();
			DataTable _data1 = PassbookModel.SelectPeriodById(_periodId);

			if(_data1.Rows.Count == 0)
			{
                MessageBox.Show(IMessage.MSG_SOMETHING_WENT_WRONG, IMessage.CPT_NOTICE);
                return;
			}

			object[] _period = _data1.Rows[0].ItemArray;

			if (Processor.Compare((_current - _opened).Days.ToString(), _period[TblColumn.T_PERIOD].ToString()) < 0)
			{
                MessageBox.Show(IMessage.MSG_NOTENOUGH_TIMES, IMessage.CPT_NOTICE);
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
                    MessageBox.Show(IMessage.MSG_REQUIRED, IMessage.CPT_NOTICE);
					return;
				}


				// Validate input
				double _outcome = Processor.ConvertToDouble(txt_cash_withdrawal.Text);
				if(_outcome == Processor.UNIDENTIFIED)
				{
                    MessageBox.Show(IMessage.MSG_WRONG_INPUT, IMessage.CPT_NOTICE);
					return;
				}

				if(_outcome > Processor.ConvertToDouble(_cash))
				{
                    MessageBox.Show(IMessage.MSG_NOTENOUGH_MONEY, IMessage.CPT_NOTICE);
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

			string _staffId = cbb_staff_withdrawal.Text.Split(':')[0];

			// Create withdrawal
			if (PassbookModel.InsertOutcome(_passbookId, _staffId, _withdrawal, _current.ToString()) == false)
			{
                MessageBox.Show(IMessage.MSG_SOMETHING_WENT_WRONG, IMessage.CPT_NOTICE);
				return;
			}

			// Close passbook
			if (Processor.Compare(_cash, "0") == 0)
			{
				List<string> _status = _passbook[TblColumn.P_STATUS].ToString().Split('|').ToList();
				_status.Add("close-" + _current.ToString());
				PassbookModel.UpdateStatusByPassbookId(_passbookId, string.Join("|", _status));
			}


			// Update info
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
                MessageBox.Show(IMessage.MSG_SOMETHING_WENT_WRONG, IMessage.CPT_NOTICE);
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

			list_monthly.Items.Clear();
		}

		private void btn_show_monthly_Click(object sender, EventArgs e)
		{
			if(cbb_period_monthly.Text == "")
			{
                MessageBox.Show(IMessage.MSG_CHOOSE_PS, IMessage.CPT_NOTICE);
				return;
			}

			DateTime _dateTime = date_monthly.Value;

			DataTable _data1 = PassbookModel.SelectPeriodByName(cbb_period_monthly.Text);

			if (_data1.Rows.Count == 0)
			{
                MessageBox.Show(IMessage.MSG_SOMETHING_WENT_WRONG, IMessage.CPT_NOTICE);
                return;
			}

			object[] _period = _data1.Rows[0].ItemArray;
			string _periodId = _period[TblColumn.T_ID].ToString();

			list_monthly.Items.Clear();

			int _daysCount = Processor.CountDay(_dateTime.Month, _dateTime.Year);

			for (int i = 0; i < _daysCount; i++)
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

				for (int j = 0; j < _data2.Rows.Count; j++)
				{
					object[] _passbook = _data2.Rows[j].ItemArray;

					if (_passbook[TblColumn.P_PERIOD_ID].ToString() == _periodId)
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

