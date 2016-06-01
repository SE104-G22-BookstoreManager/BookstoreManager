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
            txt_add_min_edit_cash.Enabled = false;
            txt_min_edit_cash.Enabled = false;
            returntypepassbook();

		}

		private void btn_apply_edit_cast_Click(object sender, EventArgs e)
		{
            if (txt_min_edit_cash.Text!="")
            {
                PassbookModel.updatemoneymin(txt_min_edit_cash.Text);
            }
         
            if(txt_add_min_edit_cash.Text!="")
            {
             PassbookModel.updateMoneyMinMore(txt_add_min_edit_cash.Text);
            }
		}

		private void btn_ok_edit_cash_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btn_add_edit_period_Click(object sender, EventArgs e)
		{
			cbb_type_edit_period.Hide();
			txt_type_edit_period.Show();
			txt_rate_edit_period.Show();
            txt_name.Show();
            txt_date.Show();
            txt_id.Hide();
            btn_delete.Hide();
            btn_edit.Hide();
		}

		private void btn_edit_edit_period_Click(object sender, EventArgs e)
		{
			cbb_type_edit_period.Show();
			txt_type_edit_period.Show();
            txt_name.Show();
            txt_rate_edit_period.Show();
            txt_date.Show();
            btn_delete.Hide();
            btn_add.Hide();
            try
                {
            string name_type = cbb_type_edit_period.Text;
            DataTable _result2 = PassbookModel.SelectIdTypePassbook(name_type);
           // int count = _result2.Rows.Count;
            object[] _itemArray2 = _result2.Rows[0].ItemArray;
            txt_id.Text = _itemArray2[0].ToString();
           txt_type_edit_period.Text  = _itemArray2[1].ToString();
           txt_name.Text = _itemArray2[2].ToString();
           txt_rate_edit_period.Text = _itemArray2[3].ToString();
           txt_date.Text = _itemArray2[4].ToString();
                txt_id.Enabled=false;
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



            

		}
        public void returntypepassbook()
        {
            DataTable _result2 = PassbookModel.SelectTypePassbook();
            if (_result2.Rows.Count != 0)
            {
                for (int i = 0; i < _result2.Rows.Count; i++)
                {
                    object[] _itemArray2 = _result2.Rows[i].ItemArray;
                    cbb_type_edit_period.Items.Add(_itemArray2[2].ToString());
                    

                }
            }
        }

		private void btn_remove_edit_period_Click(object sender, EventArgs e)
		{
			cbb_type_edit_period.Show();
			txt_type_edit_period.Hide();
			
			txt_rate_edit_period.Hide();
            txt_date.Hide();
            txt_name.Hide();
            btn_add.Hide();
            btn_edit.Hide();
            txt_id.Hide();


            

		}

		private void btn_apply_edit_type_Click(object sender, EventArgs e)
		{
         
            if (PassbookModel.InsertTypePassbook(txt_type_edit_period.Text, txt_name.Text, txt_rate_edit_period.Text, txt_date.Text) == false)
            {
                MessageBox.Show("Something went wrong!!!");
                return;
            }
            else
            {
                MessageBox.Show("Success");
                return;
            }

		}

		private void btn_ok_edit_type_Click(object sender, EventArgs e)
		{
			Close();
		}

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            
              txt_add_min_edit_cash.Enabled = true ;
              txt_min_edit_cash.Enabled = false;
              txt_min_edit_cash.Text = "";
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            txt_min_edit_cash.Enabled = true;
            txt_add_min_edit_cash.Enabled = false;
            txt_add_min_edit_cash.Text = "";
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {

                if (PassbookModel.UpdateTypePassbook(txt_type_edit_period.Text, txt_name.Text,txt_rate_edit_period.Text,txt_date.Text,txt_id.Text) == false)
                {
                    MessageBox.Show("Something went wrong!!!");
                    return;
                }
                else
                {
                    MessageBox.Show("Success");
                    return;
                }
               
             
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string type_name = cbb_type_edit_period.Text;
            if (PassbookModel.delete_typepassbook(type_name) == false)
            {
                MessageBox.Show("Something went wrong!!!");
                return;
            }
            else
            {
                MessageBox.Show("Success");
                return;
            }

        }
	}
}
