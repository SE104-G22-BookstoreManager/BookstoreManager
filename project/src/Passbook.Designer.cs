﻿namespace PassbookManagement.src
{
	partial class Passbook
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
			this.tab_selector = new MaterialSkin.Controls.MaterialTabSelector();
			this.tab_control = new MaterialSkin.Controls.MaterialTabControl();
			this.tab_open = new System.Windows.Forms.TabPage();
			this.btn_create_open = new MaterialSkin.Controls.MaterialRaisedButton();
			this.calendar_open = new System.Windows.Forms.MonthCalendar();
			this.txt_cash_open = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.radio_6months = new MaterialSkin.Controls.MaterialRadioButton();
			this.radio_no_terms = new MaterialSkin.Controls.MaterialRadioButton();
			this.radio_3months = new MaterialSkin.Controls.MaterialRadioButton();
			this.lbl_passbook = new MaterialSkin.Controls.MaterialLabel();
			this.btn_submit_open = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btn_check_open = new MaterialSkin.Controls.MaterialRaisedButton();
			this.txt_address_open = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_phone_number_open = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.lbl_customer = new MaterialSkin.Controls.MaterialLabel();
			this.txt_identity_number_open = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_name_open = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.tab_lookup = new System.Windows.Forms.TabPage();
			this.list_lookup = new MaterialSkin.Controls.MaterialListView();
			this.col_order = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_passbook_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_customer_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tab_deposit = new System.Windows.Forms.TabPage();
			this.calendar_deposit = new System.Windows.Forms.MonthCalendar();
			this.txt_cash_deposit = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.lbl_deposit = new MaterialSkin.Controls.MaterialLabel();
			this.btn_create_deposit = new MaterialSkin.Controls.MaterialRaisedButton();
			this.cbb_passbook_deposit = new System.Windows.Forms.ComboBox();
			this.btn_check_deposit = new MaterialSkin.Controls.MaterialRaisedButton();
			this.txt_phone_number_deposit = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_identity_number_deposit = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_name_deposit = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.lbl_customer_deposit = new MaterialSkin.Controls.MaterialLabel();
			this.txt_address_deposit = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.tab_withdrawal = new System.Windows.Forms.TabPage();
			this.cbb_passbook_withdrawal = new System.Windows.Forms.ComboBox();
			this.calendar_withdrawal = new System.Windows.Forms.MonthCalendar();
			this.btn_create_withdrawal = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btn_check_withdrawal = new MaterialSkin.Controls.MaterialRaisedButton();
			this.txt_cash_withdrawal = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_identity_number_withdrawal = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_address_withdrawal = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_phone_number_withdrawal = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_name_withdrawal = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.lbl_withdrawal = new MaterialSkin.Controls.MaterialLabel();
			this.lbl_customer_withdrawal = new MaterialSkin.Controls.MaterialLabel();
			this.tab_daily_report = new System.Windows.Forms.TabPage();
			this.list_daily = new MaterialSkin.Controls.MaterialListView();
			this.col_order_daily = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_type_daily = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_income_daily = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_outcome_daily = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_total_daily = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.date_daily = new System.Windows.Forms.DateTimePicker();
			this.tab_monthly_report = new System.Windows.Forms.TabPage();
			this.list_monthly = new MaterialSkin.Controls.MaterialListView();
			this.col_order_monthly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_date_monthly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_income_monthly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_outcome_monthly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_total_monthly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.date_monthly = new System.Windows.Forms.DateTimePicker();
			this.cbb_type_monthly = new System.Windows.Forms.ComboBox();
			this.tab_control.SuspendLayout();
			this.tab_open.SuspendLayout();
			this.tab_lookup.SuspendLayout();
			this.tab_deposit.SuspendLayout();
			this.tab_withdrawal.SuspendLayout();
			this.tab_daily_report.SuspendLayout();
			this.tab_monthly_report.SuspendLayout();
			this.SuspendLayout();
			// 
			// tab_selector
			// 
			this.tab_selector.BaseTabControl = this.tab_control;
			this.tab_selector.Depth = 0;
			this.tab_selector.Location = new System.Drawing.Point(-16, 63);
			this.tab_selector.MouseState = MaterialSkin.MouseState.HOVER;
			this.tab_selector.Name = "tab_selector";
			this.tab_selector.Size = new System.Drawing.Size(725, 45);
			this.tab_selector.TabIndex = 1;
			this.tab_selector.Text = "materialTabSelector1";
			// 
			// tab_control
			// 
			this.tab_control.Controls.Add(this.tab_open);
			this.tab_control.Controls.Add(this.tab_lookup);
			this.tab_control.Controls.Add(this.tab_deposit);
			this.tab_control.Controls.Add(this.tab_withdrawal);
			this.tab_control.Controls.Add(this.tab_daily_report);
			this.tab_control.Controls.Add(this.tab_monthly_report);
			this.tab_control.Depth = 0;
			this.tab_control.Location = new System.Drawing.Point(12, 114);
			this.tab_control.MouseState = MaterialSkin.MouseState.HOVER;
			this.tab_control.Name = "tab_control";
			this.tab_control.SelectedIndex = 0;
			this.tab_control.Size = new System.Drawing.Size(676, 365);
			this.tab_control.TabIndex = 0;
			// 
			// tab_open
			// 
			this.tab_open.BackColor = System.Drawing.Color.White;
			this.tab_open.Controls.Add(this.btn_create_open);
			this.tab_open.Controls.Add(this.calendar_open);
			this.tab_open.Controls.Add(this.txt_cash_open);
			this.tab_open.Controls.Add(this.radio_6months);
			this.tab_open.Controls.Add(this.radio_no_terms);
			this.tab_open.Controls.Add(this.radio_3months);
			this.tab_open.Controls.Add(this.lbl_passbook);
			this.tab_open.Controls.Add(this.btn_submit_open);
			this.tab_open.Controls.Add(this.btn_check_open);
			this.tab_open.Controls.Add(this.txt_address_open);
			this.tab_open.Controls.Add(this.txt_phone_number_open);
			this.tab_open.Controls.Add(this.lbl_customer);
			this.tab_open.Controls.Add(this.txt_identity_number_open);
			this.tab_open.Controls.Add(this.txt_name_open);
			this.tab_open.Location = new System.Drawing.Point(4, 22);
			this.tab_open.Name = "tab_open";
			this.tab_open.Padding = new System.Windows.Forms.Padding(3);
			this.tab_open.Size = new System.Drawing.Size(668, 339);
			this.tab_open.TabIndex = 0;
			this.tab_open.Text = "Passbook";
			// 
			// btn_create_open
			// 
			this.btn_create_open.Depth = 0;
			this.btn_create_open.Location = new System.Drawing.Point(32, 284);
			this.btn_create_open.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_create_open.Name = "btn_create_open";
			this.btn_create_open.Primary = true;
			this.btn_create_open.Size = new System.Drawing.Size(250, 40);
			this.btn_create_open.TabIndex = 15;
			this.btn_create_open.Text = "Create";
			this.btn_create_open.UseVisualStyleBackColor = true;
			this.btn_create_open.Click += new System.EventHandler(this.btn_create_Click);
			// 
			// calendar_open
			// 
			this.calendar_open.Location = new System.Drawing.Point(360, 147);
			this.calendar_open.Name = "calendar_open";
			this.calendar_open.TabIndex = 14;
			// 
			// txt_cash_open
			// 
			this.txt_cash_open.Depth = 0;
			this.txt_cash_open.Hint = "Cash";
			this.txt_cash_open.Location = new System.Drawing.Point(360, 103);
			this.txt_cash_open.MaxLength = 32767;
			this.txt_cash_open.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_cash_open.Name = "txt_cash_open";
			this.txt_cash_open.PasswordChar = '\0';
			this.txt_cash_open.SelectedText = "";
			this.txt_cash_open.SelectionLength = 0;
			this.txt_cash_open.SelectionStart = 0;
			this.txt_cash_open.Size = new System.Drawing.Size(227, 23);
			this.txt_cash_open.TabIndex = 12;
			this.txt_cash_open.TabStop = false;
			this.txt_cash_open.UseSystemPasswordChar = false;
			// 
			// radio_6months
			// 
			this.radio_6months.AutoSize = true;
			this.radio_6months.Depth = 0;
			this.radio_6months.Font = new System.Drawing.Font("Roboto", 10F);
			this.radio_6months.Location = new System.Drawing.Point(446, 52);
			this.radio_6months.Margin = new System.Windows.Forms.Padding(0);
			this.radio_6months.MouseLocation = new System.Drawing.Point(-1, -1);
			this.radio_6months.MouseState = MaterialSkin.MouseState.HOVER;
			this.radio_6months.Name = "radio_6months";
			this.radio_6months.Ripple = true;
			this.radio_6months.Size = new System.Drawing.Size(87, 30);
			this.radio_6months.TabIndex = 11;
			this.radio_6months.TabStop = true;
			this.radio_6months.Text = "6 months";
			this.radio_6months.UseVisualStyleBackColor = true;
			// 
			// radio_no_terms
			// 
			this.radio_no_terms.AutoSize = true;
			this.radio_no_terms.Depth = 0;
			this.radio_no_terms.Font = new System.Drawing.Font("Roboto", 10F);
			this.radio_no_terms.Location = new System.Drawing.Point(551, 52);
			this.radio_no_terms.Margin = new System.Windows.Forms.Padding(0);
			this.radio_no_terms.MouseLocation = new System.Drawing.Point(-1, -1);
			this.radio_no_terms.MouseState = MaterialSkin.MouseState.HOVER;
			this.radio_no_terms.Name = "radio_no_terms";
			this.radio_no_terms.Ripple = true;
			this.radio_no_terms.Size = new System.Drawing.Size(87, 30);
			this.radio_no_terms.TabIndex = 10;
			this.radio_no_terms.TabStop = true;
			this.radio_no_terms.Text = "No-terms";
			this.radio_no_terms.UseVisualStyleBackColor = true;
			// 
			// radio_3months
			// 
			this.radio_3months.AutoSize = true;
			this.radio_3months.Depth = 0;
			this.radio_3months.Font = new System.Drawing.Font("Roboto", 10F);
			this.radio_3months.Location = new System.Drawing.Point(338, 52);
			this.radio_3months.Margin = new System.Windows.Forms.Padding(0);
			this.radio_3months.MouseLocation = new System.Drawing.Point(-1, -1);
			this.radio_3months.MouseState = MaterialSkin.MouseState.HOVER;
			this.radio_3months.Name = "radio_3months";
			this.radio_3months.Ripple = true;
			this.radio_3months.Size = new System.Drawing.Size(87, 30);
			this.radio_3months.TabIndex = 9;
			this.radio_3months.TabStop = true;
			this.radio_3months.Text = "3 months";
			this.radio_3months.UseVisualStyleBackColor = true;
			// 
			// lbl_passbook
			// 
			this.lbl_passbook.AutoSize = true;
			this.lbl_passbook.Depth = 0;
			this.lbl_passbook.Font = new System.Drawing.Font("Roboto", 11F);
			this.lbl_passbook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lbl_passbook.Location = new System.Drawing.Point(356, 27);
			this.lbl_passbook.MouseState = MaterialSkin.MouseState.HOVER;
			this.lbl_passbook.Name = "lbl_passbook";
			this.lbl_passbook.Size = new System.Drawing.Size(76, 19);
			this.lbl_passbook.TabIndex = 8;
			this.lbl_passbook.Text = "Passbook";
			// 
			// btn_submit_open
			// 
			this.btn_submit_open.Depth = 0;
			this.btn_submit_open.Enabled = false;
			this.btn_submit_open.Location = new System.Drawing.Point(160, 238);
			this.btn_submit_open.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_submit_open.Name = "btn_submit_open";
			this.btn_submit_open.Primary = true;
			this.btn_submit_open.Size = new System.Drawing.Size(122, 40);
			this.btn_submit_open.TabIndex = 7;
			this.btn_submit_open.Text = "Submit";
			this.btn_submit_open.UseVisualStyleBackColor = true;
			this.btn_submit_open.Click += new System.EventHandler(this.btn_submit_Click);
			// 
			// btn_check_open
			// 
			this.btn_check_open.Depth = 0;
			this.btn_check_open.Location = new System.Drawing.Point(32, 238);
			this.btn_check_open.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_check_open.Name = "btn_check_open";
			this.btn_check_open.Primary = true;
			this.btn_check_open.Size = new System.Drawing.Size(122, 40);
			this.btn_check_open.TabIndex = 6;
			this.btn_check_open.Text = "Check";
			this.btn_check_open.UseVisualStyleBackColor = true;
			this.btn_check_open.Click += new System.EventHandler(this.btn_check_Click);
			// 
			// txt_address_open
			// 
			this.txt_address_open.Depth = 0;
			this.txt_address_open.Hint = "Address";
			this.txt_address_open.Location = new System.Drawing.Point(32, 147);
			this.txt_address_open.MaxLength = 32767;
			this.txt_address_open.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_address_open.Name = "txt_address_open";
			this.txt_address_open.PasswordChar = '\0';
			this.txt_address_open.SelectedText = "";
			this.txt_address_open.SelectionLength = 0;
			this.txt_address_open.SelectionStart = 0;
			this.txt_address_open.Size = new System.Drawing.Size(250, 23);
			this.txt_address_open.TabIndex = 5;
			this.txt_address_open.TabStop = false;
			this.txt_address_open.UseSystemPasswordChar = false;
			// 
			// txt_phone_number_open
			// 
			this.txt_phone_number_open.Depth = 0;
			this.txt_phone_number_open.Hint = "Phone Number";
			this.txt_phone_number_open.Location = new System.Drawing.Point(32, 191);
			this.txt_phone_number_open.MaxLength = 32767;
			this.txt_phone_number_open.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_phone_number_open.Name = "txt_phone_number_open";
			this.txt_phone_number_open.PasswordChar = '\0';
			this.txt_phone_number_open.SelectedText = "";
			this.txt_phone_number_open.SelectionLength = 0;
			this.txt_phone_number_open.SelectionStart = 0;
			this.txt_phone_number_open.Size = new System.Drawing.Size(250, 23);
			this.txt_phone_number_open.TabIndex = 4;
			this.txt_phone_number_open.TabStop = false;
			this.txt_phone_number_open.UseSystemPasswordChar = false;
			// 
			// lbl_customer
			// 
			this.lbl_customer.AutoSize = true;
			this.lbl_customer.Depth = 0;
			this.lbl_customer.Font = new System.Drawing.Font("Roboto", 11F);
			this.lbl_customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lbl_customer.Location = new System.Drawing.Point(28, 27);
			this.lbl_customer.MouseState = MaterialSkin.MouseState.HOVER;
			this.lbl_customer.Name = "lbl_customer";
			this.lbl_customer.Size = new System.Drawing.Size(75, 19);
			this.lbl_customer.TabIndex = 3;
			this.lbl_customer.Text = "Customer";
			// 
			// txt_identity_number_open
			// 
			this.txt_identity_number_open.Depth = 0;
			this.txt_identity_number_open.Hint = "Identity Number";
			this.txt_identity_number_open.Location = new System.Drawing.Point(32, 103);
			this.txt_identity_number_open.MaxLength = 32767;
			this.txt_identity_number_open.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_identity_number_open.Name = "txt_identity_number_open";
			this.txt_identity_number_open.PasswordChar = '\0';
			this.txt_identity_number_open.SelectedText = "";
			this.txt_identity_number_open.SelectionLength = 0;
			this.txt_identity_number_open.SelectionStart = 0;
			this.txt_identity_number_open.Size = new System.Drawing.Size(250, 23);
			this.txt_identity_number_open.TabIndex = 2;
			this.txt_identity_number_open.TabStop = false;
			this.txt_identity_number_open.UseSystemPasswordChar = false;
			// 
			// txt_name_open
			// 
			this.txt_name_open.Depth = 0;
			this.txt_name_open.Hint = "Name";
			this.txt_name_open.Location = new System.Drawing.Point(32, 59);
			this.txt_name_open.MaxLength = 32767;
			this.txt_name_open.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_name_open.Name = "txt_name_open";
			this.txt_name_open.PasswordChar = '\0';
			this.txt_name_open.SelectedText = "";
			this.txt_name_open.SelectionLength = 0;
			this.txt_name_open.SelectionStart = 0;
			this.txt_name_open.Size = new System.Drawing.Size(250, 23);
			this.txt_name_open.TabIndex = 0;
			this.txt_name_open.TabStop = false;
			this.txt_name_open.UseSystemPasswordChar = false;
			// 
			// tab_lookup
			// 
			this.tab_lookup.BackColor = System.Drawing.Color.White;
			this.tab_lookup.Controls.Add(this.list_lookup);
			this.tab_lookup.Location = new System.Drawing.Point(4, 22);
			this.tab_lookup.Name = "tab_lookup";
			this.tab_lookup.Padding = new System.Windows.Forms.Padding(3);
			this.tab_lookup.Size = new System.Drawing.Size(668, 339);
			this.tab_lookup.TabIndex = 1;
			this.tab_lookup.Text = "Lookup";
			this.tab_lookup.UseVisualStyleBackColor = true;
			// 
			// list_lookup
			// 
			this.list_lookup.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.list_lookup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_order,
            this.col_passbook_id,
            this.col_type,
            this.col_customer_id,
            this.col_balance});
			this.list_lookup.Depth = 0;
			this.list_lookup.Font = new System.Drawing.Font("Roboto", 24F);
			this.list_lookup.FullRowSelect = true;
			this.list_lookup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.list_lookup.Location = new System.Drawing.Point(-4, 0);
			this.list_lookup.MouseLocation = new System.Drawing.Point(-1, -1);
			this.list_lookup.MouseState = MaterialSkin.MouseState.OUT;
			this.list_lookup.Name = "list_lookup";
			this.list_lookup.OwnerDraw = true;
			this.list_lookup.Size = new System.Drawing.Size(676, 339);
			this.list_lookup.TabIndex = 0;
			this.list_lookup.UseCompatibleStateImageBehavior = false;
			this.list_lookup.View = System.Windows.Forms.View.Details;
			// 
			// col_order
			// 
			this.col_order.Text = "Order";
			this.col_order.Width = 105;
			// 
			// col_passbook_id
			// 
			this.col_passbook_id.Text = "Passbook ID";
			this.col_passbook_id.Width = 201;
			// 
			// col_type
			// 
			this.col_type.Text = "Type";
			this.col_type.Width = 111;
			// 
			// col_customer_id
			// 
			this.col_customer_id.Text = "Customer ID";
			this.col_customer_id.Width = 133;
			// 
			// col_balance
			// 
			this.col_balance.Text = "Balance";
			this.col_balance.Width = 133;
			// 
			// tab_deposit
			// 
			this.tab_deposit.BackColor = System.Drawing.Color.White;
			this.tab_deposit.Controls.Add(this.calendar_deposit);
			this.tab_deposit.Controls.Add(this.txt_cash_deposit);
			this.tab_deposit.Controls.Add(this.lbl_deposit);
			this.tab_deposit.Controls.Add(this.btn_create_deposit);
			this.tab_deposit.Controls.Add(this.cbb_passbook_deposit);
			this.tab_deposit.Controls.Add(this.btn_check_deposit);
			this.tab_deposit.Controls.Add(this.txt_phone_number_deposit);
			this.tab_deposit.Controls.Add(this.txt_identity_number_deposit);
			this.tab_deposit.Controls.Add(this.txt_name_deposit);
			this.tab_deposit.Controls.Add(this.lbl_customer_deposit);
			this.tab_deposit.Controls.Add(this.txt_address_deposit);
			this.tab_deposit.Location = new System.Drawing.Point(4, 22);
			this.tab_deposit.Name = "tab_deposit";
			this.tab_deposit.Padding = new System.Windows.Forms.Padding(3);
			this.tab_deposit.Size = new System.Drawing.Size(668, 339);
			this.tab_deposit.TabIndex = 2;
			this.tab_deposit.Text = "Deposit";
			this.tab_deposit.UseVisualStyleBackColor = true;
			// 
			// calendar_deposit
			// 
			this.calendar_deposit.Location = new System.Drawing.Point(360, 147);
			this.calendar_deposit.Name = "calendar_deposit";
			this.calendar_deposit.TabIndex = 10;
			// 
			// txt_cash_deposit
			// 
			this.txt_cash_deposit.Depth = 0;
			this.txt_cash_deposit.Hint = "Cash";
			this.txt_cash_deposit.Location = new System.Drawing.Point(360, 103);
			this.txt_cash_deposit.MaxLength = 32767;
			this.txt_cash_deposit.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_cash_deposit.Name = "txt_cash_deposit";
			this.txt_cash_deposit.PasswordChar = '\0';
			this.txt_cash_deposit.SelectedText = "";
			this.txt_cash_deposit.SelectionLength = 0;
			this.txt_cash_deposit.SelectionStart = 0;
			this.txt_cash_deposit.Size = new System.Drawing.Size(227, 23);
			this.txt_cash_deposit.TabIndex = 9;
			this.txt_cash_deposit.TabStop = false;
			this.txt_cash_deposit.UseSystemPasswordChar = false;
			// 
			// lbl_deposit
			// 
			this.lbl_deposit.AutoSize = true;
			this.lbl_deposit.Depth = 0;
			this.lbl_deposit.Font = new System.Drawing.Font("Roboto", 11F);
			this.lbl_deposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lbl_deposit.Location = new System.Drawing.Point(356, 27);
			this.lbl_deposit.MouseState = MaterialSkin.MouseState.HOVER;
			this.lbl_deposit.Name = "lbl_deposit";
			this.lbl_deposit.Size = new System.Drawing.Size(61, 19);
			this.lbl_deposit.TabIndex = 8;
			this.lbl_deposit.Text = "Deposit";
			// 
			// btn_create_deposit
			// 
			this.btn_create_deposit.Depth = 0;
			this.btn_create_deposit.Location = new System.Drawing.Point(32, 284);
			this.btn_create_deposit.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_create_deposit.Name = "btn_create_deposit";
			this.btn_create_deposit.Primary = true;
			this.btn_create_deposit.Size = new System.Drawing.Size(250, 40);
			this.btn_create_deposit.TabIndex = 7;
			this.btn_create_deposit.Text = "Create";
			this.btn_create_deposit.UseVisualStyleBackColor = true;
			// 
			// cbb_passbook_deposit
			// 
			this.cbb_passbook_deposit.FormattingEnabled = true;
			this.cbb_passbook_deposit.Location = new System.Drawing.Point(360, 61);
			this.cbb_passbook_deposit.Name = "cbb_passbook_deposit";
			this.cbb_passbook_deposit.Size = new System.Drawing.Size(227, 21);
			this.cbb_passbook_deposit.TabIndex = 6;
			// 
			// btn_check_deposit
			// 
			this.btn_check_deposit.Depth = 0;
			this.btn_check_deposit.Location = new System.Drawing.Point(32, 238);
			this.btn_check_deposit.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_check_deposit.Name = "btn_check_deposit";
			this.btn_check_deposit.Primary = true;
			this.btn_check_deposit.Size = new System.Drawing.Size(250, 40);
			this.btn_check_deposit.TabIndex = 5;
			this.btn_check_deposit.Text = "Check";
			this.btn_check_deposit.UseVisualStyleBackColor = true;
			// 
			// txt_phone_number_deposit
			// 
			this.txt_phone_number_deposit.Depth = 0;
			this.txt_phone_number_deposit.Hint = "Phone Number";
			this.txt_phone_number_deposit.Location = new System.Drawing.Point(32, 191);
			this.txt_phone_number_deposit.MaxLength = 32767;
			this.txt_phone_number_deposit.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_phone_number_deposit.Name = "txt_phone_number_deposit";
			this.txt_phone_number_deposit.PasswordChar = '\0';
			this.txt_phone_number_deposit.SelectedText = "";
			this.txt_phone_number_deposit.SelectionLength = 0;
			this.txt_phone_number_deposit.SelectionStart = 0;
			this.txt_phone_number_deposit.Size = new System.Drawing.Size(250, 23);
			this.txt_phone_number_deposit.TabIndex = 4;
			this.txt_phone_number_deposit.TabStop = false;
			this.txt_phone_number_deposit.UseSystemPasswordChar = false;
			// 
			// txt_identity_number_deposit
			// 
			this.txt_identity_number_deposit.Depth = 0;
			this.txt_identity_number_deposit.Hint = "Identity Number";
			this.txt_identity_number_deposit.Location = new System.Drawing.Point(32, 103);
			this.txt_identity_number_deposit.MaxLength = 32767;
			this.txt_identity_number_deposit.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_identity_number_deposit.Name = "txt_identity_number_deposit";
			this.txt_identity_number_deposit.PasswordChar = '\0';
			this.txt_identity_number_deposit.SelectedText = "";
			this.txt_identity_number_deposit.SelectionLength = 0;
			this.txt_identity_number_deposit.SelectionStart = 0;
			this.txt_identity_number_deposit.Size = new System.Drawing.Size(250, 23);
			this.txt_identity_number_deposit.TabIndex = 3;
			this.txt_identity_number_deposit.TabStop = false;
			this.txt_identity_number_deposit.UseSystemPasswordChar = false;
			// 
			// txt_name_deposit
			// 
			this.txt_name_deposit.Depth = 0;
			this.txt_name_deposit.Hint = "Name";
			this.txt_name_deposit.Location = new System.Drawing.Point(32, 59);
			this.txt_name_deposit.MaxLength = 32767;
			this.txt_name_deposit.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_name_deposit.Name = "txt_name_deposit";
			this.txt_name_deposit.PasswordChar = '\0';
			this.txt_name_deposit.SelectedText = "";
			this.txt_name_deposit.SelectionLength = 0;
			this.txt_name_deposit.SelectionStart = 0;
			this.txt_name_deposit.Size = new System.Drawing.Size(250, 23);
			this.txt_name_deposit.TabIndex = 2;
			this.txt_name_deposit.TabStop = false;
			this.txt_name_deposit.UseSystemPasswordChar = false;
			// 
			// lbl_customer_deposit
			// 
			this.lbl_customer_deposit.AutoSize = true;
			this.lbl_customer_deposit.Depth = 0;
			this.lbl_customer_deposit.Font = new System.Drawing.Font("Roboto", 11F);
			this.lbl_customer_deposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lbl_customer_deposit.Location = new System.Drawing.Point(28, 27);
			this.lbl_customer_deposit.MouseState = MaterialSkin.MouseState.HOVER;
			this.lbl_customer_deposit.Name = "lbl_customer_deposit";
			this.lbl_customer_deposit.Size = new System.Drawing.Size(75, 19);
			this.lbl_customer_deposit.TabIndex = 1;
			this.lbl_customer_deposit.Text = "Customer";
			// 
			// txt_address_deposit
			// 
			this.txt_address_deposit.Depth = 0;
			this.txt_address_deposit.Hint = "Address";
			this.txt_address_deposit.Location = new System.Drawing.Point(32, 147);
			this.txt_address_deposit.MaxLength = 32767;
			this.txt_address_deposit.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_address_deposit.Name = "txt_address_deposit";
			this.txt_address_deposit.PasswordChar = '\0';
			this.txt_address_deposit.SelectedText = "";
			this.txt_address_deposit.SelectionLength = 0;
			this.txt_address_deposit.SelectionStart = 0;
			this.txt_address_deposit.Size = new System.Drawing.Size(250, 23);
			this.txt_address_deposit.TabIndex = 0;
			this.txt_address_deposit.TabStop = false;
			this.txt_address_deposit.UseSystemPasswordChar = false;
			// 
			// tab_withdrawal
			// 
			this.tab_withdrawal.BackColor = System.Drawing.Color.White;
			this.tab_withdrawal.Controls.Add(this.cbb_passbook_withdrawal);
			this.tab_withdrawal.Controls.Add(this.calendar_withdrawal);
			this.tab_withdrawal.Controls.Add(this.btn_create_withdrawal);
			this.tab_withdrawal.Controls.Add(this.btn_check_withdrawal);
			this.tab_withdrawal.Controls.Add(this.txt_cash_withdrawal);
			this.tab_withdrawal.Controls.Add(this.txt_identity_number_withdrawal);
			this.tab_withdrawal.Controls.Add(this.txt_address_withdrawal);
			this.tab_withdrawal.Controls.Add(this.txt_phone_number_withdrawal);
			this.tab_withdrawal.Controls.Add(this.txt_name_withdrawal);
			this.tab_withdrawal.Controls.Add(this.lbl_withdrawal);
			this.tab_withdrawal.Controls.Add(this.lbl_customer_withdrawal);
			this.tab_withdrawal.Location = new System.Drawing.Point(4, 22);
			this.tab_withdrawal.Name = "tab_withdrawal";
			this.tab_withdrawal.Padding = new System.Windows.Forms.Padding(3);
			this.tab_withdrawal.Size = new System.Drawing.Size(668, 339);
			this.tab_withdrawal.TabIndex = 3;
			this.tab_withdrawal.Text = "Withdrawal";
			this.tab_withdrawal.UseVisualStyleBackColor = true;
			// 
			// cbb_passbook_withdrawal
			// 
			this.cbb_passbook_withdrawal.FormattingEnabled = true;
			this.cbb_passbook_withdrawal.Location = new System.Drawing.Point(360, 61);
			this.cbb_passbook_withdrawal.Name = "cbb_passbook_withdrawal";
			this.cbb_passbook_withdrawal.Size = new System.Drawing.Size(227, 21);
			this.cbb_passbook_withdrawal.TabIndex = 10;
			// 
			// calendar_withdrawal
			// 
			this.calendar_withdrawal.Location = new System.Drawing.Point(360, 147);
			this.calendar_withdrawal.Name = "calendar_withdrawal";
			this.calendar_withdrawal.TabIndex = 9;
			// 
			// btn_create_withdrawal
			// 
			this.btn_create_withdrawal.Depth = 0;
			this.btn_create_withdrawal.Location = new System.Drawing.Point(32, 284);
			this.btn_create_withdrawal.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_create_withdrawal.Name = "btn_create_withdrawal";
			this.btn_create_withdrawal.Primary = true;
			this.btn_create_withdrawal.Size = new System.Drawing.Size(250, 40);
			this.btn_create_withdrawal.TabIndex = 8;
			this.btn_create_withdrawal.Text = "Create";
			this.btn_create_withdrawal.UseVisualStyleBackColor = true;
			// 
			// btn_check_withdrawal
			// 
			this.btn_check_withdrawal.Depth = 0;
			this.btn_check_withdrawal.Location = new System.Drawing.Point(32, 238);
			this.btn_check_withdrawal.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_check_withdrawal.Name = "btn_check_withdrawal";
			this.btn_check_withdrawal.Primary = true;
			this.btn_check_withdrawal.Size = new System.Drawing.Size(250, 40);
			this.btn_check_withdrawal.TabIndex = 7;
			this.btn_check_withdrawal.Text = "Check";
			this.btn_check_withdrawal.UseVisualStyleBackColor = true;
			// 
			// txt_cash_withdrawal
			// 
			this.txt_cash_withdrawal.Depth = 0;
			this.txt_cash_withdrawal.Hint = "Cash";
			this.txt_cash_withdrawal.Location = new System.Drawing.Point(360, 103);
			this.txt_cash_withdrawal.MaxLength = 32767;
			this.txt_cash_withdrawal.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_cash_withdrawal.Name = "txt_cash_withdrawal";
			this.txt_cash_withdrawal.PasswordChar = '\0';
			this.txt_cash_withdrawal.SelectedText = "";
			this.txt_cash_withdrawal.SelectionLength = 0;
			this.txt_cash_withdrawal.SelectionStart = 0;
			this.txt_cash_withdrawal.Size = new System.Drawing.Size(227, 23);
			this.txt_cash_withdrawal.TabIndex = 6;
			this.txt_cash_withdrawal.TabStop = false;
			this.txt_cash_withdrawal.UseSystemPasswordChar = false;
			// 
			// txt_identity_number_withdrawal
			// 
			this.txt_identity_number_withdrawal.Depth = 0;
			this.txt_identity_number_withdrawal.Hint = "Identity Number";
			this.txt_identity_number_withdrawal.Location = new System.Drawing.Point(32, 103);
			this.txt_identity_number_withdrawal.MaxLength = 32767;
			this.txt_identity_number_withdrawal.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_identity_number_withdrawal.Name = "txt_identity_number_withdrawal";
			this.txt_identity_number_withdrawal.PasswordChar = '\0';
			this.txt_identity_number_withdrawal.SelectedText = "";
			this.txt_identity_number_withdrawal.SelectionLength = 0;
			this.txt_identity_number_withdrawal.SelectionStart = 0;
			this.txt_identity_number_withdrawal.Size = new System.Drawing.Size(250, 23);
			this.txt_identity_number_withdrawal.TabIndex = 5;
			this.txt_identity_number_withdrawal.TabStop = false;
			this.txt_identity_number_withdrawal.UseSystemPasswordChar = false;
			// 
			// txt_address_withdrawal
			// 
			this.txt_address_withdrawal.Depth = 0;
			this.txt_address_withdrawal.Hint = "Address";
			this.txt_address_withdrawal.Location = new System.Drawing.Point(32, 147);
			this.txt_address_withdrawal.MaxLength = 32767;
			this.txt_address_withdrawal.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_address_withdrawal.Name = "txt_address_withdrawal";
			this.txt_address_withdrawal.PasswordChar = '\0';
			this.txt_address_withdrawal.SelectedText = "";
			this.txt_address_withdrawal.SelectionLength = 0;
			this.txt_address_withdrawal.SelectionStart = 0;
			this.txt_address_withdrawal.Size = new System.Drawing.Size(250, 23);
			this.txt_address_withdrawal.TabIndex = 4;
			this.txt_address_withdrawal.TabStop = false;
			this.txt_address_withdrawal.UseSystemPasswordChar = false;
			// 
			// txt_phone_number_withdrawal
			// 
			this.txt_phone_number_withdrawal.Depth = 0;
			this.txt_phone_number_withdrawal.Hint = "Phone Number";
			this.txt_phone_number_withdrawal.Location = new System.Drawing.Point(32, 191);
			this.txt_phone_number_withdrawal.MaxLength = 32767;
			this.txt_phone_number_withdrawal.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_phone_number_withdrawal.Name = "txt_phone_number_withdrawal";
			this.txt_phone_number_withdrawal.PasswordChar = '\0';
			this.txt_phone_number_withdrawal.SelectedText = "";
			this.txt_phone_number_withdrawal.SelectionLength = 0;
			this.txt_phone_number_withdrawal.SelectionStart = 0;
			this.txt_phone_number_withdrawal.Size = new System.Drawing.Size(250, 23);
			this.txt_phone_number_withdrawal.TabIndex = 3;
			this.txt_phone_number_withdrawal.TabStop = false;
			this.txt_phone_number_withdrawal.UseSystemPasswordChar = false;
			// 
			// txt_name_withdrawal
			// 
			this.txt_name_withdrawal.Depth = 0;
			this.txt_name_withdrawal.Hint = "Name";
			this.txt_name_withdrawal.Location = new System.Drawing.Point(32, 59);
			this.txt_name_withdrawal.MaxLength = 32767;
			this.txt_name_withdrawal.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_name_withdrawal.Name = "txt_name_withdrawal";
			this.txt_name_withdrawal.PasswordChar = '\0';
			this.txt_name_withdrawal.SelectedText = "";
			this.txt_name_withdrawal.SelectionLength = 0;
			this.txt_name_withdrawal.SelectionStart = 0;
			this.txt_name_withdrawal.Size = new System.Drawing.Size(250, 23);
			this.txt_name_withdrawal.TabIndex = 2;
			this.txt_name_withdrawal.TabStop = false;
			this.txt_name_withdrawal.UseSystemPasswordChar = false;
			// 
			// lbl_withdrawal
			// 
			this.lbl_withdrawal.AutoSize = true;
			this.lbl_withdrawal.Depth = 0;
			this.lbl_withdrawal.Font = new System.Drawing.Font("Roboto", 11F);
			this.lbl_withdrawal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lbl_withdrawal.Location = new System.Drawing.Point(356, 27);
			this.lbl_withdrawal.MouseState = MaterialSkin.MouseState.HOVER;
			this.lbl_withdrawal.Name = "lbl_withdrawal";
			this.lbl_withdrawal.Size = new System.Drawing.Size(83, 19);
			this.lbl_withdrawal.TabIndex = 1;
			this.lbl_withdrawal.Text = "Withdrawal";
			// 
			// lbl_customer_withdrawal
			// 
			this.lbl_customer_withdrawal.AutoSize = true;
			this.lbl_customer_withdrawal.Depth = 0;
			this.lbl_customer_withdrawal.Font = new System.Drawing.Font("Roboto", 11F);
			this.lbl_customer_withdrawal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lbl_customer_withdrawal.Location = new System.Drawing.Point(28, 27);
			this.lbl_customer_withdrawal.MouseState = MaterialSkin.MouseState.HOVER;
			this.lbl_customer_withdrawal.Name = "lbl_customer_withdrawal";
			this.lbl_customer_withdrawal.Size = new System.Drawing.Size(75, 19);
			this.lbl_customer_withdrawal.TabIndex = 0;
			this.lbl_customer_withdrawal.Text = "Customer";
			// 
			// tab_daily_report
			// 
			this.tab_daily_report.BackColor = System.Drawing.Color.White;
			this.tab_daily_report.Controls.Add(this.list_daily);
			this.tab_daily_report.Controls.Add(this.date_daily);
			this.tab_daily_report.Location = new System.Drawing.Point(4, 22);
			this.tab_daily_report.Name = "tab_daily_report";
			this.tab_daily_report.Padding = new System.Windows.Forms.Padding(3);
			this.tab_daily_report.Size = new System.Drawing.Size(668, 339);
			this.tab_daily_report.TabIndex = 4;
			this.tab_daily_report.Text = "Daily Report";
			this.tab_daily_report.UseVisualStyleBackColor = true;
			// 
			// list_daily
			// 
			this.list_daily.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.list_daily.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_order_daily,
            this.col_type_daily,
            this.col_income_daily,
            this.col_outcome_daily,
            this.col_total_daily});
			this.list_daily.Depth = 0;
			this.list_daily.Font = new System.Drawing.Font("Roboto", 24F);
			this.list_daily.FullRowSelect = true;
			this.list_daily.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.list_daily.Location = new System.Drawing.Point(0, 32);
			this.list_daily.MouseLocation = new System.Drawing.Point(-1, -1);
			this.list_daily.MouseState = MaterialSkin.MouseState.OUT;
			this.list_daily.Name = "list_daily";
			this.list_daily.OwnerDraw = true;
			this.list_daily.Size = new System.Drawing.Size(672, 311);
			this.list_daily.TabIndex = 1;
			this.list_daily.UseCompatibleStateImageBehavior = false;
			this.list_daily.View = System.Windows.Forms.View.Details;
			// 
			// col_order_daily
			// 
			this.col_order_daily.Text = "Order";
			this.col_order_daily.Width = 110;
			// 
			// col_type_daily
			// 
			this.col_type_daily.Text = "Type";
			this.col_type_daily.Width = 124;
			// 
			// col_income_daily
			// 
			this.col_income_daily.Text = "Income";
			this.col_income_daily.Width = 135;
			// 
			// col_outcome_daily
			// 
			this.col_outcome_daily.Text = "Outcome";
			this.col_outcome_daily.Width = 156;
			// 
			// col_total_daily
			// 
			this.col_total_daily.Text = "Total";
			this.col_total_daily.Width = 143;
			// 
			// date_daily
			// 
			this.date_daily.Location = new System.Drawing.Point(6, 6);
			this.date_daily.Name = "date_daily";
			this.date_daily.Size = new System.Drawing.Size(200, 20);
			this.date_daily.TabIndex = 0;
			// 
			// tab_monthly_report
			// 
			this.tab_monthly_report.BackColor = System.Drawing.Color.White;
			this.tab_monthly_report.Controls.Add(this.list_monthly);
			this.tab_monthly_report.Controls.Add(this.date_monthly);
			this.tab_monthly_report.Controls.Add(this.cbb_type_monthly);
			this.tab_monthly_report.Location = new System.Drawing.Point(4, 22);
			this.tab_monthly_report.Name = "tab_monthly_report";
			this.tab_monthly_report.Padding = new System.Windows.Forms.Padding(3);
			this.tab_monthly_report.Size = new System.Drawing.Size(668, 339);
			this.tab_monthly_report.TabIndex = 5;
			this.tab_monthly_report.Text = "Monthly Report";
			this.tab_monthly_report.UseVisualStyleBackColor = true;
			// 
			// list_monthly
			// 
			this.list_monthly.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.list_monthly.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_order_monthly,
            this.col_date_monthly,
            this.col_income_monthly,
            this.col_outcome_monthly,
            this.col_total_monthly});
			this.list_monthly.Depth = 0;
			this.list_monthly.Font = new System.Drawing.Font("Roboto", 24F);
			this.list_monthly.FullRowSelect = true;
			this.list_monthly.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.list_monthly.Location = new System.Drawing.Point(0, 33);
			this.list_monthly.MouseLocation = new System.Drawing.Point(-1, -1);
			this.list_monthly.MouseState = MaterialSkin.MouseState.OUT;
			this.list_monthly.Name = "list_monthly";
			this.list_monthly.OwnerDraw = true;
			this.list_monthly.Size = new System.Drawing.Size(672, 310);
			this.list_monthly.TabIndex = 2;
			this.list_monthly.UseCompatibleStateImageBehavior = false;
			this.list_monthly.View = System.Windows.Forms.View.Details;
			// 
			// col_order_monthly
			// 
			this.col_order_monthly.Text = "Order";
			this.col_order_monthly.Width = 94;
			// 
			// col_date_monthly
			// 
			this.col_date_monthly.Text = "Date";
			this.col_date_monthly.Width = 142;
			// 
			// col_income_monthly
			// 
			this.col_income_monthly.Text = "Income";
			this.col_income_monthly.Width = 149;
			// 
			// col_outcome_monthly
			// 
			this.col_outcome_monthly.Text = "Outcome";
			this.col_outcome_monthly.Width = 139;
			// 
			// col_total_monthly
			// 
			this.col_total_monthly.Text = "Total";
			this.col_total_monthly.Width = 147;
			// 
			// date_monthly
			// 
			this.date_monthly.Location = new System.Drawing.Point(133, 7);
			this.date_monthly.Name = "date_monthly";
			this.date_monthly.Size = new System.Drawing.Size(200, 20);
			this.date_monthly.TabIndex = 1;
			// 
			// cbb_type_monthly
			// 
			this.cbb_type_monthly.FormattingEnabled = true;
			this.cbb_type_monthly.Location = new System.Drawing.Point(6, 6);
			this.cbb_type_monthly.Name = "cbb_type_monthly";
			this.cbb_type_monthly.Size = new System.Drawing.Size(121, 21);
			this.cbb_type_monthly.TabIndex = 0;
			// 
			// Passbook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 480);
			this.Controls.Add(this.tab_selector);
			this.Controls.Add(this.tab_control);
			this.Name = "Passbook";
			this.Text = "Passbook Management";
			this.tab_control.ResumeLayout(false);
			this.tab_open.ResumeLayout(false);
			this.tab_open.PerformLayout();
			this.tab_lookup.ResumeLayout(false);
			this.tab_deposit.ResumeLayout(false);
			this.tab_deposit.PerformLayout();
			this.tab_withdrawal.ResumeLayout(false);
			this.tab_withdrawal.PerformLayout();
			this.tab_daily_report.ResumeLayout(false);
			this.tab_monthly_report.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MaterialSkin.Controls.MaterialTabSelector tab_selector;
		private MaterialSkin.Controls.MaterialTabControl tab_control;
		private System.Windows.Forms.TabPage tab_open;
		private System.Windows.Forms.TabPage tab_lookup;
		private System.Windows.Forms.TabPage tab_deposit;
		private System.Windows.Forms.TabPage tab_withdrawal;
		private System.Windows.Forms.TabPage tab_daily_report;
		private System.Windows.Forms.TabPage tab_monthly_report;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_name_open;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_identity_number_open;
		private MaterialSkin.Controls.MaterialLabel lbl_customer;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_address_open;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_phone_number_open;
		private MaterialSkin.Controls.MaterialRaisedButton btn_submit_open;
		private MaterialSkin.Controls.MaterialRaisedButton btn_check_open;
		private MaterialSkin.Controls.MaterialRadioButton radio_6months;
		private MaterialSkin.Controls.MaterialRadioButton radio_no_terms;
		private MaterialSkin.Controls.MaterialRadioButton radio_3months;
		private MaterialSkin.Controls.MaterialLabel lbl_passbook;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_cash_open;
		private System.Windows.Forms.MonthCalendar calendar_open;
		private MaterialSkin.Controls.MaterialRaisedButton btn_create_open;
		private MaterialSkin.Controls.MaterialListView list_lookup;
		private System.Windows.Forms.ColumnHeader col_order;
		private System.Windows.Forms.ColumnHeader col_passbook_id;
		private System.Windows.Forms.ColumnHeader col_type;
		private System.Windows.Forms.ColumnHeader col_customer_id;
		private System.Windows.Forms.ColumnHeader col_balance;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_address_deposit;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_phone_number_deposit;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_identity_number_deposit;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_name_deposit;
		private MaterialSkin.Controls.MaterialLabel lbl_customer_deposit;
		private MaterialSkin.Controls.MaterialRaisedButton btn_check_deposit;
		private System.Windows.Forms.ComboBox cbb_passbook_deposit;
		private MaterialSkin.Controls.MaterialRaisedButton btn_create_deposit;
		private MaterialSkin.Controls.MaterialLabel lbl_deposit;
		private System.Windows.Forms.MonthCalendar calendar_deposit;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_cash_deposit;
		private System.Windows.Forms.ComboBox cbb_passbook_withdrawal;
		private System.Windows.Forms.MonthCalendar calendar_withdrawal;
		private MaterialSkin.Controls.MaterialRaisedButton btn_create_withdrawal;
		private MaterialSkin.Controls.MaterialRaisedButton btn_check_withdrawal;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_cash_withdrawal;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_identity_number_withdrawal;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_address_withdrawal;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_phone_number_withdrawal;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_name_withdrawal;
		private MaterialSkin.Controls.MaterialLabel lbl_withdrawal;
		private MaterialSkin.Controls.MaterialLabel lbl_customer_withdrawal;
		private MaterialSkin.Controls.MaterialListView list_daily;
		private System.Windows.Forms.ColumnHeader col_order_daily;
		private System.Windows.Forms.ColumnHeader col_type_daily;
		private System.Windows.Forms.ColumnHeader col_income_daily;
		private System.Windows.Forms.ColumnHeader col_outcome_daily;
		private System.Windows.Forms.ColumnHeader col_total_daily;
		private System.Windows.Forms.DateTimePicker date_daily;
		private MaterialSkin.Controls.MaterialListView list_monthly;
		private System.Windows.Forms.ColumnHeader col_order_monthly;
		private System.Windows.Forms.ColumnHeader col_date_monthly;
		private System.Windows.Forms.ColumnHeader col_income_monthly;
		private System.Windows.Forms.ColumnHeader col_outcome_monthly;
		private System.Windows.Forms.ColumnHeader col_total_monthly;
		private System.Windows.Forms.DateTimePicker date_monthly;
		private System.Windows.Forms.ComboBox cbb_type_monthly;
	}
}