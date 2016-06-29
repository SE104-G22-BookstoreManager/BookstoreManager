using MaterialSkin.Controls;
using System;
using System.Data;
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

			if((Convert.ToInt32(Params.CURRENT_SESSION[Params.CURRENT_ROLES]) & Roles.ROLE_MANAGER) == Roles.ROLE_MANAGER)
			{
				tab_manage_staffs.Parent = tab_control_edit;
			}
			else
			{
				tab_manage_staffs.Parent = null;
			}
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
				double _cash = Processor.ConvertToDouble(txt_min_edit_cash.Text);

				if (_cash > 0)
				{
					PassbookModel.UpdateMinCash(txt_min_edit_cash.Text);
					MessageBox.Show("Success update min cash to " + txt_min_edit_cash.Text);
				}
			}

			if (txt_add_min_edit_cash.Text != "")
			{
				double _income = Processor.ConvertToDouble(txt_add_min_edit_cash.Text);

				if (_income > 0)
				{
					PassbookModel.UpdateMinIncome(txt_add_min_edit_cash.Text);
					MessageBox.Show("Success update min income to " + txt_add_min_edit_cash.Text);
				}
			}
		}

		private void btn_ok_edit_cash_Click(object sender, EventArgs e)
		{
			Hide();
			DialogResult = DialogResult.OK;
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
						MessageBox.Show("Current period have deleted successfully", "Delete period");
					}
					break;
				default:
					break;
			}
		}

		private void btn_ok_edit_type_Click(object sender, EventArgs e)
		{
			Hide();
			DialogResult = DialogResult.OK;
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
	}
}
