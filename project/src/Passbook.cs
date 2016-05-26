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
			materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber600, Primary.Amber800, Primary.Amber300, Accent.LightBlue200, TextShade.WHITE);
		}

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
					string _query1 = "SELECT * FROM Customers WHERE identity_number=\"" + txt_identity_number_open.Text + "\"";
					DataTable _result1 = Database.SQLiteDatabase.GetDataTable(_query1);

					if (_result1.Rows.Count == 0)
					{
						//object[] _itemArray = _result1.Rows[0].ItemArray;
						txt_name_open.Text = "AAAAAAAAAAAAAAAAAA";
						txt_identity_number_open.Text = "AAAAAAAAAAAAAAAAAA";
						txt_address_open.Text = "AAAAAAAAAAAAAAAAAA";
						txt_phone_number_open.Text = "AAAAAAAAAAAAAAAAAA";

						btn_check_open.Enabled = false;
						btn_submit_open.Enabled = false;

						txt_name_open.Enabled = false;
						txt_identity_number_open.Enabled = false;
						txt_address_open.Enabled = false;
						txt_phone_number_open.Enabled = false;
					}
					else
					{
						MessageBox.Show("Account not found. Please type all information to add new account!!!");

						btn_check_open.Enabled = false;
						btn_submit_open.Enabled = true;
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
							txt_address_open.Text == "" ||
							txt_phone_number_open.Text == "")
			{
				MessageBox.Show("All informations are required!!!");
			}
			else
			{
				Database.SQLiteDatabase.Insert("Customers", SDictionary.CreateCustomer(txt_name_open.Text, txt_identity_number_open.Text, txt_address_open.Text, txt_phone_number_open.Text));
			}
		}

		private void btn_create_Click(object sender, EventArgs e)
		{
			//string TietKiemLoai = "0";
			//if (radio_no_terms.Checked == true)
			//{
			//	TietKiemLoai = "0";
			//}
			//if (radio_3months.Checked == true)
			//{
			//	TietKiemLoai = "3";
			//}
			//if (radio_6months.Checked == true)
			//{
			//	TietKiemLoai = "6";
			//}
			//double tien = Convert.ToDouble(txt_cash_open.Text);
			//if (tien < 1000000)
			//{
			//	MessageBox.Show(" tien duoi 1000000 nhap lai", "Thong Bao ");
			//}
			//else
			//{

			//	String sql1 = "select id from KhachHang where CMND=\"" + txt_identity_number_open.Text + "\" ";

			//	DataTable _queryResult1 = Database.SQLiteDatabase.GetDataTable(sql1);


			//	if (_queryResult1.Rows.Count == 0)
			//	{
			//		Database.SQLiteDatabase.Insert("KhachHang", SDictionary.CreateCustomer(txt_name_open.Text, txt_identity_number_open.Text, txt_address_open.Text, txt_phone_number_open.Text));
			//		String sql2 = "select id from KhachHang where CMND=\"" + txt_cmnd.Text + "\" ";
			//		DataTable _queryResult2 = a.m_database.GetDataTable(sql2);
			//		object[] _itemArray = _queryResult1.Rows[0].ItemArray;
			//		txt_MKH.Text = _itemArray[0].ToString();
			//		a.m_database.Insert("SoTietKiem", CreateDictionary(txt_MKH.Text, txt_tiengui.Text, txt_ngaygui.Text, TietKiemLoai));
			//		MessageBox.Show(" DA Mo DUOC SO TIET KIEM");

			//	}
			//	else
			//	{


			//		object[] _itemArray = _queryResult1.Rows[0].ItemArray;
			//		txt_MKH.Text = _itemArray[0].ToString();
			//		a.m_database.Insert("SoTietKiem", CreateDictionary(txt_MKH.Text, txt_tiengui.Text, txt_ngaygui.Text, TietKiemLoai));
			//		MessageBox.Show(" DA Mo DUOC SO TIET KIEM");



			//	}
			//}
		}
	}
}
