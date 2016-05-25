namespace PassbookManagement.src
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
			this.btn_create = new MaterialSkin.Controls.MaterialRaisedButton();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.txt_cash = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.radio_6months = new MaterialSkin.Controls.MaterialRadioButton();
			this.radio_no_terms = new MaterialSkin.Controls.MaterialRadioButton();
			this.radio_3months = new MaterialSkin.Controls.MaterialRadioButton();
			this.lbl_passbook = new MaterialSkin.Controls.MaterialLabel();
			this.btn_submit = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btn_check = new MaterialSkin.Controls.MaterialRaisedButton();
			this.txt_address = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_phone_number = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.lbl_customer = new MaterialSkin.Controls.MaterialLabel();
			this.txt_identity_number = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.tab_lookup = new System.Windows.Forms.TabPage();
			this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
			this.col_order = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_passbook_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_customer_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tab_deposit = new System.Windows.Forms.TabPage();
			this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
			this.txt_cash_deposit = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.lbl_deposit = new MaterialSkin.Controls.MaterialLabel();
			this.btn_create_deposit = new MaterialSkin.Controls.MaterialRaisedButton();
			this.cbb_passbook = new System.Windows.Forms.ComboBox();
			this.btn_check_deposit = new MaterialSkin.Controls.MaterialRaisedButton();
			this.txt_phone_number_deposit = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_identity_number_deposit = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_name_deposit = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.lbl_customer_deposit = new MaterialSkin.Controls.MaterialLabel();
			this.txt_address_deposit = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.tab_withdrawal = new System.Windows.Forms.TabPage();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.monthCalendar3 = new System.Windows.Forms.MonthCalendar();
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
			this.materialListView2 = new MaterialSkin.Controls.MaterialListView();
			this.col_order_daily = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_type_daily = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_income_daily = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_outcome_daily = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_total_daily = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.tab_monthly_report = new System.Windows.Forms.TabPage();
			this.materialListView3 = new MaterialSkin.Controls.MaterialListView();
			this.col_order_monthly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_date_monthly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_income_monthly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_outcome_monthly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_total_monthly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
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
			this.tab_control.Location = new System.Drawing.Point(12, 103);
			this.tab_control.MouseState = MaterialSkin.MouseState.HOVER;
			this.tab_control.Name = "tab_control";
			this.tab_control.SelectedIndex = 0;
			this.tab_control.Size = new System.Drawing.Size(676, 365);
			this.tab_control.TabIndex = 0;
			// 
			// tab_open
			// 
			this.tab_open.BackColor = System.Drawing.Color.White;
			this.tab_open.Controls.Add(this.btn_create);
			this.tab_open.Controls.Add(this.monthCalendar1);
			this.tab_open.Controls.Add(this.txt_cash);
			this.tab_open.Controls.Add(this.radio_6months);
			this.tab_open.Controls.Add(this.radio_no_terms);
			this.tab_open.Controls.Add(this.radio_3months);
			this.tab_open.Controls.Add(this.lbl_passbook);
			this.tab_open.Controls.Add(this.btn_submit);
			this.tab_open.Controls.Add(this.btn_check);
			this.tab_open.Controls.Add(this.txt_address);
			this.tab_open.Controls.Add(this.txt_phone_number);
			this.tab_open.Controls.Add(this.lbl_customer);
			this.tab_open.Controls.Add(this.txt_identity_number);
			this.tab_open.Controls.Add(this.txt_name);
			this.tab_open.Location = new System.Drawing.Point(4, 22);
			this.tab_open.Name = "tab_open";
			this.tab_open.Padding = new System.Windows.Forms.Padding(3);
			this.tab_open.Size = new System.Drawing.Size(668, 339);
			this.tab_open.TabIndex = 0;
			this.tab_open.Text = "Passbook";
			// 
			// btn_create
			// 
			this.btn_create.Depth = 0;
			this.btn_create.Location = new System.Drawing.Point(32, 284);
			this.btn_create.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_create.Name = "btn_create";
			this.btn_create.Primary = true;
			this.btn_create.Size = new System.Drawing.Size(250, 40);
			this.btn_create.TabIndex = 15;
			this.btn_create.Text = "Create";
			this.btn_create.UseVisualStyleBackColor = true;
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(360, 147);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 14;
			// 
			// txt_cash
			// 
			this.txt_cash.Depth = 0;
			this.txt_cash.Hint = "Cash";
			this.txt_cash.Location = new System.Drawing.Point(360, 103);
			this.txt_cash.MaxLength = 32767;
			this.txt_cash.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_cash.Name = "txt_cash";
			this.txt_cash.PasswordChar = '\0';
			this.txt_cash.SelectedText = "";
			this.txt_cash.SelectionLength = 0;
			this.txt_cash.SelectionStart = 0;
			this.txt_cash.Size = new System.Drawing.Size(227, 23);
			this.txt_cash.TabIndex = 12;
			this.txt_cash.TabStop = false;
			this.txt_cash.UseSystemPasswordChar = false;
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
			// btn_submit
			// 
			this.btn_submit.Depth = 0;
			this.btn_submit.Location = new System.Drawing.Point(78, 260);
			this.btn_submit.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_submit.Name = "btn_submit";
			this.btn_submit.Primary = true;
			this.btn_submit.Size = new System.Drawing.Size(250, 40);
			this.btn_submit.TabIndex = 7;
			this.btn_submit.Text = "Submit";
			this.btn_submit.UseVisualStyleBackColor = true;
			// 
			// btn_check
			// 
			this.btn_check.Depth = 0;
			this.btn_check.Location = new System.Drawing.Point(32, 238);
			this.btn_check.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_check.Name = "btn_check";
			this.btn_check.Primary = true;
			this.btn_check.Size = new System.Drawing.Size(250, 40);
			this.btn_check.TabIndex = 6;
			this.btn_check.Text = "Check";
			this.btn_check.UseVisualStyleBackColor = true;
			// 
			// txt_address
			// 
			this.txt_address.Depth = 0;
			this.txt_address.Hint = "Address";
			this.txt_address.Location = new System.Drawing.Point(32, 147);
			this.txt_address.MaxLength = 32767;
			this.txt_address.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_address.Name = "txt_address";
			this.txt_address.PasswordChar = '\0';
			this.txt_address.SelectedText = "";
			this.txt_address.SelectionLength = 0;
			this.txt_address.SelectionStart = 0;
			this.txt_address.Size = new System.Drawing.Size(250, 23);
			this.txt_address.TabIndex = 5;
			this.txt_address.TabStop = false;
			this.txt_address.UseSystemPasswordChar = false;
			// 
			// txt_phone_number
			// 
			this.txt_phone_number.Depth = 0;
			this.txt_phone_number.Hint = "Phone Number";
			this.txt_phone_number.Location = new System.Drawing.Point(32, 191);
			this.txt_phone_number.MaxLength = 32767;
			this.txt_phone_number.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_phone_number.Name = "txt_phone_number";
			this.txt_phone_number.PasswordChar = '\0';
			this.txt_phone_number.SelectedText = "";
			this.txt_phone_number.SelectionLength = 0;
			this.txt_phone_number.SelectionStart = 0;
			this.txt_phone_number.Size = new System.Drawing.Size(250, 23);
			this.txt_phone_number.TabIndex = 4;
			this.txt_phone_number.TabStop = false;
			this.txt_phone_number.UseSystemPasswordChar = false;
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
			// txt_identity_number
			// 
			this.txt_identity_number.Depth = 0;
			this.txt_identity_number.Hint = "Identity Number";
			this.txt_identity_number.Location = new System.Drawing.Point(32, 103);
			this.txt_identity_number.MaxLength = 32767;
			this.txt_identity_number.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_identity_number.Name = "txt_identity_number";
			this.txt_identity_number.PasswordChar = '\0';
			this.txt_identity_number.SelectedText = "";
			this.txt_identity_number.SelectionLength = 0;
			this.txt_identity_number.SelectionStart = 0;
			this.txt_identity_number.Size = new System.Drawing.Size(250, 23);
			this.txt_identity_number.TabIndex = 2;
			this.txt_identity_number.TabStop = false;
			this.txt_identity_number.UseSystemPasswordChar = false;
			// 
			// txt_name
			// 
			this.txt_name.Depth = 0;
			this.txt_name.Hint = "Name";
			this.txt_name.Location = new System.Drawing.Point(32, 59);
			this.txt_name.MaxLength = 32767;
			this.txt_name.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_name.Name = "txt_name";
			this.txt_name.PasswordChar = '\0';
			this.txt_name.SelectedText = "";
			this.txt_name.SelectionLength = 0;
			this.txt_name.SelectionStart = 0;
			this.txt_name.Size = new System.Drawing.Size(250, 23);
			this.txt_name.TabIndex = 0;
			this.txt_name.TabStop = false;
			this.txt_name.UseSystemPasswordChar = false;
			// 
			// tab_lookup
			// 
			this.tab_lookup.BackColor = System.Drawing.Color.White;
			this.tab_lookup.Controls.Add(this.materialListView1);
			this.tab_lookup.Location = new System.Drawing.Point(4, 22);
			this.tab_lookup.Name = "tab_lookup";
			this.tab_lookup.Padding = new System.Windows.Forms.Padding(3);
			this.tab_lookup.Size = new System.Drawing.Size(668, 339);
			this.tab_lookup.TabIndex = 1;
			this.tab_lookup.Text = "Lookup";
			this.tab_lookup.UseVisualStyleBackColor = true;
			// 
			// materialListView1
			// 
			this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_order,
            this.col_passbook_id,
            this.col_type,
            this.col_customer_id,
            this.col_balance});
			this.materialListView1.Depth = 0;
			this.materialListView1.Font = new System.Drawing.Font("Roboto", 24F);
			this.materialListView1.FullRowSelect = true;
			this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.materialListView1.Location = new System.Drawing.Point(-4, 0);
			this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
			this.materialListView1.Name = "materialListView1";
			this.materialListView1.OwnerDraw = true;
			this.materialListView1.Size = new System.Drawing.Size(676, 339);
			this.materialListView1.TabIndex = 0;
			this.materialListView1.UseCompatibleStateImageBehavior = false;
			this.materialListView1.View = System.Windows.Forms.View.Details;
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
			this.tab_deposit.Controls.Add(this.monthCalendar2);
			this.tab_deposit.Controls.Add(this.txt_cash_deposit);
			this.tab_deposit.Controls.Add(this.lbl_deposit);
			this.tab_deposit.Controls.Add(this.btn_create_deposit);
			this.tab_deposit.Controls.Add(this.cbb_passbook);
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
			// monthCalendar2
			// 
			this.monthCalendar2.Location = new System.Drawing.Point(360, 147);
			this.monthCalendar2.Name = "monthCalendar2";
			this.monthCalendar2.TabIndex = 10;
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
			// cbb_passbook
			// 
			this.cbb_passbook.FormattingEnabled = true;
			this.cbb_passbook.Location = new System.Drawing.Point(360, 61);
			this.cbb_passbook.Name = "cbb_passbook";
			this.cbb_passbook.Size = new System.Drawing.Size(227, 21);
			this.cbb_passbook.TabIndex = 6;
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
			this.tab_withdrawal.Controls.Add(this.comboBox1);
			this.tab_withdrawal.Controls.Add(this.monthCalendar3);
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
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(360, 61);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(227, 21);
			this.comboBox1.TabIndex = 10;
			// 
			// monthCalendar3
			// 
			this.monthCalendar3.Location = new System.Drawing.Point(360, 147);
			this.monthCalendar3.Name = "monthCalendar3";
			this.monthCalendar3.TabIndex = 9;
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
			this.tab_daily_report.Controls.Add(this.materialListView2);
			this.tab_daily_report.Controls.Add(this.dateTimePicker1);
			this.tab_daily_report.Location = new System.Drawing.Point(4, 22);
			this.tab_daily_report.Name = "tab_daily_report";
			this.tab_daily_report.Padding = new System.Windows.Forms.Padding(3);
			this.tab_daily_report.Size = new System.Drawing.Size(668, 339);
			this.tab_daily_report.TabIndex = 4;
			this.tab_daily_report.Text = "Daily Report";
			this.tab_daily_report.UseVisualStyleBackColor = true;
			// 
			// materialListView2
			// 
			this.materialListView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.materialListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_order_daily,
            this.col_type_daily,
            this.col_income_daily,
            this.col_outcome_daily,
            this.col_total_daily});
			this.materialListView2.Depth = 0;
			this.materialListView2.Font = new System.Drawing.Font("Roboto", 24F);
			this.materialListView2.FullRowSelect = true;
			this.materialListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.materialListView2.Location = new System.Drawing.Point(0, 32);
			this.materialListView2.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialListView2.MouseState = MaterialSkin.MouseState.OUT;
			this.materialListView2.Name = "materialListView2";
			this.materialListView2.OwnerDraw = true;
			this.materialListView2.Size = new System.Drawing.Size(672, 311);
			this.materialListView2.TabIndex = 1;
			this.materialListView2.UseCompatibleStateImageBehavior = false;
			this.materialListView2.View = System.Windows.Forms.View.Details;
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
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(6, 6);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// tab_monthly_report
			// 
			this.tab_monthly_report.BackColor = System.Drawing.Color.White;
			this.tab_monthly_report.Controls.Add(this.materialListView3);
			this.tab_monthly_report.Controls.Add(this.dateTimePicker2);
			this.tab_monthly_report.Controls.Add(this.comboBox2);
			this.tab_monthly_report.Location = new System.Drawing.Point(4, 22);
			this.tab_monthly_report.Name = "tab_monthly_report";
			this.tab_monthly_report.Padding = new System.Windows.Forms.Padding(3);
			this.tab_monthly_report.Size = new System.Drawing.Size(668, 339);
			this.tab_monthly_report.TabIndex = 5;
			this.tab_monthly_report.Text = "Monthly Report";
			this.tab_monthly_report.UseVisualStyleBackColor = true;
			// 
			// materialListView3
			// 
			this.materialListView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.materialListView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_order_monthly,
            this.col_date_monthly,
            this.col_income_monthly,
            this.col_outcome_monthly,
            this.col_total_monthly});
			this.materialListView3.Depth = 0;
			this.materialListView3.Font = new System.Drawing.Font("Roboto", 24F);
			this.materialListView3.FullRowSelect = true;
			this.materialListView3.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.materialListView3.Location = new System.Drawing.Point(0, 33);
			this.materialListView3.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialListView3.MouseState = MaterialSkin.MouseState.OUT;
			this.materialListView3.Name = "materialListView3";
			this.materialListView3.OwnerDraw = true;
			this.materialListView3.Size = new System.Drawing.Size(672, 310);
			this.materialListView3.TabIndex = 2;
			this.materialListView3.UseCompatibleStateImageBehavior = false;
			this.materialListView3.View = System.Windows.Forms.View.Details;
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
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(133, 7);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker2.TabIndex = 1;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(6, 6);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 0;
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
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_name;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_identity_number;
		private MaterialSkin.Controls.MaterialLabel lbl_customer;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_address;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_phone_number;
		private MaterialSkin.Controls.MaterialRaisedButton btn_submit;
		private MaterialSkin.Controls.MaterialRaisedButton btn_check;
		private MaterialSkin.Controls.MaterialRadioButton radio_6months;
		private MaterialSkin.Controls.MaterialRadioButton radio_no_terms;
		private MaterialSkin.Controls.MaterialRadioButton radio_3months;
		private MaterialSkin.Controls.MaterialLabel lbl_passbook;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_cash;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private MaterialSkin.Controls.MaterialRaisedButton btn_create;
		private MaterialSkin.Controls.MaterialListView materialListView1;
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
		private System.Windows.Forms.ComboBox cbb_passbook;
		private MaterialSkin.Controls.MaterialRaisedButton btn_create_deposit;
		private MaterialSkin.Controls.MaterialLabel lbl_deposit;
		private System.Windows.Forms.MonthCalendar monthCalendar2;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_cash_deposit;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.MonthCalendar monthCalendar3;
		private MaterialSkin.Controls.MaterialRaisedButton btn_create_withdrawal;
		private MaterialSkin.Controls.MaterialRaisedButton btn_check_withdrawal;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_cash_withdrawal;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_identity_number_withdrawal;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_address_withdrawal;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_phone_number_withdrawal;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_name_withdrawal;
		private MaterialSkin.Controls.MaterialLabel lbl_withdrawal;
		private MaterialSkin.Controls.MaterialLabel lbl_customer_withdrawal;
		private MaterialSkin.Controls.MaterialListView materialListView2;
		private System.Windows.Forms.ColumnHeader col_order_daily;
		private System.Windows.Forms.ColumnHeader col_type_daily;
		private System.Windows.Forms.ColumnHeader col_income_daily;
		private System.Windows.Forms.ColumnHeader col_outcome_daily;
		private System.Windows.Forms.ColumnHeader col_total_daily;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private MaterialSkin.Controls.MaterialListView materialListView3;
		private System.Windows.Forms.ColumnHeader col_order_monthly;
		private System.Windows.Forms.ColumnHeader col_date_monthly;
		private System.Windows.Forms.ColumnHeader col_income_monthly;
		private System.Windows.Forms.ColumnHeader col_outcome_monthly;
		private System.Windows.Forms.ColumnHeader col_total_monthly;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.ComboBox comboBox2;
	}
}