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

		public Dashboard()
		{
			InitializeComponent();

			cbb_period_edit_period.Hide();
			m_control = ControlBtn.CONTROL_ADD;

			InitializeAccount();
		}

		////////////////////////////////////////////////////////////////////
		// Control for edit cash
		/// <summary>
		///     
		/// </summary>
		private void btn_apply_edit_cast_Click(object sender, EventArgs e)
		{
			if (txt_min_cash.Text != "")
			{
				double _cash = Processor.ConvertToDouble(txt_min_cash.Text);

				if (_cash == Processor.UNIDENTIFIED)
				{
					MessageBox.Show("Your input is incorrect. Please check again...", "Notice");
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
					MessageBox.Show("Your input is incorrect. Please check again...", "Notice");
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
			switch(m_control)
			{
				case ControlBtn.CONTROL_ADD:
					{
						DataTable _data = PassbookModel.SelectPeriodByName(txt_name_edit_period.Text);

						if (_data.Rows.Count != 0)
						{
							MessageBox.Show("Current period is already exist. Please choose another name for this period...", "Notice");
							return;
						}

						if (PassbookModel.InsertPeriod(txt_name_edit_period.Text, txt_rate_edit_period.Text, txt_period_edit_period.Text) == false)
						{
							MessageBox.Show("Something went wrong!!!", "Notice");
							return;
						}
						MessageBox.Show("Current period have added successfully", "Create period");
					}
					break;
				case ControlBtn.CONTROL_EDIT:
					{
						if (PassbookModel.UpdatePeriod(lbl_id_edit_period.Text, txt_name_edit_period.Text, txt_rate_edit_period.Text, txt_period_edit_period.Text) == false)
						{
							MessageBox.Show("Something went wrong!!!", "Notice");
							return;
						}
						MessageBox.Show("Current period have edited successfully", "Edit period");
					}
					break;
				case ControlBtn.CONTROL_REMOVE:
					{
						DataTable _data = PassbookModel.SelectPeriodByName(cbb_period_edit_period.Text);

						if (_data.Rows.Count == 0)
						{
							MessageBox.Show("Something went wrong!!!", "Notice");
							return;
						}

						object[] _period = _data.Rows[0].ItemArray;
						string _periodId = _period[TblColumn.T_ID].ToString();

						if (_periodId == "1")
						{
							MessageBox.Show("System alert!!! Cannot delete this period.", "Notice");
							return;
						}

						if (PassbookModel.DeletePeriodById(_periodId) == false)
						{
							MessageBox.Show("Something went wrong!!!", "Notice");
							return;
						}
						MessageBox.Show("Current period have deleted successfully.", "Delete period");
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
				MessageBox.Show("The selected period does not exist!!!", "Notice");
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
				MessageBox.Show("All informations are required!!!", "Notice");
				return;
			}

			if(PassbookModel.UpdateStaff(lbl_id_account.Text, 
											txt_name_account.Text, 
											txt_email_account.Text, 
											txt_identity_number_account.Text, 
											txt_phone_number_account.Text) == false)
			{
				MessageBox.Show("Cannot update your account. Something went wrong!!!", "Notice");
				return;
			}

			MessageBox.Show("Your account have edited successfully.", "Notice");
		}

		private void btn_change_password_account_Click(object sender, EventArgs e)
		{
			if (txt_current_password_account.Text == "" ||
				txt_new_password.Text == "" ||
				txt_new_password_confirm.Text == "")
			{
				MessageBox.Show("All informations are required!!!", "Notice");
				return;
			}

			using (MD5 md5Hash = MD5.Create())
			{
				string passwordHash = Processor.GetMd5Hash(md5Hash, txt_current_password_account.Text);
				if (!Processor.VerifyMd5Hash(md5Hash, txt_current_password_account.Text, passwordHash))
				{
					MessageBox.Show("Something went wrong!!!", "Notice");
					return;
				}

				if(passwordHash != Params.CURRENT_SESSION[Params.CURRENT_PASSWORD].ToString())
				{
					MessageBox.Show("Current password is incorrect. Please try again!!!", "Notice");
					return;
				}
			}

			if(txt_new_password.Text != txt_new_password_confirm.Text)
			{
				MessageBox.Show("New password and New password confirm are mismatched. Please try again!!!", "Notice");
				return;
			}

			using (MD5 md5Hash = MD5.Create())
			{
				string passwordHash = Processor.GetMd5Hash(md5Hash, txt_new_password.Text);
				if (!Processor.VerifyMd5Hash(md5Hash, txt_new_password.Text, passwordHash))
				{
					MessageBox.Show("Something went wrong!!!", "Notice");
					return;
				}

				if (PassbookModel.UpdatePasswordByStaffId(lbl_id_account.Text, passwordHash) == false)
				{
					MessageBox.Show("Cannot update your password. Something went wrong!!!", "Notice");
					return;
				}

				MessageBox.Show("Your password have edited successfully.", "Notice");
			}
		}

		private void InitializeAccount()
		{
			DataTable _data = PassbookModel.SelectStaffByEmail(Params.CURRENT_SESSION[Params.CURRENT_EMAIL].ToString());

			if(_data.Rows.Count == 0)
			{
				MessageBox.Show("Something went wrong!!!", "Notice");
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
		}
	}
}
