using MaterialSkin.Controls;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PassbookManagement.src
{
	public enum ControlBtn
	{
		CONTROL_ADD,
		CONTROL_EDIT,
		CONTROL_REMOVE
	}

	public partial class Dashboard : MaterialForm
	{
		private ControlBtn m_control;
		private int m_roles;

        private static readonly double S_MIN_CASH = 1000000;
        private static readonly double S_MIN_INCOME = 1000000;

        public Dashboard()
		{
			InitializeComponent();

			cbb_period_edit_period.Hide();
			m_control = ControlBtn.CONTROL_ADD;

			string _roles = Params.CURRENT_SESSION[Params.CURRENT_ROLES].ToString();
			m_roles = Convert.ToInt32(_roles);

			InitializeAccount();
		}

		////////////////////////////////////////////////////////////////////
		// Control for edit cash
		/// <summary>
		///     
		/// </summary>
		private void btn_apply_edit_cast_Click(object sender, EventArgs e)
		{
			if ((m_roles & Roles.ROLE_MANAGER) != Roles.ROLE_MANAGER)
			{
				MessageBox.Show(IMessage.MSG_PERMISSION_DENY, IMessage.CPT_NOTICE);
				return;
			}

			if (txt_min_cash.Text != "")
			{
				double _cash = Processor.ConvertToDouble(txt_min_cash.Text);

				if (_cash == Processor.UNIDENTIFIED)
				{
					MessageBox.Show(IMessage.MSG_WRONG_INPUT, IMessage.CPT_NOTICE);
					return;
				}

                if(_cash < S_MIN_CASH)
                {
                    MessageBox.Show(IMessage.MSG_TOO_FEW_CASH, IMessage.CPT_NOTICE);
                    return;
                }

				PassbookModel.UpdateMinCash(txt_min_cash.Text);
				MessageBox.Show("Success update min cash to " + txt_min_cash.Text);
			}

			if (txt_min_income.Text != "")
			{
				double _income = Processor.ConvertToDouble(txt_min_income.Text);

				if (_income == Processor.UNIDENTIFIED)
				{
					MessageBox.Show(IMessage.MSG_WRONG_INPUT, IMessage.CPT_NOTICE);
					return;
				}

                if (_income < S_MIN_INCOME)
                {
                    MessageBox.Show(IMessage.MSG_TOO_FEW_CASH, IMessage.CPT_NOTICE);
                    return;
                }

                PassbookModel.UpdateMinIncome(txt_min_income.Text);
				MessageBox.Show("Success update min income to " + txt_min_income.Text);
			}
		}

		private void btn_cancel_edit_cash_Click(object sender, EventArgs e)
		{
			Hide();
			DialogResult = DialogResult.Cancel;
		}


		////////////////////////////////////////////////////////////////////
		// Control for edit period
		/// <summary>
		///     
		/// </summary>
		private void btn_add_edit_period_Click(object sender, EventArgs e)
		{
			cbb_period_edit_period.Hide();

			lbl_id_edit_period.Show();
			txt_name_edit_period.Show();

			txt_rate_edit_period.Show();
			txt_period_edit_period.Show();

			lbl_id_edit_period.Text = "ID";
			txt_name_edit_period.Clear();
			txt_rate_edit_period.Clear();
			txt_period_edit_period.Clear();

			m_control = ControlBtn.CONTROL_ADD;
		}

		private void btn_edit_edit_period_Click(object sender, EventArgs e)
		{
			cbb_period_edit_period.Show();

			lbl_id_edit_period.Show();
			txt_name_edit_period.Show();

			txt_rate_edit_period.Show();
			txt_period_edit_period.Show();

			GetPeriod();

			cbb_period_edit_period.Text = "";
			lbl_id_edit_period.Text = "ID";
			txt_name_edit_period.Clear();
			txt_rate_edit_period.Clear();
			txt_period_edit_period.Clear();

			m_control = ControlBtn.CONTROL_EDIT;
		}

		private void btn_remove_edit_period_Click(object sender, EventArgs e)
		{
			cbb_period_edit_period.Show();

			lbl_id_edit_period.Hide();
			txt_name_edit_period.Hide();

			txt_rate_edit_period.Hide();
			txt_period_edit_period.Hide();

			GetPeriod();

			cbb_period_edit_period.Text = "";
			lbl_id_edit_period.Text = "ID";
			txt_name_edit_period.Clear();
			txt_rate_edit_period.Clear();
			txt_period_edit_period.Clear();

			m_control = ControlBtn.CONTROL_REMOVE;
		}

		private void btn_apply_edit_period_Click(object sender, EventArgs e)
		{
			if ((m_roles & Roles.ROLE_MANAGER) != Roles.ROLE_MANAGER)
			{
				MessageBox.Show(IMessage.MSG_PERMISSION_DENY, IMessage.CPT_NOTICE);
				return;
			}

			switch (m_control)
			{
				case ControlBtn.CONTROL_ADD:
					{
						if(txt_name_edit_period.Text == "" ||
							txt_rate_edit_period.Text == "" ||
							txt_period_edit_period.Text == "")
						{
							MessageBox.Show(IMessage.MSG_REQUIRED_ALL, IMessage.CPT_NOTICE);
							return;
						}

						DataTable _data = PassbookModel.SelectPeriodByName(txt_name_edit_period.Text);

						if (_data.Rows.Count != 0)
						{
							MessageBox.Show(IMessage.MSG_PERIOD_ALREADY_EXIST, IMessage.CPT_NOTICE);
							return;
						}

						if (PassbookModel.InsertPeriod(txt_name_edit_period.Text, txt_rate_edit_period.Text, txt_period_edit_period.Text) == false)
						{
							MessageBox.Show(IMessage.MSG_SOMETHING_WENT_WRONG, IMessage.CPT_NOTICE);
							return;
						}
						MessageBox.Show(IMessage.MSG_SUCCESS_ADD_PERIOD, IMessage.CPT_CREATE_PERIOD);
					}
					break;
				case ControlBtn.CONTROL_EDIT:
					{
						if (txt_name_edit_period.Text == "" ||
							txt_rate_edit_period.Text == "" ||
							txt_period_edit_period.Text == "")
						{
							MessageBox.Show(IMessage.MSG_REQUIRED_ALL, IMessage.CPT_NOTICE);
							return;
						}

						if (PassbookModel.UpdatePeriod(lbl_id_edit_period.Text, txt_name_edit_period.Text, txt_rate_edit_period.Text, txt_period_edit_period.Text) == false)
						{
							MessageBox.Show(IMessage.MSG_SOMETHING_WENT_WRONG, IMessage.CPT_NOTICE);
							return;
						}
						MessageBox.Show(IMessage.MSG_SUCCESS_EDIT_PERIOD, IMessage.CPT_EDIT_PERIOD);
					}
					break;
				case ControlBtn.CONTROL_REMOVE:
					{
						if(cbb_period_edit_period.Text == "")
						{
							MessageBox.Show(IMessage.MSG_PERIOD_NOT_EXIST, IMessage.CPT_NOTICE);
							return;
						}

						DataTable _data = PassbookModel.SelectPeriodByName(cbb_period_edit_period.Text);

						if (_data.Rows.Count == 0)
						{
							MessageBox.Show(IMessage.MSG_SOMETHING_WENT_WRONG, IMessage.CPT_NOTICE);
							return;
						}

						object[] _period = _data.Rows[0].ItemArray;
						string _periodId = _period[TblColumn.T_ID].ToString();

						if (_periodId == "1")
						{
							MessageBox.Show(IMessage.MSG_FAILED_DELETE_PERIOD, IMessage.CPT_NOTICE);
							return;
						}

						if (PassbookModel.DeletePeriodById(_periodId) == false)
						{
							MessageBox.Show(IMessage.MSG_SOMETHING_WENT_WRONG, IMessage.CPT_NOTICE);
							return;
						}
						MessageBox.Show(IMessage.MSG_SUCCESS_DELETE_PERIOD, IMessage.CPT_DELETE_PERIOD);
					}
					break;
				default:
					break;
			}
		}

		private void btn_cancel_edit_type_Click(object sender, EventArgs e)
		{
			Hide();
			DialogResult = DialogResult.Cancel;
		}

		private void cbb_period_edit_period_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable _data = PassbookModel.SelectPeriodByName(cbb_period_edit_period.Text);

			if(_data.Rows.Count == 0)
			{
				MessageBox.Show(IMessage.MSG_PERIOD_NOT_EXIST, IMessage.CPT_NOTICE);
				return;
			}

			object[] _period = _data.Rows[0].ItemArray;

			lbl_id_edit_period.Text = _period[TblColumn.T_ID].ToString();

			txt_name_edit_period.Text = _period[TblColumn.T_NAME].ToString();
			txt_rate_edit_period.Text = _period[TblColumn.T_RATE].ToString();
			txt_period_edit_period.Text = _period[TblColumn.T_PERIOD].ToString();
		}

		private void GetPeriod()
		{
			cbb_period_edit_period.Items.Clear();

			DataTable _data = PassbookModel.SelectAllPeriod();
			if (_data.Rows.Count != 0)
			{
				for (int i = 0; i < _data.Rows.Count; i++)
				{
					object[] _period = _data.Rows[i].ItemArray;
					cbb_period_edit_period.Items.Add(_period[TblColumn.T_NAME].ToString());
				}
			}
		}


		////////////////////////////////////////////////////////////////////
		// Control for edit account
		/// <summary>
		///     
		/// </summary>
		private void btn_edit_account_Click(object sender, EventArgs e)
		{
			if(	txt_email_account.Text == "" ||
				txt_name_account.Text == "" ||
				txt_identity_number_account.Text == "" ||
				txt_phone_number_account.Text == "")
			{
				MessageBox.Show(IMessage.MSG_REQUIRED_ALL, IMessage.CPT_NOTICE);
				return;
			}

			if(PassbookModel.UpdateStaff(lbl_id_account.Text, 
											txt_name_account.Text, 
											txt_email_account.Text, 
											txt_identity_number_account.Text, 
											txt_phone_number_account.Text) == false)
			{
				MessageBox.Show(IMessage.MSG_FAILED_EDIT_ACCOUNT, IMessage.CPT_NOTICE);
				return;
			}

            MessageBox.Show(IMessage.MSG_SUCCESS_EDIT_ACCOUNT, IMessage.CPT_NOTICE);
		}

		private void btn_change_password_account_Click(object sender, EventArgs e)
		{
			if (txt_current_password_account.Text == "" ||
				txt_new_password.Text == "" ||
				txt_new_password_confirm.Text == "")
			{
				MessageBox.Show(IMessage.MSG_REQUIRED_ALL, IMessage.CPT_NOTICE);
				return;
			}

			using (MD5 md5Hash = MD5.Create())
			{
				string passwordHash = Processor.GetMd5Hash(md5Hash, txt_current_password_account.Text);
				if (!Processor.VerifyMd5Hash(md5Hash, txt_current_password_account.Text, passwordHash))
				{
                    MessageBox.Show(IMessage.MSG_SOMETHING_WENT_WRONG, IMessage.CPT_NOTICE);
					return;
				}

				if(passwordHash != Params.CURRENT_SESSION[Params.CURRENT_PASSWORD].ToString())
				{
					MessageBox.Show(IMessage.MSG_WRONG_CURRENT_PASSWORD,IMessage.CPT_NOTICE);
					return;
				}
			}

			if(txt_new_password.Text != txt_new_password_confirm.Text)
			{
                MessageBox.Show(IMessage.MSG_PASSWORD_MISMATCHED, IMessage.CPT_NOTICE);
				return;
			}

			using (MD5 md5Hash = MD5.Create())
			{
				string passwordHash = Processor.GetMd5Hash(md5Hash, txt_new_password.Text);
				if (!Processor.VerifyMd5Hash(md5Hash, txt_new_password.Text, passwordHash))
				{
                    MessageBox.Show(IMessage.MSG_SOMETHING_WENT_WRONG, IMessage.CPT_NOTICE);
					return;
				}

				if (PassbookModel.UpdatePasswordByStaffId(lbl_id_account.Text, passwordHash) == false)
				{
                    MessageBox.Show(IMessage.MSG_CANNOT_UPDATE_PASSWORD, IMessage.CPT_NOTICE);
					return;
				}

                MessageBox.Show(IMessage.MSG_SUCCESS_UPDATE_PASSWORD, IMessage.CPT_NOTICE);
			}
		}

		private void InitializeAccount()
		{
			DataTable _data = PassbookModel.SelectStaffByEmail(Params.CURRENT_SESSION[Params.CURRENT_EMAIL].ToString());

			if(_data.Rows.Count == 0)
			{
				MessageBox.Show(IMessage.MSG_SOMETHING_WENT_WRONG,IMessage.CPT_NOTICE);
				return;
			}

			object[] _account = _data.Rows[0].ItemArray;

			lbl_id_account.Text = _account[TblColumn.S_ID].ToString();
			txt_email_account.Text = _account[TblColumn.S_EMAIL].ToString();
			txt_name_account.Text = _account[TblColumn.S_NAME].ToString();
			txt_identity_number_account.Text = _account[TblColumn.S_IDENTITY_NUMBER].ToString();
			txt_phone_number_account.Text = _account[TblColumn.S_PHONE_NUMBER].ToString();

			txt_email_account.Enabled = false;
			txt_name_account.Enabled = true;
			txt_identity_number_account.Enabled = false;
			txt_phone_number_account.Enabled = true;

			if((m_roles & Roles.ROLE_MANAGER) == Roles.ROLE_MANAGER)
			{
				tab_cash_edit.Parent = tab_control_edit;
				tab_period_edit.Parent = tab_control_edit;
			}
			else
			{
				tab_cash_edit.Parent = null;
				tab_period_edit.Parent = null;
			}

		}

		////////////////////////////////////////////////////////////////////
		// Control for edit customer
		/// <summary>
		///     
		/// </summary>
		/// 
		private void SelectCustomer()
		{
			DataTable _data = null;

			// Select customer by identity number. This is priority order.
			if (txt_identity_number_customer.Text != "")
			{
				_data = PassbookModel.SelectCustomerByIdentityNumber(txt_identity_number_customer.Text);
			}
			// Select customer by phone number
			else if (txt_phone_number_customer.Text != "")
			{
				_data = PassbookModel.SelectCustomerByPhoneNumber(txt_phone_number_customer.Text);
			}
			else
			{
				MessageBox.Show(IMessage.MSG_REQUIRE_ID, IMessage.CPT_NOTICE);
				return;
			}

			if (_data.Rows.Count == 0)
			{
				MessageBox.Show(IMessage.MSG_ACCOUNT_NOT_FOUND, IMessage.CPT_NOTICE);
				return;
			}

			// Extract info
			object[] _customer = _data.Rows[0].ItemArray;

			lbl_customer_id_customer.Text = _customer[TblColumn.A_ID].ToString();
			txt_name_customer.Text = _customer[TblColumn.A_NAME].ToString();
			txt_identity_number_customer.Text = _customer[TblColumn.A_IDENTITY_NUMBER].ToString();
			txt_address_customer.Text = _customer[TblColumn.A_ADDRESS].ToString();
			txt_phone_number_customer.Text = _customer[TblColumn.A_PHONE_NUMBER].ToString();
			
			txt_identity_number_customer.Enabled = false;
		}

		private void btn_check_edit_customer_Click(object sender, EventArgs e)
		{
			SelectCustomer();
		}

		private void txt_identity_number_edit_customer_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				SelectCustomer();
			}
		}

		private void txt_phone_number_edit_customer_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				SelectCustomer();
			}
		}

		private void btn_apply_edit_customer_Click(object sender, EventArgs e)
		{
			if (txt_name_customer.Text == "" ||
				txt_identity_number_customer.Text == "" ||
				txt_address_customer.Text == "" ||
				txt_phone_number_customer.Text == "")
			{
				MessageBox.Show(IMessage.MSG_REQUIRED_ALL, IMessage.CPT_NOTICE);
				return;
			}

			if (PassbookModel.UpdateCustomer(lbl_customer_id_customer.Text,
											txt_name_customer.Text,
											txt_identity_number_customer.Text,
											txt_address_customer.Text,
											txt_phone_number_customer.Text) == false)
			{
				MessageBox.Show(IMessage.MSG_FAILED_EDIT_ACCOUNT, IMessage.CPT_NOTICE);
				return;
			}

			MessageBox.Show(IMessage.MSG_SUCCESS_EDIT_ACCOUNT, IMessage.CPT_NOTICE);
		}

		private void btn_cancel_edit_customer_Click(object sender, EventArgs e)
		{
			Hide();
			DialogResult = DialogResult.Cancel;
		}

		private void btn_refresh_edit_customer_Click(object sender, EventArgs e)
		{
			txt_identity_number_customer.Enabled = true;

			lbl_customer_id_customer.Text = "ID";
			txt_name_customer.Text = "";
			txt_identity_number_customer.Text = "";
			txt_address_customer.Text = "";
			txt_phone_number_customer.Text = "";
		}
	}
}
