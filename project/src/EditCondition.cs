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
	public partial class EditCondition : MaterialForm
	{
		public EditCondition()
		{
			InitializeComponent();

		}

		private void btn_apply_edit_cast_Click(object sender, EventArgs e)
		{

		}

		private void btn_ok_edit_cash_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btn_add_edit_period_Click(object sender, EventArgs e)
		{
			cbb_type_edit_period.Hide();
			txt_name_edit_period.Show();
			txt_period_edit_period.Show();
			txt_rate_edit_period.Show();
		}

		private void btn_edit_edit_period_Click(object sender, EventArgs e)
		{
			cbb_type_edit_period.Show();
			txt_name_edit_period.Show();
			txt_period_edit_period.Show();
			txt_rate_edit_period.Show();
		}

		private void btn_remove_edit_period_Click(object sender, EventArgs e)
		{
			cbb_type_edit_period.Show();
			txt_name_edit_period.Hide();
			txt_period_edit_period.Hide();
			txt_rate_edit_period.Hide();
		}

		private void btn_apply_edit_type_Click(object sender, EventArgs e)
		{

		}

		private void btn_ok_edit_type_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
