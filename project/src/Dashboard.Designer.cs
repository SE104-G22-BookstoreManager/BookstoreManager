namespace PassbookManagement.src
{
	partial class Dashboard
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
			this.tab_selector_edit = new MaterialSkin.Controls.MaterialTabSelector();
			this.tab_control_edit = new MaterialSkin.Controls.MaterialTabControl();
			this.tab_cash_edit = new System.Windows.Forms.TabPage();
			this.btn_cancel_edit_cash = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btn_apply_edit_cast = new MaterialSkin.Controls.MaterialRaisedButton();
			this.txt_min_cash = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_min_income = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.tab_period_edit = new System.Windows.Forms.TabPage();
			this.lbl_id_edit_period = new MaterialSkin.Controls.MaterialLabel();
			this.txt_period_edit_period = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_name_edit_period = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_rate_edit_period = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.btn_edit_edit_period = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btn_remove_edit_period = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btn_add_edit_period = new MaterialSkin.Controls.MaterialRaisedButton();
			this.cbb_period_edit_period = new System.Windows.Forms.ComboBox();
			this.btn_apply_edit_period = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btn_cancel_edit_period = new MaterialSkin.Controls.MaterialRaisedButton();
			this.tab_account_edit = new System.Windows.Forms.TabPage();
			this.lbl_id_account = new MaterialSkin.Controls.MaterialLabel();
			this.btn_change_password_account = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btn_edit_account = new MaterialSkin.Controls.MaterialRaisedButton();
			this.txt_new_password_confirm = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_phone_number_account = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_identity_number_account = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_new_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_current_password_account = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_name_account = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_email_account = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.tab_customer = new System.Windows.Forms.TabPage();
			this.btn_check_customer = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btn_refresh_customer = new MaterialSkin.Controls.MaterialFlatButton();
			this.btn_apply_edit_customer = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btn_cancel_edit_customer = new MaterialSkin.Controls.MaterialRaisedButton();
			this.lbl_customer_id_customer = new MaterialSkin.Controls.MaterialLabel();
			this.txt_address_customer = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_phone_number_customer = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.lbl_customer_customer = new MaterialSkin.Controls.MaterialLabel();
			this.txt_identity_number_customer = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_name_customer = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.tab_control_edit.SuspendLayout();
			this.tab_cash_edit.SuspendLayout();
			this.tab_period_edit.SuspendLayout();
			this.tab_account_edit.SuspendLayout();
			this.tab_customer.SuspendLayout();
			this.SuspendLayout();
			// 
			// tab_selector_edit
			// 
			this.tab_selector_edit.BaseTabControl = this.tab_control_edit;
			this.tab_selector_edit.Depth = 0;
			this.tab_selector_edit.Location = new System.Drawing.Point(0, 64);
			this.tab_selector_edit.MouseState = MaterialSkin.MouseState.HOVER;
			this.tab_selector_edit.Name = "tab_selector_edit";
			this.tab_selector_edit.Size = new System.Drawing.Size(1500, 45);
			this.tab_selector_edit.TabIndex = 1;
			this.tab_selector_edit.Text = "TabSelector";
			this.tab_selector_edit.Click += new System.EventHandler(this.tab_selector_edit_Click);
			// 
			// tab_control_edit
			// 
			this.tab_control_edit.Controls.Add(this.tab_cash_edit);
			this.tab_control_edit.Controls.Add(this.tab_period_edit);
			this.tab_control_edit.Controls.Add(this.tab_account_edit);
			this.tab_control_edit.Controls.Add(this.tab_customer);
			this.tab_control_edit.Depth = 0;
			this.tab_control_edit.Location = new System.Drawing.Point(12, 114);
			this.tab_control_edit.MouseState = MaterialSkin.MouseState.HOVER;
			this.tab_control_edit.Name = "tab_control_edit";
			this.tab_control_edit.SelectedIndex = 0;
			this.tab_control_edit.Size = new System.Drawing.Size(576, 232);
			this.tab_control_edit.TabIndex = 0;
			// 
			// tab_cash_edit
			// 
			this.tab_cash_edit.BackColor = System.Drawing.Color.White;
			this.tab_cash_edit.Controls.Add(this.btn_cancel_edit_cash);
			this.tab_cash_edit.Controls.Add(this.btn_apply_edit_cast);
			this.tab_cash_edit.Controls.Add(this.txt_min_cash);
			this.tab_cash_edit.Controls.Add(this.txt_min_income);
			this.tab_cash_edit.Location = new System.Drawing.Point(4, 22);
			this.tab_cash_edit.Name = "tab_cash_edit";
			this.tab_cash_edit.Padding = new System.Windows.Forms.Padding(3);
			this.tab_cash_edit.Size = new System.Drawing.Size(568, 206);
			this.tab_cash_edit.TabIndex = 0;
			this.tab_cash_edit.Text = "Cash";
			// 
			// btn_cancel_edit_cash
			// 
			this.btn_cancel_edit_cash.Depth = 0;
			this.btn_cancel_edit_cash.Location = new System.Drawing.Point(487, 160);
			this.btn_cancel_edit_cash.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_cancel_edit_cash.Name = "btn_cancel_edit_cash";
			this.btn_cancel_edit_cash.Primary = true;
			this.btn_cancel_edit_cash.Size = new System.Drawing.Size(75, 40);
			this.btn_cancel_edit_cash.TabIndex = 3;
			this.btn_cancel_edit_cash.Text = "Cancel";
			this.btn_cancel_edit_cash.UseVisualStyleBackColor = true;
			this.btn_cancel_edit_cash.Click += new System.EventHandler(this.btn_cancel_edit_cash_Click);
			// 
			// btn_apply_edit_cast
			// 
			this.btn_apply_edit_cast.Depth = 0;
			this.btn_apply_edit_cast.Location = new System.Drawing.Point(406, 160);
			this.btn_apply_edit_cast.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_apply_edit_cast.Name = "btn_apply_edit_cast";
			this.btn_apply_edit_cast.Primary = true;
			this.btn_apply_edit_cast.Size = new System.Drawing.Size(75, 40);
			this.btn_apply_edit_cast.TabIndex = 2;
			this.btn_apply_edit_cast.Text = "Apply";
			this.btn_apply_edit_cast.UseVisualStyleBackColor = true;
			this.btn_apply_edit_cast.Click += new System.EventHandler(this.btn_apply_edit_cast_Click);
			// 
			// txt_min_cash
			// 
			this.txt_min_cash.Depth = 0;
			this.txt_min_cash.Hint = "Min cash (VND)";
			this.txt_min_cash.Location = new System.Drawing.Point(31, 27);
			this.txt_min_cash.MaxLength = 32767;
			this.txt_min_cash.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_min_cash.Name = "txt_min_cash";
			this.txt_min_cash.PasswordChar = '\0';
			this.txt_min_cash.SelectedText = "";
			this.txt_min_cash.SelectionLength = 0;
			this.txt_min_cash.SelectionStart = 0;
			this.txt_min_cash.Size = new System.Drawing.Size(250, 23);
			this.txt_min_cash.TabIndex = 0;
			this.txt_min_cash.TabStop = false;
			this.txt_min_cash.UseSystemPasswordChar = false;
			// 
			// txt_min_income
			// 
			this.txt_min_income.Depth = 0;
			this.txt_min_income.Hint = "Min income (VND)";
			this.txt_min_income.Location = new System.Drawing.Point(31, 67);
			this.txt_min_income.MaxLength = 32767;
			this.txt_min_income.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_min_income.Name = "txt_min_income";
			this.txt_min_income.PasswordChar = '\0';
			this.txt_min_income.SelectedText = "";
			this.txt_min_income.SelectionLength = 0;
			this.txt_min_income.SelectionStart = 0;
			this.txt_min_income.Size = new System.Drawing.Size(250, 23);
			this.txt_min_income.TabIndex = 1;
			this.txt_min_income.TabStop = false;
			this.txt_min_income.UseSystemPasswordChar = false;
			// 
			// tab_period_edit
			// 
			this.tab_period_edit.BackColor = System.Drawing.Color.White;
			this.tab_period_edit.Controls.Add(this.lbl_id_edit_period);
			this.tab_period_edit.Controls.Add(this.txt_period_edit_period);
			this.tab_period_edit.Controls.Add(this.txt_name_edit_period);
			this.tab_period_edit.Controls.Add(this.txt_rate_edit_period);
			this.tab_period_edit.Controls.Add(this.btn_edit_edit_period);
			this.tab_period_edit.Controls.Add(this.btn_remove_edit_period);
			this.tab_period_edit.Controls.Add(this.btn_add_edit_period);
			this.tab_period_edit.Controls.Add(this.cbb_period_edit_period);
			this.tab_period_edit.Controls.Add(this.btn_apply_edit_period);
			this.tab_period_edit.Controls.Add(this.btn_cancel_edit_period);
			this.tab_period_edit.Location = new System.Drawing.Point(4, 22);
			this.tab_period_edit.Name = "tab_period_edit";
			this.tab_period_edit.Padding = new System.Windows.Forms.Padding(3);
			this.tab_period_edit.Size = new System.Drawing.Size(568, 206);
			this.tab_period_edit.TabIndex = 2;
			this.tab_period_edit.Text = "Period";
			// 
			// lbl_id_edit_period
			// 
			this.lbl_id_edit_period.AutoSize = true;
			this.lbl_id_edit_period.Depth = 0;
			this.lbl_id_edit_period.Font = new System.Drawing.Font("Roboto", 11F);
			this.lbl_id_edit_period.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lbl_id_edit_period.Location = new System.Drawing.Point(146, 53);
			this.lbl_id_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.lbl_id_edit_period.Name = "lbl_id_edit_period";
			this.lbl_id_edit_period.Size = new System.Drawing.Size(23, 19);
			this.lbl_id_edit_period.TabIndex = 4;
			this.lbl_id_edit_period.Text = "ID";
			// 
			// txt_period_edit_period
			// 
			this.txt_period_edit_period.Depth = 0;
			this.txt_period_edit_period.Hint = "Period (days)";
			this.txt_period_edit_period.Location = new System.Drawing.Point(150, 111);
			this.txt_period_edit_period.MaxLength = 32767;
			this.txt_period_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_period_edit_period.Name = "txt_period_edit_period";
			this.txt_period_edit_period.PasswordChar = '\0';
			this.txt_period_edit_period.SelectedText = "";
			this.txt_period_edit_period.SelectionLength = 0;
			this.txt_period_edit_period.SelectionStart = 0;
			this.txt_period_edit_period.Size = new System.Drawing.Size(200, 23);
			this.txt_period_edit_period.TabIndex = 7;
			this.txt_period_edit_period.TabStop = false;
			this.txt_period_edit_period.UseSystemPasswordChar = false;
			// 
			// txt_name_edit_period
			// 
			this.txt_name_edit_period.Depth = 0;
			this.txt_name_edit_period.Hint = "Name";
			this.txt_name_edit_period.Location = new System.Drawing.Point(175, 53);
			this.txt_name_edit_period.MaxLength = 32767;
			this.txt_name_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_name_edit_period.Name = "txt_name_edit_period";
			this.txt_name_edit_period.PasswordChar = '\0';
			this.txt_name_edit_period.SelectedText = "";
			this.txt_name_edit_period.SelectionLength = 0;
			this.txt_name_edit_period.SelectionStart = 0;
			this.txt_name_edit_period.Size = new System.Drawing.Size(175, 23);
			this.txt_name_edit_period.TabIndex = 5;
			this.txt_name_edit_period.TabStop = false;
			this.txt_name_edit_period.UseSystemPasswordChar = false;
			// 
			// txt_rate_edit_period
			// 
			this.txt_rate_edit_period.Depth = 0;
			this.txt_rate_edit_period.Hint = "Rate (%)";
			this.txt_rate_edit_period.Location = new System.Drawing.Point(150, 82);
			this.txt_rate_edit_period.MaxLength = 32767;
			this.txt_rate_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_rate_edit_period.Name = "txt_rate_edit_period";
			this.txt_rate_edit_period.PasswordChar = '\0';
			this.txt_rate_edit_period.SelectedText = "";
			this.txt_rate_edit_period.SelectionLength = 0;
			this.txt_rate_edit_period.SelectionStart = 0;
			this.txt_rate_edit_period.Size = new System.Drawing.Size(200, 23);
			this.txt_rate_edit_period.TabIndex = 6;
			this.txt_rate_edit_period.TabStop = false;
			this.txt_rate_edit_period.UseSystemPasswordChar = false;
			// 
			// btn_edit_edit_period
			// 
			this.btn_edit_edit_period.Depth = 0;
			this.btn_edit_edit_period.Location = new System.Drawing.Point(25, 56);
			this.btn_edit_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_edit_edit_period.Name = "btn_edit_edit_period";
			this.btn_edit_edit_period.Primary = true;
			this.btn_edit_edit_period.Size = new System.Drawing.Size(75, 23);
			this.btn_edit_edit_period.TabIndex = 1;
			this.btn_edit_edit_period.Text = "Edit";
			this.btn_edit_edit_period.UseVisualStyleBackColor = true;
			this.btn_edit_edit_period.Click += new System.EventHandler(this.btn_edit_edit_period_Click);
			// 
			// btn_remove_edit_period
			// 
			this.btn_remove_edit_period.Depth = 0;
			this.btn_remove_edit_period.Location = new System.Drawing.Point(25, 85);
			this.btn_remove_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_remove_edit_period.Name = "btn_remove_edit_period";
			this.btn_remove_edit_period.Primary = true;
			this.btn_remove_edit_period.Size = new System.Drawing.Size(75, 23);
			this.btn_remove_edit_period.TabIndex = 2;
			this.btn_remove_edit_period.Text = "Remove";
			this.btn_remove_edit_period.UseVisualStyleBackColor = true;
			this.btn_remove_edit_period.Click += new System.EventHandler(this.btn_remove_edit_period_Click);
			// 
			// btn_add_edit_period
			// 
			this.btn_add_edit_period.Depth = 0;
			this.btn_add_edit_period.Location = new System.Drawing.Point(25, 25);
			this.btn_add_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_add_edit_period.Name = "btn_add_edit_period";
			this.btn_add_edit_period.Primary = true;
			this.btn_add_edit_period.Size = new System.Drawing.Size(75, 25);
			this.btn_add_edit_period.TabIndex = 0;
			this.btn_add_edit_period.Text = "Add";
			this.btn_add_edit_period.UseVisualStyleBackColor = true;
			this.btn_add_edit_period.Click += new System.EventHandler(this.btn_add_edit_period_Click);
			// 
			// cbb_period_edit_period
			// 
			this.cbb_period_edit_period.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbb_period_edit_period.FormattingEnabled = true;
			this.cbb_period_edit_period.Location = new System.Drawing.Point(150, 25);
			this.cbb_period_edit_period.Name = "cbb_period_edit_period";
			this.cbb_period_edit_period.Size = new System.Drawing.Size(200, 21);
			this.cbb_period_edit_period.TabIndex = 3;
			this.cbb_period_edit_period.SelectedIndexChanged += new System.EventHandler(this.cbb_period_edit_period_SelectedIndexChanged);
			// 
			// btn_apply_edit_period
			// 
			this.btn_apply_edit_period.Depth = 0;
			this.btn_apply_edit_period.Location = new System.Drawing.Point(406, 160);
			this.btn_apply_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_apply_edit_period.Name = "btn_apply_edit_period";
			this.btn_apply_edit_period.Primary = true;
			this.btn_apply_edit_period.Size = new System.Drawing.Size(75, 40);
			this.btn_apply_edit_period.TabIndex = 8;
			this.btn_apply_edit_period.Text = "Apply";
			this.btn_apply_edit_period.UseVisualStyleBackColor = true;
			this.btn_apply_edit_period.Click += new System.EventHandler(this.btn_apply_edit_period_Click);
			// 
			// btn_cancel_edit_period
			// 
			this.btn_cancel_edit_period.Depth = 0;
			this.btn_cancel_edit_period.Location = new System.Drawing.Point(487, 160);
			this.btn_cancel_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_cancel_edit_period.Name = "btn_cancel_edit_period";
			this.btn_cancel_edit_period.Primary = true;
			this.btn_cancel_edit_period.Size = new System.Drawing.Size(75, 40);
			this.btn_cancel_edit_period.TabIndex = 9;
			this.btn_cancel_edit_period.Text = "Cancel";
			this.btn_cancel_edit_period.UseVisualStyleBackColor = true;
			this.btn_cancel_edit_period.Click += new System.EventHandler(this.btn_cancel_edit_type_Click);
			// 
			// tab_account_edit
			// 
			this.tab_account_edit.BackColor = System.Drawing.Color.White;
			this.tab_account_edit.Controls.Add(this.lbl_id_account);
			this.tab_account_edit.Controls.Add(this.btn_change_password_account);
			this.tab_account_edit.Controls.Add(this.btn_edit_account);
			this.tab_account_edit.Controls.Add(this.txt_new_password_confirm);
			this.tab_account_edit.Controls.Add(this.txt_phone_number_account);
			this.tab_account_edit.Controls.Add(this.txt_identity_number_account);
			this.tab_account_edit.Controls.Add(this.txt_new_password);
			this.tab_account_edit.Controls.Add(this.txt_current_password_account);
			this.tab_account_edit.Controls.Add(this.txt_name_account);
			this.tab_account_edit.Controls.Add(this.txt_email_account);
			this.tab_account_edit.Location = new System.Drawing.Point(4, 22);
			this.tab_account_edit.Name = "tab_account_edit";
			this.tab_account_edit.Padding = new System.Windows.Forms.Padding(3);
			this.tab_account_edit.Size = new System.Drawing.Size(568, 206);
			this.tab_account_edit.TabIndex = 3;
			this.tab_account_edit.Text = "Account";
			// 
			// lbl_id_account
			// 
			this.lbl_id_account.AutoSize = true;
			this.lbl_id_account.Depth = 0;
			this.lbl_id_account.Font = new System.Drawing.Font("Roboto", 11F);
			this.lbl_id_account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lbl_id_account.Location = new System.Drawing.Point(34, 25);
			this.lbl_id_account.MouseState = MaterialSkin.MouseState.HOVER;
			this.lbl_id_account.Name = "lbl_id_account";
			this.lbl_id_account.Size = new System.Drawing.Size(23, 19);
			this.lbl_id_account.TabIndex = 0;
			this.lbl_id_account.Text = "ID";
			// 
			// btn_change_password_account
			// 
			this.btn_change_password_account.Depth = 0;
			this.btn_change_password_account.Location = new System.Drawing.Point(299, 141);
			this.btn_change_password_account.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_change_password_account.Name = "btn_change_password_account";
			this.btn_change_password_account.Primary = true;
			this.btn_change_password_account.Size = new System.Drawing.Size(200, 40);
			this.btn_change_password_account.TabIndex = 9;
			this.btn_change_password_account.Text = "Change Password";
			this.btn_change_password_account.UseVisualStyleBackColor = true;
			this.btn_change_password_account.Click += new System.EventHandler(this.btn_change_password_account_Click);
			// 
			// btn_edit_account
			// 
			this.btn_edit_account.Depth = 0;
			this.btn_edit_account.Location = new System.Drawing.Point(38, 141);
			this.btn_edit_account.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_edit_account.Name = "btn_edit_account";
			this.btn_edit_account.Primary = true;
			this.btn_edit_account.Size = new System.Drawing.Size(200, 40);
			this.btn_edit_account.TabIndex = 5;
			this.btn_edit_account.Text = "Update";
			this.btn_edit_account.UseVisualStyleBackColor = true;
			this.btn_edit_account.Click += new System.EventHandler(this.btn_edit_account_Click);
			// 
			// txt_new_password_confirm
			// 
			this.txt_new_password_confirm.Depth = 0;
			this.txt_new_password_confirm.Hint = "New Password Confirm";
			this.txt_new_password_confirm.Location = new System.Drawing.Point(299, 102);
			this.txt_new_password_confirm.MaxLength = 32767;
			this.txt_new_password_confirm.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_new_password_confirm.Name = "txt_new_password_confirm";
			this.txt_new_password_confirm.PasswordChar = '●';
			this.txt_new_password_confirm.SelectedText = "";
			this.txt_new_password_confirm.SelectionLength = 0;
			this.txt_new_password_confirm.SelectionStart = 0;
			this.txt_new_password_confirm.Size = new System.Drawing.Size(200, 23);
			this.txt_new_password_confirm.TabIndex = 8;
			this.txt_new_password_confirm.TabStop = false;
			this.txt_new_password_confirm.UseSystemPasswordChar = true;
			// 
			// txt_phone_number_account
			// 
			this.txt_phone_number_account.Depth = 0;
			this.txt_phone_number_account.Hint = "Phone Number";
			this.txt_phone_number_account.Location = new System.Drawing.Point(38, 112);
			this.txt_phone_number_account.MaxLength = 32767;
			this.txt_phone_number_account.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_phone_number_account.Name = "txt_phone_number_account";
			this.txt_phone_number_account.PasswordChar = '\0';
			this.txt_phone_number_account.SelectedText = "";
			this.txt_phone_number_account.SelectionLength = 0;
			this.txt_phone_number_account.SelectionStart = 0;
			this.txt_phone_number_account.Size = new System.Drawing.Size(200, 23);
			this.txt_phone_number_account.TabIndex = 4;
			this.txt_phone_number_account.TabStop = false;
			this.txt_phone_number_account.UseSystemPasswordChar = false;
			// 
			// txt_identity_number_account
			// 
			this.txt_identity_number_account.Depth = 0;
			this.txt_identity_number_account.Hint = "Identity Number";
			this.txt_identity_number_account.Location = new System.Drawing.Point(38, 83);
			this.txt_identity_number_account.MaxLength = 32767;
			this.txt_identity_number_account.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_identity_number_account.Name = "txt_identity_number_account";
			this.txt_identity_number_account.PasswordChar = '\0';
			this.txt_identity_number_account.SelectedText = "";
			this.txt_identity_number_account.SelectionLength = 0;
			this.txt_identity_number_account.SelectionStart = 0;
			this.txt_identity_number_account.Size = new System.Drawing.Size(200, 23);
			this.txt_identity_number_account.TabIndex = 3;
			this.txt_identity_number_account.TabStop = false;
			this.txt_identity_number_account.UseSystemPasswordChar = false;
			// 
			// txt_new_password
			// 
			this.txt_new_password.Depth = 0;
			this.txt_new_password.Hint = "New Password";
			this.txt_new_password.Location = new System.Drawing.Point(299, 64);
			this.txt_new_password.MaxLength = 32767;
			this.txt_new_password.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_new_password.Name = "txt_new_password";
			this.txt_new_password.PasswordChar = '●';
			this.txt_new_password.SelectedText = "";
			this.txt_new_password.SelectionLength = 0;
			this.txt_new_password.SelectionStart = 0;
			this.txt_new_password.Size = new System.Drawing.Size(200, 23);
			this.txt_new_password.TabIndex = 7;
			this.txt_new_password.TabStop = false;
			this.txt_new_password.UseSystemPasswordChar = true;
			// 
			// txt_current_password_account
			// 
			this.txt_current_password_account.Depth = 0;
			this.txt_current_password_account.Hint = "Current Password";
			this.txt_current_password_account.Location = new System.Drawing.Point(299, 25);
			this.txt_current_password_account.MaxLength = 32767;
			this.txt_current_password_account.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_current_password_account.Name = "txt_current_password_account";
			this.txt_current_password_account.PasswordChar = '●';
			this.txt_current_password_account.SelectedText = "";
			this.txt_current_password_account.SelectionLength = 0;
			this.txt_current_password_account.SelectionStart = 0;
			this.txt_current_password_account.Size = new System.Drawing.Size(200, 23);
			this.txt_current_password_account.TabIndex = 6;
			this.txt_current_password_account.TabStop = false;
			this.txt_current_password_account.UseSystemPasswordChar = true;
			// 
			// txt_name_account
			// 
			this.txt_name_account.Depth = 0;
			this.txt_name_account.Hint = "Name";
			this.txt_name_account.Location = new System.Drawing.Point(63, 25);
			this.txt_name_account.MaxLength = 32767;
			this.txt_name_account.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_name_account.Name = "txt_name_account";
			this.txt_name_account.PasswordChar = '\0';
			this.txt_name_account.SelectedText = "";
			this.txt_name_account.SelectionLength = 0;
			this.txt_name_account.SelectionStart = 0;
			this.txt_name_account.Size = new System.Drawing.Size(175, 23);
			this.txt_name_account.TabIndex = 1;
			this.txt_name_account.TabStop = false;
			this.txt_name_account.UseSystemPasswordChar = false;
			// 
			// txt_email_account
			// 
			this.txt_email_account.Depth = 0;
			this.txt_email_account.Hint = "Email";
			this.txt_email_account.Location = new System.Drawing.Point(38, 54);
			this.txt_email_account.MaxLength = 32767;
			this.txt_email_account.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_email_account.Name = "txt_email_account";
			this.txt_email_account.PasswordChar = '\0';
			this.txt_email_account.SelectedText = "";
			this.txt_email_account.SelectionLength = 0;
			this.txt_email_account.SelectionStart = 0;
			this.txt_email_account.Size = new System.Drawing.Size(200, 23);
			this.txt_email_account.TabIndex = 2;
			this.txt_email_account.TabStop = false;
			this.txt_email_account.UseSystemPasswordChar = false;
			// 
			// tab_customer
			// 
			this.tab_customer.BackColor = System.Drawing.Color.White;
			this.tab_customer.Controls.Add(this.btn_check_customer);
			this.tab_customer.Controls.Add(this.btn_refresh_customer);
			this.tab_customer.Controls.Add(this.btn_apply_edit_customer);
			this.tab_customer.Controls.Add(this.btn_cancel_edit_customer);
			this.tab_customer.Controls.Add(this.lbl_customer_id_customer);
			this.tab_customer.Controls.Add(this.txt_address_customer);
			this.tab_customer.Controls.Add(this.txt_phone_number_customer);
			this.tab_customer.Controls.Add(this.lbl_customer_customer);
			this.tab_customer.Controls.Add(this.txt_identity_number_customer);
			this.tab_customer.Controls.Add(this.txt_name_customer);
			this.tab_customer.Location = new System.Drawing.Point(4, 22);
			this.tab_customer.Name = "tab_customer";
			this.tab_customer.Padding = new System.Windows.Forms.Padding(3);
			this.tab_customer.Size = new System.Drawing.Size(568, 206);
			this.tab_customer.TabIndex = 4;
			this.tab_customer.Text = "Customer";
			// 
			// btn_check_customer
			// 
			this.btn_check_customer.Depth = 0;
			this.btn_check_customer.Location = new System.Drawing.Point(41, 150);
			this.btn_check_customer.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_check_customer.Name = "btn_check_customer";
			this.btn_check_customer.Primary = true;
			this.btn_check_customer.Size = new System.Drawing.Size(250, 40);
			this.btn_check_customer.TabIndex = 6;
			this.btn_check_customer.Text = "Check";
			this.btn_check_customer.UseVisualStyleBackColor = true;
			this.btn_check_customer.Click += new System.EventHandler(this.btn_check_edit_customer_Click);
			// 
			// btn_refresh_customer
			// 
			this.btn_refresh_customer.AutoSize = true;
			this.btn_refresh_customer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btn_refresh_customer.Depth = 0;
			this.btn_refresh_customer.Location = new System.Drawing.Point(498, 0);
			this.btn_refresh_customer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btn_refresh_customer.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_refresh_customer.Name = "btn_refresh_customer";
			this.btn_refresh_customer.Primary = false;
			this.btn_refresh_customer.Size = new System.Drawing.Size(70, 36);
			this.btn_refresh_customer.TabIndex = 9;
			this.btn_refresh_customer.Text = "Refresh";
			this.btn_refresh_customer.UseVisualStyleBackColor = true;
			this.btn_refresh_customer.Click += new System.EventHandler(this.btn_refresh_edit_customer_Click);
			// 
			// btn_apply_edit_customer
			// 
			this.btn_apply_edit_customer.Depth = 0;
			this.btn_apply_edit_customer.Location = new System.Drawing.Point(406, 160);
			this.btn_apply_edit_customer.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_apply_edit_customer.Name = "btn_apply_edit_customer";
			this.btn_apply_edit_customer.Primary = true;
			this.btn_apply_edit_customer.Size = new System.Drawing.Size(75, 40);
			this.btn_apply_edit_customer.TabIndex = 8;
			this.btn_apply_edit_customer.Text = "Apply";
			this.btn_apply_edit_customer.UseVisualStyleBackColor = true;
			this.btn_apply_edit_customer.Click += new System.EventHandler(this.btn_apply_edit_customer_Click);
			// 
			// btn_cancel_edit_customer
			// 
			this.btn_cancel_edit_customer.Depth = 0;
			this.btn_cancel_edit_customer.Location = new System.Drawing.Point(487, 160);
			this.btn_cancel_edit_customer.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_cancel_edit_customer.Name = "btn_cancel_edit_customer";
			this.btn_cancel_edit_customer.Primary = true;
			this.btn_cancel_edit_customer.Size = new System.Drawing.Size(75, 40);
			this.btn_cancel_edit_customer.TabIndex = 13;
			this.btn_cancel_edit_customer.Text = "Cancel";
			this.btn_cancel_edit_customer.UseVisualStyleBackColor = true;
			this.btn_cancel_edit_customer.Click += new System.EventHandler(this.btn_cancel_edit_customer_Click);
			// 
			// lbl_customer_id_customer
			// 
			this.lbl_customer_id_customer.AutoSize = true;
			this.lbl_customer_id_customer.Depth = 0;
			this.lbl_customer_id_customer.Font = new System.Drawing.Font("Roboto", 11F);
			this.lbl_customer_id_customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lbl_customer_id_customer.Location = new System.Drawing.Point(37, 34);
			this.lbl_customer_id_customer.MouseState = MaterialSkin.MouseState.HOVER;
			this.lbl_customer_id_customer.Name = "lbl_customer_id_customer";
			this.lbl_customer_id_customer.Size = new System.Drawing.Size(23, 19);
			this.lbl_customer_id_customer.TabIndex = 1;
			this.lbl_customer_id_customer.Text = "ID";
			// 
			// txt_address_customer
			// 
			this.txt_address_customer.Depth = 0;
			this.txt_address_customer.Hint = "Address";
			this.txt_address_customer.Location = new System.Drawing.Point(41, 92);
			this.txt_address_customer.MaxLength = 32767;
			this.txt_address_customer.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_address_customer.Name = "txt_address_customer";
			this.txt_address_customer.PasswordChar = '\0';
			this.txt_address_customer.SelectedText = "";
			this.txt_address_customer.SelectionLength = 0;
			this.txt_address_customer.SelectionStart = 0;
			this.txt_address_customer.Size = new System.Drawing.Size(250, 23);
			this.txt_address_customer.TabIndex = 4;
			this.txt_address_customer.TabStop = false;
			this.txt_address_customer.UseSystemPasswordChar = false;
			// 
			// txt_phone_number_customer
			// 
			this.txt_phone_number_customer.Depth = 0;
			this.txt_phone_number_customer.Hint = "Phone Number";
			this.txt_phone_number_customer.Location = new System.Drawing.Point(41, 121);
			this.txt_phone_number_customer.MaxLength = 32767;
			this.txt_phone_number_customer.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_phone_number_customer.Name = "txt_phone_number_customer";
			this.txt_phone_number_customer.PasswordChar = '\0';
			this.txt_phone_number_customer.SelectedText = "";
			this.txt_phone_number_customer.SelectionLength = 0;
			this.txt_phone_number_customer.SelectionStart = 0;
			this.txt_phone_number_customer.Size = new System.Drawing.Size(250, 23);
			this.txt_phone_number_customer.TabIndex = 5;
			this.txt_phone_number_customer.TabStop = false;
			this.txt_phone_number_customer.UseSystemPasswordChar = false;
			this.txt_phone_number_customer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_phone_number_edit_customer_KeyDown);
			// 
			// lbl_customer_customer
			// 
			this.lbl_customer_customer.AutoSize = true;
			this.lbl_customer_customer.Depth = 0;
			this.lbl_customer_customer.Font = new System.Drawing.Font("Roboto", 11F);
			this.lbl_customer_customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lbl_customer_customer.Location = new System.Drawing.Point(37, 8);
			this.lbl_customer_customer.MouseState = MaterialSkin.MouseState.HOVER;
			this.lbl_customer_customer.Name = "lbl_customer_customer";
			this.lbl_customer_customer.Size = new System.Drawing.Size(75, 19);
			this.lbl_customer_customer.TabIndex = 0;
			this.lbl_customer_customer.Text = "Customer";
			// 
			// txt_identity_number_customer
			// 
			this.txt_identity_number_customer.Depth = 0;
			this.txt_identity_number_customer.Hint = "Identity Number";
			this.txt_identity_number_customer.Location = new System.Drawing.Point(41, 63);
			this.txt_identity_number_customer.MaxLength = 32767;
			this.txt_identity_number_customer.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_identity_number_customer.Name = "txt_identity_number_customer";
			this.txt_identity_number_customer.PasswordChar = '\0';
			this.txt_identity_number_customer.SelectedText = "";
			this.txt_identity_number_customer.SelectionLength = 0;
			this.txt_identity_number_customer.SelectionStart = 0;
			this.txt_identity_number_customer.Size = new System.Drawing.Size(250, 23);
			this.txt_identity_number_customer.TabIndex = 3;
			this.txt_identity_number_customer.TabStop = false;
			this.txt_identity_number_customer.UseSystemPasswordChar = false;
			this.txt_identity_number_customer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_identity_number_edit_customer_KeyDown);
			// 
			// txt_name_customer
			// 
			this.txt_name_customer.Depth = 0;
			this.txt_name_customer.Hint = "Name";
			this.txt_name_customer.Location = new System.Drawing.Point(79, 34);
			this.txt_name_customer.MaxLength = 32767;
			this.txt_name_customer.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_name_customer.Name = "txt_name_customer";
			this.txt_name_customer.PasswordChar = '\0';
			this.txt_name_customer.SelectedText = "";
			this.txt_name_customer.SelectionLength = 0;
			this.txt_name_customer.SelectionStart = 0;
			this.txt_name_customer.Size = new System.Drawing.Size(212, 23);
			this.txt_name_customer.TabIndex = 2;
			this.txt_name_customer.TabStop = false;
			this.txt_name_customer.UseSystemPasswordChar = false;
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 350);
			this.Controls.Add(this.tab_selector_edit);
			this.Controls.Add(this.tab_control_edit);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Dashboard";
			this.Text = "Dashboard";
			this.tab_control_edit.ResumeLayout(false);
			this.tab_cash_edit.ResumeLayout(false);
			this.tab_period_edit.ResumeLayout(false);
			this.tab_period_edit.PerformLayout();
			this.tab_account_edit.ResumeLayout(false);
			this.tab_account_edit.PerformLayout();
			this.tab_customer.ResumeLayout(false);
			this.tab_customer.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private MaterialSkin.Controls.MaterialTabSelector tab_selector_edit;
		private MaterialSkin.Controls.MaterialTabControl tab_control_edit;
		private System.Windows.Forms.TabPage tab_cash_edit;
		private MaterialSkin.Controls.MaterialRaisedButton btn_cancel_edit_cash;
		private MaterialSkin.Controls.MaterialRaisedButton btn_apply_edit_cast;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_min_cash;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_min_income;
		private System.Windows.Forms.TabPage tab_period_edit;
		private MaterialSkin.Controls.MaterialLabel lbl_id_edit_period;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_period_edit_period;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_name_edit_period;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_rate_edit_period;
		private MaterialSkin.Controls.MaterialRaisedButton btn_edit_edit_period;
		private MaterialSkin.Controls.MaterialRaisedButton btn_remove_edit_period;
		private MaterialSkin.Controls.MaterialRaisedButton btn_add_edit_period;
		private System.Windows.Forms.ComboBox cbb_period_edit_period;
		private MaterialSkin.Controls.MaterialRaisedButton btn_apply_edit_period;
		private MaterialSkin.Controls.MaterialRaisedButton btn_cancel_edit_period;
		private System.Windows.Forms.TabPage tab_account_edit;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_identity_number_account;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_new_password;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_current_password_account;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_name_account;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_email_account;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_phone_number_account;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_new_password_confirm;
		private MaterialSkin.Controls.MaterialRaisedButton btn_change_password_account;
		private MaterialSkin.Controls.MaterialRaisedButton btn_edit_account;
		private MaterialSkin.Controls.MaterialLabel lbl_id_account;
		private System.Windows.Forms.TabPage tab_customer;
		private MaterialSkin.Controls.MaterialRaisedButton btn_apply_edit_customer;
		private MaterialSkin.Controls.MaterialRaisedButton btn_cancel_edit_customer;
		private MaterialSkin.Controls.MaterialLabel lbl_customer_id_customer;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_address_customer;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_phone_number_customer;
		private MaterialSkin.Controls.MaterialLabel lbl_customer_customer;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_identity_number_customer;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_name_customer;
		private MaterialSkin.Controls.MaterialFlatButton btn_refresh_customer;
		private MaterialSkin.Controls.MaterialRaisedButton btn_check_customer;
	}
}