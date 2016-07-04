using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassbookManagement.src
{
	public partial class LoginForm : MaterialForm
	{
		public LoginForm()
		{
			InitializeComponent();

			if (Params.PARAMS[Params.USERNAME].ToString() != "")
			{
				txt_email_login.Text = Params.PARAMS[Params.USERNAME].ToString();
				txt_password_login.Text = Params.PARAMS[Params.PASSWORD].ToString();
				check_remember_me.Checked = true;
			}
			else
			{
				check_remember_me.Checked = false;
			}
		}

		private void Login()
		{
			if (txt_email_login.Text == "" || txt_password_login.Text == "")
			{
				MessageBox.Show(IMessage.MSG_REQUIRED,IMessage.CPT_NOTICE);
				return;
			}

			using (MD5 md5Hash = MD5.Create())
			{
				string passwordHash = Processor.GetMd5Hash(md5Hash, txt_password_login.Text);
				if (!Processor.VerifyMd5Hash(md5Hash, txt_password_login.Text, passwordHash))
				{
					MessageBox.Show(IMessage.MSG_SOMETHING_WENT_WRONG,IMessage.CPT_NOTICE);
					return;
				}

				DataTable _data = PassbookModel.SelectStaffByEmailAndPassword(txt_email_login.Text, passwordHash);

				if (_data.Rows.Count == 0)
				{
					MessageBox.Show(IMessage.MSG_WRONG_SIGNIN, IMessage.CPT_NOTICE);
					return;
				}

				object[] _staff = _data.Rows[0].ItemArray;

				Params.CURRENT_SESSION.Add(_staff[TblColumn.S_ID]);
				Params.CURRENT_SESSION.Add(_staff[TblColumn.S_EMAIL]);
				Params.CURRENT_SESSION.Add(_staff[TblColumn.S_PASSWORD]);
				Params.CURRENT_SESSION.Add(_staff[TblColumn.S_NAME]);
				Params.CURRENT_SESSION.Add(_staff[TblColumn.S_ROLES]);

				if (check_remember_me.Checked == true)
				{
					Params.PARAMS[Params.USERNAME] = txt_email_login.Text;
					Params.PARAMS[Params.PASSWORD] = txt_password_login.Text;
				}
				else
				{
					Params.PARAMS[Params.USERNAME] = "";
					Params.PARAMS[Params.PASSWORD] = "";
				}

				Processor.WriteParams(Processor.PARAMS_FILE);

				Hide();
				DialogResult = DialogResult.OK;
			}
		}

		private void btn_login_login_Click(object sender, EventArgs e)
		{
			Login();
		}

		private void btn_cancel_login_Click(object sender, EventArgs e)
		{
			Hide();
			DialogResult = DialogResult.Cancel;
		}

		private void txt_password_login_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				Login();
			}
		}

		private void txt_email_login_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				SelectNextControl((Control)sender, true, true, true, true);
			}
		}
	}
}
