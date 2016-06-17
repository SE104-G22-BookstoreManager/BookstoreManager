﻿using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace PassbookManagement.src
{
	public enum Control
	{
		CONTROL_ADD,
		CONTROL_EDIT,
		CONTROL_REMOVE
	}

	public partial class EditCondition : MaterialForm
	{
		private Control m_control;

		public EditCondition()
		{
			InitializeComponent();

			cbb_period_edit_period.Hide();
			m_control = Control.CONTROL_ADD;
		}

		////////////////////////////////////////////////////////////////////
		// Control for edit cash
		/// <summary>
		///     
		/// </summary>
		private void btn_apply_edit_cast_Click(object sender, EventArgs e)
		{
			if (txt_min_edit_cash.Text != "")
			{
				PassbookModel.UpdateMinCash(txt_min_edit_cash.Text);
				MessageBox.Show("Success update min cash to " + txt_min_edit_cash.Text);
			}

			if (txt_add_min_edit_cash.Text != "")
			{
				PassbookModel.UpdateMinIncome(txt_add_min_edit_cash.Text);
				MessageBox.Show("Success update min income to " + txt_add_min_edit_cash.Text);
			}
		}

		private void btn_ok_edit_cash_Click(object sender, EventArgs e)
		{
			Close();
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

			m_control = Control.CONTROL_ADD;
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

			m_control = Control.CONTROL_EDIT;
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

			m_control = Control.CONTROL_REMOVE;
		}

		private void btn_apply_edit_type_Click(object sender, EventArgs e)
		{
			switch(m_control)
			{
				case Control.CONTROL_ADD:
					if (PassbookModel.InsertPeriod(txt_name_edit_period.Text, txt_rate_edit_period.Text, txt_period_edit_period.Text) == false)
					{
						MessageBox.Show("Something went wrong!!!");
						return;
					}
					MessageBox.Show("Success");
					break;
				case Control.CONTROL_EDIT:
					if (PassbookModel.UpdatePeriod(lbl_id_edit_period.Text, txt_name_edit_period.Text, txt_rate_edit_period.Text, txt_period_edit_period.Text) == false)
					{
						MessageBox.Show("Something went wrong!!!");
						return;
					}
					MessageBox.Show("Success");
					break;
				case Control.CONTROL_REMOVE:
					DataTable _data = PassbookModel.SelectPeriodByName(cbb_period_edit_period.Text);

					if(_data.Rows.Count == 0)
					{
						MessageBox.Show("Something went wrong!!!");
						return;
					}

					object[] _period = _data.Rows[0].ItemArray;
					string _periodId = _period[TblColumn.T_ID].ToString();

					if(_periodId == "1")
					{
						MessageBox.Show("System alert!!! Cannot delete this period.");
						return;
					}

					if (PassbookModel.DeletePeriodById(_periodId) == false)
					{
						MessageBox.Show("Something went wrong!!!");
						return;
					}
					MessageBox.Show("Success");
					break;
				default:
					break;
			}
		}

		private void btn_ok_edit_type_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cbb_period_edit_period_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				string name_type = cbb_period_edit_period.Text;
				DataTable _result2 = PassbookModel.SelectPeriodByName(name_type);

				object[] _itemArray2 = _result2.Rows[0].ItemArray;
				lbl_id_edit_period.Text = _itemArray2[0].ToString();

				txt_name_edit_period.Text = _itemArray2[2].ToString();
				txt_rate_edit_period.Text = _itemArray2[3].ToString();
				txt_period_edit_period.Text = _itemArray2[4].ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void GetPeriod()
		{
			cbb_period_edit_period.Items.Clear();

			DataTable _result2 = PassbookModel.SelectAllPeriod();
			if (_result2.Rows.Count != 0)
			{
				for (int i = 0; i < _result2.Rows.Count; i++)
				{
					object[] _itemArray2 = _result2.Rows[i].ItemArray;
					cbb_period_edit_period.Items.Add(_itemArray2[2].ToString());
				}
			}
		}
	}
}
