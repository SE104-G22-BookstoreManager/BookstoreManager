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
		private void btn_check_Click(object sender, EventArgs e)
		{
			try
			{
				if(txt_identity_number_open.Text == "")
				{
					MessageBox.Show("Please type identity number!!!");
				}
				else
				{
					DataTable _result1 = PassbookModel.SelectCustomerByIdentityNumber(txt_identity_number_open.Text);

					if (_result1.Rows.Count != 0)
					{
						object[] _itemArray = _result1.Rows[0].ItemArray;

						lbl_customer_id_open.Text = _itemArray[0].ToString();

						txt_name_open.Text = _itemArray[1].ToString();
						txt_identity_number_open.Text = _itemArray[2].ToString();
						txt_address_open.Text = _itemArray[3].ToString();
						txt_phone_number_open.Text = _itemArray[4].ToString();

						txt_name_open.Enabled = false;
						txt_identity_number_open.Enabled = false;
						txt_address_open.Enabled = false;
						txt_phone_number_open.Enabled = false;
					}
					else
					{
						MessageBox.Show("Account not found. Please type all information to add new account!!!");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btn_submit_Click(object sender, EventArgs e)
		{
			if (txt_name_open.Text == "" ||
				txt_identity_number_open.Text == "" ||
				txt_address_open.Text == "" ||
				txt_phone_number_open.Text == "")
			{
				MessageBox.Show("All informations are required!!!");
			}
			else
			{
				DataTable _result1 = PassbookModel.SelectCustomerByIdentityNumber(txt_identity_number_open.Text);

				if (_result1.Rows.Count != 0)
				{
					MessageBox.Show("Account is already exist!!!");
				}
				else
				{
					if(PassbookModel.InsertCustomer(txt_name_open.Text, txt_identity_number_open.Text, txt_address_open.Text, txt_phone_number_open.Text) == false)
					{
						MessageBox.Show("Something went wrong!!!");
						return;
					}

					DataTable _result2 = PassbookModel.SelectCustomerByIdentityNumber(txt_identity_number_open.Text);
					object[] _itemArray = _result1.Rows[0].ItemArray;
					lbl_customer_id_open.Text = _itemArray[0].ToString();

					txt_name_open.Enabled = false;
					txt_identity_number_open.Enabled = false;
					txt_address_open.Enabled = false;
					txt_phone_number_open.Enabled = false;
				}
			}
		}

		private void btn_create_Click(object sender, EventArgs e)
		{
			int _typeID = 0;
			//if (radio_no_terms.Checked == true)
			//{
			//	_typeID = 0;
			//}
			//else if (radio_3months.Checked == true)
			//{
			//	_typeID = 1;
			//}
			//else if (radio_6months.Checked == true)
			//{
			//	_typeID = 2;
			//}

			if(Convert.ToInt64(txt_cash_open.Text) < 1000000)
			{
				MessageBox.Show("Số tiền gửi quá ít, vui lòng kiểm tra lại");
				return;
			}

			DateTime _dateTime = calendar_open.SelectionEnd.Date;
			if (PassbookModel.InsertPassbook(_typeID.ToString(), lbl_customer_id_open.Text, txt_cash_open.Text, _dateTime.ToString()) == false)
			{
				MessageBox.Show("Something went wrong!!!");
				return;
			}
		}

		private void btn_clear_open_Click(object sender, EventArgs e)
		{
			txt_name_open.Enabled = true;
			txt_identity_number_open.Enabled = true;
			txt_address_open.Enabled = true;
			txt_phone_number_open.Enabled = true;

			txt_name_open.Text = "";
			txt_identity_number_open.Text = "";
			txt_address_open.Text = "";
			txt_phone_number_open.Text = "";

			txt_cash_open.Text = "";
		}
		////////////////////////////////////////////////////////////////////


		////////////////////////////////////////////////////////////////////
		// Control for create lookup
		private void btn_refresh_lookup_Click(object sender, EventArgs e)
		{

		}
		////////////////////////////////////////////////////////////////////


		////////////////////////////////////////////////////////////////////
		// Control for create deposit
		private void btn_check_deposit_Click(object sender, EventArgs e)
		{

		}

		private void btn_create_deposit_Click(object sender, EventArgs e)
		{

		}

		private void btn_refresh_deposit_Click(object sender, EventArgs e)
		{

		}
		////////////////////////////////////////////////////////////////////


		////////////////////////////////////////////////////////////////////
		// Control for create withdrawal
		private void btn_check_withdrawal_Click(object sender, EventArgs e)
		{

		}

		private void btn_create_withdrawal_Click(object sender, EventArgs e)
		{

		}

		private void btn_refresh_withdrawal_Click(object sender, EventArgs e)
		{

		}
		////////////////////////////////////////////////////////////////////


		////////////////////////////////////////////////////////////////////
		// Control for create daily report
		private void btn_refresh_daily_Click(object sender, EventArgs e)
		{

		}
		////////////////////////////////////////////////////////////////////


		////////////////////////////////////////////////////////////////////
		// Control for create monthly report
		private void btn_refresh_monthly_Click(object sender, EventArgs e)
		{
			
		}
		////////////////////////////////////////////////////////////////////
	}
}
